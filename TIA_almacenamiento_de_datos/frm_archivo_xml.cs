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
using System.Xml;

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

       

        private void btn_cargar_archivo_Click(object sender, EventArgs e)
        {
            /*try
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
            }*/
           
           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                XmlSerializer serializer = new XmlSerializer(typeof(List<Usuarios>));
                List<Usuarios> user;

                try
                {
                    using (XmlReader reader = XmlReader.Create(filePath))
                    {
                        user = (List<Usuarios>)serializer.Deserialize(reader);
                    }

                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Id");
                    dataTable.Columns.Add("Nombre");
                    dataTable.Columns.Add("Apellido");
                    dataTable.Columns.Add("Edad");

                    foreach (Usuarios usuario in user)
                    {
                        dataTable.Rows.Add(usuario.id_usuario, usuario.nombre_usuario, usuario.apellido_usuario, usuario.edad_usuario);
                    }

                    // Asignar el DataTable al origen de datos del DataGridView
                    dgv_datos_usuarios.DataSource = dataTable;

                    MessageBox.Show("Archivo XML leído correctamente y mostrado en el DataGridView.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo XML: " + ex.Message);
                }
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

        /// <summary>
        /// metodos:
        /// </summary>

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
            catch (Exception ex)
            {
                MessageBox.Show(" Error al agregar usuario " + ex.Message);
            }


        }

        private void btn_editar_archivo_Click(object sender, EventArgs e)
        {


            /* SaveFileDialog saveFileDialog = new SaveFileDialog();
             saveFileDialog.Filter = "Archivos XML (*.xml)|*.xml";

             if (saveFileDialog.ShowDialog() == DialogResult.OK)
             {
                 try
                 {
                     // Crear un nuevo DataSet
                     DataSet dataSet = new DataSet();

                     // Crear una tabla en el DataSet con las columnas correspondientes
                     DataTable dataTable = new DataTable("Datos");
                     foreach (DataGridViewColumn column in dgv_datos_usuarios.Columns)
                     {
                         dataTable.Columns.Add(column.Name);
                     }

                     // Recorrer las filas del DataGridView y agregarlas a la tabla del DataSet
                     foreach (DataGridViewRow row in dgv_datos_usuarios.Rows)
                     {
                         DataRow dataRow = dataTable.NewRow();
                         foreach (DataGridViewCell cell in row.Cells)
                         {
                             dataRow[cell.ColumnIndex] = cell.Value;
                         }
                         dataTable.Rows.Add(dataRow);
                     }

                     // Agregar la tabla al DataSet
                     dataSet.Tables.Add(dataTable);

                     // Leer los datos existentes del archivo XML si existe
                     if (File.Exists(saveFileDialog.FileName))
                     {
                         dataSet.ReadXml(saveFileDialog.FileName);
                     }

                     // Guardar el DataSet en un archivo XML
                     dataSet.WriteXml(saveFileDialog.FileName);

                     MessageBox.Show("Datos guardados correctamente en el archivo XML.");
                 }
                 catch (InvalidOperationException ex)
                 {
                     MessageBox.Show("Error de deserialización XML: " + ex.Message);
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                 }

             }*/
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos XML (*.xml)|*.xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Crear un nuevo DataSet
                    DataSet dataSet = new DataSet();

                    // Crear una tabla en el DataSet con las columnas correspondientes
                    DataTable dataTable = new DataTable("Datos");
                    foreach (DataGridViewColumn column in dgv_datos_usuarios.Columns)
                    {
                        dataTable.Columns.Add(column.Name);
                    }

                    // Recorrer las filas del DataGridView y agregarlas a la tabla del DataSet
                    foreach (DataGridViewRow row in dgv_datos_usuarios.Rows)
                    {
                        DataRow dataRow = dataTable.NewRow();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            dataRow[cell.ColumnIndex] = cell.Value;
                        }
                        dataTable.Rows.Add(dataRow);
                    }

                    // Agregar la tabla al DataSet
                    dataSet.Tables.Add(dataTable);

                    // Guardar el DataSet en un archivo XML
                    dataSet.WriteXml(saveFileDialog.FileName, XmlWriteMode.WriteSchema);

                    MessageBox.Show("Datos guardados correctamente en el archivo XML.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                }
            }


        }


    }

}
