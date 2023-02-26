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
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.comboBox3 = new System.Windows.Forms.ComboBox();
      this.comboBox4 = new System.Windows.Forms.ComboBox();
      this.labelBaudRate = new System.Windows.Forms.Label();
      this.labelDataBits = new System.Windows.Forms.Label();
      this.labelParity = new System.Windows.Forms.Label();
      this.comboBox5 = new System.Windows.Forms.ComboBox();
      this.labelStopBits = new System.Windows.Forms.Label();
      this.labelControl = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(111, 71);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 20);
      this.comboBox1.TabIndex = 26;
      // 
      // comboBox2
      // 
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new System.Drawing.Point(111, 124);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(121, 20);
      this.comboBox2.TabIndex = 27;
      // 
      // comboBox3
      // 
      this.comboBox3.FormattingEnabled = true;
      this.comboBox3.Location = new System.Drawing.Point(111, 170);
      this.comboBox3.Name = "comboBox3";
      this.comboBox3.Size = new System.Drawing.Size(121, 20);
      this.comboBox3.TabIndex = 28;
      // 
      // comboBox4
      // 
      this.comboBox4.FormattingEnabled = true;
      this.comboBox4.Location = new System.Drawing.Point(111, 212);
      this.comboBox4.Name = "comboBox4";
      this.comboBox4.Size = new System.Drawing.Size(121, 20);
      this.comboBox4.TabIndex = 29;
      // 
      // labelBaudRate
      // 
      this.labelBaudRate.AutoSize = true;
      this.labelBaudRate.Location = new System.Drawing.Point(38, 79);
      this.labelBaudRate.Name = "labelBaudRate";
      this.labelBaudRate.Size = new System.Drawing.Size(63, 12);
      this.labelBaudRate.TabIndex = 31;
      this.labelBaudRate.Text = "Baud Rate";
      // 
      // labelDataBits
      // 
      this.labelDataBits.AutoSize = true;
      this.labelDataBits.Location = new System.Drawing.Point(40, 131);
      this.labelDataBits.Name = "labelDataBits";
      this.labelDataBits.Size = new System.Drawing.Size(55, 12);
      this.labelDataBits.TabIndex = 32;
      this.labelDataBits.Text = "Data Bits";
      // 
      // labelParity
      // 
      this.labelParity.AutoSize = true;
      this.labelParity.Location = new System.Drawing.Point(40, 170);
      this.labelParity.Name = "labelParity";
      this.labelParity.Size = new System.Drawing.Size(37, 12);
      this.labelParity.TabIndex = 33;
      this.labelParity.Text = "Parity";
      // 
      // comboBox5
      // 
      this.comboBox5.FormattingEnabled = true;
      this.comboBox5.Location = new System.Drawing.Point(111, 259);
      this.comboBox5.Name = "comboBox5";
      this.comboBox5.Size = new System.Drawing.Size(121, 20);
      this.comboBox5.TabIndex = 29;
      // 
      // labelStopBits
      // 
      this.labelStopBits.AutoSize = true;
      this.labelStopBits.Location = new System.Drawing.Point(40, 212);
      this.labelStopBits.Name = "labelStopBits";
      this.labelStopBits.Size = new System.Drawing.Size(55, 12);
      this.labelStopBits.TabIndex = 33;
      this.labelStopBits.Text = "Stop Bits";
      // 
      // labelControl
      // 
      this.labelControl.AutoSize = true;
      this.labelControl.Location = new System.Drawing.Point(38, 262);
      this.labelControl.Name = "labelControl";
      this.labelControl.Size = new System.Drawing.Size(45, 12);
      this.labelControl.TabIndex = 33;
      this.labelControl.Text = "Control";
      // 
      // Setting
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(249, 295);
      this.Controls.Add(this.labelControl);
      this.Controls.Add(this.labelStopBits);
      this.Controls.Add(this.labelParity);
      this.Controls.Add(this.labelDataBits);
      this.Controls.Add(this.labelBaudRate);
      this.Controls.Add(this.comboBox5);
      this.Controls.Add(this.comboBox4);
      this.Controls.Add(this.comboBox3);
      this.Controls.Add(this.comboBox2);
      this.Controls.Add(this.comboBox1);
      this.Name = "Setting";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Setting";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label labelStopBits;
        private System.Windows.Forms.Label labelControl;
    }
}