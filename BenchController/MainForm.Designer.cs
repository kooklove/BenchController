using System.Drawing;

namespace BenchController
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.buttonConnect = new System.Windows.Forms.Button();
      this.buttonBenchReset = new System.Windows.Forms.Button();
      this.radioButtonMibCanOn = new System.Windows.Forms.RadioButton();
      this.radioButtonMibCanOff = new System.Windows.Forms.RadioButton();
      this.groupBoxMibCan = new System.Windows.Forms.GroupBox();
      this.radioButtonAbCanOn = new System.Windows.Forms.RadioButton();
      this.radioButtonAbCanOff = new System.Windows.Forms.RadioButton();
      this.groupBoxAbCan = new System.Windows.Forms.GroupBox();
      this.checkBoxExtended = new System.Windows.Forms.CheckBox();
      this.radioButtonKL15On = new System.Windows.Forms.RadioButton();
      this.radioButtonKL15Off = new System.Windows.Forms.RadioButton();
      this.groupBoxKl15 = new System.Windows.Forms.GroupBox();
      this.radioButtonDownloadModeOff = new System.Windows.Forms.RadioButton();
      this.radioButtonDownloadModeOn = new System.Windows.Forms.RadioButton();
      this.comboBoxPort = new System.Windows.Forms.ComboBox();
      this.groupBoxDownloadMode = new System.Windows.Forms.GroupBox();
      this.abCanConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.checkBoxShowTaskBar = new System.Windows.Forms.CheckBox();
      this.checkBoxShowConsole = new System.Windows.Forms.CheckBox();
      this.checkBoxTopMost = new System.Windows.Forms.CheckBox();
      this.buttonReset = new System.Windows.Forms.Button();
      this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
      this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.toolStripMenuItemShowWindow = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemTopMost = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemPower = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemKL15 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemDownloadMode = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemEcuReset = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemBenchReset = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemMibCanConnect = new System.Windows.Forms.ToolStripMenuItem();
      this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.radioButtonPowerOn = new System.Windows.Forms.RadioButton();
      this.radioButtonPowerOff = new System.Windows.Forms.RadioButton();
      this.groupBoxPower = new System.Windows.Forms.GroupBox();
      this.serialPort = new System.IO.Ports.SerialPort(this.components);
      this.settings = new System.Windows.Forms.Button();
      this.groupBoxDoIP = new System.Windows.Forms.GroupBox();
      this.radioButtonDoipOn = new System.Windows.Forms.RadioButton();
      this.radioButtonDoipOff = new System.Windows.Forms.RadioButton();
      this.textBoxPrint = new System.Windows.Forms.TextBox();
      this.groupBoxAutoBenchReset = new System.Windows.Forms.GroupBox();
      this.label_auto_bench_reset_sec = new System.Windows.Forms.Label();
      this.Timer_AutoBenchReset = new System.Windows.Forms.TextBox();
      this.radioButtonAutoBenchResetOn = new System.Windows.Forms.RadioButton();
      this.radioButtonAutoBenchResetOff = new System.Windows.Forms.RadioButton();
      this.groupBoxAutoEcuReset = new System.Windows.Forms.GroupBox();
      this.label_auto_ecu_reset_sec = new System.Windows.Forms.Label();
      this.Timer_AutoEcuReset = new System.Windows.Forms.TextBox();
      this.radioButtonAutoEcuResetOn = new System.Windows.Forms.RadioButton();
      this.radioButtonAutoEcuResetOff = new System.Windows.Forms.RadioButton();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
      this.groupBoxMibCan.SuspendLayout();
      this.groupBoxAbCan.SuspendLayout();
      this.groupBoxKl15.SuspendLayout();
      this.groupBoxDownloadMode.SuspendLayout();
      this.contextMenuStrip.SuspendLayout();
      this.groupBoxPower.SuspendLayout();
      this.groupBoxDoIP.SuspendLayout();
      this.groupBoxAutoBenchReset.SuspendLayout();
      this.groupBoxAutoEcuReset.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonConnect
      // 
      this.buttonConnect.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonConnect.Cursor = System.Windows.Forms.Cursors.Hand;
      this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.buttonConnect.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonConnect.ForeColor = System.Drawing.SystemColors.ControlText;
      this.buttonConnect.Location = new System.Drawing.Point(73, 37);
      this.buttonConnect.Margin = new System.Windows.Forms.Padding(0);
      this.buttonConnect.Name = "buttonConnect";
      this.buttonConnect.Size = new System.Drawing.Size(71, 24);
      this.buttonConnect.TabIndex = 23;
      this.buttonConnect.Text = "Connect";
      this.buttonConnect.UseVisualStyleBackColor = false;
      this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
      // 
      // buttonBenchReset
      // 
      this.buttonBenchReset.BackColor = System.Drawing.Color.IndianRed;
      this.buttonBenchReset.Cursor = System.Windows.Forms.Cursors.Hand;
      this.buttonBenchReset.Enabled = false;
      this.buttonBenchReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.buttonBenchReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonBenchReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.buttonBenchReset.Location = new System.Drawing.Point(6, 65);
      this.buttonBenchReset.Margin = new System.Windows.Forms.Padding(0);
      this.buttonBenchReset.Name = "buttonBenchReset";
      this.buttonBenchReset.Size = new System.Drawing.Size(96, 25);
      this.buttonBenchReset.TabIndex = 22;
      this.buttonBenchReset.Text = "BenchReset";
      this.buttonBenchReset.UseVisualStyleBackColor = false;
      this.buttonBenchReset.Click += new System.EventHandler(this.buttonBenchReset_Click);
      // 
      // radioButtonMibCanOn
      // 
      this.radioButtonMibCanOn.Appearance = System.Windows.Forms.Appearance.Button;
      this.radioButtonMibCanOn.AutoSize = true;
      this.radioButtonMibCanOn.BackColor = System.Drawing.Color.Transparent;
      this.radioButtonMibCanOn.Enabled = false;
      this.radioButtonMibCanOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonMibCanOn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
      this.radioButtonMibCanOn.Location = new System.Drawing.Point(67, 12);
      this.radioButtonMibCanOn.Margin = new System.Windows.Forms.Padding(0);
      this.radioButtonMibCanOn.Name = "radioButtonMibCanOn";
      this.radioButtonMibCanOn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.radioButtonMibCanOn.Size = new System.Drawing.Size(31, 22);
      this.radioButtonMibCanOn.TabIndex = 4;
      this.radioButtonMibCanOn.TabStop = true;
      this.radioButtonMibCanOn.Text = "On";
      this.radioButtonMibCanOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.radioButtonMibCanOn.UseVisualStyleBackColor = false;
      this.radioButtonMibCanOn.CheckedChanged += new System.EventHandler(this.radioButtonMibCanOn_CheckedChanged);
      // 
      // radioButtonMibCanOff
      // 
      this.radioButtonMibCanOff.Appearance = System.Windows.Forms.Appearance.Button;
      this.radioButtonMibCanOff.AutoSize = true;
      this.radioButtonMibCanOff.BackColor = System.Drawing.Color.Transparent;
      this.radioButtonMibCanOff.Enabled = false;
      this.radioButtonMibCanOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonMibCanOff.Location = new System.Drawing.Point(100, 12);
      this.radioButtonMibCanOff.Margin = new System.Windows.Forms.Padding(0);
      this.radioButtonMibCanOff.Name = "radioButtonMibCanOff";
      this.radioButtonMibCanOff.Size = new System.Drawing.Size(32, 22);
      this.radioButtonMibCanOff.TabIndex = 3;
      this.radioButtonMibCanOff.TabStop = true;
      this.radioButtonMibCanOff.Text = "Off";
      this.radioButtonMibCanOff.UseVisualStyleBackColor = false;
      this.radioButtonMibCanOff.CheckedChanged += new System.EventHandler(this.radioButtonMibCanOff_CheckedChanged);
      // 
      // groupBoxMibCan
      // 
      this.groupBoxMibCan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.groupBoxMibCan.Controls.Add(this.radioButtonMibCanOn);
      this.groupBoxMibCan.Controls.Add(this.radioButtonMibCanOff);
      this.groupBoxMibCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.groupBoxMibCan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
      this.groupBoxMibCan.Location = new System.Drawing.Point(6, 252);
      this.groupBoxMibCan.Margin = new System.Windows.Forms.Padding(0);
      this.groupBoxMibCan.Name = "groupBoxMibCan";
      this.groupBoxMibCan.Padding = new System.Windows.Forms.Padding(0);
      this.groupBoxMibCan.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.groupBoxMibCan.Size = new System.Drawing.Size(155, 40);
      this.groupBoxMibCan.TabIndex = 19;
      this.groupBoxMibCan.TabStop = false;
      this.groupBoxMibCan.Text = "MIB CAN";
      this.groupBoxMibCan.Visible = false;
      // 
      // radioButtonAbCanOn
      // 
      this.radioButtonAbCanOn.Appearance = System.Windows.Forms.Appearance.Button;
      this.radioButtonAbCanOn.AutoSize = true;
      this.radioButtonAbCanOn.BackColor = System.Drawing.Color.Transparent;
      this.radioButtonAbCanOn.Enabled = false;
      this.radioButtonAbCanOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonAbCanOn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
      this.radioButtonAbCanOn.Location = new System.Drawing.Point(67, 10);
      this.radioButtonAbCanOn.Margin = new System.Windows.Forms.Padding(0);
      this.radioButtonAbCanOn.Name = "radioButtonAbCanOn";
      this.radioButtonAbCanOn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.radioButtonAbCanOn.Size = new System.Drawing.Size(31, 22);
      this.radioButtonAbCanOn.TabIndex = 4;
      this.radioButtonAbCanOn.TabStop = true;
      this.radioButtonAbCanOn.Text = "On";
      this.radioButtonAbCanOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.radioButtonAbCanOn.UseVisualStyleBackColor = false;
      this.radioButtonAbCanOn.CheckedChanged += new System.EventHandler(this.radioButtonAbCanOn_CheckedChanged);
      // 
      // radioButtonAbCanOff
      // 
      this.radioButtonAbCanOff.Appearance = System.Windows.Forms.Appearance.Button;
      this.radioButtonAbCanOff.AutoSize = true;
      this.radioButtonAbCanOff.BackColor = System.Drawing.Color.Transparent;
      this.radioButtonAbCanOff.Enabled = false;
      this.radioButtonAbCanOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonAbCanOff.Location = new System.Drawing.Point(100, 10);
      this.radioButtonAbCanOff.Margin = new System.Windows.Forms.Padding(0);
      this.radioButtonAbCanOff.Name = "radioButtonAbCanOff";
      this.radioButtonAbCanOff.Size = new System.Drawing.Size(32, 22);
      this.radioButtonAbCanOff.TabIndex = 3;
      this.radioButtonAbCanOff.TabStop = true;
      this.radioButtonAbCanOff.Text = "Off";
      this.radioButtonAbCanOff.UseVisualStyleBackColor = false;
      this.radioButtonAbCanOff.CheckedChanged += new System.EventHandler(this.radioButtonAbCanOff_CheckedChanged);
      // 
      // groupBoxAbCan
      // 
      this.groupBoxAbCan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.groupBoxAbCan.Controls.Add(this.radioButtonAbCanOn);
      this.groupBoxAbCan.Controls.Add(this.radioButtonAbCanOff);
      this.groupBoxAbCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.groupBoxAbCan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
      this.groupBoxAbCan.Location = new System.Drawing.Point(6, 211);
      this.groupBoxAbCan.Margin = new System.Windows.Forms.Padding(0);
      this.groupBoxAbCan.Name = "groupBoxAbCan";
      this.groupBoxAbCan.Padding = new System.Windows.Forms.Padding(0);
      this.groupBoxAbCan.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.groupBoxAbCan.Size = new System.Drawing.Size(155, 38);
      this.groupBoxAbCan.TabIndex = 20;
      this.groupBoxAbCan.TabStop = false;
      this.groupBoxAbCan.Text = "AB CAN";
      this.groupBoxAbCan.Visible = false;
      // 
      // checkBoxExtended
      // 
      this.checkBoxExtended.AutoSize = true;
      this.checkBoxExtended.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBoxExtended.Location = new System.Drawing.Point(6, 19);
      this.checkBoxExtended.Margin = new System.Windows.Forms.Padding(0);
      this.checkBoxExtended.Name = "checkBoxExtended";
      this.checkBoxExtended.Size = new System.Drawing.Size(76, 16);
      this.checkBoxExtended.TabIndex = 21;
      this.checkBoxExtended.Text = "Extended";
      this.checkBoxExtended.UseVisualStyleBackColor = true;
      this.checkBoxExtended.CheckedChanged += new System.EventHandler(this.CheckBoxExtended_CheckedChanged);
      // 
      // radioButtonKL15On
      // 
      this.radioButtonKL15On.Appearance = System.Windows.Forms.Appearance.Button;
      this.radioButtonKL15On.AutoSize = true;
      this.radioButtonKL15On.BackColor = System.Drawing.Color.Transparent;
      this.radioButtonKL15On.Enabled = false;
      this.radioButtonKL15On.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonKL15On.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButtonKL15On.Location = new System.Drawing.Point(66, 11);
      this.radioButtonKL15On.Margin = new System.Windows.Forms.Padding(0);
      this.radioButtonKL15On.Name = "radioButtonKL15On";
      this.radioButtonKL15On.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.radioButtonKL15On.Size = new System.Drawing.Size(31, 22);
      this.radioButtonKL15On.TabIndex = 4;
      this.radioButtonKL15On.TabStop = true;
      this.radioButtonKL15On.Text = "On";
      this.radioButtonKL15On.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.radioButtonKL15On.UseVisualStyleBackColor = false;
      this.radioButtonKL15On.CheckedChanged += new System.EventHandler(this.radioButtonKL15On_CheckedChanged);
      // 
      // radioButtonKL15Off
      // 
      this.radioButtonKL15Off.Appearance = System.Windows.Forms.Appearance.Button;
      this.radioButtonKL15Off.AutoSize = true;
      this.radioButtonKL15Off.BackColor = System.Drawing.Color.Transparent;
      this.radioButtonKL15Off.Enabled = false;
      this.radioButtonKL15Off.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonKL15Off.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButtonKL15Off.Location = new System.Drawing.Point(99, 11);
      this.radioButtonKL15Off.Margin = new System.Windows.Forms.Padding(0);
      this.radioButtonKL15Off.Name = "radioButtonKL15Off";
      this.radioButtonKL15Off.Size = new System.Drawing.Size(32, 22);
      this.radioButtonKL15Off.TabIndex = 3;
      this.radioButtonKL15Off.TabStop = true;
      this.radioButtonKL15Off.Text = "Off";
      this.radioButtonKL15Off.UseVisualStyleBackColor = false;
      this.radioButtonKL15Off.CheckedChanged += new System.EventHandler(this.radioButtonKL15Off_CheckedChanged);
      // 
      // groupBoxKl15
      // 
      this.groupBoxKl15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.groupBoxKl15.Controls.Add(this.radioButtonKL15On);
      this.groupBoxKl15.Controls.Add(this.radioButtonKL15Off);
      this.groupBoxKl15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.groupBoxKl15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBoxKl15.Location = new System.Drawing.Point(8, 130);
      this.groupBoxKl15.Margin = new System.Windows.Forms.Padding(0);
      this.groupBoxKl15.Name = "groupBoxKl15";
      this.groupBoxKl15.Padding = new System.Windows.Forms.Padding(0);
      this.groupBoxKl15.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.groupBoxKl15.Size = new System.Drawing.Size(153, 39);
      this.groupBoxKl15.TabIndex = 17;
      this.groupBoxKl15.TabStop = false;
      this.groupBoxKl15.Text = "KL15";
      // 
      // radioButtonDownloadModeOff
      // 
      this.radioButtonDownloadModeOff.Appearance = System.Windows.Forms.Appearance.Button;
      this.radioButtonDownloadModeOff.AutoSize = true;
      this.radioButtonDownloadModeOff.BackColor = System.Drawing.Color.Transparent;
      this.radioButtonDownloadModeOff.Enabled = false;
      this.radioButtonDownloadModeOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonDownloadModeOff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButtonDownloadModeOff.Location = new System.Drawing.Point(100, 10);
      this.radioButtonDownloadModeOff.Margin = new System.Windows.Forms.Padding(0);
      this.radioButtonDownloadModeOff.Name = "radioButtonDownloadModeOff";
      this.radioButtonDownloadModeOff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.radioButtonDownloadModeOff.Size = new System.Drawing.Size(32, 22);
      this.radioButtonDownloadModeOff.TabIndex = 4;
      this.radioButtonDownloadModeOff.TabStop = true;
      this.radioButtonDownloadModeOff.Text = "Off";
      this.radioButtonDownloadModeOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.radioButtonDownloadModeOff.UseVisualStyleBackColor = false;
      this.radioButtonDownloadModeOff.CheckedChanged += new System.EventHandler(this.radioButtonDownloadModeOff_CheckedChanged);
      // 
      // radioButtonDownloadModeOn
      // 
      this.radioButtonDownloadModeOn.Appearance = System.Windows.Forms.Appearance.Button;
      this.radioButtonDownloadModeOn.AutoSize = true;
      this.radioButtonDownloadModeOn.BackColor = System.Drawing.Color.Transparent;
      this.radioButtonDownloadModeOn.Enabled = false;
      this.radioButtonDownloadModeOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonDownloadModeOn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButtonDownloadModeOn.Location = new System.Drawing.Point(66, 10);
      this.radioButtonDownloadModeOn.Margin = new System.Windows.Forms.Padding(0);
      this.radioButtonDownloadModeOn.Name = "radioButtonDownloadModeOn";
      this.radioButtonDownloadModeOn.Size = new System.Drawing.Size(31, 22);
      this.radioButtonDownloadModeOn.TabIndex = 3;
      this.radioButtonDownloadModeOn.TabStop = true;
      this.radioButtonDownloadModeOn.Text = "On";
      this.radioButtonDownloadModeOn.UseVisualStyleBackColor = false;
      this.radioButtonDownloadModeOn.CheckedChanged += new System.EventHandler(this.radioButtonDownloadModeOn_CheckedChanged);
      // 
      // comboBoxPort
      // 
      this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxPort.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBoxPort.FormattingEnabled = true;
      this.comboBoxPort.Location = new System.Drawing.Point(6, 37);
      this.comboBoxPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.comboBoxPort.Name = "comboBoxPort";
      this.comboBoxPort.Size = new System.Drawing.Size(64, 20);
      this.comboBoxPort.Sorted = true;
      this.comboBoxPort.TabIndex = 24;
      this.comboBoxPort.DropDown += new System.EventHandler(this.ComboBoxPort_DropDownSelected);
      this.comboBoxPort.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPort_SelectedIndexChanged);
      // 
      // groupBoxDownloadMode
      // 
      this.groupBoxDownloadMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.groupBoxDownloadMode.Controls.Add(this.radioButtonDownloadModeOff);
      this.groupBoxDownloadMode.Controls.Add(this.radioButtonDownloadModeOn);
      this.groupBoxDownloadMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.groupBoxDownloadMode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBoxDownloadMode.Location = new System.Drawing.Point(8, 171);
      this.groupBoxDownloadMode.Margin = new System.Windows.Forms.Padding(0);
      this.groupBoxDownloadMode.Name = "groupBoxDownloadMode";
      this.groupBoxDownloadMode.Padding = new System.Windows.Forms.Padding(0);
      this.groupBoxDownloadMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.groupBoxDownloadMode.Size = new System.Drawing.Size(153, 39);
      this.groupBoxDownloadMode.TabIndex = 18;
      this.groupBoxDownloadMode.TabStop = false;
      this.groupBoxDownloadMode.Text = "DN Mode";
      // 
      // abCanConnectToolStripMenuItem
      // 
      this.abCanConnectToolStripMenuItem.Name = "abCanConnectToolStripMenuItem";
      this.abCanConnectToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
      this.abCanConnectToolStripMenuItem.Text = "ABCAN Connect";
      this.abCanConnectToolStripMenuItem.Visible = false;
      // 
      // checkBoxShowTaskBar
      // 
      this.checkBoxShowTaskBar.AutoSize = true;
      this.checkBoxShowTaskBar.Checked = true;
      this.checkBoxShowTaskBar.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxShowTaskBar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBoxShowTaskBar.Location = new System.Drawing.Point(96, 1);
      this.checkBoxShowTaskBar.Margin = new System.Windows.Forms.Padding(0);
      this.checkBoxShowTaskBar.Name = "checkBoxShowTaskBar";
      this.checkBoxShowTaskBar.Size = new System.Drawing.Size(70, 16);
      this.checkBoxShowTaskBar.TabIndex = 14;
      this.checkBoxShowTaskBar.Text = "TaskBar";
      this.checkBoxShowTaskBar.UseVisualStyleBackColor = true;
      this.checkBoxShowTaskBar.CheckedChanged += new System.EventHandler(this.CheckBoxShowTaskBar_CheckedChanged);
      // 
      // checkBoxShowConsole
      // 
      this.checkBoxShowConsole.AutoSize = true;
      this.checkBoxShowConsole.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBoxShowConsole.Location = new System.Drawing.Point(96, 19);
      this.checkBoxShowConsole.Margin = new System.Windows.Forms.Padding(0);
      this.checkBoxShowConsole.Name = "checkBoxShowConsole";
      this.checkBoxShowConsole.Size = new System.Drawing.Size(69, 16);
      this.checkBoxShowConsole.TabIndex = 15;
      this.checkBoxShowConsole.Text = "Console";
      this.checkBoxShowConsole.UseVisualStyleBackColor = true;
      this.checkBoxShowConsole.CheckedChanged += new System.EventHandler(this.CheckBoxShowConsole_CheckedChanged);
      // 
      // checkBoxTopMost
      // 
      this.checkBoxTopMost.AutoSize = true;
      this.checkBoxTopMost.Checked = true;
      this.checkBoxTopMost.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxTopMost.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkBoxTopMost.Location = new System.Drawing.Point(6, 1);
      this.checkBoxTopMost.Margin = new System.Windows.Forms.Padding(0);
      this.checkBoxTopMost.Name = "checkBoxTopMost";
      this.checkBoxTopMost.Size = new System.Drawing.Size(71, 16);
      this.checkBoxTopMost.TabIndex = 13;
      this.checkBoxTopMost.Text = "TopMost";
      this.checkBoxTopMost.UseVisualStyleBackColor = true;
      this.checkBoxTopMost.CheckedChanged += new System.EventHandler(this.CheckBoxTopMost_CheckedChanged);
      // 
      // buttonReset
      // 
      this.buttonReset.BackColor = System.Drawing.Color.IndianRed;
      this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
      this.buttonReset.Enabled = false;
      this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.buttonReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.buttonReset.Location = new System.Drawing.Point(105, 65);
      this.buttonReset.Margin = new System.Windows.Forms.Padding(0);
      this.buttonReset.Name = "buttonReset";
      this.buttonReset.Size = new System.Drawing.Size(58, 25);
      this.buttonReset.TabIndex = 12;
      this.buttonReset.Text = "Reset";
      this.buttonReset.UseVisualStyleBackColor = false;
      this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
      // 
      // notifyIcon
      // 
      this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
      this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
      this.notifyIcon.Text = "BenchController";
      this.notifyIcon.Visible = true;
      this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
      // 
      // contextMenuStrip
      // 
      this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShowWindow,
            this.toolStripMenuItemTopMost,
            this.toolStripMenuItemPower,
            this.toolStripMenuItemKL15,
            this.toolStripMenuItemDownloadMode,
            this.toolStripMenuItemEcuReset,
            this.toolStripMenuItemBenchReset,
            this.abCanConnectToolStripMenuItem,
            this.toolStripMenuItemMibCanConnect,
            this.closeToolStripMenuItem});
      this.contextMenuStrip.Name = "contextMenuStrip";
      this.contextMenuStrip.Size = new System.Drawing.Size(170, 224);
      this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
      // 
      // toolStripMenuItemShowWindow
      // 
      this.toolStripMenuItemShowWindow.Name = "toolStripMenuItemShowWindow";
      this.toolStripMenuItemShowWindow.Size = new System.Drawing.Size(169, 22);
      this.toolStripMenuItemShowWindow.Text = "ShowWindow";
      this.toolStripMenuItemShowWindow.Click += new System.EventHandler(this.toolStripMenuItemShowWindow_Click);
      // 
      // toolStripMenuItemTopMost
      // 
      this.toolStripMenuItemTopMost.Checked = this.TopMost;
      this.toolStripMenuItemTopMost.CheckOnClick = true;
      this.toolStripMenuItemTopMost.CheckState = System.Windows.Forms.CheckState.Checked;
      this.toolStripMenuItemTopMost.Name = "toolStripMenuItemTopMost";
      this.toolStripMenuItemTopMost.Size = new System.Drawing.Size(169, 22);
      this.toolStripMenuItemTopMost.Text = "TopMost";
      this.toolStripMenuItemTopMost.Click += new System.EventHandler(this.toolStripMenuItemTopMost_Click);
      // 
      // toolStripMenuItemPower
      // 
      this.toolStripMenuItemPower.Checked = true;
      this.toolStripMenuItemPower.CheckOnClick = true;
      this.toolStripMenuItemPower.CheckState = System.Windows.Forms.CheckState.Checked;
      this.toolStripMenuItemPower.Enabled = false;
      this.toolStripMenuItemPower.Name = "toolStripMenuItemPower";
      this.toolStripMenuItemPower.Size = new System.Drawing.Size(169, 22);
      this.toolStripMenuItemPower.Text = "PowerOn";
      this.toolStripMenuItemPower.Click += new System.EventHandler(this.toolStripMenuItemPower_Click);
      // 
      // toolStripMenuItemKL15
      // 
      this.toolStripMenuItemKL15.Checked = true;
      this.toolStripMenuItemKL15.CheckOnClick = true;
      this.toolStripMenuItemKL15.CheckState = System.Windows.Forms.CheckState.Checked;
      this.toolStripMenuItemKL15.Enabled = false;
      this.toolStripMenuItemKL15.Name = "toolStripMenuItemKL15";
      this.toolStripMenuItemKL15.Size = new System.Drawing.Size(169, 22);
      this.toolStripMenuItemKL15.Text = "KL15On";
      this.toolStripMenuItemKL15.Click += new System.EventHandler(this.toolStripMenuItemKL15_Click);
      // 
      // toolStripMenuItemDownloadMode
      // 
      this.toolStripMenuItemDownloadMode.Checked = true;
      this.toolStripMenuItemDownloadMode.CheckOnClick = true;
      this.toolStripMenuItemDownloadMode.CheckState = System.Windows.Forms.CheckState.Checked;
      this.toolStripMenuItemDownloadMode.Enabled = false;
      this.toolStripMenuItemDownloadMode.Name = "toolStripMenuItemDownloadMode";
      this.toolStripMenuItemDownloadMode.Size = new System.Drawing.Size(169, 22);
      this.toolStripMenuItemDownloadMode.Text = "Download Mode";
      this.toolStripMenuItemDownloadMode.Click += new System.EventHandler(this.toolStripMenuItemDownloadMode_Click);
      // 
      // toolStripMenuItemEcuReset
      // 
      this.toolStripMenuItemEcuReset.Enabled = false;
      this.toolStripMenuItemEcuReset.Name = "toolStripMenuItemEcuReset";
      this.toolStripMenuItemEcuReset.Size = new System.Drawing.Size(169, 22);
      this.toolStripMenuItemEcuReset.Text = "Reset";
      // 
      // toolStripMenuItemBenchReset
      // 
      this.toolStripMenuItemBenchReset.Enabled = false;
      this.toolStripMenuItemBenchReset.Name = "toolStripMenuItemBenchReset";
      this.toolStripMenuItemBenchReset.Size = new System.Drawing.Size(169, 22);
      this.toolStripMenuItemBenchReset.Text = "Bench Reset";
      // 
      // toolStripMenuItemMibCanConnect
      // 
      this.toolStripMenuItemMibCanConnect.Enabled = false;
      this.toolStripMenuItemMibCanConnect.Name = "toolStripMenuItemMibCanConnect";
      this.toolStripMenuItemMibCanConnect.Size = new System.Drawing.Size(169, 22);
      this.toolStripMenuItemMibCanConnect.Text = "MIBCAN Connect";
      this.toolStripMenuItemMibCanConnect.Visible = false;
      // 
      // closeToolStripMenuItem
      // 
      this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
      this.closeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
      this.closeToolStripMenuItem.Text = "Close";
      this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
      // 
      // radioButtonPowerOn
      // 
      this.radioButtonPowerOn.Appearance = System.Windows.Forms.Appearance.Button;
      this.radioButtonPowerOn.AutoSize = true;
      this.radioButtonPowerOn.BackColor = System.Drawing.Color.Transparent;
      this.radioButtonPowerOn.Enabled = false;
      this.radioButtonPowerOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonPowerOn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButtonPowerOn.Location = new System.Drawing.Point(67, 10);
      this.radioButtonPowerOn.Margin = new System.Windows.Forms.Padding(0);
      this.radioButtonPowerOn.Name = "radioButtonPowerOn";
      this.radioButtonPowerOn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.radioButtonPowerOn.Size = new System.Drawing.Size(31, 22);
      this.radioButtonPowerOn.TabIndex = 4;
      this.radioButtonPowerOn.TabStop = true;
      this.radioButtonPowerOn.Text = "On";
      this.radioButtonPowerOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.radioButtonPowerOn.UseVisualStyleBackColor = false;
      this.radioButtonPowerOn.CheckedChanged += new System.EventHandler(this.radioButtonPowerOn_CheckedChanged);
      // 
      // radioButtonPowerOff
      // 
      this.radioButtonPowerOff.Appearance = System.Windows.Forms.Appearance.Button;
      this.radioButtonPowerOff.AutoSize = true;
      this.radioButtonPowerOff.BackColor = System.Drawing.Color.Transparent;
      this.radioButtonPowerOff.Enabled = false;
      this.radioButtonPowerOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonPowerOff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButtonPowerOff.Location = new System.Drawing.Point(100, 10);
      this.radioButtonPowerOff.Margin = new System.Windows.Forms.Padding(0);
      this.radioButtonPowerOff.Name = "radioButtonPowerOff";
      this.radioButtonPowerOff.Size = new System.Drawing.Size(32, 22);
      this.radioButtonPowerOff.TabIndex = 3;
      this.radioButtonPowerOff.TabStop = true;
      this.radioButtonPowerOff.Text = "Off";
      this.radioButtonPowerOff.UseVisualStyleBackColor = false;
      this.radioButtonPowerOff.CheckedChanged += new System.EventHandler(this.radioButtonPowerOff_CheckedChanged);
      // 
      // groupBoxPower
      // 
      this.groupBoxPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.groupBoxPower.Controls.Add(this.radioButtonPowerOn);
      this.groupBoxPower.Controls.Add(this.radioButtonPowerOff);
      this.groupBoxPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.groupBoxPower.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBoxPower.Location = new System.Drawing.Point(8, 92);
      this.groupBoxPower.Margin = new System.Windows.Forms.Padding(0);
      this.groupBoxPower.Name = "groupBoxPower";
      this.groupBoxPower.Padding = new System.Windows.Forms.Padding(0);
      this.groupBoxPower.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.groupBoxPower.Size = new System.Drawing.Size(153, 38);
      this.groupBoxPower.TabIndex = 16;
      this.groupBoxPower.TabStop = false;
      this.groupBoxPower.Text = "Power";
      // 
      // settings
      // 
      this.settings.BackgroundImage = global::BenchController.Properties.Resources.settings;
      this.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.settings.FlatAppearance.BorderSize = 0;
      this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.settings.Location = new System.Drawing.Point(145, 39);
      this.settings.Margin = new System.Windows.Forms.Padding(0);
      this.settings.Name = "settings";
      this.settings.Size = new System.Drawing.Size(19, 19);
      this.settings.TabIndex = 25;
      this.settings.UseVisualStyleBackColor = true;
      this.settings.Click += new System.EventHandler(this.settings_Click);
      // 
      // groupBoxDoIP
      // 
      this.groupBoxDoIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.groupBoxDoIP.Controls.Add(this.radioButtonDoipOn);
      this.groupBoxDoIP.Controls.Add(this.radioButtonDoipOff);
      this.groupBoxDoIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.groupBoxDoIP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
      this.groupBoxDoIP.Location = new System.Drawing.Point(6, 295);
      this.groupBoxDoIP.Margin = new System.Windows.Forms.Padding(0);
      this.groupBoxDoIP.Name = "groupBoxDoIP";
      this.groupBoxDoIP.Padding = new System.Windows.Forms.Padding(0);
      this.groupBoxDoIP.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.groupBoxDoIP.Size = new System.Drawing.Size(155, 40);
      this.groupBoxDoIP.TabIndex = 20;
      this.groupBoxDoIP.TabStop = false;
      this.groupBoxDoIP.Text = "DoIP";
      this.groupBoxDoIP.Visible = false;
      // 
      // radioButtonDoipOn
      // 
      this.radioButtonDoipOn.Appearance = System.Windows.Forms.Appearance.Button;
      this.radioButtonDoipOn.AutoSize = true;
      this.radioButtonDoipOn.BackColor = System.Drawing.Color.Transparent;
      this.radioButtonDoipOn.Enabled = false;
      this.radioButtonDoipOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonDoipOn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
      this.radioButtonDoipOn.Location = new System.Drawing.Point(67, 12);
      this.radioButtonDoipOn.Margin = new System.Windows.Forms.Padding(0);
      this.radioButtonDoipOn.Name = "radioButtonDoipOn";
      this.radioButtonDoipOn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.radioButtonDoipOn.Size = new System.Drawing.Size(31, 22);
      this.radioButtonDoipOn.TabIndex = 4;
      this.radioButtonDoipOn.TabStop = true;
      this.radioButtonDoipOn.Text = "On";
      this.radioButtonDoipOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.radioButtonDoipOn.UseVisualStyleBackColor = false;
      this.radioButtonDoipOn.CheckedChanged += new System.EventHandler(this.radioButtonDoIPOn_CheckedChanged);
      // 
      // radioButtonDoipOff
      // 
      this.radioButtonDoipOff.Appearance = System.Windows.Forms.Appearance.Button;
      this.radioButtonDoipOff.AutoSize = true;
      this.radioButtonDoipOff.BackColor = System.Drawing.Color.Transparent;
      this.radioButtonDoipOff.Enabled = false;
      this.radioButtonDoipOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonDoipOff.Location = new System.Drawing.Point(100, 12);
      this.radioButtonDoipOff.Margin = new System.Windows.Forms.Padding(0);
      this.radioButtonDoipOff.Name = "radioButtonDoipOff";
      this.radioButtonDoipOff.Size = new System.Drawing.Size(32, 22);
      this.radioButtonDoipOff.TabIndex = 3;
      this.radioButtonDoipOff.TabStop = true;
      this.radioButtonDoipOff.Text = "Off";
      this.radioButtonDoipOff.UseVisualStyleBackColor = false;
      this.radioButtonDoipOff.CheckedChanged += new System.EventHandler(this.radioButtonDoIPOff_CheckedChanged);
      // 
      // textBoxPrint
      // 
      this.textBoxPrint.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxPrint.Location = new System.Drawing.Point(187, 5);
      this.textBoxPrint.Multiline = true;
      this.textBoxPrint.Name = "textBoxPrint";
      this.textBoxPrint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBoxPrint.Size = new System.Drawing.Size(146, 198);
      this.textBoxPrint.TabIndex = 26;
      this.textBoxPrint.TextChanged += new System.EventHandler(this.TextBoxPrint_TextChanged);
      // 
      // groupBoxAutoBenchReset
      // 
      this.groupBoxAutoBenchReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.groupBoxAutoBenchReset.Controls.Add(this.label_auto_bench_reset_sec);
      this.groupBoxAutoBenchReset.Controls.Add(this.Timer_AutoBenchReset);
      this.groupBoxAutoBenchReset.Controls.Add(this.radioButtonAutoBenchResetOn);
      this.groupBoxAutoBenchReset.Controls.Add(this.radioButtonAutoBenchResetOff);
      this.groupBoxAutoBenchReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.groupBoxAutoBenchReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
      this.groupBoxAutoBenchReset.Location = new System.Drawing.Point(6, 335);
      this.groupBoxAutoBenchReset.Margin = new System.Windows.Forms.Padding(0);
      this.groupBoxAutoBenchReset.Name = "groupBoxAutoBenchReset";
      this.groupBoxAutoBenchReset.Padding = new System.Windows.Forms.Padding(0);
      this.groupBoxAutoBenchReset.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.groupBoxAutoBenchReset.Size = new System.Drawing.Size(155, 40);
      this.groupBoxAutoBenchReset.TabIndex = 21;
      this.groupBoxAutoBenchReset.TabStop = false;
      this.groupBoxAutoBenchReset.Text = "Auto Bench Reset";
      this.groupBoxAutoBenchReset.Visible = false;
      // 
      // label_auto_bench_reset_sec
      // 
      this.label_auto_bench_reset_sec.AutoSize = true;
      this.label_auto_bench_reset_sec.Location = new System.Drawing.Point(59, 16);
      this.label_auto_bench_reset_sec.Name = "label_auto_bench_reset_sec";
      this.label_auto_bench_reset_sec.Size = new System.Drawing.Size(25, 12);
      this.label_auto_bench_reset_sec.TabIndex = 29;
      this.label_auto_bench_reset_sec.Text = "sec";
      // 
      // Timer_AutoBenchReset
      // 
      this.Timer_AutoBenchReset.Location = new System.Drawing.Point(6, 13);
      this.Timer_AutoBenchReset.Name = "Timer_AutoBenchReset";
      this.Timer_AutoBenchReset.Size = new System.Drawing.Size(53, 20);
      this.Timer_AutoBenchReset.TabIndex = 27;
      this.Timer_AutoBenchReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.Timer_AutoBenchReset.Validating += new System.ComponentModel.CancelEventHandler(this.Timer_AutoBenchReset_Validating);
      // 
      // radioButtonAutoBenchResetOn
      // 
      this.radioButtonAutoBenchResetOn.Appearance = System.Windows.Forms.Appearance.Button;
      this.radioButtonAutoBenchResetOn.AutoSize = true;
      this.radioButtonAutoBenchResetOn.BackColor = System.Drawing.SystemColors.Control;
      this.radioButtonAutoBenchResetOn.Enabled = false;
      this.radioButtonAutoBenchResetOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonAutoBenchResetOn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
      this.radioButtonAutoBenchResetOn.Location = new System.Drawing.Point(87, 11);
      this.radioButtonAutoBenchResetOn.Margin = new System.Windows.Forms.Padding(0);
      this.radioButtonAutoBenchResetOn.Name = "radioButtonAutoBenchResetOn";
      this.radioButtonAutoBenchResetOn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.radioButtonAutoBenchResetOn.Size = new System.Drawing.Size(31, 22);
      this.radioButtonAutoBenchResetOn.TabIndex = 4;
      this.radioButtonAutoBenchResetOn.TabStop = true;
      this.radioButtonAutoBenchResetOn.Text = "On";
      this.radioButtonAutoBenchResetOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.radioButtonAutoBenchResetOn.UseVisualStyleBackColor = false;
      this.radioButtonAutoBenchResetOn.CheckedChanged += new System.EventHandler(this.radioButtonAutoBenchResetOn_CheckedChanged);
      // 
      // radioButtonAutoBenchResetOff
      // 
      this.radioButtonAutoBenchResetOff.Appearance = System.Windows.Forms.Appearance.Button;
      this.radioButtonAutoBenchResetOff.AutoSize = true;
      this.radioButtonAutoBenchResetOff.BackColor = System.Drawing.Color.LightCoral;
      this.radioButtonAutoBenchResetOff.Enabled = false;
      this.radioButtonAutoBenchResetOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonAutoBenchResetOff.Location = new System.Drawing.Point(120, 11);
      this.radioButtonAutoBenchResetOff.Margin = new System.Windows.Forms.Padding(0);
      this.radioButtonAutoBenchResetOff.Name = "radioButtonAutoBenchResetOff";
      this.radioButtonAutoBenchResetOff.Size = new System.Drawing.Size(32, 22);
      this.radioButtonAutoBenchResetOff.TabIndex = 3;
      this.radioButtonAutoBenchResetOff.TabStop = true;
      this.radioButtonAutoBenchResetOff.Text = "Off";
      this.radioButtonAutoBenchResetOff.UseVisualStyleBackColor = false;
      this.radioButtonAutoBenchResetOff.CheckedChanged += new System.EventHandler(this.radioButtonAutoBenchResetOff_CheckedChanged);
      // 
      // groupBoxAutoEcuReset
      // 
      this.groupBoxAutoEcuReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.groupBoxAutoEcuReset.Controls.Add(this.label_auto_ecu_reset_sec);
      this.groupBoxAutoEcuReset.Controls.Add(this.Timer_AutoEcuReset);
      this.groupBoxAutoEcuReset.Controls.Add(this.radioButtonAutoEcuResetOn);
      this.groupBoxAutoEcuReset.Controls.Add(this.radioButtonAutoEcuResetOff);
      this.groupBoxAutoEcuReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.groupBoxAutoEcuReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
      this.groupBoxAutoEcuReset.Location = new System.Drawing.Point(5, 375);
      this.groupBoxAutoEcuReset.Margin = new System.Windows.Forms.Padding(0);
      this.groupBoxAutoEcuReset.Name = "groupBoxAutoEcuReset";
      this.groupBoxAutoEcuReset.Padding = new System.Windows.Forms.Padding(0);
      this.groupBoxAutoEcuReset.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.groupBoxAutoEcuReset.Size = new System.Drawing.Size(156, 40);
      this.groupBoxAutoEcuReset.TabIndex = 22;
      this.groupBoxAutoEcuReset.TabStop = false;
      this.groupBoxAutoEcuReset.Text = "Auto ECU Reset";
      this.groupBoxAutoEcuReset.Visible = false;
      // 
      // label_auto_ecu_reset_sec
      // 
      this.label_auto_ecu_reset_sec.AutoSize = true;
      this.label_auto_ecu_reset_sec.Location = new System.Drawing.Point(60, 17);
      this.label_auto_ecu_reset_sec.Name = "label_auto_ecu_reset_sec";
      this.label_auto_ecu_reset_sec.Size = new System.Drawing.Size(25, 12);
      this.label_auto_ecu_reset_sec.TabIndex = 5;
      this.label_auto_ecu_reset_sec.Text = "sec";
      // 
      // Timer_AutoEcuReset
      // 
      this.Timer_AutoEcuReset.Location = new System.Drawing.Point(7, 14);
      this.Timer_AutoEcuReset.Name = "Timer_AutoEcuReset";
      this.Timer_AutoEcuReset.Size = new System.Drawing.Size(53, 20);
      this.Timer_AutoEcuReset.TabIndex = 28;
      this.Timer_AutoEcuReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.Timer_AutoEcuReset.Validating += new System.ComponentModel.CancelEventHandler(this.Timer_AutoEcuReset_Validating);
      // 
      // radioButtonAutoEcuResetOn
      // 
      this.radioButtonAutoEcuResetOn.Appearance = System.Windows.Forms.Appearance.Button;
      this.radioButtonAutoEcuResetOn.AutoSize = true;
      this.radioButtonAutoEcuResetOn.BackColor = System.Drawing.SystemColors.Control;
      this.radioButtonAutoEcuResetOn.Enabled = false;
      this.radioButtonAutoEcuResetOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonAutoEcuResetOn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
      this.radioButtonAutoEcuResetOn.Location = new System.Drawing.Point(88, 12);
      this.radioButtonAutoEcuResetOn.Margin = new System.Windows.Forms.Padding(0);
      this.radioButtonAutoEcuResetOn.Name = "radioButtonAutoEcuResetOn";
      this.radioButtonAutoEcuResetOn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.radioButtonAutoEcuResetOn.Size = new System.Drawing.Size(31, 22);
      this.radioButtonAutoEcuResetOn.TabIndex = 4;
      this.radioButtonAutoEcuResetOn.TabStop = true;
      this.radioButtonAutoEcuResetOn.Text = "On";
      this.radioButtonAutoEcuResetOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.radioButtonAutoEcuResetOn.UseVisualStyleBackColor = false;
      // 
      // radioButtonAutoEcuResetOff
      // 
      this.radioButtonAutoEcuResetOff.Appearance = System.Windows.Forms.Appearance.Button;
      this.radioButtonAutoEcuResetOff.AutoSize = true;
      this.radioButtonAutoEcuResetOff.BackColor = System.Drawing.Color.LightCoral;
      this.radioButtonAutoEcuResetOff.Enabled = false;
      this.radioButtonAutoEcuResetOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonAutoEcuResetOff.Location = new System.Drawing.Point(121, 12);
      this.radioButtonAutoEcuResetOff.Margin = new System.Windows.Forms.Padding(0);
      this.radioButtonAutoEcuResetOff.Name = "radioButtonAutoEcuResetOff";
      this.radioButtonAutoEcuResetOff.Size = new System.Drawing.Size(32, 22);
      this.radioButtonAutoEcuResetOff.TabIndex = 3;
      this.radioButtonAutoEcuResetOff.TabStop = true;
      this.radioButtonAutoEcuResetOff.Text = "Off";
      this.radioButtonAutoEcuResetOff.UseVisualStyleBackColor = false;
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // errorProvider2
      // 
      this.errorProvider2.ContainerControl = this;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(167, 211);
      this.Controls.Add(this.groupBoxAutoEcuReset);
      this.Controls.Add(this.groupBoxAutoBenchReset);
      this.Controls.Add(this.textBoxPrint);
      this.Controls.Add(this.groupBoxDoIP);
      this.Controls.Add(this.settings);
      this.Controls.Add(this.buttonConnect);
      this.Controls.Add(this.buttonBenchReset);
      this.Controls.Add(this.groupBoxMibCan);
      this.Controls.Add(this.groupBoxAbCan);
      this.Controls.Add(this.checkBoxExtended);
      this.Controls.Add(this.groupBoxKl15);
      this.Controls.Add(this.comboBoxPort);
      this.Controls.Add(this.groupBoxDownloadMode);
      this.Controls.Add(this.checkBoxShowTaskBar);
      this.Controls.Add(this.checkBoxShowConsole);
      this.Controls.Add(this.checkBoxTopMost);
      this.Controls.Add(this.buttonReset);
      this.Controls.Add(this.groupBoxPower);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.ShowInTaskbar = this.checkBoxShowTaskBar.Checked;
      this.Text = "BenchController";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.groupBoxMibCan.ResumeLayout(false);
      this.groupBoxMibCan.PerformLayout();
      this.groupBoxAbCan.ResumeLayout(false);
      this.groupBoxAbCan.PerformLayout();
      this.groupBoxKl15.ResumeLayout(false);
      this.groupBoxKl15.PerformLayout();
      this.groupBoxDownloadMode.ResumeLayout(false);
      this.groupBoxDownloadMode.PerformLayout();
      this.contextMenuStrip.ResumeLayout(false);
      this.groupBoxPower.ResumeLayout(false);
      this.groupBoxPower.PerformLayout();
      this.groupBoxDoIP.ResumeLayout(false);
      this.groupBoxDoIP.PerformLayout();
      this.groupBoxAutoBenchReset.ResumeLayout(false);
      this.groupBoxAutoBenchReset.PerformLayout();
      this.groupBoxAutoEcuReset.ResumeLayout(false);
      this.groupBoxAutoEcuReset.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonBenchReset;
        private System.Windows.Forms.RadioButton radioButtonPowerOn;
        private System.Windows.Forms.RadioButton radioButtonPowerOff;
        private System.Windows.Forms.GroupBox groupBoxPower;
        private System.Windows.Forms.RadioButton radioButtonDownloadModeOff;
        private System.Windows.Forms.RadioButton radioButtonDownloadModeOn;
        private System.Windows.Forms.GroupBox groupBoxDownloadMode;
        private System.Windows.Forms.RadioButton radioButtonKL15On;
        private System.Windows.Forms.RadioButton radioButtonKL15Off;
        private System.Windows.Forms.GroupBox groupBoxKl15;
        private System.Windows.Forms.RadioButton radioButtonDoipOn;
        private System.Windows.Forms.RadioButton radioButtonDoipOff;
        private System.Windows.Forms.GroupBox groupBoxDoIP;
        private System.Windows.Forms.RadioButton radioButtonMibCanOn;
        private System.Windows.Forms.RadioButton radioButtonMibCanOff;
        private System.Windows.Forms.GroupBox groupBoxMibCan;
        private System.Windows.Forms.RadioButton radioButtonAbCanOn;
        private System.Windows.Forms.RadioButton radioButtonAbCanOff;
        private System.Windows.Forms.GroupBox groupBoxAbCan;
        private System.Windows.Forms.GroupBox groupBoxAutoBenchReset;
        private System.Windows.Forms.Label label_auto_bench_reset_sec;
        private System.Windows.Forms.TextBox Timer_AutoBenchReset;
        private System.Windows.Forms.RadioButton radioButtonAutoBenchResetOn;
        private System.Windows.Forms.RadioButton radioButtonAutoBenchResetOff;
        private System.Windows.Forms.GroupBox groupBoxAutoEcuReset;
        private System.Windows.Forms.RadioButton radioButtonAutoEcuResetOn;
        private System.Windows.Forms.RadioButton radioButtonAutoEcuResetOff;
        private System.Windows.Forms.TextBox Timer_AutoEcuReset;
        private System.Windows.Forms.Label label_auto_ecu_reset_sec;
        private System.Windows.Forms.CheckBox checkBoxExtended;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ToolStripMenuItem abCanConnectToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxShowTaskBar;
        private System.Windows.Forms.CheckBox checkBoxShowConsole;
        private System.Windows.Forms.CheckBox checkBoxTopMost;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTopMost;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowWindow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPower;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemKL15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDownloadMode;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBenchReset;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEcuReset;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMibCanConnect;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox textBoxPrint;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.ErrorProvider errorProvider2;
  }
}

