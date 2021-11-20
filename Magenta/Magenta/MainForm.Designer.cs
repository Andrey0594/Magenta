namespace Magenta
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AutoincrementChBox = new System.Windows.Forms.CheckBox();
            this.AuthomaticWriteChBox = new System.Windows.Forms.CheckBox();
            this.WriteSettingsGBox = new System.Windows.Forms.GroupBox();
            this.CheckAfterWriteChBox = new System.Windows.Forms.CheckBox();
            this.CardBeforeUrl = new System.Windows.Forms.RadioButton();
            this.UrlBeforeCardBtn = new System.Windows.Forms.RadioButton();
            this.OnlyCardBtn = new System.Windows.Forms.RadioButton();
            this.OnlyUrlBtn = new System.Windows.Forms.RadioButton();
            this.WriteBtn = new System.Windows.Forms.Button();
            this.FormatBtn = new System.Windows.Forms.Button();
            this.DataSettingsGBox = new System.Windows.Forms.GroupBox();
            this.LogTBox = new System.Windows.Forms.RichTextBox();
            this.SettingsGBox = new System.Windows.Forms.GroupBox();
            this.StatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.MaxSizeValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.MaxSizeLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.SumSizeValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.SumSizeLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.ParametrsDGView = new Telerik.WinControls.UI.RadGridView();
            this.VcfTBox = new System.Windows.Forms.RichTextBox();
            this.SizeStrip = new System.Windows.Forms.StatusStrip();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.AddCardPanel = new System.Windows.Forms.Panel();
            this.UrlDGView = new Telerik.WinControls.UI.RadGridView();
            this.UrlContainer = new System.Windows.Forms.SplitContainer();
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.ClearDbItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.WriteSettingsGBox.SuspendLayout();
            this.DataSettingsGBox.SuspendLayout();
            this.SettingsGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParametrsDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametrsDGView.MasterTemplate)).BeginInit();
            this.SizeStrip.SuspendLayout();
            this.AddCardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UrlDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrlDGView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrlContainer)).BeginInit();
            this.UrlContainer.Panel1.SuspendLayout();
            this.UrlContainer.Panel2.SuspendLayout();
            this.UrlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoincrementChBox
            // 
            this.AutoincrementChBox.AutoSize = true;
            this.AutoincrementChBox.Location = new System.Drawing.Point(63, 65);
            this.AutoincrementChBox.Name = "AutoincrementChBox";
            this.AutoincrementChBox.Size = new System.Drawing.Size(178, 17);
            this.AutoincrementChBox.TabIndex = 2;
            this.AutoincrementChBox.Text = "Переход к следующей записи";
            this.AutoincrementChBox.UseVisualStyleBackColor = true;
            // 
            // AuthomaticWriteChBox
            // 
            this.AuthomaticWriteChBox.AutoSize = true;
            this.AuthomaticWriteChBox.Location = new System.Drawing.Point(63, 19);
            this.AuthomaticWriteChBox.Name = "AuthomaticWriteChBox";
            this.AuthomaticWriteChBox.Size = new System.Drawing.Size(149, 17);
            this.AuthomaticWriteChBox.TabIndex = 0;
            this.AuthomaticWriteChBox.Text = "Автоматическая запись";
            this.AuthomaticWriteChBox.UseVisualStyleBackColor = true;
            // 
            // WriteSettingsGBox
            // 
            this.WriteSettingsGBox.Controls.Add(this.AutoincrementChBox);
            this.WriteSettingsGBox.Controls.Add(this.CheckAfterWriteChBox);
            this.WriteSettingsGBox.Controls.Add(this.AuthomaticWriteChBox);
            this.WriteSettingsGBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.WriteSettingsGBox.Location = new System.Drawing.Point(3, 16);
            this.WriteSettingsGBox.Name = "WriteSettingsGBox";
            this.WriteSettingsGBox.Size = new System.Drawing.Size(269, 89);
            this.WriteSettingsGBox.TabIndex = 0;
            this.WriteSettingsGBox.TabStop = false;
            this.WriteSettingsGBox.Text = "Настройки записи";
            // 
            // CheckAfterWriteChBox
            // 
            this.CheckAfterWriteChBox.AutoSize = true;
            this.CheckAfterWriteChBox.Location = new System.Drawing.Point(63, 42);
            this.CheckAfterWriteChBox.Name = "CheckAfterWriteChBox";
            this.CheckAfterWriteChBox.Size = new System.Drawing.Size(194, 17);
            this.CheckAfterWriteChBox.TabIndex = 1;
            this.CheckAfterWriteChBox.Text = "Проверять данные после записи";
            this.CheckAfterWriteChBox.UseVisualStyleBackColor = true;
            // 
            // CardBeforeUrl
            // 
            this.CardBeforeUrl.AutoSize = true;
            this.CardBeforeUrl.Enabled = false;
            this.CardBeforeUrl.Location = new System.Drawing.Point(62, 89);
            this.CardBeforeUrl.Name = "CardBeforeUrl";
            this.CardBeforeUrl.Size = new System.Drawing.Size(73, 17);
            this.CardBeforeUrl.TabIndex = 3;
            this.CardBeforeUrl.Text = "VCard, Url";
            this.CardBeforeUrl.UseVisualStyleBackColor = true;
            this.CardBeforeUrl.CheckedChanged += new System.EventHandler(this.OnlyUrlBtn_CheckedChanged);
            // 
            // UrlBeforeCardBtn
            // 
            this.UrlBeforeCardBtn.AutoSize = true;
            this.UrlBeforeCardBtn.Enabled = false;
            this.UrlBeforeCardBtn.Location = new System.Drawing.Point(62, 66);
            this.UrlBeforeCardBtn.Name = "UrlBeforeCardBtn";
            this.UrlBeforeCardBtn.Size = new System.Drawing.Size(73, 17);
            this.UrlBeforeCardBtn.TabIndex = 2;
            this.UrlBeforeCardBtn.Text = "Url, VCard";
            this.UrlBeforeCardBtn.UseVisualStyleBackColor = true;
            this.UrlBeforeCardBtn.CheckedChanged += new System.EventHandler(this.OnlyUrlBtn_CheckedChanged);
            // 
            // OnlyCardBtn
            // 
            this.OnlyCardBtn.AutoSize = true;
            this.OnlyCardBtn.Enabled = false;
            this.OnlyCardBtn.Location = new System.Drawing.Point(62, 43);
            this.OnlyCardBtn.Name = "OnlyCardBtn";
            this.OnlyCardBtn.Size = new System.Drawing.Size(94, 17);
            this.OnlyCardBtn.TabIndex = 1;
            this.OnlyCardBtn.Text = "Только VCard";
            this.OnlyCardBtn.UseVisualStyleBackColor = true;
            this.OnlyCardBtn.CheckedChanged += new System.EventHandler(this.OnlyUrlBtn_CheckedChanged);
            // 
            // OnlyUrlBtn
            // 
            this.OnlyUrlBtn.AutoSize = true;
            this.OnlyUrlBtn.Checked = true;
            this.OnlyUrlBtn.Location = new System.Drawing.Point(62, 20);
            this.OnlyUrlBtn.Name = "OnlyUrlBtn";
            this.OnlyUrlBtn.Size = new System.Drawing.Size(78, 17);
            this.OnlyUrlBtn.TabIndex = 0;
            this.OnlyUrlBtn.TabStop = true;
            this.OnlyUrlBtn.Text = "Только Url";
            this.OnlyUrlBtn.UseVisualStyleBackColor = true;
            this.OnlyUrlBtn.CheckedChanged += new System.EventHandler(this.OnlyUrlBtn_CheckedChanged);
            // 
            // WriteBtn
            // 
            this.WriteBtn.Enabled = false;
            this.WriteBtn.Location = new System.Drawing.Point(7, 290);
            this.WriteBtn.Name = "WriteBtn";
            this.WriteBtn.Size = new System.Drawing.Size(265, 23);
            this.WriteBtn.TabIndex = 3;
            this.WriteBtn.Text = "Записать данные ";
            this.WriteBtn.UseVisualStyleBackColor = true;
            this.WriteBtn.Click += new System.EventHandler(this.WriteBtn_Click);
            // 
            // FormatBtn
            // 
            this.FormatBtn.Location = new System.Drawing.Point(7, 261);
            this.FormatBtn.Name = "FormatBtn";
            this.FormatBtn.Size = new System.Drawing.Size(265, 23);
            this.FormatBtn.TabIndex = 2;
            this.FormatBtn.Text = "Форматировать карту";
            this.FormatBtn.UseVisualStyleBackColor = true;
            this.FormatBtn.Click += new System.EventHandler(this.FormatBtn_Click);
            // 
            // DataSettingsGBox
            // 
            this.DataSettingsGBox.Controls.Add(this.CardBeforeUrl);
            this.DataSettingsGBox.Controls.Add(this.UrlBeforeCardBtn);
            this.DataSettingsGBox.Controls.Add(this.OnlyCardBtn);
            this.DataSettingsGBox.Controls.Add(this.OnlyUrlBtn);
            this.DataSettingsGBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataSettingsGBox.Location = new System.Drawing.Point(3, 105);
            this.DataSettingsGBox.Name = "DataSettingsGBox";
            this.DataSettingsGBox.Size = new System.Drawing.Size(269, 112);
            this.DataSettingsGBox.TabIndex = 1;
            this.DataSettingsGBox.TabStop = false;
            this.DataSettingsGBox.Text = "Данные для записи";
            // 
            // LogTBox
            // 
            this.LogTBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTBox.Location = new System.Drawing.Point(0, 0);
            this.LogTBox.Name = "LogTBox";
            this.LogTBox.ReadOnly = true;
            this.LogTBox.Size = new System.Drawing.Size(1604, 320);
            this.LogTBox.TabIndex = 1;
            this.LogTBox.Text = "";
            this.LogTBox.TextChanged += new System.EventHandler(this.LogTBox_TextChanged);
            // 
            // SettingsGBox
            // 
            this.SettingsGBox.Controls.Add(this.WriteBtn);
            this.SettingsGBox.Controls.Add(this.FormatBtn);
            this.SettingsGBox.Controls.Add(this.DataSettingsGBox);
            this.SettingsGBox.Controls.Add(this.WriteSettingsGBox);
            this.SettingsGBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.SettingsGBox.Location = new System.Drawing.Point(1604, 0);
            this.SettingsGBox.Name = "SettingsGBox";
            this.SettingsGBox.Size = new System.Drawing.Size(275, 320);
            this.SettingsGBox.TabIndex = 0;
            this.SettingsGBox.TabStop = false;
            this.SettingsGBox.Text = "Настройки";
            // 
            // StatusLbl
            // 
            this.StatusLbl.Image = global::Magenta.Properties.Resources.ok;
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(16, 19);
            // 
            // MaxSizeValue
            // 
            this.MaxSizeValue.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.MaxSizeValue.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.MaxSizeValue.Name = "MaxSizeValue";
            this.MaxSizeValue.Size = new System.Drawing.Size(29, 19);
            this.MaxSizeValue.Text = "716";
            // 
            // MaxSizeLbl
            // 
            this.MaxSizeLbl.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.MaxSizeLbl.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.MaxSizeLbl.Name = "MaxSizeLbl";
            this.MaxSizeLbl.Size = new System.Drawing.Size(95, 19);
            this.MaxSizeLbl.Text = "Общий размер";
            // 
            // SumSizeValue
            // 
            this.SumSizeValue.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.SumSizeValue.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.SumSizeValue.Name = "SumSizeValue";
            this.SumSizeValue.Size = new System.Drawing.Size(17, 19);
            this.SumSizeValue.Text = "0";
            // 
            // SumSizeLbl
            // 
            this.SumSizeLbl.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.SumSizeLbl.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.SumSizeLbl.Name = "SumSizeLbl";
            this.SumSizeLbl.Size = new System.Drawing.Size(178, 19);
            this.SumSizeLbl.Text = "Размер записываемых данных";
            // 
            // ParametrsDGView
            // 
            this.ParametrsDGView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParametrsDGView.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.ParametrsDGView.MasterTemplate.AllowAddNewRow = false;
            this.ParametrsDGView.MasterTemplate.AllowCellContextMenu = false;
            this.ParametrsDGView.MasterTemplate.AllowColumnChooser = false;
            this.ParametrsDGView.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.ParametrsDGView.MasterTemplate.AllowColumnReorder = false;
            this.ParametrsDGView.MasterTemplate.AllowDeleteRow = false;
            this.ParametrsDGView.MasterTemplate.AllowDragToGroup = false;
            this.ParametrsDGView.MasterTemplate.AllowRowHeaderContextMenu = false;
            this.ParametrsDGView.MasterTemplate.AllowRowResize = false;
            this.ParametrsDGView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "Параметр";
            gridViewTextBoxColumn1.Name = "ParametrColumn";
            gridViewTextBoxColumn1.Width = 123;
            gridViewTextBoxColumn2.HeaderText = "Значение";
            gridViewTextBoxColumn2.Name = "ValueColumn";
            gridViewTextBoxColumn2.Width = 381;
            this.ParametrsDGView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.ParametrsDGView.MasterTemplate.ShowFilteringRow = false;
            this.ParametrsDGView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.ParametrsDGView.Name = "ParametrsDGView";
            this.ParametrsDGView.ShowCellErrors = false;
            this.ParametrsDGView.ShowGroupPanel = false;
            this.ParametrsDGView.ShowGroupPanelScrollbars = false;
            this.ParametrsDGView.ShowItemToolTips = false;
            this.ParametrsDGView.ShowNoDataText = false;
            this.ParametrsDGView.ShowRowErrors = false;
            this.ParametrsDGView.Size = new System.Drawing.Size(524, 324);
            this.ParametrsDGView.TabIndex = 2;
            this.ParametrsDGView.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.ParametrsDGView_CellValueChanged);
            // 
            // VcfTBox
            // 
            this.VcfTBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.VcfTBox.Location = new System.Drawing.Point(0, 324);
            this.VcfTBox.Name = "VcfTBox";
            this.VcfTBox.ReadOnly = true;
            this.VcfTBox.Size = new System.Drawing.Size(524, 219);
            this.VcfTBox.TabIndex = 1;
            this.VcfTBox.Text = "";
            this.VcfTBox.TextChanged += new System.EventHandler(this.VcfTBox_TextChanged);
            // 
            // SizeStrip
            // 
            this.SizeStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SumSizeLbl,
            this.SumSizeValue,
            this.MaxSizeLbl,
            this.MaxSizeValue,
            this.StatusLbl});
            this.SizeStrip.Location = new System.Drawing.Point(0, 543);
            this.SizeStrip.Name = "SizeStrip";
            this.SizeStrip.Size = new System.Drawing.Size(524, 24);
            this.SizeStrip.TabIndex = 0;
            this.SizeStrip.Text = "statusStrip1";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseBtn.Location = new System.Drawing.Point(0, 163);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(428, 23);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "Отменить запись";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AddCardPanel
            // 
            this.AddCardPanel.BackgroundImage = global::Magenta.Properties.Resources.photo_2021_08_23_14_18_34;
            this.AddCardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddCardPanel.Controls.Add(this.CloseBtn);
            this.AddCardPanel.Location = new System.Drawing.Point(36, 340);
            this.AddCardPanel.Name = "AddCardPanel";
            this.AddCardPanel.Size = new System.Drawing.Size(428, 186);
            this.AddCardPanel.TabIndex = 1;
            this.AddCardPanel.Visible = false;
            // 
            // UrlDGView
            // 
            this.UrlDGView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UrlDGView.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.UrlDGView.MasterTemplate.AllowAddNewRow = false;
            this.UrlDGView.MasterTemplate.AllowCellContextMenu = false;
            this.UrlDGView.MasterTemplate.AllowColumnChooser = false;
            this.UrlDGView.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.UrlDGView.MasterTemplate.AllowColumnReorder = false;
            this.UrlDGView.MasterTemplate.AllowDeleteRow = false;
            this.UrlDGView.MasterTemplate.AllowDragToGroup = false;
            this.UrlDGView.MasterTemplate.AllowEditRow = false;
            this.UrlDGView.MasterTemplate.AllowRowHeaderContextMenu = false;
            this.UrlDGView.MasterTemplate.AllowRowResize = false;
            this.UrlDGView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.UrlDGView.MasterTemplate.ShowFilteringRow = false;
            this.UrlDGView.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.UrlDGView.Name = "UrlDGView";
            this.UrlDGView.ShowCellErrors = false;
            this.UrlDGView.ShowGroupPanel = false;
            this.UrlDGView.ShowGroupPanelScrollbars = false;
            this.UrlDGView.ShowItemToolTips = false;
            this.UrlDGView.ShowNoDataText = false;
            this.UrlDGView.ShowRowErrors = false;
            this.UrlDGView.Size = new System.Drawing.Size(1349, 567);
            this.UrlDGView.TabIndex = 0;
            this.UrlDGView.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.UrlDGView_CurrentRowChanged);
            // 
            // UrlContainer
            // 
            this.UrlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UrlContainer.Location = new System.Drawing.Point(0, 0);
            this.UrlContainer.Name = "UrlContainer";
            // 
            // UrlContainer.Panel1
            // 
            this.UrlContainer.Panel1.Controls.Add(this.UrlDGView);
            // 
            // UrlContainer.Panel2
            // 
            this.UrlContainer.Panel2.Controls.Add(this.AddCardPanel);
            this.UrlContainer.Panel2.Controls.Add(this.ParametrsDGView);
            this.UrlContainer.Panel2.Controls.Add(this.VcfTBox);
            this.UrlContainer.Panel2.Controls.Add(this.SizeStrip);
            this.UrlContainer.Panel2MinSize = 500;
            this.UrlContainer.Size = new System.Drawing.Size(1881, 569);
            this.UrlContainer.SplitterDistance = 1351;
            this.UrlContainer.TabIndex = 0;
            // 
            // MainContainer
            // 
            this.MainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(0, 24);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.Controls.Add(this.UrlContainer);
            // 
            // MainContainer.Panel2
            // 
            this.MainContainer.Panel2.Controls.Add(this.LogTBox);
            this.MainContainer.Panel2.Controls.Add(this.SettingsGBox);
            this.MainContainer.Size = new System.Drawing.Size(1881, 895);
            this.MainContainer.SplitterDistance = 569;
            this.MainContainer.TabIndex = 3;
            // 
            // ClearDbItem
            // 
            this.ClearDbItem.Image = global::Magenta.Properties.Resources.data_delete;
            this.ClearDbItem.Name = "ClearDbItem";
            this.ClearDbItem.Size = new System.Drawing.Size(153, 22);
            this.ClearDbItem.Text = "Очистить БД";
            this.ClearDbItem.Click += new System.EventHandler(this.ClearDbItem_Click);
            // 
            // OpenFileItem
            // 
            this.OpenFileItem.Name = "OpenFileItem";
            this.OpenFileItem.Size = new System.Drawing.Size(153, 22);
            this.OpenFileItem.Text = "Открыть файл";
            this.OpenFileItem.Click += new System.EventHandler(this.OpenFileItem_Click);
            // 
            // FileItem
            // 
            this.FileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileItem,
            this.ClearDbItem});
            this.FileItem.Image = global::Magenta.Properties.Resources.document_plain;
            this.FileItem.Name = "FileItem";
            this.FileItem.Size = new System.Drawing.Size(64, 20);
            this.FileItem.Text = "Файл";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1881, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1881, 919);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magenta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.WriteSettingsGBox.ResumeLayout(false);
            this.WriteSettingsGBox.PerformLayout();
            this.DataSettingsGBox.ResumeLayout(false);
            this.DataSettingsGBox.PerformLayout();
            this.SettingsGBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ParametrsDGView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParametrsDGView)).EndInit();
            this.SizeStrip.ResumeLayout(false);
            this.SizeStrip.PerformLayout();
            this.AddCardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UrlDGView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrlDGView)).EndInit();
            this.UrlContainer.Panel1.ResumeLayout(false);
            this.UrlContainer.Panel2.ResumeLayout(false);
            this.UrlContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UrlContainer)).EndInit();
            this.UrlContainer.ResumeLayout(false);
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox AutoincrementChBox;
        private System.Windows.Forms.CheckBox AuthomaticWriteChBox;
        private System.Windows.Forms.GroupBox WriteSettingsGBox;
        private System.Windows.Forms.CheckBox CheckAfterWriteChBox;
        private System.Windows.Forms.RadioButton CardBeforeUrl;
        private System.Windows.Forms.RadioButton UrlBeforeCardBtn;
        private System.Windows.Forms.RadioButton OnlyCardBtn;
        private System.Windows.Forms.RadioButton OnlyUrlBtn;
        private System.Windows.Forms.Button WriteBtn;
        private System.Windows.Forms.Button FormatBtn;
        private System.Windows.Forms.GroupBox DataSettingsGBox;
        private System.Windows.Forms.GroupBox SettingsGBox;
        private System.Windows.Forms.ToolStripStatusLabel StatusLbl;
        private System.Windows.Forms.ToolStripStatusLabel MaxSizeValue;
        private System.Windows.Forms.ToolStripStatusLabel MaxSizeLbl;
        private System.Windows.Forms.ToolStripStatusLabel SumSizeValue;
        private System.Windows.Forms.ToolStripStatusLabel SumSizeLbl;
        private Telerik.WinControls.UI.RadGridView ParametrsDGView;
        private System.Windows.Forms.RichTextBox VcfTBox;
        private System.Windows.Forms.StatusStrip SizeStrip;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Panel AddCardPanel;
        private Telerik.WinControls.UI.RadGridView UrlDGView;
        private System.Windows.Forms.SplitContainer UrlContainer;
        private System.Windows.Forms.SplitContainer MainContainer;
        private System.Windows.Forms.ToolStripMenuItem ClearDbItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileItem;
        private System.Windows.Forms.ToolStripMenuItem FileItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.RichTextBox LogTBox;
    }
}

