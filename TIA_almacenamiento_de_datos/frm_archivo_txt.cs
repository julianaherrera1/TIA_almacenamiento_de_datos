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
            //  mostrar datos del archivo txt en el datagrid
            try
            {
                List<string[]> datos = new List<string[]>();
                using (StreamReader reader = new StreamReader("Datos.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] parts = line.Split(',');
                        datos.Add(parts);
                    }
                }

                DataTable tabla = new DataTable();
                tabla.Columns.Add("Id");
                tabla.Columns.Add("Nombre");
                tabla.Columns.Add("Apellido");
                tabla.Columns.Add("Edad");

                foreach (string[] rowdata in datos)
                {
                    if(rowdata.Length == 4)
                    {
                        tabla.Rows.Add(rowdata);
                    }
                }

                dgv_datos_usuario.DataSource = tabla;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(" Error al cargar los datos: " + ex.Message);
            }
        }

        private void btn_editar_datos_Click(object sender, EventArgs e)
        {
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
