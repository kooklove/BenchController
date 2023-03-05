using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenchController
{
  public partial class Setting : Form {
    public Setting() {
      InitializeComponent();
    }

    private void Setting_Load(object sender, EventArgs e) {

    }

    private void comboBoxBaudRate_SelectedIndexChanged(object sender, EventArgs e) {
      if (comboBoxBaudRate.SelectedItem != null) {

      }
    }

    private void comboBoxDataBits_SelectedIndexChanged(object sender, EventArgs e) {
      if (comboBoxDataBits.SelectedItem != null) {

      }
    }

    private void comboBoxParity_SelectedIndexChanged(object sender, EventArgs e) {
      if (comboBoxParity.SelectedItem != null) {

      }
    }

    private void comboBoxStopBits_SelectedIndexChanged(object sender, EventArgs e) {
      if (comboBoxStopBits.SelectedItem != null) {

      }
    }

    private void comboBoxControl_SelectedIndexChanged(object sender, EventArgs e) {
      if (comboBoxControl.SelectedItem != null) {

      }
    }
  }
}
