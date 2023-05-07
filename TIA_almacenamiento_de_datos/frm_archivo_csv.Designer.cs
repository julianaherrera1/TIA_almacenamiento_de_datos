namespace TIA_almacenamiento_de_datos
{
    partial class frm_archivo_csv
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_guardar_datos = new System.Windows.Forms.Button();
            this.btn_borrar_datos = new System.Windows.Forms.Button();
            this.btn_editar_datos = new System.Windows.Forms.Button();
            this.btn_cargar_archivo = new System.Windows.Forms.Button();
            this.dgv_datos_usuario = new System.Windows.Forms.DataGridView();
            this.column_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgv_mostrar_datos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_minimizar_form = new System.Windows.Forms.Button();
            this.btn_cerrar_form = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar_datos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_guardar_datos
            // 
            this.btn_guardar_datos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_guardar_datos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_guardar_datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_datos.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_datos.ForeColor = System.Drawing.Color.LightGray;
            this.btn_guardar_datos.Location = new System.Drawing.Point(14, 62);
            this.btn_guardar_datos.Name = "btn_guardar_datos";
            this.btn_guardar_datos.Size = new System.Drawing.Size(91, 32);
            this.btn_guardar_datos.TabIndex = 6;
            this.btn_guardar_datos.Text = "Guardar";
            this.btn_guardar_datos.UseVisualStyleBackColor = true;
            this.btn_guardar_datos.Click += new System.EventHandler(this.btn_guardar_datos_Click);
            // 
            // btn_borrar_datos
            // 
            this.btn_borrar_datos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_borrar_datos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_borrar_datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar_datos.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar_datos.ForeColor = System.Drawing.Color.LightGray;
            this.btn_borrar_datos.Location = new System.Drawing.Point(545, 60);
            this.btn_borrar_datos.Name = "btn_borrar_datos";
            this.btn_borrar_datos.Size = new System.Drawing.Size(91, 34);
            this.btn_borrar_datos.TabIndex = 10;
            this.btn_borrar_datos.Text = "Eliminar";
            this.btn_borrar_datos.UseVisualStyleBackColor = true;
            this.btn_borrar_datos.Click += new System.EventHandler(this.btn_borrar_datos_Click);
            // 
            // btn_editar_datos
            // 
            this.btn_editar_datos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_editar_datos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_editar_datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_datos.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_datos.ForeColor = System.Drawing.Color.LightGray;
            this.btn_editar_datos.Location = new System.Drawing.Point(454, 60);
            this.btn_editar_datos.Name = "btn_editar_datos";
            this.btn_editar_datos.Size = new System.Drawing.Size(85, 34);
            this.btn_editar_datos.TabIndex = 9;
            this.btn_editar_datos.Text = "Editar";
            this.btn_editar_datos.UseVisualStyleBackColor = true;
            this.btn_editar_datos.Click += new System.EventHandler(this.btn_editar_datos_Click);
            // 
            // btn_cargar_archivo
            // 
            this.btn_cargar_archivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cargar_archivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cargar_archivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargar_archivo.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar_archivo.ForeColor = System.Drawing.Color.LightGray;
            this.btn_cargar_archivo.Location = new System.Drawing.Point(353, 60);
            this.btn_cargar_archivo.Name = "btn_cargar_archivo";
            this.btn_cargar_archivo.Size = new System.Drawing.Size(95, 34);
            this.btn_cargar_archivo.TabIndex = 8;
            this.btn_cargar_archivo.Text = "Cargar";
            this.btn_cargar_archivo.UseVisualStyleBackColor = true;
            this.btn_cargar_archivo.Click += new System.EventHandler(this.btn_cargar_archivo_Click);
            // 
            // dgv_datos_usuario
            // 
            this.dgv_datos_usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos_usuario.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_datos_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_datos_usuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_datos_usuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_datos_usuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_datos_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos_usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_nombre,
            this.column_apellido,
            this.colum_edad});
            this.dgv_datos_usuario.Location = new System.Drawing.Point(14, 100);
            this.dgv_datos_usuario.Name = "dgv_datos_usuario";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_datos_usuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_datos_usuario.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_datos_usuario.Size = new System.Drawing.Size(311, 218);
            this.dgv_datos_usuario.TabIndex = 7;
            // 
            // column_nombre
            // 
            this.column_nombre.HeaderText = "Nombre";
            this.column_nombre.Name = "column_nombre";
            // 
            // column_apellido
            // 
            this.column_apellido.HeaderText = "Apellido";
            this.column_apellido.Name = "column_apellido";
            // 
            // colum_edad
            // 
            this.colum_edad.HeaderText = "Edad";
            this.colum_edad.Name = "colum_edad";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgv_mostrar_datos
            // 
            this.dgv_mostrar_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_mostrar_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_mostrar_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mostrar_datos.Location = new System.Drawing.Point(353, 100);
            this.dgv_mostrar_datos.Name = "dgv_mostrar_datos";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_mostrar_datos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_mostrar_datos.Size = new System.Drawing.Size(283, 218);
            this.dgv_mostrar_datos.TabIndex = 11;
            this.dgv_mostrar_datos.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_minimizar);
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Controls.Add(this.btn_minimizar_form);
            this.panel1.Controls.Add(this.btn_cerrar_form);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 41);
            this.panel1.TabIndex = 12;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_minimizar.Location = new System.Drawing.Point(582, 12);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(32, 24);
            this.btn_minimizar.TabIndex = 3;
            this.btn_minimizar.Text = "-";
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_cerrar.Location = new System.Drawing.Point(620, 12);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(32, 24);
            this.btn_cerrar.TabIndex = 2;
            this.btn_cerrar.Text = "X";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_minimizar_form
            // 
            this.btn_minimizar_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar_form.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizar_form.ForeColor = System.Drawing.Color.LightGray;
            this.btn_minimizar_form.Location = new System.Drawing.Point(683, 12);
            this.btn_minimizar_form.Name = "btn_minimizar_form";
            this.btn_minimizar_form.Size = new System.Drawing.Size(32, 24);
            this.btn_minimizar_form.TabIndex = 1;
            this.btn_minimizar_form.Text = "-";
            this.btn_minimizar_form.UseVisualStyleBackColor = true;
            // 
            // btn_cerrar_form
            // 
            this.btn_cerrar_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_form.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_form.ForeColor = System.Drawing.Color.LightGray;
            this.btn_cerrar_form.Location = new System.Drawing.Point(721, 12);
            this.btn_cerrar_form.Name = "btn_cerrar_form";
            this.btn_cerrar_form.Size = new System.Drawing.Size(32, 24);
            this.btn_cerrar_form.TabIndex = 0;
            this.btn_cerrar_form.Text = "X";
            this.btn_cerrar_form.UseVisualStyleBackColor = true;
            // 
            // frm_archivo_csv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(676, 349);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_mostrar_datos);
            this.Controls.Add(this.btn_guardar_datos);
            this.Controls.Add(this.btn_borrar_datos);
            this.Controls.Add(this.btn_editar_datos);
            this.Controls.Add(this.btn_cargar_archivo);
            this.Controls.Add(this.dgv_datos_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_archivo_csv";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_archivo_csv";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar_datos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_guardar_datos;
        private System.Windows.Forms.Button btn_borrar_datos;
        private System.Windows.Forms.Button btn_editar_datos;
        private System.Windows.Forms.Button btn_cargar_archivo;
        private System.Windows.Forms.DataGridView dgv_datos_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_edad;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgv_mostrar_datos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_minimizar_form;
        private System.Windows.Forms.Button btn_cerrar_form;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
    }
}