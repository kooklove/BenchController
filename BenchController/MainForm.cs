﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;

namespace BenchController {
  enum WmHotKeyId {
    Power,
    BenchReset,
    Reset,
    DonwloadMode,
    KL15,
    Connect,
    TopMost
  }

  enum KeyModifier {
    None = 0x0000,
    Alt = 0x0001,
    Ctrl = 0x0002,
    Shift = 0x0004,
    Win = 0x0008,
    NoRepeat = 0x4000
  }

  enum Commands {
    Empty,
    Help,
    GetStatus,
    PowerOn,
    PowerOff,
    Reset,
    DownloadModeOn,
    DownloadModeOff,
    KL15On,
    KL15Off,
    ABCAN_On,
    ABCAN_Off,
    MIBCAN_On,
    MIBCAN_Off,
    DoIP_On,
    DoIP_Off
  }

  public partial class MainForm : Form {
    private const int WmHotkey = 0x0312;
    private bool get_status = false;

    private const string EMPTY = "";
    private const string HELP = "help";
    private const string HELP_SHORT = "h";
    private const string GET_STATUS = "get status";
    private const string POWER_ON = "power on";
    private const string POWER_ON_CANOE = "power on CANOE";
    private const string POWER_OFF = "power off";
    private const string POWER_OFF_CANOE = "power off CANOE";
    private const string POWER_ICAS3_ON = "icas3 on";
    private const string POWER_ICAS3_ON_SHORT = "on";
    private const string POWER_ICAS3_OFF = "icas3 off";
    private const string POWER_ICAS3_OFF_SHORT = "off";
    private const string RESET_ICAS3 = "icas3 reset";
    private const string RESET_ICAS3_SHORT = "reset";
    private const string MODE_DOWNLOAD = "mode download";
    private const string MODE_DOWNLOAD_ON = "dn";
    private const string MODE_NORMAL = "mode normal";
    private const string MODE_NORMAL_SHORT = "normal";
    private const string MODE_DOWNLOAD_OFF = "up";
    private const string KL15_ON = "kl15 on";
    private const string KL15_OFF = "kl15 off";
    private const string KLS_ON = "kls on not working";
    private const string AB_CAN_ON = "abcan on";
    private const string AB_CAN_OFF = "abcan off";
    private const string MIB_CAN_ON = "mibcan on";
    private const string MIB_CAN_OFF = "mibcan off";
    private const string DOIP_ON = "doip on";
    private const string DOIP_OFF = "doip off";

    [DllImport("user32.dll")]
    private static extern int RegisterHotKey(int hwnd, int id, int fsModifiers, int vk);

    [DllImport("user32.dll")]
    private static extern int UnregisterHotKey(int hwnd, int id);

    public MainForm() {
      InitializeComponent();
      FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
      Keys key = keyData & ~(Keys.Control | Keys.Shift);
      if ((keyData & Keys.Control) != 0) {
        switch (key) {
          case Keys.P:
            ToggleRadioButtonPower();
            break;
          case Keys.B:
            DoBenchReset();
            break;
          case Keys.R:
            DoReset();
            break;
          case Keys.D:
            ToggleRadioButtonDownloadMode();
            break;
          case Keys.K:
            ToggleRadioButtonKL15();
            break;
          case Keys.C:
            UpdateButtonConnect();
            break;
          case Keys.T:
            TogglecheckBoxTopMost();
            break;
        }
      }
      return base.ProcessCmdKey(ref msg, keyData);
    }

    protected override void WndProc(ref Message m) {

      if (m.Msg == WmHotkey) {
        int id = m.WParam.ToInt32();
        switch (id) {
          case (int)WmHotKeyId.Power:
            ToggleRadioButtonPower();
            break;
          case (int)WmHotKeyId.BenchReset:
            DoBenchReset();
            break;
          case (int)WmHotKeyId.Reset:
            DoReset();
            break;
          case (int)WmHotKeyId.DonwloadMode:
            ToggleRadioButtonDownloadMode();
            break;
          case (int)WmHotKeyId.KL15:
            ToggleRadioButtonKL15();
            break;
          case (int)WmHotKeyId.Connect:
            UpdateButtonConnect();
            break;
          case (int)WmHotKeyId.TopMost:
            TogglecheckBoxTopMost();
            break;
        }
      }
      base.WndProc(ref m);
    }

    private void MainForm_Load(object sender, EventArgs e) {
      RegisterHotKey((int)this.Handle, (int)WmHotKeyId.Power, (int)(KeyModifier.Alt | KeyModifier.Shift), (int)Keys.P);
      RegisterHotKey((int)this.Handle, (int)WmHotKeyId.BenchReset, (int)(KeyModifier.Alt | KeyModifier.Shift), (int)Keys.B);
      RegisterHotKey((int)this.Handle, (int)WmHotKeyId.Reset, (int)(KeyModifier.Alt | KeyModifier.Shift), (int)Keys.R);
      RegisterHotKey((int)this.Handle, (int)WmHotKeyId.DonwloadMode, (int)(KeyModifier.Alt | KeyModifier.Shift), (int)Keys.D);
      RegisterHotKey((int)this.Handle, (int)WmHotKeyId.KL15, (int)(KeyModifier.Alt | KeyModifier.Shift), (int)Keys.K);
      RegisterHotKey((int)this.Handle, (int)WmHotKeyId.Connect, (int)(KeyModifier.Alt | KeyModifier.Shift), (int)Keys.C);
      RegisterHotKey((int)this.Handle, (int)WmHotKeyId.TopMost, (int)(KeyModifier.Alt | KeyModifier.Shift), (int)Keys.T);
    }

    private void MainForm_FormClosing(Object sender, FormClosingEventArgs e) {
      UnregisterHotKey((int)this.Handle, (int)WmHotKeyId.Power);
      UnregisterHotKey((int)this.Handle, (int)WmHotKeyId.BenchReset);
      UnregisterHotKey((int)this.Handle, (int)WmHotKeyId.Reset);
      UnregisterHotKey((int)this.Handle, (int)WmHotKeyId.DonwloadMode);
      UnregisterHotKey((int)this.Handle, (int)WmHotKeyId.KL15);
      UnregisterHotKey((int)this.Handle, (int)WmHotKeyId.Connect);
      UnregisterHotKey((int)this.Handle, (int)WmHotKeyId.TopMost);
    }

    private void UpdateCheckBoxTopMost() {
      if (checkBoxTopMost.Checked) {
        this.TopMost = true;
        this.toolStripMenuItemTopMost.CheckState = CheckState.Checked;
      } else {
        this.TopMost = false;
        this.toolStripMenuItemTopMost.CheckState = CheckState.Unchecked;
      }
    }

    private void UpdateCheckBoxShowTaskBar() {
      if (checkBoxShowTaskBar.Checked) {
        this.ShowInTaskbar = true;
      } else {
        this.ShowInTaskbar = false;
      }
    }

    private void UpdateCheckboxExtended() {
      if (checkBoxExtended.Checked) {
        this.groupBoxAbCan.Visible = true;
        this.groupBoxMibCan.Visible = true;
        this.groupBoxDoIP.Visible = true;
        this.ClientSize = new System.Drawing.Size(this.ClientSize.Width, 340);
      } else {
        this.groupBoxAbCan.Visible = false;
        this.groupBoxMibCan.Visible = false;
        this.groupBoxDoIP.Visible = false;
        this.ClientSize = new System.Drawing.Size(this.ClientSize.Width, 213);
      }
    }

    private void UpdateCheckboxShowConsole() {
      if (checkBoxShowConsole.Checked) {
        this.ClientSize = new System.Drawing.Size(324, this.ClientSize.Height);
      } else {
        this.ClientSize = new System.Drawing.Size(154, this.ClientSize.Height);
      }
    }

    private void TogglecheckBoxTopMost() {
      if (checkBoxTopMost.Checked)
        checkBoxTopMost.Checked = false;
      else
        checkBoxTopMost.Checked = true;
      UpdateCheckBoxTopMost();
    }

    private readonly object lock_uart = new object();
    private string received_statuses = "";
    private bool parse_received_statuses = false;

    private void ParseReceivedStatus(string received_statuses) {
      string[] switch_statuses = received_statuses.Split('\n');
      foreach (var switch_status in switch_statuses) {
        Console.WriteLine("Status: " + switch_status);
        switch (switch_status.Trim('\r', '\n')) {
          case POWER_ON:
            UpdateRadioButtonPower(true, false);
            break;
          case POWER_OFF:
            UpdateRadioButtonPower(false, false);
            break;
          case KL15_ON:
            UpdateRadioButtonKL15(true, false);
            break;
          case KL15_OFF:
            UpdateRadioButtonKL15(false, false);
            break;
          case MODE_DOWNLOAD_ON:
            UpdateRadioButtonDownloadMode(true, false);
            break;
          case MODE_DOWNLOAD_OFF:
            UpdateRadioButtonDownloadMode(false, false);
            break;
        }
      }
    }

    private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e) {
      lock(lock_uart) {
        if (get_status == true) {
          get_status = false;
          parse_received_statuses = true;
        }
        string indata = serialPort.ReadExisting();
        if (this.textBoxPrint.InvokeRequired == true) {
          this.textBoxPrint.Invoke((MethodInvoker)delegate {
          this.textBoxPrint.AppendText(indata);
          this.textBoxPrint.AppendText(Environment.NewLine);
          });
        }
        if (parse_received_statuses) {
          received_statuses += indata;
          if (indata.Contains("=")) {
            ParseReceivedStatus(received_statuses);
            parse_received_statuses = false;
            received_statuses = "";
          }
        }
        if (indata.Contains("Unexpected Command")) {
          Console.WriteLine(indata);
          SerialPortWriteAndRead(Commands.GetStatus);
        }
      }
    }

    private void ComboBoxPort_SelectedIndexChanged(object sender, EventArgs e) {
      if (comboBoxPort.SelectedItem != null) {
        if (!serialPort.IsOpen) {
          serialPort.PortName = comboBoxPort.SelectedItem.ToString();
          serialPort.BaudRate = 115200;
          serialPort.Parity = Parity.None;
          serialPort.StopBits = StopBits.One;
          serialPort.DataBits = 8;
          serialPort.Handshake = Handshake.None;
          serialPort.RtsEnable = true;
          serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
        }
      }
    }

    private readonly object lock_connect = new object();
    private async void UpdateButtonConnect() {
      try {
        if (buttonConnect.Text == "Connect") {
          await Task.Delay(200);  // Prevent Unexpected Response from Arduino
          lock (lock_connect) {
            //serialPort.Close();
            serialPort.Open();
            if (serialPort.IsOpen) {
              buttonConnect.BackColor = System.Drawing.Color.SpringGreen;
              buttonConnect.Text = "Connected";
              this.textBoxPrint.Clear();
              modeChangeAllButtons(true);
              SerialPortWriteAndRead(Commands.Empty);
              SerialPortWriteAndRead(Commands.GetStatus);
            } else {
              MessageBox.Show("Failed Open Serial Port");
            }
          }
        } else {
          await Task.Delay(200);  // Prevent Unexpected Response from Arduino
          lock (lock_connect) {
            serialPort.DiscardInBuffer();
            serialPort.DiscardOutBuffer();
            serialPort.Close();
            serialPort.Dispose();
            this.textBoxPrint.AppendText("Disconnected");
            this.textBoxPrint.AppendText(Environment.NewLine);
            if (serialPort.IsOpen == false) {
              buttonConnect.BackColor = SystemColors.Control;
              buttonConnect.Text = "Connect";
              modeChangeAllButtons(false);
            } else {
              MessageBox.Show("Failed Close Serial Port");
            }
          }
        }
      } catch {
        if (serialPort.PortName == "COM1") {
          MessageBox.Show("Please select COM Port.");
        } else {
          MessageBox.Show("The port is alreay in use.");
        }
      }
    }

    private void CheckBoxTopMost_CheckedChanged(object sender, EventArgs e) {
      UpdateCheckBoxTopMost();
    }

    private void CheckBoxShowTaskBar_CheckedChanged(object sender, EventArgs e) {
      UpdateCheckBoxShowTaskBar();
    }

    private void CheckBoxExtended_CheckedChanged(object sender, EventArgs e) {
      UpdateCheckboxExtended();
    }

    private void CheckBoxShowConsole_CheckedChanged(object sender, EventArgs e) {
      UpdateCheckboxShowConsole();
    }

    private void buttonConnect_Click(object sender, EventArgs e) {
      UpdateButtonConnect();
    }

    private void settings_Click(object sender, EventArgs e) {
      var setting = new Setting();
      setting.Show();
    }

    private bool IsEnabledButtonBenchReset() {
      return this.buttonBenchReset.Enabled == true;
    }

    private bool IsEnabledButtonReset() {
      return this.buttonReset.Enabled;
    }

    private bool IsEnabledRadioButtonPower() {
      return this.radioButtonPowerOn.Enabled == true && this.radioButtonPowerOff.Enabled == true;
    }

    private bool IsEnabledradioButtonDoIP() {
      return this.radioButtonDoipOn.Enabled == true && this.radioButtonDoipOff.Enabled == true;
    }

    private bool IsEnabledRadioButtonDownloadMode() {
      return this.radioButtonDownloadModeOff.Enabled == true && this.radioButtonDownloadModeOn.Enabled == true;
    }
    private bool IsEnabledRadioButtonKL15() {
      return this.radioButtonKL15On.Enabled == true && this.radioButtonKL15Off.Enabled == true;
    }

    private bool ToggleRadioButtonPower() {
      bool result = false;
      if (IsEnabledRadioButtonPower()) {
        result = true;
        if (this.radioButtonPowerOn.Checked) {
          radioButtonPowerOn.Checked = false;
          radioButtonPowerOff.Checked = true;
          UpdateRadioButtonPower(true);
        } else {
          radioButtonPowerOn.Checked = true;
          radioButtonPowerOff.Checked = false;
          UpdateRadioButtonPower(false);
        }
        
      }
      return result;
    }

    private bool ToggleRadioButtonDownloadMode() {
      bool result = false;
      if (IsEnabledRadioButtonDownloadMode()) {
        result = true;
        if (this.radioButtonDownloadModeOn.Checked) {
          radioButtonDownloadModeOn.Checked = false;
          radioButtonDownloadModeOff.Checked = true;
          UpdateRadioButtonDownloadMode(true);
        } else {
          radioButtonDownloadModeOn.Checked = true;
          radioButtonDownloadModeOff.Checked = false;
          UpdateRadioButtonDownloadMode(false);
        }
      }
      return result;
    }

    private bool ToggleRadioButtonKL15() {
      bool result = false;
      if (IsEnabledRadioButtonKL15()) {
        result = true;
        if (this.radioButtonKL15On.Checked) {
          radioButtonKL15On.Checked = false;
          radioButtonKL15Off.Checked = true;
          UpdateRadioButtonKL15(true);
        } else {
          radioButtonKL15On.Checked = true;
          radioButtonKL15Off.Checked = false;
          UpdateRadioButtonKL15(false);
        }
      }
      return result;
    }

    private void UpdateRadioButtonPower(bool on_off, bool send_command = true) {
      if (IsEnabledRadioButtonPower()) {
        if (on_off) {
          if (this.radioButtonPowerOn.Checked || (send_command == false)) {
            if (send_command)
              SerialPortWriteAndRead(Commands.PowerOn);
            radioButtonPowerOn.BackColor = System.Drawing.Color.SpringGreen;
            radioButtonPowerOff.BackColor = SystemColors.Control;
          }
        } else {
          if (this.radioButtonPowerOff.Checked || (send_command == false)) {
            if (send_command)
              SerialPortWriteAndRead(Commands.PowerOff);
            radioButtonPowerOn.BackColor = SystemColors.Control;
            radioButtonPowerOff.BackColor = System.Drawing.Color.LightCoral;
          } 
        }
      } else {
        Console.WriteLine("Button Not Activated");
      }
    }

    private void UpdateRadioButtonKL15(bool on_off, bool send_command = true) {
      if (IsEnabledRadioButtonKL15()) {
        if (on_off) {
          if (this.radioButtonKL15On.Checked || (send_command == false)) {
            if (send_command)
              SerialPortWriteAndRead(Commands.KL15On);
            radioButtonKL15On.BackColor = System.Drawing.Color.SpringGreen;
            radioButtonKL15Off.BackColor = SystemColors.Control;
          }
        } else {
          if (this.radioButtonKL15Off.Checked || (send_command == false)) {
            if (send_command)
              SerialPortWriteAndRead(Commands.KL15Off);
            radioButtonKL15On.BackColor = SystemColors.Control;
            radioButtonKL15Off.BackColor = System.Drawing.Color.LightCoral;
          }
        }
      }
    }

    private void UpdateRadioButtonDownloadMode(bool up_dn, bool send_command = true) {
      if (IsEnabledRadioButtonDownloadMode()) {
        if (up_dn) {
          if (this.radioButtonDownloadModeOn.Checked || (send_command == false)) {
            if (send_command)
              SerialPortWriteAndRead(Commands.DownloadModeOn);
            radioButtonDownloadModeOn.BackColor = System.Drawing.Color.LightBlue;
            radioButtonDownloadModeOff.BackColor = SystemColors.Control;
          }
        } else {
          if (this.radioButtonDownloadModeOff.Checked || (send_command == false)) {
            if (send_command)
              SerialPortWriteAndRead(Commands.DownloadModeOff);
            radioButtonDownloadModeOn.BackColor = SystemColors.Control;
            radioButtonDownloadModeOff.BackColor = System.Drawing.Color.Yellow;
          }
        }
      }
    }

    private void radioButtonPowerOn_CheckedChanged(object sender, EventArgs e) {
      if (IsEnabledRadioButtonPower())
        UpdateRadioButtonPower(true);
    }

    private void radioButtonPowerOff_CheckedChanged(object sender, EventArgs e) {
      if (IsEnabledRadioButtonPower())
        UpdateRadioButtonPower(false);
    }

    private void toolStripMenuItemPower_Click(object sender, EventArgs e) {
      if (IsEnabledRadioButtonPower())
        ToggleRadioButtonPower();
    }

    private void radioButtonKL15On_CheckedChanged(object sender, EventArgs e) {
      if (IsEnabledRadioButtonKL15())
        UpdateRadioButtonKL15(true);
    }

    private void radioButtonKL15Off_CheckedChanged(object sender, EventArgs e) {
      if (IsEnabledRadioButtonKL15())
        UpdateRadioButtonKL15(false);
    }

    private void buttonBenchReset_Click(object sender, EventArgs e) {
      DoBenchReset();
    }

    private void radioButtonDownloadModeOn_CheckedChanged(object sender, EventArgs e) {
      UpdateRadioButtonDownloadMode(true);
    }

    private void radioButtonDownloadModeOff_CheckedChanged(object sender, EventArgs e) {
      UpdateRadioButtonDownloadMode(false);
    }

    private void radioButtonAbCanOn_CheckedChanged(object sender, EventArgs e) {
      radioButtonAbCanOn.BackColor = System.Drawing.Color.SpringGreen;
      radioButtonAbCanOff.BackColor = SystemColors.Control;
    }

    private void radioButtonAbCanOff_CheckedChanged(object sender, EventArgs e) {
      radioButtonAbCanOn.BackColor = SystemColors.Control;
      radioButtonAbCanOff.BackColor = System.Drawing.Color.LightCoral;
    }

    private void radioButtonMibCanOn_CheckedChanged(object sender, EventArgs e) {
      radioButtonMibCanOn.BackColor = System.Drawing.Color.SpringGreen;
      radioButtonMibCanOff.BackColor = SystemColors.Control;
    }

    private void radioButtonMibCanOff_CheckedChanged(object sender, EventArgs e) {
      radioButtonMibCanOn.BackColor = SystemColors.Control;
      radioButtonMibCanOff.BackColor = System.Drawing.Color.LightCoral;
    }
    private void radioButtonDoIPOn_CheckedChanged(object sender, EventArgs e) {
      radioButtonDoipOn.BackColor = System.Drawing.Color.SpringGreen;
      radioButtonDoipOff.BackColor = SystemColors.Control;
    }

    private void radioButtonDoIPOff_CheckedChanged(object sender, EventArgs e) {
      radioButtonDoipOn.BackColor = SystemColors.Control;
      radioButtonDoipOff.BackColor = System.Drawing.Color.LightCoral;
    }

    private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
      this.Activate();
    }

    private void contextMenuStrip_Opening(object sender, CancelEventArgs e) {

    }

    private void toolStripMenuItemTopMost_Click(object sender, EventArgs e) {
      if (toolStripMenuItemTopMost.Checked) {
        this.checkBoxTopMost.Checked = true;
      } else {
        this.checkBoxTopMost.Checked = false;
      }
      UpdateCheckBoxTopMost();
    }

    private void toolStripMenuItemShowWindow_Click(object sender, EventArgs e) {
      this.Activate();
    }

    private void toolStripMenuItemDownloadMode_Click(object sender, EventArgs e) {
      if (toolStripMenuItemDownloadMode.Checked) {
        this.radioButtonDownloadModeOff.Checked = false;
        this.radioButtonDownloadModeOn.Checked = true;
        radioButtonDownloadModeOn_CheckedChanged(sender, e);
      } else {
        this.radioButtonDownloadModeOff.Checked = true;
        this.radioButtonDownloadModeOn.Checked = false;
        radioButtonDownloadModeOff_CheckedChanged(sender, e);
      }
    }

    private void toolStripMenuItemKL15_Click(object sender, EventArgs e) {
      if (toolStripMenuItemKL15.Checked) {
        this.radioButtonKL15On.Checked = true;
        this.radioButtonKL15Off.Checked = false;
        UpdateRadioButtonKL15(true);
      } else {
        this.radioButtonKL15On.Checked = false;
        this.radioButtonKL15Off.Checked = true;
        UpdateRadioButtonKL15(false);
      }
    }

    private async void DoBenchReset() {
      if (IsEnabledButtonBenchReset()) {
        buttonBenchReset.Enabled = false;
        radioButtonPowerOn.Checked = false;
        radioButtonPowerOff.Checked = true;
        UpdateRadioButtonPower(false);
        await Task.Delay(200);
        radioButtonPowerOn.Checked = true;
        radioButtonPowerOff.Checked = false;
        UpdateRadioButtonPower(true);
        await Task.Delay(500);
        radioButtonKL15On.Checked = false;
        radioButtonKL15Off.Checked = true;
        UpdateRadioButtonKL15(false);
        await Task.Delay(200);
        radioButtonKL15On.Checked = true;
        radioButtonKL15Off.Checked = false;
        UpdateRadioButtonKL15(true);
        buttonBenchReset.Enabled = true;
      }
    }

    private async void DoReset() {
      if (IsEnabledButtonReset()) {
        buttonReset.Enabled = false;
        await Task.Delay(200);
        buttonReset.Enabled = true;
      }
    }

    private void buttonReset_Click(object sender, EventArgs e) {
      DoReset();
    }

    private void modeChangeAllButtons(bool modeOn) {
      if (modeOn) {
        this.buttonBenchReset.Enabled = true;
        this.buttonReset.Enabled = true;
        this.radioButtonPowerOn.Enabled = true;
        this.radioButtonPowerOff.Enabled = true;
        this.radioButtonKL15On.Enabled = true;
        this.radioButtonKL15Off.Enabled = true;
        this.radioButtonDownloadModeOn.Enabled = true;
        this.radioButtonDownloadModeOff.Enabled = true;
        this.radioButtonAbCanOn.Enabled = true;
        this.radioButtonAbCanOff.Enabled = true;
        this.radioButtonMibCanOn.Enabled = true;
        this.radioButtonMibCanOff.Enabled = true;
        this.radioButtonDoipOn.Enabled = true;
        this.radioButtonDoipOff.Enabled = true;
        this.toolStripMenuItemPower.Enabled = true;
        this.toolStripMenuItemEcuReset.Enabled = true;
        this.toolStripMenuItemDownloadMode.Enabled = true;
        this.toolStripMenuItemKL15.Enabled = true;
        this.toolStripMenuItemBenchReset.Enabled = true;
        this.toolStripMenuItemMibCanConnect.Enabled = true;
        this.toolStripMenuItemPower.Enabled = true;
      } else {
        this.buttonBenchReset.Enabled = false;
        this.buttonReset.Enabled = false;
        this.radioButtonPowerOn.Enabled = false;
        this.radioButtonPowerOff.Enabled = false;
        this.radioButtonKL15On.Enabled = false;
        this.radioButtonKL15Off.Enabled = false;
        this.radioButtonDownloadModeOn.Enabled = false;
        this.radioButtonDownloadModeOff.Enabled = false;
        this.radioButtonAbCanOn.Enabled = false;
        this.radioButtonAbCanOff.Enabled = false;
        this.radioButtonMibCanOn.Enabled = false;
        this.radioButtonMibCanOff.Enabled = false;
        this.radioButtonDoipOn.Enabled = false;
        this.radioButtonDoipOff.Enabled = false;
        this.toolStripMenuItemPower.Enabled = false;
        this.toolStripMenuItemEcuReset.Enabled = false;
        this.toolStripMenuItemDownloadMode.Enabled = false;
        this.toolStripMenuItemKL15.Enabled = false;
        this.toolStripMenuItemBenchReset.Enabled = false;
        this.toolStripMenuItemMibCanConnect.Enabled = false;
        this.toolStripMenuItemPower.Enabled = false;
      }
    }

    private void ComboBoxPort_DropDownSelected(object sender, EventArgs e) {
      string[] comPortList = System.IO.Ports.SerialPort.GetPortNames();
      string currentItemString = "";

      if (comboBoxPort.SelectedItem != null) {
        currentItemString = comboBoxPort.SelectedItem.ToString();
      }

      if (comPortList.Length > 0) {
        comboBoxPort.Items.Clear();
        comboBoxPort.Items.AddRange(comPortList);

        if (currentItemString != "") {
          for (int i = 0; i < comboBoxPort.Items.Count; i++) {
            if (currentItemString == comboBoxPort.Items[i].ToString()) {
              comboBoxPort.SelectedIndex = i;
              break;
            }
          }
        }
      }
    }

    private void TextBoxPrint_TextChanged(object sender, EventArgs e) {

    }

    private void SerialPortWriteAndRead(Commands command) {
      if (serialPort.IsOpen) {
        switch (command) {
          case Commands.Empty:
            serialPort.Write(EMPTY + "\n");
            break;
          case Commands.Help:
            serialPort.Write(HELP + "\n");
            break;
          case Commands.GetStatus:
            get_status = true;
            serialPort.Write(GET_STATUS + "\n");
            break;
          case Commands.PowerOn:
            serialPort.Write(POWER_ON + "\n");
            break;
          case Commands.PowerOff:
            serialPort.Write(POWER_OFF + "\n");
            break;
          case Commands.Reset:
            serialPort.Write(RESET_ICAS3_SHORT + "\n");
            break;
          case Commands.DownloadModeOn:
            serialPort.Write(MODE_DOWNLOAD_ON + "\n");
            break;
          case Commands.DownloadModeOff:
            serialPort.Write(MODE_DOWNLOAD_OFF + "\n");
            break;
          case Commands.KL15On:
            serialPort.Write(KL15_ON + "\n");
            break;
          case Commands.KL15Off:
            serialPort.Write(KL15_OFF + "\n");
            break;
          case Commands.ABCAN_On:
            serialPort.Write(AB_CAN_ON + "\n");
            break;
          case Commands.ABCAN_Off:
            serialPort.Write(AB_CAN_OFF + "\n");
            break;
          case Commands.MIBCAN_On:
            serialPort.Write(MIB_CAN_ON + "\n");
            break;
          case Commands.MIBCAN_Off:
            serialPort.Write(MIB_CAN_OFF + "\n");
            break;
          case Commands.DoIP_On:
            serialPort.Write(DOIP_ON + "\n");
            break;
          case Commands.DoIP_Off:
            serialPort.Write(DOIP_OFF + "\n");
            break;
        }
      }
    }
  }
}