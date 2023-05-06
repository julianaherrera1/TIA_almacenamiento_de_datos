namespace TIA_almacenamiento_de_datos
{
    partial class frm_elegir
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_archivo_txt = new System.Windows.Forms.Button();
            this.btn_archivo_csv = new System.Windows.Forms.Button();
            this.btn_archivo_xml = new System.Windows.Forms.Button();
            this.btn_archivo_rtf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_archivo_txt
            // 
            this.btn_archivo_txt.Location = new System.Drawing.Point(61, 53);
            this.btn_archivo_txt.Name = "btn_archivo_txt";
            this.btn_archivo_txt.Size = new System.Drawing.Size(75, 23);
            this.btn_archivo_txt.TabIndex = 0;
            this.btn_archivo_txt.Text = "Archivo txt";
            this.btn_archivo_txt.UseVisualStyleBackColor = true;
            this.btn_archivo_txt.Click += new System.EventHandler(this.btn_archivo_txt_Click);
            // 
            // btn_archivo_csv
            // 
            this.btn_archivo_csv.Location = new System.Drawing.Point(61, 111);
            this.btn_archivo_csv.Name = "btn_archivo_csv";
            this.btn_archivo_csv.Size = new System.Drawing.Size(75, 23);
            this.btn_archivo_csv.TabIndex = 1;
            this.btn_archivo_csv.Text = "Archivo csv";
            this.btn_archivo_csv.UseVisualStyleBackColor = true;
            this.btn_archivo_csv.Click += new System.EventHandler(this.btn_archivo_csv_Click);
            // 
            // btn_archivo_xml
            // 
            this.btn_archivo_xml.Location = new System.Drawing.Point(61, 82);
            this.btn_archivo_xml.Name = "btn_archivo_xml";
            this.btn_archivo_xml.Size = new System.Drawing.Size(75, 23);
            this.btn_archivo_xml.TabIndex = 2;
            this.btn_archivo_xml.Text = "Archivo xml";
            this.btn_archivo_xml.UseVisualStyleBackColor = true;
            this.btn_archivo_xml.Click += new System.EventHandler(this.btn_archivo_xml_Click);
            // 
            // btn_archivo_rtf
            // 
            this.btn_archivo_rtf.Location = new System.Drawing.Point(61, 140);
            this.btn_archivo_rtf.Name = "btn_archivo_rtf";
            this.btn_archivo_rtf.Size = new System.Drawing.Size(75, 23);
            this.btn_archivo_rtf.TabIndex = 3;
            this.btn_archivo_rtf.Text = "Archivo rtf";
            this.btn_archivo_rtf.UseVisualStyleBackColor = true;
            // 
            // frm_elegir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 226);
            this.Controls.Add(this.btn_archivo_rtf);
            this.Controls.Add(this.btn_archivo_xml);
            this.Controls.Add(this.btn_archivo_csv);
            this.Controls.Add(this.btn_archivo_txt);
            this.Name = "frm_elegir";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_archivo_txt;
        private System.Windows.Forms.Button btn_archivo_csv;
        private System.Windows.Forms.Button btn_archivo_xml;
        private System.Windows.Forms.Button btn_archivo_rtf;
    }
}

