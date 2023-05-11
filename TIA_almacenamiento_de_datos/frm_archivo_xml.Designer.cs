namespace TIA_almacenamiento_de_datos
{
    partial class frm_archivo_xml
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_datos_usuarios = new System.Windows.Forms.DataGridView();
            this.txt_nombre_usuario = new System.Windows.Forms.TextBox();
            this.lbl_nombre_usuario = new System.Windows.Forms.Label();
            this.lbl_apellido_usuario = new System.Windows.Forms.Label();
            this.txt_apellido_usuario = new System.Windows.Forms.TextBox();
            this.lbl_edad_usuario = new System.Windows.Forms.Label();
            this.txt_edad_usuario = new System.Windows.Forms.TextBox();
            this.btn_crear_archivo = new System.Windows.Forms.Button();
            this.btn_cargar_archivo = new System.Windows.Forms.Button();
            this.btn_editar_archivo = new System.Windows.Forms.Button();
            this.btn_eliminar_archivo = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimizar_form = new System.Windows.Forms.Button();
            this.btn_cerrar_form = new System.Windows.Forms.Button();
            this.lbl_nombre_2 = new System.Windows.Forms.Label();
            this.lbl_apellido_2 = new System.Windows.Forms.Label();
            this.lbl_edad_2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_datos_usuarios
            // 
            this.dgv_datos_usuarios.AllowUserToAddRows = false;
            this.dgv_datos_usuarios.AllowUserToDeleteRows = false;
            this.dgv_datos_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_datos_usuarios.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_datos_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_datos_usuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_datos_usuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_datos_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_datos_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos_usuarios.Location = new System.Drawing.Point(12, 57);
            this.dgv_datos_usuarios.Name = "dgv_datos_usuarios";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_datos_usuarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_datos_usuarios.Size = new System.Drawing.Size(322, 205);
            this.dgv_datos_usuarios.TabIndex = 0;
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.BackColor = System.Drawing.Color.Black;
            this.txt_nombre_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre_usuario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.txt_nombre_usuario.Location = new System.Drawing.Point(438, 91);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(100, 26);
            this.txt_nombre_usuario.TabIndex = 1;
            // 
            // lbl_nombre_usuario
            // 
            this.lbl_nombre_usuario.AutoSize = true;
            this.lbl_nombre_usuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_nombre_usuario.Location = new System.Drawing.Point(340, 105);
            this.lbl_nombre_usuario.Name = "lbl_nombre_usuario";
            this.lbl_nombre_usuario.Size = new System.Drawing.Size(89, 22);
            this.lbl_nombre_usuario.TabIndex = 2;
            this.lbl_nombre_usuario.Text = "Nombre:";
            // 
            // lbl_apellido_usuario
            // 
            this.lbl_apellido_usuario.AutoSize = true;
            this.lbl_apellido_usuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_apellido_usuario.Location = new System.Drawing.Point(340, 157);
            this.lbl_apellido_usuario.Name = "lbl_apellido_usuario";
            this.lbl_apellido_usuario.Size = new System.Drawing.Size(89, 22);
            this.lbl_apellido_usuario.TabIndex = 3;
            this.lbl_apellido_usuario.Text = "Apellido:";
            // 
            // txt_apellido_usuario
            // 
            this.txt_apellido_usuario.BackColor = System.Drawing.Color.Black;
            this.txt_apellido_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellido_usuario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.txt_apellido_usuario.Location = new System.Drawing.Point(438, 145);
            this.txt_apellido_usuario.Name = "txt_apellido_usuario";
            this.txt_apellido_usuario.Size = new System.Drawing.Size(100, 26);
            this.txt_apellido_usuario.TabIndex = 4;
            // 
            // lbl_edad_usuario
            // 
            this.lbl_edad_usuario.AutoSize = true;
            this.lbl_edad_usuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edad_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_edad_usuario.Location = new System.Drawing.Point(365, 200);
            this.lbl_edad_usuario.Name = "lbl_edad_usuario";
            this.lbl_edad_usuario.Size = new System.Drawing.Size(64, 22);
            this.lbl_edad_usuario.TabIndex = 5;
            this.lbl_edad_usuario.Text = "Edad:";
            // 
            // txt_edad_usuario
            // 
            this.txt_edad_usuario.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_edad_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_edad_usuario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edad_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.txt_edad_usuario.Location = new System.Drawing.Point(438, 200);
            this.txt_edad_usuario.Name = "txt_edad_usuario";
            this.txt_edad_usuario.Size = new System.Drawing.Size(100, 26);
            this.txt_edad_usuario.TabIndex = 6;
            // 
            // btn_crear_archivo
            // 
            this.btn_crear_archivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_crear_archivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_crear_archivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear_archivo.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear_archivo.ForeColor = System.Drawing.Color.LightGray;
            this.btn_crear_archivo.Location = new System.Drawing.Point(539, 258);
            this.btn_crear_archivo.Name = "btn_crear_archivo";
            this.btn_crear_archivo.Size = new System.Drawing.Size(77, 31);
            this.btn_crear_archivo.TabIndex = 7;
            this.btn_crear_archivo.Text = "Guardar";
            this.btn_crear_archivo.UseVisualStyleBackColor = true;
            this.btn_crear_archivo.Click += new System.EventHandler(this.btn_crear_archivo_Click);
            // 
            // btn_cargar_archivo
            // 
            this.btn_cargar_archivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cargar_archivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cargar_archivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargar_archivo.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar_archivo.ForeColor = System.Drawing.Color.LightGray;
            this.btn_cargar_archivo.Location = new System.Drawing.Point(26, 280);
            this.btn_cargar_archivo.Name = "btn_cargar_archivo";
            this.btn_cargar_archivo.Size = new System.Drawing.Size(77, 31);
            this.btn_cargar_archivo.TabIndex = 8;
            this.btn_cargar_archivo.Text = "Cargar";
            this.btn_cargar_archivo.UseVisualStyleBackColor = true;
            this.btn_cargar_archivo.Click += new System.EventHandler(this.btn_cargar_archivo_Click);
            // 
            // btn_editar_archivo
            // 
            this.btn_editar_archivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_editar_archivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_editar_archivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_archivo.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_archivo.ForeColor = System.Drawing.Color.LightGray;
            this.btn_editar_archivo.Location = new System.Drawing.Point(126, 280);
            this.btn_editar_archivo.Name = "btn_editar_archivo";
            this.btn_editar_archivo.Size = new System.Drawing.Size(77, 31);
            this.btn_editar_archivo.TabIndex = 9;
            this.btn_editar_archivo.Text = "Editar";
            this.btn_editar_archivo.UseVisualStyleBackColor = true;
            this.btn_editar_archivo.Click += new System.EventHandler(this.btn_editar_archivo_Click);
            // 
            // btn_eliminar_archivo
            // 
            this.btn_eliminar_archivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_eliminar_archivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_eliminar_archivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_archivo.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_archivo.ForeColor = System.Drawing.Color.LightGray;
            this.btn_eliminar_archivo.Location = new System.Drawing.Point(225, 280);
            this.btn_eliminar_archivo.Name = "btn_eliminar_archivo";
            this.btn_eliminar_archivo.Size = new System.Drawing.Size(77, 31);
            this.btn_eliminar_archivo.TabIndex = 10;
            this.btn_eliminar_archivo.Text = "Eliminar";
            this.btn_eliminar_archivo.UseVisualStyleBackColor = true;
            this.btn_eliminar_archivo.Click += new System.EventHandler(this.btn_eliminar_archivo_Click);
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
            this.panel1.Size = new System.Drawing.Size(628, 41);
            this.panel1.TabIndex = 11;
            // 
            // btn_minimizar_form
            // 
            this.btn_minimizar_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar_form.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizar_form.ForeColor = System.Drawing.Color.LightGray;
            this.btn_minimizar_form.Location = new System.Drawing.Point(507, 12);
            this.btn_minimizar_form.Name = "btn_minimizar_form";
            this.btn_minimizar_form.Size = new System.Drawing.Size(32, 24);
            this.btn_minimizar_form.TabIndex = 3;
            this.btn_minimizar_form.Text = "-";
            this.btn_minimizar_form.UseVisualStyleBackColor = true;
            this.btn_minimizar_form.Click += new System.EventHandler(this.btn_minimizar_form_Click);
            // 
            // btn_cerrar_form
            // 
            this.btn_cerrar_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_form.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_form.ForeColor = System.Drawing.Color.LightGray;
            this.btn_cerrar_form.Location = new System.Drawing.Point(545, 12);
            this.btn_cerrar_form.Name = "btn_cerrar_form";
            this.btn_cerrar_form.Size = new System.Drawing.Size(32, 24);
            this.btn_cerrar_form.TabIndex = 2;
            this.btn_cerrar_form.Text = "X";
            this.btn_cerrar_form.UseVisualStyleBackColor = true;
            this.btn_cerrar_form.Click += new System.EventHandler(this.btn_cerrar_form_Click);
            // 
            // lbl_nombre_2
            // 
            this.lbl_nombre_2.AutoSize = true;
            this.lbl_nombre_2.Location = new System.Drawing.Point(435, 114);
            this.lbl_nombre_2.Name = "lbl_nombre_2";
            this.lbl_nombre_2.Size = new System.Drawing.Size(181, 13);
            this.lbl_nombre_2.TabIndex = 12;
            this.lbl_nombre_2.Text = "_____________________________";
            // 
            // lbl_apellido_2
            // 
            this.lbl_apellido_2.AutoSize = true;
            this.lbl_apellido_2.Location = new System.Drawing.Point(435, 168);
            this.lbl_apellido_2.Name = "lbl_apellido_2";
            this.lbl_apellido_2.Size = new System.Drawing.Size(181, 13);
            this.lbl_apellido_2.TabIndex = 13;
            this.lbl_apellido_2.Text = "_____________________________";
            // 
            // lbl_edad_2
            // 
            this.lbl_edad_2.AutoSize = true;
            this.lbl_edad_2.Location = new System.Drawing.Point(435, 227);
            this.lbl_edad_2.Name = "lbl_edad_2";
            this.lbl_edad_2.Size = new System.Drawing.Size(181, 13);
            this.lbl_edad_2.TabIndex = 14;
            this.lbl_edad_2.Text = "_____________________________";
            // 
            // frm_archivo_xml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(628, 350);
            this.Controls.Add(this.lbl_edad_2);
            this.Controls.Add(this.txt_apellido_usuario);
            this.Controls.Add(this.lbl_apellido_2);
            this.Controls.Add(this.txt_nombre_usuario);
            this.Controls.Add(this.lbl_nombre_2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_eliminar_archivo);
            this.Controls.Add(this.btn_editar_archivo);
            this.Controls.Add(this.btn_cargar_archivo);
            this.Controls.Add(this.btn_crear_archivo);
            this.Controls.Add(this.txt_edad_usuario);
            this.Controls.Add(this.lbl_edad_usuario);
            this.Controls.Add(this.lbl_apellido_usuario);
            this.Controls.Add(this.lbl_nombre_usuario);
            this.Controls.Add(this.dgv_datos_usuarios);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_archivo_xml";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archivos xml";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_datos_usuarios;
        private System.Windows.Forms.TextBox txt_nombre_usuario;
        private System.Windows.Forms.Label lbl_nombre_usuario;
        private System.Windows.Forms.Label lbl_apellido_usuario;
        private System.Windows.Forms.TextBox txt_apellido_usuario;
        private System.Windows.Forms.Label lbl_edad_usuario;
        private System.Windows.Forms.TextBox txt_edad_usuario;
        private System.Windows.Forms.Button btn_crear_archivo;
        private System.Windows.Forms.Button btn_cargar_archivo;
        private System.Windows.Forms.Button btn_editar_archivo;
        private System.Windows.Forms.Button btn_eliminar_archivo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_minimizar_form;
        private System.Windows.Forms.Button btn_cerrar_form;
        private System.Windows.Forms.Label lbl_nombre_2;
        private System.Windows.Forms.Label lbl_edad_2;
        private System.Windows.Forms.Label lbl_apellido_2;
    }
}