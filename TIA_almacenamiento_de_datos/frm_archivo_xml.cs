using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace TIA_almacenamiento_de_datos
{
    public partial class frm_archivo_xml : Form
    {
        /// <summary>
        /// Codigo de formulario de archivos XML
        /// </summary>
        public frm_archivo_xml()
        {
            InitializeComponent();
        }

        // variables globales
        List<Usuarios> datos = new List<Usuarios>();
        int id = 0;

        private void btn_crear_archivo_Click(object sender, EventArgs e)
        {
            /// VALIDAR CAMPOS NO ESTEN VACIOS, QUE LA EDAD SEA 
            /// UN NUMERO VALIDO Y NO HAYAN CARACTERES NO DESEADOS
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nombre_usuario.Text))
                {
                    errorProvider1.SetError(txt_nombre_usuario, "Debe ingresar el nombre");
                    txt_nombre_usuario.Focus();
                    return;
                }
                errorProvider1.SetError(txt_nombre_usuario, "");

                if (string.IsNullOrWhiteSpace(txt_apellido_usuario.Text))
                {
                    errorProvider1.SetError(txt_apellido_usuario, "Debe ingresar el apellido");
                    txt_apellido_usuario.Focus();
                    return;
                }
                errorProvider1.SetError(txt_apellido_usuario, "");

                if (string.IsNullOrWhiteSpace(txt_edad_usuario.Text))
                {
                    errorProvider1.SetError(txt_edad_usuario, "Debe ingresar la edad");
                    txt_edad_usuario.Focus();
                    return;
                }

                if (!int.TryParse(txt_edad_usuario.Text, out int edad) || edad <= 0)
                {
                    errorProvider1.SetError(txt_edad_usuario, "La edad debe ser un número válido");
                    txt_edad_usuario.Focus();
                    return;
                }
                errorProvider1.SetError(txt_edad_usuario, "");

                guardarArchivo();
                limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al agregar usuario " + ex.Message);
            }

        }

        // METODO LIMPIAR CAMPOS DE TEXTO 
        public void limpiar()
        {
            txt_nombre_usuario.Text = "";
            txt_apellido_usuario.Text = "";
            txt_edad_usuario.Text = "";
            txt_nombre_usuario.Focus();
        }

        // METODO GUARDAR ARCHIVOS XML
        public void guardarArchivo()
        {
            try
            {
                // Crear instancia con la clase 
                Usuarios usuario = new Usuarios();
                // Agregar los datos de los campos de texto 
                usuario.id_usuario = id + 1;
                id = usuario.id_usuario;
                usuario.nombre_usuario = txt_nombre_usuario.Text;
                usuario.apellido_usuario = txt_apellido_usuario.Text;
                usuario.edad_usuario = Convert.ToInt32(txt_edad_usuario.Text);

                // agregar a la lista 
                datos.Add(usuario);

                XmlSerializer serializer = new XmlSerializer(typeof(List<Usuarios>));

                using (TextWriter escribir = new StreamWriter("Datos.xml"))
                {
                    serializer.Serialize(escribir, datos);
                }
                MessageBox.Show("Archivo XML creado correctamente");

            }
            catch(Exception ex)
            {
                MessageBox.Show(" Error al agregar usuario " + ex.Message);
            }
           

        }

        private void btn_cargar_archivo_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Usuarios>));
                List<Usuarios> user;
                using (TextReader reader = new StreamReader("Datos.xml"))
                {
                    user = (List<Usuarios>)serializer.Deserialize(reader);
                }
                dgv_datos_usuarios.DataSource = user;
                MessageBox.Show(" Archivo XML cargado correctamente ");

            }
            catch(Exception ex)
            {
                MessageBox.Show(" Error al cargar el archivo xml" + ex.Message);
            }
        }

        private void btn_eliminar_archivo_Click(object sender, EventArgs e)
        {
            string ruta = "Datos.xml";
            try
            {
                // Verificar si el archivo existe antes de eliminarlo
                if (File.Exists(ruta))
                {
                    // Eliminar el archivo
                    File.Delete(ruta);
                    MessageBox.Show("Archivo XML eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("El archivo XML no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el archivo XML: " + ex.Message);
            }
        }
    }
}
