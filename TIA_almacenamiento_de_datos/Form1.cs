using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIA_almacenamiento_de_datos
{
    public partial class frm_elegir : Form
    {

        /// <summary>
        /// Formulario de entrada 
        /// Se elige que formulario se quiere abrir 
        /// </summary>
        public frm_elegir()
        {
            InitializeComponent();
        }

        private void btn_cerrar_form_Click(object sender, EventArgs e)
        {
            // Cerrar formulario
            this.Close();
        }
        private void btn_minimizar_form_Click(object sender, EventArgs e)
        {
            // Minimizar formulario
            this.WindowState = FormWindowState.Minimized;
        }


        private void btn_archivo_txt_Click(object sender, EventArgs e)
        {
            // abrir formularia de archivo de TXT
           frm_archivo_txt frm = new frm_archivo_txt();
            frm.Show();
        }

        private void btn_archivo_xml_Click(object sender, EventArgs e)
        {
            // abrir formulario de archivo XML
            frm_archivo_xml frm = new frm_archivo_xml();
            frm.Show();
        }

        private void btn_archivo_csv_Click(object sender, EventArgs e)
        {
            // abrir formulario de archivo CSV
            frm_archivo_csv frm = new frm_archivo_csv();
            frm.Show();
        }

        private void btn_archivo_rtf_Click(object sender, EventArgs e)
        {
            // abrir formularioa de archivo RTF
            frm_archivo_rtf frm = new frm_archivo_rtf();
            frm.Show();
        }

       
    }
}
