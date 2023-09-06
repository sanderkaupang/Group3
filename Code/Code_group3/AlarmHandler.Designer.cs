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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlarmActive
            // 
            this.btnAlarmActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarmActive.Location = new System.Drawing.Point(90, 24);
            this.btnAlarmActive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlarmActive.Name = "btnAlarmActive";
            this.btnAlarmActive.Size = new System.Drawing.Size(136, 35);
            this.btnAlarmActive.TabIndex = 0;
            this.btnAlarmActive.Text = "Away (Active)";
            this.btnAlarmActive.UseVisualStyleBackColor = true;
            // 
            // btnAlarmDeactive
            // 
            this.btnAlarmDeactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarmDeactive.Location = new System.Drawing.Point(314, 24);
            this.btnAlarmDeactive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlarmDeactive.Name = "btnAlarmDeactive";
            this.btnAlarmDeactive.Size = new System.Drawing.Size(146, 35);
            this.btnAlarmDeactive.TabIndex = 1;
            this.btnAlarmDeactive.Text = "Home (Deactive)";
            this.btnAlarmDeactive.UseVisualStyleBackColor = true;
            // 
            // dgvAlarmList
            // 
            this.dgvAlarmList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlarmList.Location = new System.Drawing.Point(90, 87);
            this.dgvAlarmList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAlarmList.Name = "dgvAlarmList";
            this.dgvAlarmList.RowHeadersWidth = 51;
            this.dgvAlarmList.RowTemplate.Height = 24;
            this.dgvAlarmList.Size = new System.Drawing.Size(370, 180);
            this.dgvAlarmList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alarm List";
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(124, 285);
            this.btnLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(80, 35);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(328, 285);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reset Alarm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(525, 11);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(64, 20);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // AlarmHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAlarmList);
            this.Controls.Add(this.btnAlarmDeactive);
            this.Controls.Add(this.btnAlarmActive);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AlarmHandler";
            this.Text = "AlarmHandler";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlarmActive;
        private System.Windows.Forms.Button btnAlarmDeactive;
        private System.Windows.Forms.DataGridView dgvAlarmList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHome;
    }
}