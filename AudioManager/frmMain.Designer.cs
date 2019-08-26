namespace AudioManager
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxOutput = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxInput = new System.Windows.Forms.ComboBox();
            this.trackBarOutput = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarInput = new System.Windows.Forms.TrackBar();
            this.lblOutputValue = new System.Windows.Forms.Label();
            this.lblInputValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInput)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxOutput
            // 
            this.comboBoxOutput.FormattingEnabled = true;
            this.comboBoxOutput.Location = new System.Drawing.Point(25, 46);
            this.comboBoxOutput.Name = "comboBoxOutput";
            this.comboBoxOutput.Size = new System.Drawing.Size(404, 20);
            this.comboBoxOutput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "所有音频输出设备";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "所有音频输入设备";
            // 
            // comboBoxInput
            // 
            this.comboBoxInput.FormattingEnabled = true;
            this.comboBoxInput.Location = new System.Drawing.Point(25, 142);
            this.comboBoxInput.Name = "comboBoxInput";
            this.comboBoxInput.Size = new System.Drawing.Size(404, 20);
            this.comboBoxInput.TabIndex = 2;
            // 
            // trackBarOutput
            // 
            this.trackBarOutput.Location = new System.Drawing.Point(447, 46);
            this.trackBarOutput.Maximum = 100;
            this.trackBarOutput.Name = "trackBarOutput";
            this.trackBarOutput.Size = new System.Drawing.Size(404, 45);
            this.trackBarOutput.TabIndex = 4;
            this.trackBarOutput.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarOutput.Value = 1;
            this.trackBarOutput.ValueChanged += new System.EventHandler(this.trackBarOutput_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "默认输出设备音量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "默认输入设备音量";
            // 
            // trackBarInput
            // 
            this.trackBarInput.Location = new System.Drawing.Point(449, 142);
            this.trackBarInput.Maximum = 100;
            this.trackBarInput.Name = "trackBarInput";
            this.trackBarInput.Size = new System.Drawing.Size(404, 45);
            this.trackBarInput.TabIndex = 6;
            this.trackBarInput.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarInput.Value = 1;
            this.trackBarInput.ValueChanged += new System.EventHandler(this.trackBarInput_ValueChanged);
            // 
            // lblOutputValue
            // 
            this.lblOutputValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutputValue.Location = new System.Drawing.Point(857, 57);
            this.lblOutputValue.Name = "lblOutputValue";
            this.lblOutputValue.Size = new System.Drawing.Size(48, 23);
            this.lblOutputValue.TabIndex = 8;
            this.lblOutputValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputValue
            // 
            this.lblInputValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInputValue.Location = new System.Drawing.Point(857, 153);
            this.lblInputValue.Name = "lblInputValue";
            this.lblInputValue.Size = new System.Drawing.Size(48, 23);
            this.lblInputValue.TabIndex = 8;
            this.lblInputValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 209);
            this.Controls.Add(this.lblInputValue);
            this.Controls.Add(this.lblOutputValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBarInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxOutput);
            this.Name = "frmMain";
            this.Text = "音频设备管理器";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxInput;
        private System.Windows.Forms.TrackBar trackBarOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarInput;
        private System.Windows.Forms.Label lblOutputValue;
        private System.Windows.Forms.Label lblInputValue;
    }
}

