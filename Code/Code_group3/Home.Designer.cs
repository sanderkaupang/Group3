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
            this.SuspendLayout();
            // 
            // btnAlarmHandling
            // 
            this.btnAlarmHandling.BackColor = System.Drawing.Color.Transparent;
            this.btnAlarmHandling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlarmHandling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlarmHandling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarmHandling.Location = new System.Drawing.Point(146, 122);
            this.btnAlarmHandling.Name = "btnAlarmHandling";
            this.btnAlarmHandling.Size = new System.Drawing.Size(181, 122);
            this.btnAlarmHandling.TabIndex = 0;
            this.btnAlarmHandling.Text = "Alarm Handling";
            this.btnAlarmHandling.UseVisualStyleBackColor = false;
            // 
            // btnMonitoring
            // 
            this.btnMonitoring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMonitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonitoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitoring.Location = new System.Drawing.Point(456, 122);
            this.btnMonitoring.Name = "btnMonitoring";
            this.btnMonitoring.Size = new System.Drawing.Size(174, 122);
            this.btnMonitoring.TabIndex = 1;
            this.btnMonitoring.Text = "Monitoring";
            this.btnMonitoring.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMonitoring);
            this.Controls.Add(this.btnAlarmHandling);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlarmHandling;
        private System.Windows.Forms.Button btnMonitoring;
    }
}

