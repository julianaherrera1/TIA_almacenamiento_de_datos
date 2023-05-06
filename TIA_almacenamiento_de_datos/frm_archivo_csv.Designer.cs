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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar_datos
            // 
            this.btn_guardar_datos.Location = new System.Drawing.Point(327, 20);
            this.btn_guardar_datos.Name = "btn_guardar_datos";
            this.btn_guardar_datos.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar_datos.TabIndex = 6;
            this.btn_guardar_datos.Text = "Guardar";
            this.btn_guardar_datos.UseVisualStyleBackColor = true;
            this.btn_guardar_datos.Click += new System.EventHandler(this.btn_guardar_datos_Click);
            // 
            // btn_borrar_datos
            // 
            this.btn_borrar_datos.Location = new System.Drawing.Point(420, 49);
            this.btn_borrar_datos.Name = "btn_borrar_datos";
            this.btn_borrar_datos.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar_datos.TabIndex = 10;
            this.btn_borrar_datos.Text = "Eliminar";
            this.btn_borrar_datos.UseVisualStyleBackColor = true;
            this.btn_borrar_datos.Click += new System.EventHandler(this.btn_borrar_datos_Click);
            // 
            // btn_editar_datos
            // 
            this.btn_editar_datos.Location = new System.Drawing.Point(420, 20);
            this.btn_editar_datos.Name = "btn_editar_datos";
            this.btn_editar_datos.Size = new System.Drawing.Size(75, 23);
            this.btn_editar_datos.TabIndex = 9;
            this.btn_editar_datos.Text = "Editar";
            this.btn_editar_datos.UseVisualStyleBackColor = true;
            // 
            // btn_cargar_archivo
            // 
            this.btn_cargar_archivo.Location = new System.Drawing.Point(350, 95);
            this.btn_cargar_archivo.Name = "btn_cargar_archivo";
            this.btn_cargar_archivo.Size = new System.Drawing.Size(75, 23);
            this.btn_cargar_archivo.TabIndex = 8;
            this.btn_cargar_archivo.Text = "Cargar";
            this.btn_cargar_archivo.UseVisualStyleBackColor = true;
            this.btn_cargar_archivo.Click += new System.EventHandler(this.btn_cargar_archivo_Click);
            // 
            // dgv_datos_usuario
            // 
            this.dgv_datos_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos_usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_nombre,
            this.column_apellido,
            this.colum_edad});
            this.dgv_datos_usuario.Location = new System.Drawing.Point(12, 20);
            this.dgv_datos_usuario.Name = "dgv_datos_usuario";
            this.dgv_datos_usuario.Size = new System.Drawing.Size(287, 153);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(350, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.Visible = false;
            // 
            // frm_archivo_csv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 300);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_guardar_datos);
            this.Controls.Add(this.btn_borrar_datos);
            this.Controls.Add(this.btn_editar_datos);
            this.Controls.Add(this.btn_cargar_archivo);
            this.Controls.Add(this.dgv_datos_usuario);
            this.Name = "frm_archivo_csv";
            this.Text = "frm_archivo_csv";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}