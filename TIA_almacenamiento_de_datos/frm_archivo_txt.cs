using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TIA_almacenamiento_de_datos
{
    /// <summary>
    /// codigo de formulario de archivo TXT
    /// </summary>
    public partial class frm_archivo_txt : Form
    {
        public frm_archivo_txt()
        {
            InitializeComponent();
        }

        // variables globales
        public List<Usuarios> lista_datos_usuarios = new List<Usuarios>();
        int id = 0;

        private void btn_cerrar_form_Click(object sender, EventArgs e)
        {
            // cerrar formulario
            this.Close();
        }
        private void btn_minimizar_form_Click(object sender, EventArgs e)
        {
            // Minimizar formulario 
            this.WindowState = FormWindowState.Minimized;
        }


        private void btn_guardar_datos_Click(object sender, EventArgs e)
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

                Usuarios user = new Usuarios();
                // Asignar los valores de los campos de texto a las propiedades del objeto
                user.id_usuario = id + 1;
                id = user.id_usuario;
                user.nombre_usuario = txt_nombre_usuario.Text;
                user.apellido_usuario = txt_apellido_usuario.Text;
                user.edad_usuario = edad;
                // Agregar el objeto del usuario a la lista 
                lista_datos_usuarios.Add(user);

                // Guardar en el archivo y limpiar los campos de texto
                guardar_archivo();
                limpiar();

            }
            catch(Exception ex)
            {
                MessageBox.Show(" Error al agregar usuario "+ ex.Message);
            }


           
        }



        private void btn_cargar_archivo_Click(object sender, EventArgs e)
        {
            // Crea un OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";

            // Muestra el cuadro de diálogo de abrir archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // Leer los datos del archivo de texto
                    List<string[]> datos = new List<string[]>();
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] parts = line.Split(',');
                            datos.Add(parts);
                        }
                    }

                    // Crear una tabla y agregar columnas
                    DataTable tabla = new DataTable();
                    tabla.Columns.Add("Id");
                    tabla.Columns.Add("Nombre");
                    tabla.Columns.Add("Apellido");
                    tabla.Columns.Add("Edad");

                    // Agregar filas a la tabla
                    foreach (string[] rowdata in datos)
                    {
                        if (rowdata.Length == 4)
                        {
                            tabla.Rows.Add(rowdata);
                        }
                    }

                    // Limpiar el DataGridView
                    dgv_datos_usuario.DataSource = null;
                    // Asignar la tabla como origen de datos del DataGridView
                    dgv_datos_usuario.DataSource = tabla;

                    dgv_datos_usuario.AutoResizeColumns();

                    MessageBox.Show("Archivo cargado en el DataGridView.");
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error al cargar el archivo: " + ex.Message);
                }
            }
        }

        private void btn_editar_datos_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                    {
                        // Recorrer las filas y columnas del DataGridView
                        for (int row = 0; row < dgv_datos_usuario.Rows.Count; row++)
                        {
                            for (int col = 0; col < dgv_datos_usuario.Columns.Count; col++)
                            {
                                // Obtener el valor de la celda
                                string value = dgv_datos_usuario.Rows[row].Cells[col].Value?.ToString();

                                // Escribir el valor en el archivo separado por comas
                                writer.Write(value);

                                // Agregar una coma si no es la última columna
                                if (col < dgv_datos_usuario.Columns.Count - 1)
                                {
                                    writer.Write(",");
                                }
                            }

                            // Agregar un salto de línea después de cada fila
                            writer.WriteLine();
                        }
                    }

                    MessageBox.Show("Datos guardados correctamente en el archivo.");
                    dgv_datos_usuario.DataSource = null;
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                }
            }
        }


        // eliminar archivo txt
        private void btn_borrar_datos_Click(object sender, EventArgs e)
        {
            string ruta = "Datos.txt";
            if (File.Exists(ruta))
            {
                try
                {
                    File.Delete("Datos.txt");
                    MessageBox.Show("Archivo eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el archivo: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show(" No hay ningun archivo ");
            }
        }

        // METODOS : 

        // METODO LIMPIAR
        public void limpiar()
        {
            txt_nombre_usuario.Text = "";
            txt_apellido_usuario.Text = "";
            txt_edad_usuario.Text="";
            txt_nombre_usuario.Focus();
        }

        //  METODO GUARDAR DATOS EN ARCHIVO TXT
        public void guardar_archivo()
        {
            try
            {
                //crear archivo y guardar lo que hay en la lista
                using (StreamWriter escribir = new StreamWriter("Datos.txt"))
                {
                    foreach (Usuarios u in lista_datos_usuarios)
                    {
                        escribir.WriteLine(u.id_usuario + "," + u.nombre_usuario + "," + u.apellido_usuario + "," + u.edad_usuario);
                    }
                }

                MessageBox.Show("Datos guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }

        }

       
    }
}
