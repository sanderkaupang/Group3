namespace Code_group3
{
    partial class AlarmHandler
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
            this.btnAlarmActive = new System.Windows.Forms.Button();
            this.btnAlarmDeactive = new System.Windows.Forms.Button();
            this.dgvAlarmList = new System.Windows.Forms.DataGridView();
            this.btnLog = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxDeactive = new System.Windows.Forms.PictureBox();
            this.picBoxActive = new System.Windows.Forms.PictureBox();
            this.AlarmList = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDeactive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxActive)).BeginInit();
            this.AlarmList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlarmActive
            // 
            this.btnAlarmActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarmActive.Location = new System.Drawing.Point(24, 176);
            this.btnAlarmActive.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlarmActive.Name = "btnAlarmActive";
            this.btnAlarmActive.Size = new System.Drawing.Size(123, 35);
            this.btnAlarmActive.TabIndex = 0;
            this.btnAlarmActive.Text = "Away (Active)";
            this.btnAlarmActive.UseVisualStyleBackColor = true;
            this.btnAlarmActive.Click += new System.EventHandler(this.btnAlarmActive_Click);
            // 
            // btnAlarmDeactive
            // 
            this.btnAlarmDeactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarmDeactive.Location = new System.Drawing.Point(24, 256);
            this.btnAlarmDeactive.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlarmDeactive.Name = "btnAlarmDeactive";
            this.btnAlarmDeactive.Size = new System.Drawing.Size(123, 35);
            this.btnAlarmDeactive.TabIndex = 1;
            this.btnAlarmDeactive.Text = "Home (Deactive)";
            this.btnAlarmDeactive.UseVisualStyleBackColor = true;
            this.btnAlarmDeactive.Click += new System.EventHandler(this.btnAlarmDeactive_Click);
            // 
            // dgvAlarmList
            // 
            this.dgvAlarmList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlarmList.Location = new System.Drawing.Point(69, 37);
            this.dgvAlarmList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAlarmList.Name = "dgvAlarmList";
            this.dgvAlarmList.RowHeadersWidth = 51;
            this.dgvAlarmList.RowTemplate.Height = 24;
            this.dgvAlarmList.Size = new System.Drawing.Size(370, 180);
            this.dgvAlarmList.TabIndex = 2;
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(132, 246);
            this.btnLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(80, 35);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(292, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reset Alarm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(877, 11);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(64, 20);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.picBoxDeactive);
            this.panel1.Controls.Add(this.picBoxActive);
            this.panel1.Controls.Add(this.btnAlarmActive);
            this.panel1.Controls.Add(this.btnAlarmDeactive);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 518);
            this.panel1.TabIndex = 7;
            // 
            // picBoxDeactive
            // 
            this.picBoxDeactive.Image = global::Code_group3.Properties.Resources._checked;
            this.picBoxDeactive.Location = new System.Drawing.Point(152, 256);
            this.picBoxDeactive.Name = "picBoxDeactive";
            this.picBoxDeactive.Size = new System.Drawing.Size(43, 35);
            this.picBoxDeactive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxDeactive.TabIndex = 9;
            this.picBoxDeactive.TabStop = false;
            this.picBoxDeactive.Visible = false;
            // 
            // picBoxActive
            // 
            this.picBoxActive.Image = global::Code_group3.Properties.Resources.circle_button;
            this.picBoxActive.Location = new System.Drawing.Point(152, 176);
            this.picBoxActive.Name = "picBoxActive";
            this.picBoxActive.Size = new System.Drawing.Size(43, 35);
            this.picBoxActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxActive.TabIndex = 9;
            this.picBoxActive.TabStop = false;
            this.picBoxActive.Visible = false;
            // 
            // AlarmList
            // 
            this.AlarmList.Controls.Add(this.dgvAlarmList);
            this.AlarmList.Controls.Add(this.btnLog);
            this.AlarmList.Controls.Add(this.button1);
            this.AlarmList.Location = new System.Drawing.Point(299, 97);
            this.AlarmList.Name = "AlarmList";
            this.AlarmList.Size = new System.Drawing.Size(508, 339);
            this.AlarmList.TabIndex = 8;
            this.AlarmList.TabStop = false;
            this.AlarmList.Text = "Alarm List";
            // 
            // AlarmHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 566);
            this.Controls.Add(this.AlarmList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AlarmHandler";
            this.Text = "AlarmHandler";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmList)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDeactive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxActive)).EndInit();
            this.AlarmList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlarmActive;
        private System.Windows.Forms.Button btnAlarmDeactive;
        private System.Windows.Forms.DataGridView dgvAlarmList;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox AlarmList;
        private System.Windows.Forms.PictureBox picBoxActive;
        private System.Windows.Forms.PictureBox picBoxDeactive;
    }
}