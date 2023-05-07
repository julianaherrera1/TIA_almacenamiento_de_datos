namespace TIA_almacenamiento_de_datos
{
    partial class frm_archivo_txt
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_nombre_usuario = new System.Windows.Forms.TextBox();
            this.lbl_nombre_usuario = new System.Windows.Forms.Label();
            this.grp_info_usuario = new System.Windows.Forms.GroupBox();
            this.btn_guardar_datos = new System.Windows.Forms.Button();
            this.txt_edad_usuario = new System.Windows.Forms.TextBox();
            this.lbl_edad_usuario = new System.Windows.Forms.Label();
            this.txt_apellido_usuario = new System.Windows.Forms.TextBox();
            this.lbl_apellido_usuario = new System.Windows.Forms.Label();
            this.dgv_datos_usuario = new System.Windows.Forms.DataGridView();
            this.btn_cargar_archivo = new System.Windows.Forms.Button();
            this.btn_editar_datos = new System.Windows.Forms.Button();
            this.btn_borrar_datos = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cerrar_form = new System.Windows.Forms.Button();
            this.btn_minimizar_form = new System.Windows.Forms.Button();
            this.lbl_nombre_2 = new System.Windows.Forms.Label();
            this.lbl_apellido_2 = new System.Windows.Forms.Label();
            this.lbl_edad_2 = new System.Windows.Forms.Label();
            this.grp_info_usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.BackColor = System.Drawing.Color.Black;
            this.txt_nombre_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.txt_nombre_usuario.Location = new System.Drawing.Point(126, 56);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_usuario.TabIndex = 0;
            // 
            // lbl_nombre_usuario
            // 
            this.lbl_nombre_usuario.AutoSize = true;
            this.lbl_nombre_usuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_usuario.Location = new System.Drawing.Point(21, 71);
            this.lbl_nombre_usuario.Name = "lbl_nombre_usuario";
            this.lbl_nombre_usuario.Size = new System.Drawing.Size(89, 22);
            this.lbl_nombre_usuario.TabIndex = 1;
            this.lbl_nombre_usuario.Text = "Nombre:";
            // 
            // grp_info_usuario
            // 
            this.grp_info_usuario.Controls.Add(this.txt_edad_usuario);
            this.grp_info_usuario.Controls.Add(this.lbl_edad_2);
            this.grp_info_usuario.Controls.Add(this.txt_apellido_usuario);
            this.grp_info_usuario.Controls.Add(this.lbl_apellido_2);
            this.grp_info_usuario.Controls.Add(this.txt_nombre_usuario);
            this.grp_info_usuario.Controls.Add(this.lbl_nombre_2);
            this.grp_info_usuario.Controls.Add(this.btn_guardar_datos);
            this.grp_info_usuario.Controls.Add(this.lbl_edad_usuario);
            this.grp_info_usuario.Controls.Add(this.lbl_apellido_usuario);
            this.grp_info_usuario.Controls.Add(this.lbl_nombre_usuario);
            this.grp_info_usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_info_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.grp_info_usuario.Location = new System.Drawing.Point(24, 69);
            this.grp_info_usuario.Name = "grp_info_usuario";
            this.grp_info_usuario.Size = new System.Drawing.Size(318, 280);
            this.grp_info_usuario.TabIndex = 2;
            this.grp_info_usuario.TabStop = false;
            this.grp_info_usuario.Text = "Informacion del usuario";
            // 
            // btn_guardar_datos
            // 
            this.btn_guardar_datos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_guardar_datos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_guardar_datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_datos.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_datos.ForeColor = System.Drawing.Color.LightGray;
            this.btn_guardar_datos.Location = new System.Drawing.Point(190, 221);
            this.btn_guardar_datos.Name = "btn_guardar_datos";
            this.btn_guardar_datos.Size = new System.Drawing.Size(93, 36);
            this.btn_guardar_datos.TabIndex = 6;
            this.btn_guardar_datos.Text = "Guardar";
            this.btn_guardar_datos.UseVisualStyleBackColor = true;
            this.btn_guardar_datos.Click += new System.EventHandler(this.btn_guardar_datos_Click);
            // 
            // txt_edad_usuario
            // 
            this.txt_edad_usuario.BackColor = System.Drawing.Color.Black;
            this.txt_edad_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_edad_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edad_usuario.ForeColor = System.Drawing.Color.Silver;
            this.txt_edad_usuario.Location = new System.Drawing.Point(126, 156);
            this.txt_edad_usuario.Name = "txt_edad_usuario";
            this.txt_edad_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_edad_usuario.TabIndex = 5;
            // 
            // lbl_edad_usuario
            // 
            this.lbl_edad_usuario.AutoSize = true;
            this.lbl_edad_usuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edad_usuario.Location = new System.Drawing.Point(46, 169);
            this.lbl_edad_usuario.Name = "lbl_edad_usuario";
            this.lbl_edad_usuario.Size = new System.Drawing.Size(64, 22);
            this.lbl_edad_usuario.TabIndex = 4;
            this.lbl_edad_usuario.Text = "Edad:";
            // 
            // txt_apellido_usuario
            // 
            this.txt_apellido_usuario.BackColor = System.Drawing.Color.Black;
            this.txt_apellido_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellido_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.txt_apellido_usuario.Location = new System.Drawing.Point(126, 104);
            this.txt_apellido_usuario.Name = "txt_apellido_usuario";
            this.txt_apellido_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido_usuario.TabIndex = 3;
            // 
            // lbl_apellido_usuario
            // 
            this.lbl_apellido_usuario.AutoSize = true;
            this.lbl_apellido_usuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido_usuario.Location = new System.Drawing.Point(21, 118);
            this.lbl_apellido_usuario.Name = "lbl_apellido_usuario";
            this.lbl_apellido_usuario.Size = new System.Drawing.Size(89, 22);
            this.lbl_apellido_usuario.TabIndex = 2;
            this.lbl_apellido_usuario.Text = "Apellido:";
            // 
            // dgv_datos_usuario
            // 
            this.dgv_datos_usuario.AllowUserToAddRows = false;
            this.dgv_datos_usuario.AllowUserToDeleteRows = false;
            this.dgv_datos_usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos_usuario.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_datos_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_datos_usuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_datos_usuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_datos_usuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_datos_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos_usuario.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_datos_usuario.Location = new System.Drawing.Point(369, 69);
            this.dgv_datos_usuario.Name = "dgv_datos_usuario";
            this.dgv_datos_usuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_datos_usuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_datos_usuario.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_datos_usuario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_datos_usuario.Size = new System.Drawing.Size(366, 223);
            this.dgv_datos_usuario.TabIndex = 3;
            // 
            // btn_cargar_archivo
            // 
            this.btn_cargar_archivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cargar_archivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cargar_archivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargar_archivo.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar_archivo.ForeColor = System.Drawing.Color.LightGray;
            this.btn_cargar_archivo.Location = new System.Drawing.Point(642, 312);
            this.btn_cargar_archivo.Name = "btn_cargar_archivo";
            this.btn_cargar_archivo.Size = new System.Drawing.Size(93, 36);
            this.btn_cargar_archivo.TabIndex = 4;
            this.btn_cargar_archivo.Text = "Cargar";
            this.btn_cargar_archivo.UseVisualStyleBackColor = true;
            this.btn_cargar_archivo.Click += new System.EventHandler(this.btn_cargar_archivo_Click);
            // 
            // btn_editar_datos
            // 
            this.btn_editar_datos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_editar_datos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_editar_datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_datos.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_datos.ForeColor = System.Drawing.Color.LightGray;
            this.btn_editar_datos.Location = new System.Drawing.Point(534, 312);
            this.btn_editar_datos.Name = "btn_editar_datos";
            this.btn_editar_datos.Size = new System.Drawing.Size(93, 36);
            this.btn_editar_datos.TabIndex = 5;
            this.btn_editar_datos.Text = "Editar";
            this.btn_editar_datos.UseVisualStyleBackColor = true;
            this.btn_editar_datos.Click += new System.EventHandler(this.btn_editar_datos_Click);
            // 
            // btn_borrar_datos
            // 
            this.btn_borrar_datos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_borrar_datos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_borrar_datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar_datos.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar_datos.ForeColor = System.Drawing.Color.LightGray;
            this.btn_borrar_datos.Location = new System.Drawing.Point(415, 312);
            this.btn_borrar_datos.Name = "btn_borrar_datos";
            this.btn_borrar_datos.Size = new System.Drawing.Size(93, 36);
            this.btn_borrar_datos.TabIndex = 6;
            this.btn_borrar_datos.Text = "Eliminar";
            this.btn_borrar_datos.UseVisualStyleBackColor = true;
            this.btn_borrar_datos.Click += new System.EventHandler(this.btn_borrar_datos_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_minimizar_form);
            this.panel1.Controls.Add(this.btn_cerrar_form);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 41);
            this.panel1.TabIndex = 7;
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
            this.btn_cerrar_form.Click += new System.EventHandler(this.btn_cerrar_form_Click);
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
            this.btn_minimizar_form.Click += new System.EventHandler(this.btn_minimizar_form_Click);
            // 
            // lbl_nombre_2
            // 
            this.lbl_nombre_2.AutoSize = true;
            this.lbl_nombre_2.Location = new System.Drawing.Point(122, 73);
            this.lbl_nombre_2.Name = "lbl_nombre_2";
            this.lbl_nombre_2.Size = new System.Drawing.Size(161, 20);
            this.lbl_nombre_2.TabIndex = 7;
            this.lbl_nombre_2.Text = "___________________";
            // 
            // lbl_apellido_2
            // 
            this.lbl_apellido_2.AutoSize = true;
            this.lbl_apellido_2.Location = new System.Drawing.Point(122, 120);
            this.lbl_apellido_2.Name = "lbl_apellido_2";
            this.lbl_apellido_2.Size = new System.Drawing.Size(161, 20);
            this.lbl_apellido_2.TabIndex = 8;
            this.lbl_apellido_2.Text = "___________________";
            // 
            // lbl_edad_2
            // 
            this.lbl_edad_2.AutoSize = true;
            this.lbl_edad_2.Location = new System.Drawing.Point(122, 171);
            this.lbl_edad_2.Name = "lbl_edad_2";
            this.lbl_edad_2.Size = new System.Drawing.Size(161, 20);
            this.lbl_edad_2.TabIndex = 9;
            this.lbl_edad_2.Text = "___________________";
            // 
            // frm_archivo_txt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(764, 398);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_borrar_datos);
            this.Controls.Add(this.btn_editar_datos);
            this.Controls.Add(this.btn_cargar_archivo);
            this.Controls.Add(this.dgv_datos_usuario);
            this.Controls.Add(this.grp_info_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_archivo_txt";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_archivo_txt";
            this.grp_info_usuario.ResumeLayout(false);
            this.grp_info_usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre_usuario;
        private System.Windows.Forms.Label lbl_nombre_usuario;
        private System.Windows.Forms.GroupBox grp_info_usuario;
        private System.Windows.Forms.Button btn_guardar_datos;
        private System.Windows.Forms.TextBox txt_edad_usuario;
        private System.Windows.Forms.Label lbl_edad_usuario;
        private System.Windows.Forms.TextBox txt_apellido_usuario;
        private System.Windows.Forms.Label lbl_apellido_usuario;
        private System.Windows.Forms.DataGridView dgv_datos_usuario;
        private System.Windows.Forms.Button btn_cargar_archivo;
        private System.Windows.Forms.Button btn_editar_datos;
        private System.Windows.Forms.Button btn_borrar_datos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_edad_2;
        private System.Windows.Forms.Label lbl_apellido_2;
        private System.Windows.Forms.Label lbl_nombre_2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_minimizar_form;
        private System.Windows.Forms.Button btn_cerrar_form;
    }
}