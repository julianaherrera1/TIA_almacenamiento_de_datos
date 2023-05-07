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
    public partial class frm_archivo_csv : Form
    {
        /// <summary>
        /// Codigo de formulario de archivo CSV
        /// </summary>
        public frm_archivo_csv()
        {
            InitializeComponent();
        }

        //variables globales
        List<Usuarios> Datos = new List<Usuarios>();

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            // Cerrar formulario
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            // Minimizar formulario 
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_guardar_datos_Click(object sender, EventArgs e)
        {
            dgv_mostrar_datos.Visible = false;
            string rutaArchivo = "datos.csv";

            try
            {
                // Crea el archivo CSV y abre un flujo de escritura
                using (StreamWriter writer = new StreamWriter(rutaArchivo))
                {
                    // Escribe las cabeceras de las columnas
                    for (int i = 0; i < dgv_datos_usuario.ColumnCount; i++)
                    {
                        writer.Write(dgv_datos_usuario.Columns[i].HeaderText);
                        if (i < dgv_datos_usuario.ColumnCount - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();

                    // Escribe los datos de cada fila en el archivo CSV
                    foreach (DataGridViewRow row in dgv_datos_usuario.Rows)
                    {
                        for (int i = 0; i < dgv_datos_usuario.ColumnCount; i++)
                        {
                            if (row.Cells[i].Value != null)
                            {
                                writer.Write(row.Cells[i].Value.ToString());
                            }
                            if (i < dgv_datos_usuario.ColumnCount - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();
                    }

                    writer.Flush();  // Vacía el búfer de escritura
                }

                MessageBox.Show("Archivo CSV creado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el archivo CSV: " + ex.Message);
            }

            dgv_datos_usuario.Rows.Clear();
        }


        private void btn_cargar_archivo_Click(object sender, EventArgs e)
        {
            dgv_mostrar_datos.Visible = true;
            string rutaArchivo = "datos.csv";

            try
            {
                // Lee todos los datos del archivo CSV en un DataTable
                DataTable dataTable = new DataTable();
                using (StreamReader reader = new StreamReader(rutaArchivo))
                {
                    string encabezados = reader.ReadLine();
                    string[] columnas = encabezados.Split(',');
                    foreach (string columna in columnas)
                    {
                        dataTable.Columns.Add(columna);
                    }

                    while (!reader.EndOfStream)
                    {
                        string linea = reader.ReadLine();
                        string[] datos = linea.Split(',');
                        dataTable.Rows.Add(datos);
                    }
                }

                // Asigna el DataTable al control DataGridView
                dgv_mostrar_datos.DataSource = dataTable;

                MessageBox.Show("Datos cargados correctamente desde el archivo CSV.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos desde el archivo CSV: " + ex.Message);
            }
        }

        private void btn_borrar_datos_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "datos.csv";

            try
            {
                // Verificar si el archivo existe
                if (File.Exists(rutaArchivo))
                {
                    // Borrar archivo
                    File.Delete(rutaArchivo);
                    MessageBox.Show("Archivo CSV eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("El archivo CSV no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el archivo CSV: " + ex.Message);
            }

        }

        private void btn_editar_datos_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        // Escribir las cabeceras de las columnas en el archivo CSV
                        for (int i = 0; i < dgv_mostrar_datos.Columns.Count; i++)
                        {
                            sw.Write(dgv_mostrar_datos.Columns[i].HeaderText);
                            if (i < dgv_mostrar_datos.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        // Escribir los datos de las filas en el archivo CSV
                        foreach (DataGridViewRow row in dgv_mostrar_datos.Rows)
                        {
                            for (int i = 0; i < dgv_mostrar_datos.Columns.Count; i++)
                            {
                                if (row.Cells[i].Value != null)
                                    sw.Write(row.Cells[i].Value.ToString());
                                if (i < dgv_mostrar_datos.Columns.Count - 1)
                                    sw.Write(",");
                            }
                            sw.WriteLine();
                        }
                    }

                    MessageBox.Show("Datos guardados correctamente en el archivo CSV.");
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                }
            }

         }

       
    }
}
