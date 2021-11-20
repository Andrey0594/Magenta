using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Magenta.Classes
{
    public class Device
    {
        public string DeviceName;
        private SerialPort _port = null;
        public bool DetectCardFlag = true;
        delegate void MyDelegate();

        public static Dictionary<String, String> GetPortNames()
        {

            Dictionary<String, String> ports = new Dictionary<String, String>();
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_SerialPort");

                foreach (var obj in searcher.Get())
                {
                    var queryObj = (ManagementObject)obj;
                    if (queryObj != null && queryObj["DeviceID"].ToString().Contains("COM"))
                    {

                        String pidVid = queryObj["PNPDeviceID"].ToString().Replace("\\\\", "\\").Split('\\')[1];
                        ports.Add(pidVid, queryObj["DeviceID"].ToString());
                    }
                }
            }
            catch
            {
                //ignored
            }

            return ports;
        }


        public Device()
        {
            var temp = GetPortNames();
            for (int i = 0; i < temp.Keys.Count; i++)
            {
                try
                {
                    _port = new SerialPort(temp[temp.Keys.ToList()[i]], 115200, Parity.None, 8);
                    _port.Open();
                    _port.Write("ATI\r");
                    Application.DoEvents();
                    Thread.Sleep(200);
                    string message = _port.ReadExisting();
                    message = message.Replace("\r\n", "").Replace("\n", "").Replace("OK", "");
                    if (message == "\n")
                        message = "";
                    if (message.ToLower().Contains(@"odrfid"))
                    {
                        DeviceName = message;
                        break;
                    }

                }
                catch
                {
                    //iognored
                }



            }
        }





        private string FormatCard()
        {
            _port.Write("AT+SCAN0\r");
            _port.Write("AT+W1:140103E103E103E103E103E103E103E1\r");

            string message = _port.ReadExisting().Replace("\r\n", "\r").Trim('\n');
            if (message.ToLower().Contains("error"))
            {
                _port.Write("AT+KAD3F7D3F7D3F7\r");
                _port.Write("AT+KBFFFFFFFFFFFF\r");
                _port.Write("AT+W4:00000304D8000000FE00000000000000\r");
                for (int i = 7; i < 64; i += 4)
                {
                    _port.Write($"AT+W{i}:D3F7D3F7D3F77F078840FFFFFFFFFFFF\r");
                }
                message = _port.ReadExisting();
            }
            else
            {
                _port.Write("AT+W2:03E103E103E103E103E103E103E103E1\r");
                _port.Write("AT+W3:A0A1A2A3A4A5787788C1FFFFFFFFFFFF\r");
                _port.Write("AT+W4:00000304D8000000FE00000000000000\r");
                for (int i = 7; i < 64; i += 4)
                {
                    _port.Write($"AT+W{i}:D3F7D3F7D3F77F078840FFFFFFFFFFFF\r");
                }
                message = _port.ReadExisting();
            }

            _port.Write("AT+SCAN1\r");
            if (message.ToLower().Contains("error"))
                return "При форматировании карты возникли ошибки";
            return "Карта отформатирована";


        }
        public  bool FormatFlag;
        public void FormatCardTask()
        {
            if (_port != null)
            {
                if (!_port.IsOpen)
                    _port.Open();
                _port.DataReceived += port_DataReceivedForFormat;
                _port.Write("AT+SCAN1\r");
                FormatFlag = true;
                while (FormatFlag)
                {
                    Application.DoEvents();
                }
                _port.DataReceived -= port_DataReceivedForFormat;
            }
            else
            {
                MessageBox.Show(@"Nfc Reader не обнаружен. Перезагрузите программу.", @"Magenta", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void port_DataReceivedForFormat(object sender, SerialDataReceivedEventArgs e)
        {
            string message = _port.ReadExisting().Replace("\r\n", "").Replace("\n", "");
            MainForm frm = Application.OpenForms[0] as MainForm;
            if (message.Length == 8)
            {
                _port.DataReceived -= port_DataReceivedForFormat;

                frm.Invoke(new MyDelegate(() => { frm.LogTBox.Text = $@"Обнаружена карта-{message}" + Environment.NewLine + frm.LogTBox.Text; }));
                frm.Invoke(new MyDelegate(() => { frm.LogTBox.Text = $@"{FormatCard()}" + Environment.NewLine + frm.LogTBox.Text; }));
                FormatFlag = false;
            }
        }







        public void WriteData(string data)
        {

            _port.Write("AT+SCAN0\r");
            _port.Write("AT+KAD3F7D3F7D3F7\r");
            _port.Write("AT+KBFFFFFFFFFFFF\r");


            int i = 0;
            int block = 4;
            while (i < data.Length)
            {
                if ((block + 1) % 4 == 0)
                    block++;
                string tempUrl = data.Substring(i, 32);
                _port.Write($"AT+W{block}:{tempUrl}\r");
                block++;
                i += 32;
            }
            //_port.Write("AT+SCAN1\r");
            Application.DoEvents();



        }


        public bool WriteFlag;
        private string _data;
        public string WriteDataTask(string data)
        {
            if (_port != null)
            {
                _data = data;
                if (!_port.IsOpen)
                    _port.Open();
                _port.DataReceived += port_DataReceivedForWrite;
                _port.Write("AT+SCAN1\r");
                WriteFlag = true;
                while (WriteFlag)
                {
                    Application.DoEvents();
                }
                _port.DataReceived -= port_DataReceivedForWrite;
                return _writeMessage;
            }
            else
            {
                MessageBox.Show(@"Nfc Reader не обнаружен. Перезагрузите программу.", @"Magenta", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return "error";
            }
        }
        private string _writeMessage;
        private void port_DataReceivedForWrite(object sender, SerialDataReceivedEventArgs e)
        {
            string message = _port.ReadExisting().Replace("\r\n", "").Replace("\n", "");
            MainForm frm = Application.OpenForms[0] as MainForm;
            if (message.Length == 8)
            {
                _port.DataReceived -= port_DataReceivedForWrite;

                frm?.Invoke(new MyDelegate(() => { frm.LogTBox.Text = $@"Обнаружена карта-{message}" + Environment.NewLine + frm.LogTBox.Text; }));
                frm?.Invoke(new MyDelegate(() => { frm.LogTBox.Text = $@"{FormatCard()}" + Environment.NewLine + frm.LogTBox.Text; }));
                message = _port.ReadExisting();
                WriteData(_data);
                message = _port.ReadExisting();
                
                if (!message.ToLower().Contains("error"))
                    _writeMessage = "Данные записаны на карту";
                else
                    _writeMessage = "Во время записи возникли ошибки";
                frm?.Invoke(new MyDelegate(() => { frm.LogTBox.Text = $@"{_writeMessage}" + Environment.NewLine + frm.LogTBox.Text; }));








                WriteFlag = false;


            }
        }



        public void SetScan0()
        {

            _port.Write("AT+SCAN0\r");
            _port.ReadExisting();

        }
    }
}
