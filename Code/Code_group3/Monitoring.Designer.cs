namespace Code_group3
{
    partial class Monitoring
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
            this.dgvM = new System.Windows.Forms.DataGridView();
            this.txtHeatStatus = new System.Windows.Forms.TextBox();
            this.txtCoolingStatus = new System.Windows.Forms.TextBox();
            this.txtProcessValue = new System.Windows.Forms.TextBox();
            this.txtSetTempValue = new System.Windows.Forms.TextBox();
            this.btnLightManual = new System.Windows.Forms.Button();
            this.btnLightAuto = new System.Windows.Forms.Button();
            this.btnOffOn = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvM
            // 
            this.dgvM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvM.Location = new System.Drawing.Point(434, 117);
            this.dgvM.Name = "dgvM";
            this.dgvM.RowHeadersWidth = 51;
            this.dgvM.RowTemplate.Height = 24;
            this.dgvM.Size = new System.Drawing.Size(240, 150);
            this.dgvM.TabIndex = 0;
            // 
            // txtHeatStatus
            // 
            this.txtHeatStatus.Location = new System.Drawing.Point(36, 77);
            this.txtHeatStatus.Name = "txtHeatStatus";
            this.txtHeatStatus.Size = new System.Drawing.Size(100, 22);
            this.txtHeatStatus.TabIndex = 2;
            this.txtHeatStatus.Text = "Heat Status";
            // 
            // txtCoolingStatus
            // 
            this.txtCoolingStatus.Location = new System.Drawing.Point(166, 77);
            this.txtCoolingStatus.Name = "txtCoolingStatus";
            this.txtCoolingStatus.Size = new System.Drawing.Size(100, 22);
            this.txtCoolingStatus.TabIndex = 3;
            this.txtCoolingStatus.Text = "Cooling Status";
            // 
            // txtProcessValue
            // 
            this.txtProcessValue.Location = new System.Drawing.Point(166, 126);
            this.txtProcessValue.Name = "txtProcessValue";
            this.txtProcessValue.Size = new System.Drawing.Size(100, 22);
            this.txtProcessValue.TabIndex = 4;
            this.txtProcessValue.Text = "Process Value";
            // 
            // txtSetTempValue
            // 
            this.txtSetTempValue.Location = new System.Drawing.Point(36, 126);
            this.txtSetTempValue.Name = "txtSetTempValue";
            this.txtSetTempValue.Size = new System.Drawing.Size(100, 22);
            this.txtSetTempValue.TabIndex = 5;
            this.txtSetTempValue.Text = "Set Temp Value";
            // 
            // btnLightManual
            // 
            this.btnLightManual.Location = new System.Drawing.Point(36, 205);
            this.btnLightManual.Name = "btnLightManual";
            this.btnLightManual.Size = new System.Drawing.Size(100, 23);
            this.btnLightManual.TabIndex = 6;
            this.btnLightManual.Text = "Light Manual";
            this.btnLightManual.UseVisualStyleBackColor = true;
            // 
            // btnLightAuto
            // 
            this.btnLightAuto.Location = new System.Drawing.Point(166, 205);
            this.btnLightAuto.Name = "btnLightAuto";
            this.btnLightAuto.Size = new System.Drawing.Size(100, 23);
            this.btnLightAuto.TabIndex = 7;
            this.btnLightAuto.Text = "Light Auto";
            this.btnLightAuto.UseVisualStyleBackColor = true;
            // 
            // btnOffOn
            // 
            this.btnOffOn.Location = new System.Drawing.Point(36, 284);
            this.btnOffOn.Name = "btnOffOn";
            this.btnOffOn.Size = new System.Drawing.Size(100, 23);
            this.btnOffOn.TabIndex = 8;
            this.btnOffOn.Text = "Light Off/On";
            this.btnOffOn.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 415);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 23);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnOffOn);
            this.Controls.Add(this.btnLightAuto);
            this.Controls.Add(this.btnLightManual);
            this.Controls.Add(this.txtSetTempValue);
            this.Controls.Add(this.txtProcessValue);
            this.Controls.Add(this.txtCoolingStatus);
            this.Controls.Add(this.txtHeatStatus);
            this.Controls.Add(this.dgvM);
            this.Name = "Monitoring";
            this.Text = "Monitoring";
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvM;
        private System.Windows.Forms.TextBox txtHeatStatus;
        private System.Windows.Forms.TextBox txtCoolingStatus;
        private System.Windows.Forms.TextBox txtProcessValue;
        private System.Windows.Forms.TextBox txtSetTempValue;
        private System.Windows.Forms.Button btnLightManual;
        private System.Windows.Forms.Button btnLightAuto;
        private System.Windows.Forms.Button btnOffOn;
        private System.Windows.Forms.Button btnHome;
    }
}