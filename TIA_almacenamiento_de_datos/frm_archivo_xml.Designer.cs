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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_datos_usuarios
            // 
            this.dgv_datos_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos_usuarios.Location = new System.Drawing.Point(24, 36);
            this.dgv_datos_usuarios.Name = "dgv_datos_usuarios";
            this.dgv_datos_usuarios.Size = new System.Drawing.Size(240, 150);
            this.dgv_datos_usuarios.TabIndex = 0;
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.Location = new System.Drawing.Point(312, 48);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_usuario.TabIndex = 1;
            // 
            // lbl_nombre_usuario
            // 
            this.lbl_nombre_usuario.AutoSize = true;
            this.lbl_nombre_usuario.Location = new System.Drawing.Point(309, 32);
            this.lbl_nombre_usuario.Name = "lbl_nombre_usuario";
            this.lbl_nombre_usuario.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre_usuario.TabIndex = 2;
            this.lbl_nombre_usuario.Text = "Nombre:";
            // 
            // lbl_apellido_usuario
            // 
            this.lbl_apellido_usuario.AutoSize = true;
            this.lbl_apellido_usuario.Location = new System.Drawing.Point(309, 94);
            this.lbl_apellido_usuario.Name = "lbl_apellido_usuario";
            this.lbl_apellido_usuario.Size = new System.Drawing.Size(47, 13);
            this.lbl_apellido_usuario.TabIndex = 3;
            this.lbl_apellido_usuario.Text = "Apellido:";
            // 
            // txt_apellido_usuario
            // 
            this.txt_apellido_usuario.Location = new System.Drawing.Point(312, 120);
            this.txt_apellido_usuario.Name = "txt_apellido_usuario";
            this.txt_apellido_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido_usuario.TabIndex = 4;
            // 
            // lbl_edad_usuario
            // 
            this.lbl_edad_usuario.AutoSize = true;
            this.lbl_edad_usuario.Location = new System.Drawing.Point(318, 157);
            this.lbl_edad_usuario.Name = "lbl_edad_usuario";
            this.lbl_edad_usuario.Size = new System.Drawing.Size(35, 13);
            this.lbl_edad_usuario.TabIndex = 5;
            this.lbl_edad_usuario.Text = "Edad:";
            // 
            // txt_edad_usuario
            // 
            this.txt_edad_usuario.Location = new System.Drawing.Point(312, 173);
            this.txt_edad_usuario.Name = "txt_edad_usuario";
            this.txt_edad_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_edad_usuario.TabIndex = 6;
            // 
            // btn_crear_archivo
            // 
            this.btn_crear_archivo.Location = new System.Drawing.Point(361, 248);
            this.btn_crear_archivo.Name = "btn_crear_archivo";
            this.btn_crear_archivo.Size = new System.Drawing.Size(75, 23);
            this.btn_crear_archivo.TabIndex = 7;
            this.btn_crear_archivo.Text = "Guardar";
            this.btn_crear_archivo.UseVisualStyleBackColor = true;
            this.btn_crear_archivo.Click += new System.EventHandler(this.btn_crear_archivo_Click);
            // 
            // btn_cargar_archivo
            // 
            this.btn_cargar_archivo.Location = new System.Drawing.Point(189, 206);
            this.btn_cargar_archivo.Name = "btn_cargar_archivo";
            this.btn_cargar_archivo.Size = new System.Drawing.Size(75, 23);
            this.btn_cargar_archivo.TabIndex = 8;
            this.btn_cargar_archivo.Text = "Cargar";
            this.btn_cargar_archivo.UseVisualStyleBackColor = true;
            this.btn_cargar_archivo.Click += new System.EventHandler(this.btn_cargar_archivo_Click);
            // 
            // btn_editar_archivo
            // 
            this.btn_editar_archivo.Location = new System.Drawing.Point(108, 206);
            this.btn_editar_archivo.Name = "btn_editar_archivo";
            this.btn_editar_archivo.Size = new System.Drawing.Size(75, 23);
            this.btn_editar_archivo.TabIndex = 9;
            this.btn_editar_archivo.Text = "Editar";
            this.btn_editar_archivo.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar_archivo
            // 
            this.btn_eliminar_archivo.Location = new System.Drawing.Point(27, 206);
            this.btn_eliminar_archivo.Name = "btn_eliminar_archivo";
            this.btn_eliminar_archivo.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar_archivo.TabIndex = 10;
            this.btn_eliminar_archivo.Text = "Eliminar";
            this.btn_eliminar_archivo.UseVisualStyleBackColor = true;
            this.btn_eliminar_archivo.Click += new System.EventHandler(this.btn_eliminar_archivo_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_archivo_xml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 313);
            this.Controls.Add(this.btn_eliminar_archivo);
            this.Controls.Add(this.btn_editar_archivo);
            this.Controls.Add(this.btn_cargar_archivo);
            this.Controls.Add(this.btn_crear_archivo);
            this.Controls.Add(this.txt_edad_usuario);
            this.Controls.Add(this.lbl_edad_usuario);
            this.Controls.Add(this.txt_apellido_usuario);
            this.Controls.Add(this.lbl_apellido_usuario);
            this.Controls.Add(this.lbl_nombre_usuario);
            this.Controls.Add(this.txt_nombre_usuario);
            this.Controls.Add(this.dgv_datos_usuarios);
            this.Name = "frm_archivo_xml";
            this.Text = "Archivos xml";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
    }
}