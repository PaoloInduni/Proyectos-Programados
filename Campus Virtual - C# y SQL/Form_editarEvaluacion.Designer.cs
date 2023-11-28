namespace EZUni
{
    partial class Form_editarEvaluacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_editarEvaluacion));
            this.lbl_xSalir = new System.Windows.Forms.Label();
            this.combo_curso = new System.Windows.Forms.ComboBox();
            this.lbl_valorPorcentual = new System.Windows.Forms.Label();
            this.txt_valorPorcentual = new System.Windows.Forms.TextBox();
            this.lbl_agregarEvaluacion = new System.Windows.Forms.Label();
            this.btn_evaluacion = new System.Windows.Forms.Button();
            this.lbl_curso = new System.Windows.Forms.Label();
            this.lbl_nombreEvaluacion = new System.Windows.Forms.Label();
            this.txt_nombreEvaluacion = new System.Windows.Forms.TextBox();
            this.lbl_ejemploPorcentaje = new System.Windows.Forms.Label();
            this.dateTime_fechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.lbl_fechaEntrega = new System.Windows.Forms.Label();
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
            this.lbl_xSalir.TabIndex = 3;
            this.lbl_xSalir.Text = "x";
            this.lbl_xSalir.Click += new System.EventHandler(this.lbl_xSalir_Click);
            // 
            // combo_curso
            // 
            this.combo_curso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.combo_curso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_curso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_curso.ForeColor = System.Drawing.Color.White;
            this.combo_curso.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.combo_curso.Location = new System.Drawing.Point(67, 176);
            this.combo_curso.Name = "combo_curso";
            this.combo_curso.Size = new System.Drawing.Size(215, 29);
            this.combo_curso.TabIndex = 21;
            // 
            // lbl_valorPorcentual
            // 
            this.lbl_valorPorcentual.AutoSize = true;
            this.lbl_valorPorcentual.Location = new System.Drawing.Point(103, 223);
            this.lbl_valorPorcentual.Name = "lbl_valorPorcentual";
            this.lbl_valorPorcentual.Size = new System.Drawing.Size(139, 21);
            this.lbl_valorPorcentual.TabIndex = 29;
            this.lbl_valorPorcentual.Text = "Valor Porcentual";
            // 
            // txt_valorPorcentual
            // 
            this.txt_valorPorcentual.AccessibleName = "txtUsername";
            this.txt_valorPorcentual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_valorPorcentual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_valorPorcentual.ForeColor = System.Drawing.Color.White;
            this.txt_valorPorcentual.Location = new System.Drawing.Point(67, 269);
            this.txt_valorPorcentual.Name = "txt_valorPorcentual";
            this.txt_valorPorcentual.Size = new System.Drawing.Size(215, 27);
            this.txt_valorPorcentual.TabIndex = 28;
            // 
            // lbl_agregarEvaluacion
            // 
            this.lbl_agregarEvaluacion.AutoSize = true;
            this.lbl_agregarEvaluacion.Location = new System.Drawing.Point(82, 38);
            this.lbl_agregarEvaluacion.Name = "lbl_agregarEvaluacion";
            this.lbl_agregarEvaluacion.Size = new System.Drawing.Size(187, 21);
            this.lbl_agregarEvaluacion.TabIndex = 27;
            this.lbl_agregarEvaluacion.Text = "AÑADIR EVALUACIÓN";
            // 
            // btn_evaluacion
            // 
            this.btn_evaluacion.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_evaluacion.FlatAppearance.BorderSize = 0;
            this.btn_evaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_evaluacion.Location = new System.Drawing.Point(132, 379);
            this.btn_evaluacion.Name = "btn_evaluacion";
            this.btn_evaluacion.Size = new System.Drawing.Size(90, 32);
            this.btn_evaluacion.TabIndex = 26;
            this.btn_evaluacion.Text = "Aceptar";
            this.btn_evaluacion.UseVisualStyleBackColor = false;
            this.btn_evaluacion.Click += new System.EventHandler(this.btn_evaluacion_Click);
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.Location = new System.Drawing.Point(141, 152);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(54, 21);
            this.lbl_curso.TabIndex = 25;
            this.lbl_curso.Text = "Curso";
            // 
            // lbl_nombreEvaluacion
            // 
            this.lbl_nombreEvaluacion.AutoSize = true;
            this.lbl_nombreEvaluacion.Location = new System.Drawing.Point(148, 85);
            this.lbl_nombreEvaluacion.Name = "lbl_nombreEvaluacion";
            this.lbl_nombreEvaluacion.Size = new System.Drawing.Size(51, 21);
            this.lbl_nombreEvaluacion.TabIndex = 23;
            this.lbl_nombreEvaluacion.Text = "Título";
            // 
            // txt_nombreEvaluacion
            // 
            this.txt_nombreEvaluacion.AccessibleName = "txtNombreCurso";
            this.txt_nombreEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombreEvaluacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombreEvaluacion.ForeColor = System.Drawing.Color.White;
            this.txt_nombreEvaluacion.Location = new System.Drawing.Point(67, 109);
            this.txt_nombreEvaluacion.Name = "txt_nombreEvaluacion";
            this.txt_nombreEvaluacion.Size = new System.Drawing.Size(215, 27);
            this.txt_nombreEvaluacion.TabIndex = 22;
            // 
            // lbl_ejemploPorcentaje
            // 
            this.lbl_ejemploPorcentaje.AutoSize = true;
            this.lbl_ejemploPorcentaje.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ejemploPorcentaje.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_ejemploPorcentaje.Location = new System.Drawing.Point(135, 244);
            this.lbl_ejemploPorcentaje.Name = "lbl_ejemploPorcentaje";
            this.lbl_ejemploPorcentaje.Size = new System.Drawing.Size(76, 16);
            this.lbl_ejemploPorcentaje.TabIndex = 30;
            this.lbl_ejemploPorcentaje.Text = "Ejemplo: 3.75";
            // 
            // dateTime_fechaEntrega
            // 
            this.dateTime_fechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_fechaEntrega.Location = new System.Drawing.Point(67, 329);
            this.dateTime_fechaEntrega.Name = "dateTime_fechaEntrega";
            this.dateTime_fechaEntrega.Size = new System.Drawing.Size(215, 27);
            this.dateTime_fechaEntrega.TabIndex = 31;
            // 
            // lbl_fechaEntrega
            // 
            this.lbl_fechaEntrega.AutoSize = true;
            this.lbl_fechaEntrega.Location = new System.Drawing.Point(99, 305);
            this.lbl_fechaEntrega.Name = "lbl_fechaEntrega";
            this.lbl_fechaEntrega.Size = new System.Drawing.Size(152, 21);
            this.lbl_fechaEntrega.TabIndex = 32;
            this.lbl_fechaEntrega.Text = "Fecha de entrega";
            // 
            // Form_editarEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(348, 448);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_fechaEntrega);
            this.Controls.Add(this.dateTime_fechaEntrega);
            this.Controls.Add(this.lbl_ejemploPorcentaje);
            this.Controls.Add(this.combo_curso);
            this.Controls.Add(this.lbl_valorPorcentual);
            this.Controls.Add(this.txt_valorPorcentual);
            this.Controls.Add(this.lbl_agregarEvaluacion);
            this.Controls.Add(this.btn_evaluacion);
            this.Controls.Add(this.lbl_curso);
            this.Controls.Add(this.lbl_nombreEvaluacion);
            this.Controls.Add(this.txt_nombreEvaluacion);
            this.Controls.Add(this.lbl_xSalir);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_editarEvaluacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_xSalir;
        private System.Windows.Forms.ComboBox combo_curso;
        private System.Windows.Forms.Label lbl_valorPorcentual;
        private System.Windows.Forms.TextBox txt_valorPorcentual;
        private System.Windows.Forms.Label lbl_agregarEvaluacion;
        private System.Windows.Forms.Button btn_evaluacion;
        private System.Windows.Forms.Label lbl_curso;
        private System.Windows.Forms.Label lbl_nombreEvaluacion;
        private System.Windows.Forms.TextBox txt_nombreEvaluacion;
        private System.Windows.Forms.Label lbl_ejemploPorcentaje;
        private System.Windows.Forms.DateTimePicker dateTime_fechaEntrega;
        private System.Windows.Forms.Label lbl_fechaEntrega;
    }
}