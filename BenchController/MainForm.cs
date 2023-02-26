using System;
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

  public partial class MainForm : Form, IDisposable {
    private const int WmHotkey = 0x0312;

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

    private void ComboBoxPort_SelectedIndexChanged(object sender, EventArgs e) {
      if (comboBoxPort.SelectedItem != null) {
        serialPort.PortName = comboBoxPort.SelectedItem.ToString();
      }
    }

    private void UpdateButtonConnect() {
      try {
        if (buttonConnect.Text == "Connect") {
          //serialPort.Close();
          serialPort.Open();
          if (serialPort.IsOpen) {
            buttonConnect.BackColor = System.Drawing.Color.SpringGreen;
            buttonConnect.Text = "Connected";
            Console.WriteLine("Connected");
            modeChangeAllButtons(true);
          } else {
            Console.WriteLine("Failed Open Serial Port");
          }
        } else {
          serialPort.Close();
          if (serialPort.IsOpen == false) {
            buttonConnect.BackColor = SystemColors.Control;
            buttonConnect.Text = "Connect";
            Console.WriteLine("Disconnected");
            modeChangeAllButtons(false);
          } else {
            Console.WriteLine("Failed Close Serial Port");
          }
        }
      } catch {
        if (serialPort.PortName == "COM1") {
          MessageBox.Show("Please select COM Port.");
        } else {
          MessageBox.Show("The port is alreay in use.");
        }
        return;
      }
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
        } else {
          radioButtonPowerOn.Checked = true;
          radioButtonPowerOff.Checked = false;
        }
        UpdateRadioButtonPower();
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
        } else {
          radioButtonDownloadModeOn.Checked = true;
          radioButtonDownloadModeOff.Checked = false;
        }
        // UpdateRadioButtonDownloadMode();
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
        } else {
          radioButtonKL15On.Checked = true;
          radioButtonKL15Off.Checked = false;
        }
      }
      return result;
    }

    private void UpdateRadioButtonPower() {
      if (IsEnabledRadioButtonPower()) {
        if (this.radioButtonPowerOn.Checked) {
          radioButtonPowerOn.BackColor = System.Drawing.Color.SpringGreen;
          radioButtonPowerOff.BackColor = SystemColors.Control;
        } else {
          radioButtonPowerOn.BackColor = SystemColors.Control;
          radioButtonPowerOff.BackColor = System.Drawing.Color.LightCoral;
        }
      }
    }

    private void UpdateRadioButtonKL15() {
      if (IsEnabledRadioButtonKL15()) {
        if (this.radioButtonKL15On.Checked) {
          radioButtonKL15On.BackColor = System.Drawing.Color.SpringGreen;
          radioButtonKL15Off.BackColor = SystemColors.Control;
        } else {
          radioButtonKL15On.BackColor = SystemColors.Control;
          radioButtonKL15Off.BackColor = System.Drawing.Color.LightCoral;
        }
      }
    }

    private void radioButtonPowerOn_CheckedChanged(object sender, EventArgs e) {
      if (IsEnabledRadioButtonPower())
        UpdateRadioButtonPower();
    }

    private void radioButtonPowerOff_CheckedChanged(object sender, EventArgs e) {
      if (IsEnabledRadioButtonPower())
        UpdateRadioButtonPower();
    }

    private void toolStripMenuItemPower_Click(object sender, EventArgs e) {
      if (IsEnabledRadioButtonPower())
        ToggleRadioButtonPower();
    }

    private void radioButtonKL15On_CheckedChanged(object sender, EventArgs e) {
      UpdateRadioButtonKL15();
    }

    private void radioButtonKL15Off_CheckedChanged(object sender, EventArgs e) {
      UpdateRadioButtonKL15();
    }

    private void toolStripMenuItemKL15_Click(object sender, EventArgs e) {
      if (toolStripMenuItemKL15.Checked) {
        this.radioButtonKL15On.Checked = true;
        this.radioButtonKL15Off.Checked = false;
        UpdateRadioButtonKL15();
      } else {
        this.radioButtonKL15On.Checked = false;
        this.radioButtonKL15Off.Checked = true;
        UpdateRadioButtonKL15();
      }
    }

    private void radioButtonDownloadModeOn_CheckedChanged(object sender, EventArgs e) {
      radioButtonDownloadModeOn.BackColor = System.Drawing.Color.SpringGreen;
      radioButtonDownloadModeOff.BackColor = SystemColors.Control;
    }

    private void radioButtonModeOff_CheckedChanged(object sender, EventArgs e) {
      radioButtonDownloadModeOn.BackColor = SystemColors.Control;
      radioButtonDownloadModeOff.BackColor = System.Drawing.Color.LightCoral;
    }

    private void toolStripMenuItemDownloadMode_Click(object sender, EventArgs e) {
      if (toolStripMenuItemDownloadMode.Checked) {
        this.radioButtonDownloadModeOn.Checked = true;
        this.radioButtonDownloadModeOff.Checked = false;
        radioButtonDownloadModeOn_CheckedChanged(sender, e);
      } else {
        this.radioButtonDownloadModeOn.Checked = false;
        this.radioButtonDownloadModeOff.Checked = true;
        radioButtonModeOff_CheckedChanged(sender, e);
      }
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

    private async void DoBenchReset() {
      if (IsEnabledButtonBenchReset()) {
        buttonBenchReset.Enabled = false;
        radioButtonPowerOn.Checked = false;
        radioButtonPowerOff.Checked = true;
        UpdateRadioButtonPower();
        await Task.Delay(200);
        radioButtonPowerOn.Checked = true;
        radioButtonPowerOff.Checked = false;
        UpdateRadioButtonPower();
        await Task.Delay(500);
        radioButtonKL15On.Checked = false;
        radioButtonKL15Off.Checked = true;
        UpdateRadioButtonKL15();
        await Task.Delay(200);
        radioButtonKL15On.Checked = true;
        radioButtonKL15Off.Checked = false;
        UpdateRadioButtonKL15();
        buttonBenchReset.Enabled = true;
      }
    }

    private void buttonBenchReset_Click(object sender, EventArgs e) {
      DoBenchReset();
    }

    private void DoReset() {
      if (IsEnabledButtonReset()) {
        buttonReset.Enabled = false;
        Thread.Sleep(200);
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

    //private void comboBoxPort_ValueEnter(object sender, EventArgs e)
    //{
    //    //MessageBox.Show(comboBoxPort.Text);
    //}
  }
}