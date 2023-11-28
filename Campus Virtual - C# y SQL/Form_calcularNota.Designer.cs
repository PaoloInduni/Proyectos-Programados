namespace EZUni
{
    partial class Form_calcularNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_calcularNota));
            this.lbl_xSalir = new System.Windows.Forms.Label();
            this.lbl_nota = new System.Windows.Forms.Label();
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.btn_agregarNota = new System.Windows.Forms.Button();
            this.btn_calcularNota = new System.Windows.Forms.Button();
            this.lbl_ejemploNota = new System.Windows.Forms.Label();
            this.lbl_ejemploPorcentaje = new System.Windows.Forms.Label();
            this.txt_porcentaje = new System.Windows.Forms.TextBox();
            this.lbl_porcentaje = new System.Windows.Forms.Label();
            this.lbl_evaluacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_xSalir
            // 
            this.lbl_xSalir.AccessibleName = "xSalir";
            this.lbl_xSalir.AutoSize = true;
            this.lbl_xSalir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_xSalir.Location = new System.Drawing.Point(368, 9);
            this.lbl_xSalir.Name = "lbl_xSalir";
            this.lbl_xSalir.Size = new System.Drawing.Size(18, 21);
            this.lbl_xSalir.TabIndex = 2;
            this.lbl_xSalir.Text = "x";
            this.lbl_xSalir.Click += new System.EventHandler(this.lbl_xSalir_Click);
            // 
            // lbl_nota
            // 
            this.lbl_nota.AutoSize = true;
            this.lbl_nota.Location = new System.Drawing.Point(65, 81);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(261, 21);
            this.lbl_nota.TabIndex = 3;
            this.lbl_nota.Text = "Nota obtenida en la evaluación";
            // 
            // txt_nota
            // 
            this.txt_nota.AccessibleName = "txtNombreCurso";
            this.txt_nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nota.ForeColor = System.Drawing.Color.White;
            this.txt_nota.Location = new System.Drawing.Point(90, 130);
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(215, 27);
            this.txt_nota.TabIndex = 11;
            // 
            // btn_agregarNota
            // 
            this.btn_agregarNota.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregarNota.FlatAppearance.BorderSize = 0;
            this.btn_agregarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarNota.Location = new System.Drawing.Point(100, 269);
            this.btn_agregarNota.Name = "btn_agregarNota";
            this.btn_agregarNota.Size = new System.Drawing.Size(90, 32);
            this.btn_agregarNota.TabIndex = 15;
            this.btn_agregarNota.Text = "Agregar";
            this.btn_agregarNota.UseVisualStyleBackColor = false;
            this.btn_agregarNota.Click += new System.EventHandler(this.btn_agregarNota_Click);
            // 
            // btn_calcularNota
            // 
            this.btn_calcularNota.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_calcularNota.FlatAppearance.BorderSize = 0;
            this.btn_calcularNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcularNota.Location = new System.Drawing.Point(206, 269);
            this.btn_calcularNota.Name = "btn_calcularNota";
            this.btn_calcularNota.Size = new System.Drawing.Size(90, 32);
            this.btn_calcularNota.TabIndex = 16;
            this.btn_calcularNota.Text = "Calcular";
            this.btn_calcularNota.UseVisualStyleBackColor = false;
            this.btn_calcularNota.Click += new System.EventHandler(this.btn_calcularNota_Click);
            // 
            // lbl_ejemploNota
            // 
            this.lbl_ejemploNota.AutoSize = true;
            this.lbl_ejemploNota.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ejemploNota.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_ejemploNota.Location = new System.Drawing.Point(112, 102);
            this.lbl_ejemploNota.Name = "lbl_ejemploNota";
            this.lbl_ejemploNota.Size = new System.Drawing.Size(171, 16);
            this.lbl_ejemploNota.TabIndex = 17;
            this.lbl_ejemploNota.Text = "Formato numérico, ejemplo: 15";
            // 
            // lbl_ejemploPorcentaje
            // 
            this.lbl_ejemploPorcentaje.AutoSize = true;
            this.lbl_ejemploPorcentaje.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ejemploPorcentaje.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_ejemploPorcentaje.Location = new System.Drawing.Point(81, 196);
            this.lbl_ejemploPorcentaje.Name = "lbl_ejemploPorcentaje";
            this.lbl_ejemploPorcentaje.Size = new System.Drawing.Size(237, 16);
            this.lbl_ejemploPorcentaje.TabIndex = 20;
            this.lbl_ejemploPorcentaje.Text = "Formato numérico o decimal, ejemplo: 3.75";
            // 
            // txt_porcentaje
            // 
            this.txt_porcentaje.AccessibleName = "txtNombreCurso";
            this.txt_porcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_porcentaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_porcentaje.ForeColor = System.Drawing.Color.White;
            this.txt_porcentaje.Location = new System.Drawing.Point(90, 224);
            this.txt_porcentaje.Name = "txt_porcentaje";
            this.txt_porcentaje.Size = new System.Drawing.Size(215, 27);
            this.txt_porcentaje.TabIndex = 19;
            // 
            // lbl_porcentaje
            // 
            this.lbl_porcentaje.AutoSize = true;
            this.lbl_porcentaje.Location = new System.Drawing.Point(62, 174);
            this.lbl_porcentaje.Name = "lbl_porcentaje";
            this.lbl_porcentaje.Size = new System.Drawing.Size(276, 21);
            this.lbl_porcentaje.TabIndex = 18;
            this.lbl_porcentaje.Text = "Valor porcentual de la evaluación";
            // 
            // lbl_evaluacion
            // 
            this.lbl_evaluacion.AutoSize = true;
            this.lbl_evaluacion.Location = new System.Drawing.Point(145, 36);
            this.lbl_evaluacion.Name = "lbl_evaluacion";
            this.lbl_evaluacion.Size = new System.Drawing.Size(122, 21);
            this.lbl_evaluacion.TabIndex = 21;
            this.lbl_evaluacion.Text = "Evaluación #1";
            // 
            // Form_calcularNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(398, 348);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_evaluacion);
            this.Controls.Add(this.lbl_ejemploPorcentaje);
            this.Controls.Add(this.txt_porcentaje);
            this.Controls.Add(this.lbl_porcentaje);
            this.Controls.Add(this.lbl_ejemploNota);
            this.Controls.Add(this.btn_calcularNota);
            this.Controls.Add(this.btn_agregarNota);
            this.Controls.Add(this.txt_nota);
            this.Controls.Add(this.lbl_nota);
            this.Controls.Add(this.lbl_xSalir);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_calcularNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_xSalir;
        private System.Windows.Forms.Label lbl_nota;
        private System.Windows.Forms.TextBox txt_nota;
        private System.Windows.Forms.Button btn_agregarNota;
        private System.Windows.Forms.Button btn_calcularNota;
        private System.Windows.Forms.Label lbl_ejemploNota;
        private System.Windows.Forms.Label lbl_ejemploPorcentaje;
        private System.Windows.Forms.TextBox txt_porcentaje;
        private System.Windows.Forms.Label lbl_porcentaje;
        private System.Windows.Forms.Label lbl_evaluacion;
    }
}