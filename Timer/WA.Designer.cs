namespace Timer
{
    partial class WA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WA));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.rbRange = new System.Windows.Forms.RadioButton();
            this.rbTime = new System.Windows.Forms.RadioButton();
            this.nuHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nuMinute = new System.Windows.Forms.NumericUpDown();
            this.lbMinute = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(12, 109);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(147, 20);
            this.timePicker.TabIndex = 0;
            // 
            // rbRange
            // 
            this.rbRange.AutoSize = true;
            this.rbRange.Checked = true;
            this.rbRange.Location = new System.Drawing.Point(12, 9);
            this.rbRange.Name = "rbRange";
            this.rbRange.Size = new System.Drawing.Size(93, 17);
            this.rbRange.TabIndex = 1;
            this.rbRange.TabStop = true;
            this.rbRange.Text = "Interrupt Me in";
            this.rbRange.UseVisualStyleBackColor = true;
            // 
            // rbTime
            // 
            this.rbTime.AutoSize = true;
            this.rbTime.Location = new System.Drawing.Point(12, 76);
            this.rbTime.Name = "rbTime";
            this.rbTime.Size = new System.Drawing.Size(94, 17);
            this.rbTime.TabIndex = 2;
            this.rbTime.Text = "Interrupt Me at";
            this.rbTime.UseVisualStyleBackColor = true;
            // 
            // nuHour
            // 
            this.nuHour.Location = new System.Drawing.Point(14, 37);
            this.nuHour.Name = "nuHour";
            this.nuHour.Size = new System.Drawing.Size(34, 20);
            this.nuHour.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "H";
            // 
            // nuMinute
            // 
            this.nuMinute.Location = new System.Drawing.Point(79, 37);
            this.nuMinute.Name = "nuMinute";
            this.nuMinute.Size = new System.Drawing.Size(40, 20);
            this.nuMinute.TabIndex = 5;
            // 
            // lbMinute
            // 
            this.lbMinute.AutoSize = true;
            this.lbMinute.Location = new System.Drawing.Point(123, 40);
            this.lbMinute.Name = "lbMinute";
            this.lbMinute.Size = new System.Drawing.Size(16, 13);
            this.lbMinute.TabIndex = 7;
            this.lbMinute.Text = "M";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Timer.Properties.Resources.work;
            this.pictureBox1.Location = new System.Drawing.Point(19, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Location = new System.Drawing.Point(15, 270);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(73, 13);
            this.lbMsg.TabIndex = 9;
            this.lbMsg.Text = "Hard Working";
            this.lbMsg.Click += new System.EventHandler(this.lbMsg_Click);
            // 
            // WA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 292);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbMinute);
            this.Controls.Add(this.nuMinute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nuHour);
            this.Controls.Add(this.rbTime);
            this.Controls.Add(this.rbRange);
            this.Controls.Add(this.timePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WA";
            this.Text = "WA";
            this.Load += new System.EventHandler(this.WA_Load);
            this.SizeChanged += new System.EventHandler(this.WA_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.nuHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.RadioButton rbRange;
        private System.Windows.Forms.RadioButton rbTime;
        private System.Windows.Forms.NumericUpDown nuHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nuMinute;
        private System.Windows.Forms.Label lbMinute;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lbMsg;
    }
}

