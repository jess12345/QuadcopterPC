namespace QuadcopterPC
{
    partial class Form1
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
            this.button_CommPort = new System.Windows.Forms.Button();
            this.textBox_portName = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox_additonalPortInfo = new System.Windows.Forms.TextBox();
            this.label_additionalPortInfo = new System.Windows.Forms.Label();
            this.comboBox_portType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_CommPort
            // 
            this.button_CommPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CommPort.Location = new System.Drawing.Point(21, 379);
            this.button_CommPort.Name = "button_CommPort";
            this.button_CommPort.Size = new System.Drawing.Size(120, 64);
            this.button_CommPort.TabIndex = 0;
            this.button_CommPort.Text = "Open Port";
            this.button_CommPort.UseVisualStyleBackColor = true;
            // 
            // textBox_portName
            // 
            this.textBox_portName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_portName.Location = new System.Drawing.Point(21, 109);
            this.textBox_portName.Name = "textBox_portName";
            this.textBox_portName.Size = new System.Drawing.Size(120, 26);
            this.textBox_portName.TabIndex = 1;
            this.textBox_portName.Text = "192.168.1.19";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.textBox_additonalPortInfo);
            this.splitContainer1.Panel1.Controls.Add(this.label_additionalPortInfo);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_portType);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.button_CommPort);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_portName);
            this.splitContainer1.Size = new System.Drawing.Size(787, 458);
            this.splitContainer1.SplitterDistance = 165;
            this.splitContainer1.TabIndex = 2;
            // 
            // textBox_additonalPortInfo
            // 
            this.textBox_additonalPortInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_additonalPortInfo.Location = new System.Drawing.Point(21, 186);
            this.textBox_additonalPortInfo.Name = "textBox_additonalPortInfo";
            this.textBox_additonalPortInfo.Size = new System.Drawing.Size(120, 26);
            this.textBox_additonalPortInfo.TabIndex = 6;
            this.textBox_additonalPortInfo.Text = "5003";
            // 
            // label_additionalPortInfo
            // 
            this.label_additionalPortInfo.AutoSize = true;
            this.label_additionalPortInfo.Location = new System.Drawing.Point(17, 163);
            this.label_additionalPortInfo.Name = "label_additionalPortInfo";
            this.label_additionalPortInfo.Size = new System.Drawing.Size(98, 20);
            this.label_additionalPortInfo.TabIndex = 5;
            this.label_additionalPortInfo.Text = "Port Number";
            // 
            // comboBox_portType
            // 
            this.comboBox_portType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_portType.FormattingEnabled = true;
            this.comboBox_portType.Items.AddRange(new object[] {
            "WIFI",
            "SERIAL"});
            this.comboBox_portType.Location = new System.Drawing.Point(21, 39);
            this.comboBox_portType.Name = "comboBox_portType";
            this.comboBox_portType.Size = new System.Drawing.Size(121, 28);
            this.comboBox_portType.TabIndex = 4;
            this.comboBox_portType.Text = "WIFI";
            this.comboBox_portType.SelectedIndexChanged += new System.EventHandler(this.comboBox_portType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 458);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_CommPort;
        private System.Windows.Forms.TextBox textBox_portName;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_portType;
        private System.Windows.Forms.Label label_additionalPortInfo;
        private System.Windows.Forms.TextBox textBox_additonalPortInfo;
    }
}

