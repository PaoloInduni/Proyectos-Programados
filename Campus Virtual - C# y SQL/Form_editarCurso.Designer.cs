namespace EZUni
{
    public partial class Form_editarCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_editarCurso));
            this.lbl_xSalir = new System.Windows.Forms.Label();
            this.btn_curso = new System.Windows.Forms.Button();
            this.lbl_profesor = new System.Windows.Forms.Label();
            this.txt_profesor = new System.Windows.Forms.TextBox();
            this.lbl_nombreCurso = new System.Windows.Forms.Label();
            this.txt_nombreCurso = new System.Windows.Forms.TextBox();
            this.lbl_agregarCurso = new System.Windows.Forms.Label();
            this.lbl_carrera = new System.Windows.Forms.Label();
            this.txt_carrera = new System.Windows.Forms.TextBox();
            this.combo_dia = new System.Windows.Forms.ComboBox();
            this.lbl_horario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_xSalir
            // 
            this.lbl_xSalir.AccessibleName = "xSalir";
            this.lbl_xSalir.AutoSize = true;
            this.lbl_xSalir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_xSalir.Location = new System.Drawing.Point(318, 9);
            this.lbl_xSalir.Name = "lbl_xSalir";
            this.lbl_xSalir.Size = new System.Drawing.Size(18, 21);
            this.lbl_xSalir.TabIndex = 2;
            this.lbl_xSalir.Text = "x";
            this.lbl_xSalir.Click += new System.EventHandler(this.lbl_xSalir_Click);
            // 
            // btn_curso
            // 
            this.btn_curso.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_curso.FlatAppearance.BorderSize = 0;
            this.btn_curso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_curso.Location = new System.Drawing.Point(136, 384);
            this.btn_curso.Name = "btn_curso";
            this.btn_curso.Size = new System.Drawing.Size(90, 32);
            this.btn_curso.TabIndex = 14;
            this.btn_curso.Text = "Aceptar";
            this.btn_curso.UseVisualStyleBackColor = false;
            this.btn_curso.Click += new System.EventHandler(this.btn_curso_Click);
            // 
            // lbl_profesor
            // 
            this.lbl_profesor.AutoSize = true;
            this.lbl_profesor.Location = new System.Drawing.Point(145, 164);
            this.lbl_profesor.Name = "lbl_profesor";
            this.lbl_profesor.Size = new System.Drawing.Size(70, 21);
            this.lbl_profesor.TabIndex = 13;
            this.lbl_profesor.Text = "Profesor";
            // 
            // txt_profesor
            // 
            this.txt_profesor.AccessibleName = "txtPassword";
            this.txt_profesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_profesor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_profesor.ForeColor = System.Drawing.Color.White;
            this.txt_profesor.Location = new System.Drawing.Point(71, 188);
            this.txt_profesor.Name = "txt_profesor";
            this.txt_profesor.Size = new System.Drawing.Size(215, 27);
            this.txt_profesor.TabIndex = 12;
            // 
            // lbl_nombreCurso
            // 
            this.lbl_nombreCurso.AutoSize = true;
            this.lbl_nombreCurso.Location = new System.Drawing.Point(144, 97);
            this.lbl_nombreCurso.Name = "lbl_nombreCurso";
            this.lbl_nombreCurso.Size = new System.Drawing.Size(73, 21);
            this.lbl_nombreCurso.TabIndex = 11;
            this.lbl_nombreCurso.Text = "Nombre";
            // 
            // txt_nombreCurso
            // 
            this.txt_nombreCurso.AccessibleName = "txtNombreCurso";
            this.txt_nombreCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombreCurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombreCurso.ForeColor = System.Drawing.Color.White;
            this.txt_nombreCurso.Location = new System.Drawing.Point(71, 121);
            this.txt_nombreCurso.Name = "txt_nombreCurso";
            this.txt_nombreCurso.Size = new System.Drawing.Size(215, 27);
            this.txt_nombreCurso.TabIndex = 10;
            // 
            // lbl_agregarCurso
            // 
            this.lbl_agregarCurso.AutoSize = true;
            this.lbl_agregarCurso.Location = new System.Drawing.Point(115, 43);
            this.lbl_agregarCurso.Name = "lbl_agregarCurso";
            this.lbl_agregarCurso.Size = new System.Drawing.Size(135, 21);
            this.lbl_agregarCurso.TabIndex = 16;
            this.lbl_agregarCurso.Text = "AÑADIR CURSO";
            // 
            // lbl_carrera
            // 
            this.lbl_carrera.AutoSize = true;
            this.lbl_carrera.Location = new System.Drawing.Point(144, 229);
            this.lbl_carrera.Name = "lbl_carrera";
            this.lbl_carrera.Size = new System.Drawing.Size(70, 21);
            this.lbl_carrera.TabIndex = 18;
            this.lbl_carrera.Text = "Carrera";
            // 
            // txt_carrera
            // 
            this.txt_carrera.AccessibleName = "txtUsername";
            this.txt_carrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_carrera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_carrera.ForeColor = System.Drawing.Color.White;
            this.txt_carrera.Location = new System.Drawing.Point(71, 253);
            this.txt_carrera.Name = "txt_carrera";
            this.txt_carrera.Size = new System.Drawing.Size(215, 27);
            this.txt_carrera.TabIndex = 17;
            // 
            // combo_dia
            // 
            this.combo_dia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.combo_dia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_dia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_dia.ForeColor = System.Drawing.Color.White;
            this.combo_dia.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.combo_dia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.combo_dia.Location = new System.Drawing.Point(71, 325);
            this.combo_dia.Name = "combo_dia";
            this.combo_dia.Size = new System.Drawing.Size(215, 29);
            this.combo_dia.TabIndex = 0;
            // 
            // lbl_horario
            // 
            this.lbl_horario.AutoSize = true;
            this.lbl_horario.Location = new System.Drawing.Point(146, 296);
            this.lbl_horario.Name = "lbl_horario";
            this.lbl_horario.Size = new System.Drawing.Size(65, 21);
            this.lbl_horario.TabIndex = 20;
            this.lbl_horario.Text = "Horario";
            // 
            // Form_editarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(348, 448);
            this.ControlBox = false;
            this.Controls.Add(this.combo_dia);
            this.Controls.Add(this.lbl_horario);
            this.Controls.Add(this.lbl_carrera);
            this.Controls.Add(this.txt_carrera);
            this.Controls.Add(this.lbl_agregarCurso);
            this.Controls.Add(this.btn_curso);
            this.Controls.Add(this.lbl_profesor);
            this.Controls.Add(this.txt_profesor);
            this.Controls.Add(this.lbl_nombreCurso);
            this.Controls.Add(this.txt_nombreCurso);
            this.Controls.Add(this.lbl_xSalir);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_editarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_xSalir;
        private System.Windows.Forms.Button btn_curso;
        private System.Windows.Forms.Label lbl_profesor;
        private System.Windows.Forms.TextBox txt_profesor;
        private System.Windows.Forms.Label lbl_nombreCurso;
        private System.Windows.Forms.TextBox txt_nombreCurso;
        private System.Windows.Forms.Label lbl_agregarCurso;
        private System.Windows.Forms.Label lbl_carrera;
        private System.Windows.Forms.TextBox txt_carrera;
        private System.Windows.Forms.ComboBox combo_dia;
        private System.Windows.Forms.Label lbl_horario;
    }
}