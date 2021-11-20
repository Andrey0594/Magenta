﻿using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Magenta.Classes;
using Magenta.Classes.Model;

namespace Magenta
{
    public partial class MainForm : Form
    {
        public DataBase Db;
        public DataFile File;
        public MyData Data;
        public Device Device;
        //private bool GlobalFlag;


        public MainForm()
        {
            InitializeComponent();
            Db = new DataBase();
        }
        private void OpenFileItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog { Multiselect = false };
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                File = new DataFile(fDialog.FileName);
                UrlDGView.DataSource = File.Data.Data;
                UrlDGView.Columns[0].Width = UrlDGView.Columns[1].Width = 50;
            }
        }

        private void UrlDGView_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            if (e.CurrentRow != null)
            {
                try
                {
                    ParametrsDGView.Rows.Clear();
                    Data = new MyData(e.CurrentRow.Cells["UrlColumn"].Value.ToString());

                    if (Data?.Card?.Vcf != null)
                    {
                        VcfTBox.Text = Data.Card.Vcf;
                        var temp = Data.Card.GetStruct();
                        foreach (string[] item in temp)
                        {
                            ParametrsDGView.Rows.Add(item[0], item[1]);
                        }

                        ParametrsDGView.Rows[0].IsCurrent = true;
                    }
                    else
                    {
                        ParametrsDGView.Rows.Add("Url", UrlDGView.CurrentRow.Cells["UrlColumn"].Value.ToString());
                        ParametrsDGView.Rows[0].Cells[1].ReadOnly = true;
                        VcfTBox.Text = "";
                    }
                    WriteBtn.Enabled = true;
                    Data.GetLength();
                    OnlyUrlBtn_CheckedChanged(this, new EventArgs());
                    if (VcfTBox.Text != "")
                        OnlyCardBtn.Enabled = CardBeforeUrl.Enabled = UrlBeforeCardBtn.Enabled = true;
                    else
                    {
                        OnlyCardBtn.Enabled = CardBeforeUrl.Enabled = UrlBeforeCardBtn.Enabled = false;
                    }


                }
                catch (ArgumentException ex)
                {
                    VcfTBox.Text = ex.Message;
                    e.CurrentRow.Cells["StatusColumn"].Value = Properties.Resources.error;
                    Db.UpdateStatus(-1, int.Parse(e.CurrentRow.Cells["IdColumn"].Value.ToString()), File.Hash);
                    WriteBtn.Enabled = false;
                    OnlyCardBtn.Enabled = CardBeforeUrl.Enabled = UrlBeforeCardBtn.Enabled = false;
                    Data = null;
                }



            }

        }

        private void ClearDbItem_Click(object sender, EventArgs e)
        {
            Db?.ClearDb();
        }
        private void LogTBox_TextChanged(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(Application.StartupPath + "\\Log.txt", LogTBox.Text, Encoding.Default);
        }

        private void ParametrsDGView_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.Row != null)
            {
                var value = e.Value == null ? "" : e.Value.ToString();
                string fieldColumn = e.Row.Cells["ParametrColumn"].Value.ToString();
                Data.Card.GetType().GetField(fieldColumn).SetValue(Data.Card, value);
                Data.Card.Vcf = Data.Card.GetVCard();
                VcfTBox.Text = Data.Card.Vcf;
                Data.GetLength();
                OnlyUrlBtn_CheckedChanged(this, new EventArgs());
            }

        }
        private void OnlyUrlBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (OnlyUrlBtn.Checked)
            {
                SumSizeValue.Text = Data.OnlyUrlLength.ToString();
            }
            else if (OnlyCardBtn.Checked)
            {
                SumSizeValue.Text = Data.OnlyVcardLength.ToString();
            }
            else if (UrlBeforeCardBtn.Checked)
            {
                SumSizeValue.Text = Data.UrlBeforeCardLength.ToString();
            }
            else
            {
                SumSizeValue.Text = Data.CardBeforeUrlLength.ToString();
            }

            StatusLbl.Image = int.Parse(SumSizeValue.Text) <= int.Parse(MaxSizeValue.Text) ? Properties.Resources.ok : Properties.Resources.error;
        }


        private void MainForm_Shown(object sender, EventArgs e)
        {
            AddDeviceForm frm = new AddDeviceForm
            {
                ShowInTaskbar = false,
                MaximizeBox = false,
                MinimizeBox = false,
                StartPosition = FormStartPosition.CenterParent
            };
            frm.ShowDialog(this);
            if (string.IsNullOrEmpty(frm.Message))
            {
                Close();
            }
            else
            {
                Device = frm.Device;
                LogTBox.Text = frm.Message + LogTBox.Text;
            }
        }

        private string GetData()
        {
            if (OnlyUrlBtn.Checked)
                return Data.GetHexOnlyUrl();
            if (OnlyCardBtn.Checked)
                return Data.GetHexOnlyVcard();
            if (UrlBeforeCardBtn.Checked)
                return Data.GetHexUrlBeforeCard();
            return Data.GetHexVcardBeforeUrl();
        }
        private void VcfTBox_TextChanged(object sender, EventArgs e)
        {
            if (VcfTBox.Text == "" || VcfTBox.Text.ToLower() == "данная ссылка не существует")
                OnlyCardBtn.Enabled = CardBeforeUrl.Enabled = UrlBeforeCardBtn.Enabled = false;
            else
            {
                OnlyCardBtn.Enabled = CardBeforeUrl.Enabled = UrlBeforeCardBtn.Enabled = true;
            }
        }


        private void FormatBtn_Click(object sender, EventArgs e)
        {
            if (Device != null)
            {
                AddCardPanel.Visible = true;
                UrlDGView.Enabled = ParametrsDGView.Enabled = false;
                Device.FormatCardTask();
                AddCardPanel.Visible = false;
                UrlDGView.Enabled = ParametrsDGView.Enabled = true;
            }
            else
            {
                MessageBox.Show(@"Nfc Reader не обнаружен. Перезагрузите программу.", @"Magenta", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }



        }

        public bool GlobalFlag;
        private void WriteBtn_Click(object sender, EventArgs e)
        {
            bool writeEnabled = WriteBtn.Enabled;
            if (Device != null)
            {
                GlobalFlag = true;
                while (GlobalFlag)
                {
                    
                    if (Data != null)
                    {
                        int index = UrlDGView.CurrentRow.Index;
                        string data = GetData();
                        if (data.Length / 2 <= 716)
                        {
                            FormatBtn.Enabled = false;
                            WriteBtn.Enabled = false;
                            AddCardPanel.Visible = true;
                            Application.DoEvents();
                            UrlDGView.Enabled = ParametrsDGView.Enabled = false;

                            AddCardPanel.Visible = true;
                            UrlDGView.Enabled = ParametrsDGView.Enabled = false;
                            string message = Device.WriteDataTask(data);
                            if (message == null)
                            {
                                GlobalFlag = false;
                                continue;
                            }
                            if (message == "error")
                            {
                                MessageBox.Show(@"Nfc Reader не обнаружен. Перезагрузите программу.", @"Magenta", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                                GlobalFlag = false;
                                Close();
                            }
                            else
                            {
                                if (message.Contains("ошибки"))
                                {
                                    UrlDGView.CurrentRow.Cells["StatusColumn"].Value = Properties.Resources.error;
                                    Db.UpdateStatus(-1, int.Parse(UrlDGView.CurrentRow.Cells["IdColumn"].Value.ToString()), File.Hash);
                                    GlobalFlag = false;
                                    break;

                                }
                                UrlDGView.CurrentRow.Cells["StatusColumn"].Value = Properties.Resources.ok;
                                Db.UpdateStatus(1, int.Parse(UrlDGView.CurrentRow.Cells["IdColumn"].Value.ToString()), File.Hash);
                                if (CheckAfterWriteChBox.Checked)
                                {
                                    string vcf = "";
                                    if (Data.Card?.Vcf != null && Data.Card.Vcf != "")
                                        vcf = Data.Card.Vcf;
                                    InfoForm frm = new InfoForm(Data.Url.Url, vcf);
                                    frm.ShowDialog(this);

                                }
                                if (AutoincrementChBox.Checked && index + 1 < UrlDGView.Rows.Count)
                                    UrlDGView.Rows[++index].IsCurrent = true;
                                else if (AutoincrementChBox.Checked)
                                {
                                    writeEnabled = false;
                                }
                                if (!AuthomaticWriteChBox.Checked)
                                    break;
                            }
                            
                            AddCardPanel.Visible = false;
                            UrlDGView.Enabled = ParametrsDGView.Enabled = true;
                            Application.DoEvents();
                            Thread.Sleep(1000);
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show(@"Nfc Reader не обнаружен. Перезагрузите программу.", @"Magenta", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }
            WriteBtn.Enabled = writeEnabled;
            FormatBtn.Enabled = true;
            AddCardPanel.Visible = false;
            UrlDGView.Enabled = ParametrsDGView.Enabled = true;

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            GlobalFlag = false;
            
            Device.FormatFlag = false;
            Device.WriteFlag = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalFlag = false;
            if(Device!=null)
            {
                Device.FormatFlag = false;
                Device.WriteFlag = false;
            }
        }
    }
}
