namespace CPS_PRESEBTACION
{
    partial class FROM_LOGIN_RECUPERAR
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
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.INGRESAR_USUARIO = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnrecupear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(139, 126);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(238, 20);
            this.txtusuario.TabIndex = 1;
            // 
            // txtmensaje
            // 
            this.txtmensaje.Location = new System.Drawing.Point(139, 177);
            this.txtmensaje.Multiline = true;
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.ReadOnly = true;
            this.txtmensaje.Size = new System.Drawing.Size(238, 116);
            this.txtmensaje.TabIndex = 2;
            // 
            // INGRESAR_USUARIO
            // 
            this.INGRESAR_USUARIO.AutoSize = true;
            this.INGRESAR_USUARIO.Location = new System.Drawing.Point(15, 129);
            this.INGRESAR_USUARIO.Name = "INGRESAR_USUARIO";
            this.INGRESAR_USUARIO.Size = new System.Drawing.Size(118, 13);
            this.INGRESAR_USUARIO.TabIndex = 3;
            this.INGRESAR_USUARIO.Text = "INGRESAR_USUARIO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CPS_PRESEBTACION.Properties.Resources.perspectiva;
            this.pictureBox2.Location = new System.Drawing.Point(65, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 65);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnsalir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnsalir.Image = global::CPS_PRESEBTACION.Properties.Resources.logout;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Location = new System.Drawing.Point(28, 335);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(80, 31);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnrecupear
            // 
            this.btnrecupear.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecupear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnrecupear.Image = global::CPS_PRESEBTACION.Properties.Resources.gmail;
            this.btnrecupear.Location = new System.Drawing.Point(383, 109);
            this.btnrecupear.Name = "btnrecupear";
            this.btnrecupear.Size = new System.Drawing.Size(86, 48);
            this.btnrecupear.TabIndex = 0;
            this.btnrecupear.Text = "RECUPEAR";
            this.btnrecupear.UseVisualStyleBackColor = true;
            this.btnrecupear.Click += new System.EventHandler(this.btnrecupear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(135, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "RECUPERAR_CONTRASEÑA";
            // 
            // FROM_LOGIN_RECUPERAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(478, 407);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.INGRESAR_USUARIO);
            this.Controls.Add(this.txtmensaje);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.btnrecupear);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FROM_LOGIN_RECUPERAR";
            this.Opacity = 0.9D;
            this.Text = "FROM_LOGIN_RECUPERAR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrecupear;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtmensaje;
        private System.Windows.Forms.Label INGRESAR_USUARIO;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}