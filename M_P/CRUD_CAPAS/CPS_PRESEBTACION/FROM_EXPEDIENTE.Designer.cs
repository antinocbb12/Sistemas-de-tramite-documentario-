namespace CPS_PRESEBTACION
{
    partial class FROM_EXPEDIENTE
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
            this.PANEL_DDD = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btndocumento = new System.Windows.Forms.Button();
            this.btnsolicitud = new System.Windows.Forms.Button();
            this.PANEL_DDD.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // PANEL_DDD
            // 
            this.PANEL_DDD.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PANEL_DDD.Controls.Add(this.groupBox1);
            this.PANEL_DDD.Location = new System.Drawing.Point(384, 209);
            this.PANEL_DDD.Name = "PANEL_DDD";
            this.PANEL_DDD.Size = new System.Drawing.Size(894, 696);
            this.PANEL_DDD.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 662);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(36, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Solicitante";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(389, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "docuemntacion";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.btndocumento);
            this.groupBox6.Controls.Add(this.btnsolicitud);
            this.groupBox6.Location = new System.Drawing.Point(571, 103);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(553, 100);
            this.groupBox6.TabIndex = 36;
            this.groupBox6.TabStop = false;
            // 
            // btndocumento
            // 
            this.btndocumento.Image = global::CPS_PRESEBTACION.Properties.Resources.archivo;
            this.btndocumento.Location = new System.Drawing.Point(401, 25);
            this.btndocumento.Name = "btndocumento";
            this.btndocumento.Size = new System.Drawing.Size(87, 75);
            this.btndocumento.TabIndex = 38;
            this.btndocumento.UseVisualStyleBackColor = true;
            this.btndocumento.Click += new System.EventHandler(this.btndocumento_Click_1);
            // 
            // btnsolicitud
            // 
            this.btnsolicitud.Image = global::CPS_PRESEBTACION.Properties.Resources.lider__1_1;
            this.btnsolicitud.Location = new System.Drawing.Point(39, 25);
            this.btnsolicitud.Name = "btnsolicitud";
            this.btnsolicitud.Size = new System.Drawing.Size(87, 75);
            this.btnsolicitud.TabIndex = 0;
            this.btnsolicitud.UseVisualStyleBackColor = true;
            this.btnsolicitud.Click += new System.EventHandler(this.btnsolicitud_Click_1);
            // 
            // FROM_EXPEDIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1591, 924);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.PANEL_DDD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FROM_EXPEDIENTE";
            this.Text = "FROM_EXPEDIENTE";
            this.PANEL_DDD.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PANEL_DDD;
        private System.Windows.Forms.Button btnsolicitud;
        private System.Windows.Forms.Button btndocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}