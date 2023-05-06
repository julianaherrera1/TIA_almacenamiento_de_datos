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
            this.grp_info_usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.Location = new System.Drawing.Point(25, 63);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_usuario.TabIndex = 0;
            // 
            // lbl_nombre_usuario
            // 
            this.lbl_nombre_usuario.AutoSize = true;
            this.lbl_nombre_usuario.Location = new System.Drawing.Point(25, 32);
            this.lbl_nombre_usuario.Name = "lbl_nombre_usuario";
            this.lbl_nombre_usuario.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre_usuario.TabIndex = 1;
            this.lbl_nombre_usuario.Text = "Nombre:";
            // 
            // grp_info_usuario
            // 
            this.grp_info_usuario.Controls.Add(this.btn_guardar_datos);
            this.grp_info_usuario.Controls.Add(this.txt_edad_usuario);
            this.grp_info_usuario.Controls.Add(this.lbl_edad_usuario);
            this.grp_info_usuario.Controls.Add(this.txt_apellido_usuario);
            this.grp_info_usuario.Controls.Add(this.lbl_apellido_usuario);
            this.grp_info_usuario.Controls.Add(this.txt_nombre_usuario);
            this.grp_info_usuario.Controls.Add(this.lbl_nombre_usuario);
            this.grp_info_usuario.Location = new System.Drawing.Point(22, 24);
            this.grp_info_usuario.Name = "grp_info_usuario";
            this.grp_info_usuario.Size = new System.Drawing.Size(239, 252);
            this.grp_info_usuario.TabIndex = 2;
            this.grp_info_usuario.TabStop = false;
            this.grp_info_usuario.Text = "Informacion del usuario";
            // 
            // btn_guardar_datos
            // 
            this.btn_guardar_datos.Location = new System.Drawing.Point(139, 192);
            this.btn_guardar_datos.Name = "btn_guardar_datos";
            this.btn_guardar_datos.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar_datos.TabIndex = 6;
            this.btn_guardar_datos.Text = "Guardar";
            this.btn_guardar_datos.UseVisualStyleBackColor = true;
            this.btn_guardar_datos.Click += new System.EventHandler(this.btn_guardar_datos_Click);
            // 
            // txt_edad_usuario
            // 
            this.txt_edad_usuario.Location = new System.Drawing.Point(25, 168);
            this.txt_edad_usuario.Name = "txt_edad_usuario";
            this.txt_edad_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_edad_usuario.TabIndex = 5;
            // 
            // lbl_edad_usuario
            // 
            this.lbl_edad_usuario.AutoSize = true;
            this.lbl_edad_usuario.Location = new System.Drawing.Point(25, 142);
            this.lbl_edad_usuario.Name = "lbl_edad_usuario";
            this.lbl_edad_usuario.Size = new System.Drawing.Size(35, 13);
            this.lbl_edad_usuario.TabIndex = 4;
            this.lbl_edad_usuario.Text = "Edad:";
            // 
            // txt_apellido_usuario
            // 
            this.txt_apellido_usuario.Location = new System.Drawing.Point(25, 116);
            this.txt_apellido_usuario.Name = "txt_apellido_usuario";
            this.txt_apellido_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido_usuario.TabIndex = 3;
            // 
            // lbl_apellido_usuario
            // 
            this.lbl_apellido_usuario.AutoSize = true;
            this.lbl_apellido_usuario.Location = new System.Drawing.Point(25, 100);
            this.lbl_apellido_usuario.Name = "lbl_apellido_usuario";
            this.lbl_apellido_usuario.Size = new System.Drawing.Size(47, 13);
            this.lbl_apellido_usuario.TabIndex = 2;
            this.lbl_apellido_usuario.Text = "Apellido:";
            // 
            // dgv_datos_usuario
            // 
            this.dgv_datos_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos_usuario.Location = new System.Drawing.Point(290, 56);
            this.dgv_datos_usuario.Name = "dgv_datos_usuario";
            this.dgv_datos_usuario.Size = new System.Drawing.Size(240, 150);
            this.dgv_datos_usuario.TabIndex = 3;
            // 
            // btn_cargar_archivo
            // 
            this.btn_cargar_archivo.Location = new System.Drawing.Point(455, 216);
            this.btn_cargar_archivo.Name = "btn_cargar_archivo";
            this.btn_cargar_archivo.Size = new System.Drawing.Size(75, 23);
            this.btn_cargar_archivo.TabIndex = 4;
            this.btn_cargar_archivo.Text = "Cargar";
            this.btn_cargar_archivo.UseVisualStyleBackColor = true;
            this.btn_cargar_archivo.Click += new System.EventHandler(this.btn_cargar_archivo_Click);
            // 
            // btn_editar_datos
            // 
            this.btn_editar_datos.Location = new System.Drawing.Point(307, 215);
            this.btn_editar_datos.Name = "btn_editar_datos";
            this.btn_editar_datos.Size = new System.Drawing.Size(75, 23);
            this.btn_editar_datos.TabIndex = 5;
            this.btn_editar_datos.Text = "Editar";
            this.btn_editar_datos.UseVisualStyleBackColor = true;
            this.btn_editar_datos.Click += new System.EventHandler(this.btn_editar_datos_Click);
            // 
            // btn_borrar_datos
            // 
            this.btn_borrar_datos.Location = new System.Drawing.Point(307, 253);
            this.btn_borrar_datos.Name = "btn_borrar_datos";
            this.btn_borrar_datos.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar_datos.TabIndex = 6;
            this.btn_borrar_datos.Text = "Eliminar";
            this.btn_borrar_datos.UseVisualStyleBackColor = true;
            this.btn_borrar_datos.Click += new System.EventHandler(this.btn_borrar_datos_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_archivo_txt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 333);
            this.Controls.Add(this.btn_borrar_datos);
            this.Controls.Add(this.btn_editar_datos);
            this.Controls.Add(this.btn_cargar_archivo);
            this.Controls.Add(this.dgv_datos_usuario);
            this.Controls.Add(this.grp_info_usuario);
            this.Name = "frm_archivo_txt";
            this.Text = "frm_archivo_txt";
            this.grp_info_usuario.ResumeLayout(false);
            this.grp_info_usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
    }
}