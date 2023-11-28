namespace EZUni
{
    partial class Form_menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_menu));
            this.lbl_xSalir = new System.Windows.Forms.Label();
            this.listbox_asignaciones = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_cursos = new System.Windows.Forms.DataGridView();
            this.lbl_agregarAsignacion = new System.Windows.Forms.Label();
            this.lbl_quitarAsignacion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_actualizarLista = new System.Windows.Forms.Label();
            this.btn_calendario = new System.Windows.Forms.Button();
            this.btn_material = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_opciones = new System.Windows.Forms.Button();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_calcularNota = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_actualizarGrid = new System.Windows.Forms.Label();
            this.lbl_agregarCurso = new System.Windows.Forms.Label();
            this.lbl_quitarCurso = new System.Windows.Forms.Label();
            this.combo_curso = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cursos)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_xSalir
            // 
            this.lbl_xSalir.AutoSize = true;
            this.lbl_xSalir.Location = new System.Drawing.Point(870, 9);
            this.lbl_xSalir.Name = "lbl_xSalir";
            this.lbl_xSalir.Size = new System.Drawing.Size(18, 21);
            this.lbl_xSalir.TabIndex = 1;
            this.lbl_xSalir.Text = "x";
            this.lbl_xSalir.Click += new System.EventHandler(this.lbl_xSalir_Click);
            // 
            // listbox_asignaciones
            // 
            this.listbox_asignaciones.AccessibleName = "asignaciones_listbox";
            this.listbox_asignaciones.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listbox_asignaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listbox_asignaciones.ForeColor = System.Drawing.Color.White;
            this.listbox_asignaciones.FormattingEnabled = true;
            this.listbox_asignaciones.ItemHeight = 21;
            this.listbox_asignaciones.Location = new System.Drawing.Point(687, 184);
            this.listbox_asignaciones.Name = "listbox_asignaciones";
            this.listbox_asignaciones.Size = new System.Drawing.Size(176, 378);
            this.listbox_asignaciones.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(37, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 32);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cursos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignaciones";
            // 
            // dg_cursos
            // 
            this.dg_cursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_cursos.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dg_cursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_cursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_cursos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_cursos.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dg_cursos.Location = new System.Drawing.Point(37, 142);
            this.dg_cursos.Name = "dg_cursos";
            this.dg_cursos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_cursos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_cursos.RowHeadersVisible = false;
            this.dg_cursos.Size = new System.Drawing.Size(621, 420);
            this.dg_cursos.TabIndex = 11;
            // 
            // lbl_agregarAsignacion
            // 
            this.lbl_agregarAsignacion.AutoSize = true;
            this.lbl_agregarAsignacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_agregarAsignacion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agregarAsignacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_agregarAsignacion.Location = new System.Drawing.Point(155, -3);
            this.lbl_agregarAsignacion.Name = "lbl_agregarAsignacion";
            this.lbl_agregarAsignacion.Size = new System.Drawing.Size(21, 24);
            this.lbl_agregarAsignacion.TabIndex = 12;
            this.lbl_agregarAsignacion.Text = "+";
            this.lbl_agregarAsignacion.Click += new System.EventHandler(this.lbl_agregarAsignacion_Click);
            // 
            // lbl_quitarAsignacion
            // 
            this.lbl_quitarAsignacion.AutoSize = true;
            this.lbl_quitarAsignacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_quitarAsignacion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quitarAsignacion.Location = new System.Drawing.Point(132, -5);
            this.lbl_quitarAsignacion.Name = "lbl_quitarAsignacion";
            this.lbl_quitarAsignacion.Size = new System.Drawing.Size(17, 24);
            this.lbl_quitarAsignacion.TabIndex = 13;
            this.lbl_quitarAsignacion.Text = "-";
            this.lbl_quitarAsignacion.Click += new System.EventHandler(this.lbl_quitarAsignacion_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.lbl_actualizarLista);
            this.panel2.Controls.Add(this.lbl_agregarAsignacion);
            this.panel2.Controls.Add(this.lbl_quitarAsignacion);
            this.panel2.Location = new System.Drawing.Point(687, 566);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 19);
            this.panel2.TabIndex = 14;
            // 
            // lbl_actualizarLista
            // 
            this.lbl_actualizarLista.AutoSize = true;
            this.lbl_actualizarLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_actualizarLista.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actualizarLista.Location = new System.Drawing.Point(1, -1);
            this.lbl_actualizarLista.Name = "lbl_actualizarLista";
            this.lbl_actualizarLista.Size = new System.Drawing.Size(98, 20);
            this.lbl_actualizarLista.TabIndex = 15;
            this.lbl_actualizarLista.Text = "Actualizar ⟳";
            this.lbl_actualizarLista.Click += new System.EventHandler(this.lbl_actualizarLista_Click);
            // 
            // btn_calendario
            // 
            this.btn_calendario.BackColor = System.Drawing.Color.Transparent;
            this.btn_calendario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_calendario.FlatAppearance.BorderSize = 0;
            this.btn_calendario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_calendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calendario.Location = new System.Drawing.Point(313, 3);
            this.btn_calendario.Name = "btn_calendario";
            this.btn_calendario.Size = new System.Drawing.Size(136, 44);
            this.btn_calendario.TabIndex = 9;
            this.btn_calendario.Text = "Calendario 📅";
            this.btn_calendario.UseVisualStyleBackColor = false;
            // 
            // btn_material
            // 
            this.btn_material.BackColor = System.Drawing.Color.Transparent;
            this.btn_material.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_material.FlatAppearance.BorderSize = 0;
            this.btn_material.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_material.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_material.Location = new System.Drawing.Point(197, 3);
            this.btn_material.Name = "btn_material";
            this.btn_material.Size = new System.Drawing.Size(110, 44);
            this.btn_material.TabIndex = 8;
            this.btn_material.Text = "Material 📖";
            this.btn_material.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Transparent;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Location = new System.Drawing.Point(81, 3);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(110, 44);
            this.btn_editar.TabIndex = 6;
            this.btn_editar.Text = "Editar ✏️";
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_opciones
            // 
            this.btn_opciones.BackColor = System.Drawing.Color.Transparent;
            this.btn_opciones.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_opciones.FlatAppearance.BorderSize = 0;
            this.btn_opciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_opciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_opciones.Location = new System.Drawing.Point(686, 3);
            this.btn_opciones.Name = "btn_opciones";
            this.btn_opciones.Size = new System.Drawing.Size(135, 44);
            this.btn_opciones.TabIndex = 15;
            this.btn_opciones.Text = "Opciones ⚙︎";
            this.btn_opciones.UseVisualStyleBackColor = false;
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnl_menu.Controls.Add(this.btn_calcularNota);
            this.pnl_menu.Controls.Add(this.btn_editar);
            this.pnl_menu.Controls.Add(this.btn_opciones);
            this.pnl_menu.Controls.Add(this.btn_material);
            this.pnl_menu.Controls.Add(this.pictureBox1);
            this.pnl_menu.Controls.Add(this.btn_calendario);
            this.pnl_menu.Location = new System.Drawing.Point(37, 36);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(826, 50);
            this.pnl_menu.TabIndex = 16;
            // 
            // btn_calcularNota
            // 
            this.btn_calcularNota.BackColor = System.Drawing.Color.Transparent;
            this.btn_calcularNota.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_calcularNota.FlatAppearance.BorderSize = 0;
            this.btn_calcularNota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_calcularNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcularNota.Location = new System.Drawing.Point(455, 3);
            this.btn_calcularNota.Name = "btn_calcularNota";
            this.btn_calcularNota.Size = new System.Drawing.Size(166, 44);
            this.btn_calcularNota.TabIndex = 16;
            this.btn_calcularNota.Text = "Calcular Nota 💯";
            this.btn_calcularNota.UseVisualStyleBackColor = false;
            this.btn_calcularNota.Click += new System.EventHandler(this.btn_calcularNota_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "EZU_logo";
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::EZUni.Properties.Resources.EZU_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.Controls.Add(this.lbl_actualizarGrid);
            this.panel4.Controls.Add(this.lbl_agregarCurso);
            this.panel4.Controls.Add(this.lbl_quitarCurso);
            this.panel4.Location = new System.Drawing.Point(37, 566);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(621, 19);
            this.panel4.TabIndex = 15;
            // 
            // lbl_actualizarGrid
            // 
            this.lbl_actualizarGrid.AutoSize = true;
            this.lbl_actualizarGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_actualizarGrid.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actualizarGrid.Location = new System.Drawing.Point(2, -1);
            this.lbl_actualizarGrid.Name = "lbl_actualizarGrid";
            this.lbl_actualizarGrid.Size = new System.Drawing.Size(98, 20);
            this.lbl_actualizarGrid.TabIndex = 14;
            this.lbl_actualizarGrid.Text = "Actualizar ⟳";
            this.lbl_actualizarGrid.Click += new System.EventHandler(this.lbl_actualizarGrid_Click);
            // 
            // lbl_agregarCurso
            // 
            this.lbl_agregarCurso.AutoSize = true;
            this.lbl_agregarCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_agregarCurso.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agregarCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_agregarCurso.Location = new System.Drawing.Point(598, -3);
            this.lbl_agregarCurso.Name = "lbl_agregarCurso";
            this.lbl_agregarCurso.Size = new System.Drawing.Size(21, 24);
            this.lbl_agregarCurso.TabIndex = 12;
            this.lbl_agregarCurso.Text = "+";
            this.lbl_agregarCurso.Click += new System.EventHandler(this.lbl_agregarCurso_Click);
            // 
            // lbl_quitarCurso
            // 
            this.lbl_quitarCurso.AutoSize = true;
            this.lbl_quitarCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_quitarCurso.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quitarCurso.ForeColor = System.Drawing.Color.White;
            this.lbl_quitarCurso.Location = new System.Drawing.Point(575, -5);
            this.lbl_quitarCurso.Name = "lbl_quitarCurso";
            this.lbl_quitarCurso.Size = new System.Drawing.Size(17, 24);
            this.lbl_quitarCurso.TabIndex = 13;
            this.lbl_quitarCurso.Text = "-";
            this.lbl_quitarCurso.Click += new System.EventHandler(this.lbl_quitarCurso_Click);
            // 
            // combo_curso
            // 
            this.combo_curso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.combo_curso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_curso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_curso.ForeColor = System.Drawing.Color.White;
            this.combo_curso.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.combo_curso.Location = new System.Drawing.Point(687, 142);
            this.combo_curso.Name = "combo_curso";
            this.combo_curso.Size = new System.Drawing.Size(176, 29);
            this.combo_curso.TabIndex = 22;
            this.combo_curso.SelectionChangeCommitted += new System.EventHandler(this.combo_curso_SelectedIndexChanged);
            // 
            // Form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.ControlBox = false;
            this.Controls.Add(this.combo_curso);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dg_cursos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listbox_asignaciones);
            this.Controls.Add(this.lbl_xSalir);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cursos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_xSalir;
        private System.Windows.Forms.ListBox listbox_asignaciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dg_cursos;
        private System.Windows.Forms.Label lbl_agregarAsignacion;
        private System.Windows.Forms.Label lbl_quitarAsignacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_calendario;
        private System.Windows.Forms.Button btn_material;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_opciones;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_agregarCurso;
        private System.Windows.Forms.Label lbl_quitarCurso;
        private System.Windows.Forms.Button btn_calcularNota;
        private System.Windows.Forms.ComboBox combo_curso;
        private System.Windows.Forms.Label lbl_actualizarLista;
        private System.Windows.Forms.Label lbl_actualizarGrid;
    }
}