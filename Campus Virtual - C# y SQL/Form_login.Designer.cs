namespace EZUni
{
    partial class EZUni_login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EZUni_login));
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.lbl_xSalir = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_registrarse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // img_logo
            // 
            this.img_logo.AccessibleName = "EZU_logo";
            this.img_logo.BackColor = System.Drawing.Color.Transparent;
            this.img_logo.Cursor = System.Windows.Forms.Cursors.Default;
            this.img_logo.Image = global::EZUni.Properties.Resources.EZU_logo;
            this.img_logo.Location = new System.Drawing.Point(134, 32);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(90, 90);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_logo.TabIndex = 0;
            this.img_logo.TabStop = false;
            // 
            // lbl_xSalir
            // 
            this.lbl_xSalir.AccessibleName = "xSalir";
            this.lbl_xSalir.AutoSize = true;
            this.lbl_xSalir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_xSalir.Location = new System.Drawing.Point(318, 9);
            this.lbl_xSalir.Name = "lbl_xSalir";
            this.lbl_xSalir.Size = new System.Drawing.Size(18, 21);
            this.lbl_xSalir.TabIndex = 1;
            this.lbl_xSalir.Text = "x";
            this.lbl_xSalir.Click += new System.EventHandler(this.lbl_xSalir_Click);
            // 
            // txt_username
            // 
            this.txt_username.AccessibleName = "txtUsername";
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.ForeColor = System.Drawing.Color.White;
            this.txt_username.Location = new System.Drawing.Point(87, 182);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(182, 27);
            this.txt_username.TabIndex = 2;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(149, 158);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(66, 21);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "Usuario";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(130, 225);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(103, 21);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "Contraseña";
            // 
            // txt_password
            // 
            this.txt_password.AccessibleName = "txtPassword";
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(87, 249);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(182, 27);
            this.txt_password.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Location = new System.Drawing.Point(134, 362);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(90, 32);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Entrar";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_registrarse
            // 
            this.lbl_registrarse.AutoSize = true;
            this.lbl_registrarse.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registrarse.Location = new System.Drawing.Point(142, 309);
            this.lbl_registrarse.Name = "lbl_registrarse";
            this.lbl_registrarse.Size = new System.Drawing.Size(77, 16);
            this.lbl_registrarse.TabIndex = 8;
            this.lbl_registrarse.Text = "REGISTRARSE";
            // 
            // EZUni_login
            // 
            this.AccessibleName = "login_frame";
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(348, 448);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_registrarse);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_xSalir);
            this.Controls.Add(this.img_logo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EZUni_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.Label lbl_xSalir;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_registrarse;
    }
}

