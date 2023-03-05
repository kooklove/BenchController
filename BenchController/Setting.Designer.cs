namespace BenchController
{
    partial class Setting
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
      this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
      this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
      this.comboBoxParity = new System.Windows.Forms.ComboBox();
      this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
      this.labelBaudRate = new System.Windows.Forms.Label();
      this.labelDataBits = new System.Windows.Forms.Label();
      this.labelParity = new System.Windows.Forms.Label();
      this.comboBoxControl = new System.Windows.Forms.ComboBox();
      this.labelStopBits = new System.Windows.Forms.Label();
      this.labelControl = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // comboBoxBaudRate
      // 
      this.comboBoxBaudRate.FormattingEnabled = true;
      this.comboBoxBaudRate.Items.AddRange(new object[] {
            "115200"});
      this.comboBoxBaudRate.Location = new System.Drawing.Point(81, 7);
      this.comboBoxBaudRate.Name = "comboBoxBaudRate";
      this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 20);
      this.comboBoxBaudRate.TabIndex = 26;
      this.comboBoxBaudRate.SelectedIndex = 0;
      this.comboBoxBaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaudRate_SelectedIndexChanged);
      // 
      // comboBoxDataBits
      // 
      this.comboBoxDataBits.FormattingEnabled = true;
      this.comboBoxDataBits.Items.AddRange(new object[] {
            "8",
            "7"});
      this.comboBoxDataBits.Location = new System.Drawing.Point(81, 33);
      this.comboBoxDataBits.Name = "comboBoxDataBits";
      this.comboBoxDataBits.Size = new System.Drawing.Size(121, 20);
      this.comboBoxDataBits.TabIndex = 27;
      this.comboBoxDataBits.SelectedIndex = 0;
      this.comboBoxDataBits.SelectedIndexChanged += new System.EventHandler(this.comboBoxDataBits_SelectedIndexChanged);
      // 
      // comboBoxParity
      // 
      this.comboBoxParity.FormattingEnabled = true;
      this.comboBoxParity.Items.AddRange(new object[] {
            "none",
            "odd",
            "even",
            "mark",
            "space"});
      this.comboBoxParity.Location = new System.Drawing.Point(81, 59);
      this.comboBoxParity.Name = "comboBoxParity";
      this.comboBoxParity.Size = new System.Drawing.Size(121, 20);
      this.comboBoxParity.TabIndex = 28;
      this.comboBoxParity.SelectedIndex = 0;
      this.comboBoxParity.SelectedIndexChanged += new System.EventHandler(this.comboBoxParity_SelectedIndexChanged);
      // 
      // comboBoxStopBits
      // 
      this.comboBoxStopBits.FormattingEnabled = true;
      this.comboBoxStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
      this.comboBoxStopBits.Location = new System.Drawing.Point(81, 85);
      this.comboBoxStopBits.Name = "comboBoxStopBits";
      this.comboBoxStopBits.Size = new System.Drawing.Size(121, 20);
      this.comboBoxStopBits.TabIndex = 29;
      this.comboBoxStopBits.SelectedIndex = 0;
      this.comboBoxStopBits.SelectedIndexChanged += new System.EventHandler(this.comboBoxStopBits_SelectedIndexChanged);
      // 
      // labelBaudRate
      // 
      this.labelBaudRate.AutoSize = true;
      this.labelBaudRate.Location = new System.Drawing.Point(8, 7);
      this.labelBaudRate.Name = "labelBaudRate";
      this.labelBaudRate.Size = new System.Drawing.Size(63, 12);
      this.labelBaudRate.TabIndex = 31;
      this.labelBaudRate.Text = "Baud Rate";
      // 
      // labelDataBits
      // 
      this.labelDataBits.AutoSize = true;
      this.labelDataBits.Location = new System.Drawing.Point(8, 33);
      this.labelDataBits.Name = "labelDataBits";
      this.labelDataBits.Size = new System.Drawing.Size(55, 12);
      this.labelDataBits.TabIndex = 32;
      this.labelDataBits.Text = "Data Bits";
      // 
      // labelParity
      // 
      this.labelParity.AutoSize = true;
      this.labelParity.Location = new System.Drawing.Point(8, 59);
      this.labelParity.Name = "labelParity";
      this.labelParity.Size = new System.Drawing.Size(37, 12);
      this.labelParity.TabIndex = 33;
      this.labelParity.Text = "Parity";
      // 
      // comboBoxControl
      // 
      this.comboBoxControl.FormattingEnabled = true;
      this.comboBoxControl.Items.AddRange(new object[] {
            "none",
            "Xon/Xoff",
            "RTS/CTS",
            "DSR/DTS"});
      this.comboBoxControl.Location = new System.Drawing.Point(81, 111);
      this.comboBoxControl.Name = "comboBoxControl";
      this.comboBoxControl.Size = new System.Drawing.Size(121, 20);
      this.comboBoxControl.TabIndex = 29;
      this.comboBoxControl.SelectedIndex = 0;
      this.comboBoxControl.SelectedIndexChanged += new System.EventHandler(this.comboBoxControl_SelectedIndexChanged);
      // 
      // labelStopBits
      // 
      this.labelStopBits.AutoSize = true;
      this.labelStopBits.Location = new System.Drawing.Point(8, 85);
      this.labelStopBits.Name = "labelStopBits";
      this.labelStopBits.Size = new System.Drawing.Size(55, 12);
      this.labelStopBits.TabIndex = 33;
      this.labelStopBits.Text = "Stop Bits";
      // 
      // labelControl
      // 
      this.labelControl.AutoSize = true;
      this.labelControl.Location = new System.Drawing.Point(8, 111);
      this.labelControl.Name = "labelControl";
      this.labelControl.Size = new System.Drawing.Size(45, 12);
      this.labelControl.TabIndex = 33;
      this.labelControl.Text = "Control";
      // 
      // Setting
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(205, 136);
      this.Controls.Add(this.labelControl);
      this.Controls.Add(this.labelStopBits);
      this.Controls.Add(this.labelParity);
      this.Controls.Add(this.labelDataBits);
      this.Controls.Add(this.labelBaudRate);
      this.Controls.Add(this.comboBoxControl);
      this.Controls.Add(this.comboBoxStopBits);
      this.Controls.Add(this.comboBoxParity);
      this.Controls.Add(this.comboBoxDataBits);
      this.Controls.Add(this.comboBoxBaudRate);
      this.Name = "Setting";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Setting";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.Setting_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.ComboBox comboBoxControl;
        private System.Windows.Forms.Label labelStopBits;
        private System.Windows.Forms.Label labelControl;
    }
}