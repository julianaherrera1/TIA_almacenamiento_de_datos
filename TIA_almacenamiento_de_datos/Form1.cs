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
        public frm_elegir()
        {
            InitializeComponent();
        }

        
        private void btn_archivo_txt_Click(object sender, EventArgs e)
        {
            // abrir formularia de archivo de txt
           frm_archivo_txt frm = new frm_archivo_txt();
            frm.Show();
        }

        private void btn_archivo_xml_Click(object sender, EventArgs e)
        {
            // abrir formulario de archivo xml
            frm_archivo_xml frm = new frm_archivo_xml();
            frm.Show();
        }

        private void btn_archivo_csv_Click(object sender, EventArgs e)
        {
            // abrir formulario de archivo csv
            frm_archivo_csv frm = new frm_archivo_csv();
            frm.Show();
        }
    }
}
