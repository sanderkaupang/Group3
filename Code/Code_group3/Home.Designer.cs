namespace Code_group3
{
    partial class Home
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
            this.btnAlarmHandling = new System.Windows.Forms.Button();
            this.btnMonitoring = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlarmHandling
            // 
            this.btnAlarmHandling.BackColor = System.Drawing.Color.Azure;
            this.btnAlarmHandling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlarmHandling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlarmHandling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarmHandling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarmHandling.Location = new System.Drawing.Point(143, 327);
            this.btnAlarmHandling.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlarmHandling.Name = "btnAlarmHandling";
            this.btnAlarmHandling.Size = new System.Drawing.Size(144, 43);
            this.btnAlarmHandling.TabIndex = 1;
            this.btnAlarmHandling.Text = "Alarm Handling";
            this.btnAlarmHandling.UseVisualStyleBackColor = false;
            this.btnAlarmHandling.Click += new System.EventHandler(this.btnAlarmHandling_Click);
            // 
            // btnMonitoring
            // 
            this.btnMonitoring.BackColor = System.Drawing.Color.Azure;
            this.btnMonitoring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMonitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitoring.Location = new System.Drawing.Point(437, 327);
            this.btnMonitoring.Margin = new System.Windows.Forms.Padding(2);
            this.btnMonitoring.Name = "btnMonitoring";
            this.btnMonitoring.Size = new System.Drawing.Size(123, 43);
            this.btnMonitoring.TabIndex = 1;
            this.btnMonitoring.Text = "Monitoring";
            this.btnMonitoring.UseVisualStyleBackColor = false;
            this.btnMonitoring.Click += new System.EventHandler(this.btnMonitoring_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Code_group3.Properties.Resources.television;
            this.pictureBox1.Location = new System.Drawing.Point(437, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Code_group3.Properties.Resources.bell;
            this.pictureBox2.Location = new System.Drawing.Point(167, 237);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Made by: Weihrauch, Fagerlund and Kaupang";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(741, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnMonitoring);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAlarmHandling);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlarmHandling;
        private System.Windows.Forms.Button btnMonitoring;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

