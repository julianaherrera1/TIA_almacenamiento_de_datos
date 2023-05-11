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
    /// Codigo de formulario de archivo RTF
    /// </summary>
    public partial class frm_archivo_rtf : Form
    {
        public frm_archivo_rtf()
        {
            InitializeComponent();
        }

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

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Limpia el contenido del control RichTextBox
            rtbEditor.Clear();
        }

        private void abrirToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia del cuadro de diálogo de apertura de archivo
            OpenFileDialog Abrir = new OpenFileDialog();

            // Establecer el filtro de archivos y otras propiedades del cuadro de diálogo
            Abrir.Filter = "Text [*.txt*]|*.txt|All Files [*,*]|*,*";
            Abrir.CheckFileExists = true;
            Abrir.Title = "Abrir Archivo";

            // Mostrar el cuadro de diálogo y esperar la selección de un archivo
            Abrir.ShowDialog(this);

            try
            {
                // Utilizar un bloque 'using' para garantizar la liberación adecuada de recursos
                using (StreamReader myStreamReader = File.OpenText(Abrir.FileName))
                {
                    // Leer todo el contenido del archivo y asignarlo al control RichTextBox
                    rtbEditor.Text = myStreamReader.ReadToEnd();
                }
            }
            catch (FileNotFoundException)
            {
                // Mostrar un mensaje de error si el archivo seleccionado no existe
                MessageBox.Show("El archivo seleccionado no existe.");
            }
            catch (IOException ex)
            {
                // Mostrar un mensaje de error para errores de E/S al abrir el archivo
                MessageBox.Show("Error de E/S al abrir el archivo: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error general para otras excepciones
                MessageBox.Show("Error al abrir el archivo: " + ex.Message);
            }

        }

        private void guardarComoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            // Crear una instancia del cuadro de diálogo para guardar archivos
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "formato de texto enriquecido (*.rtf)|*.rtf|Text(*.txt*)|*.txt|CSV(*.csv*)|*.csv|XML (*.xml)|*.xml";
            guardar.CheckPathExists = true;
            guardar.Title = "Guardar como";

            // Mostrar el cuadro de diálogo y esperar a que el usuario seleccione una ubicación y nombre de archivo
            if (guardar.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    // Crear o abrir el archivo seleccionado para escribir en él
                    using (StreamWriter myStreamWriter = new StreamWriter(guardar.FileName))
                    {
                        // Escribir el contenido del control RichTextBox en el archivo
                        myStreamWriter.Write(rtbEditor.Text);
                        myStreamWriter.Flush();
                    }

                    MessageBox.Show("Archivo guardado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                }
            }
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Close();
        }

        private void atrasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Deshacer la última acción en el control RichTextBox
            rtbEditor.Undo();
        }

        private void adelanteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Rehacer la última acción deshecha en el control RichTextBox
            rtbEditor.Redo();
        }

        private void copiarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Copiar el texto seleccionado en el control RichTextBox al portapapeles
            rtbEditor.Copy();
        }

        private void pegarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Pegar el contenido del portapapeles en el control RichTextBox
            rtbEditor.Paste();
        }

        private void cortarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Cortar el texto seleccionado en el control RichTextBox
            rtbEditor.Cut();
        }

        private void seleccionarTodoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Seleccionar todo el texto en el control RichTextBox
            rtbEditor.SelectAll();
        }

        private void borrarTodoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Borrar todo el contenido del control RichTextBox
            rtbEditor.Clear();
        }

        private void fuenteToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia del cuadro de diálogo de selección de fuente
            FontDialog dialogoFuente = new FontDialog();

            // Establecer la fuente actual del control RichTextBox como fuente predeterminada en el cuadro de diálogo
            dialogoFuente.Font = rtbEditor.Font;

            // Mostrar el cuadro de diálogo y permitir al usuario seleccionar una fuente
            if (dialogoFuente.ShowDialog() == DialogResult.OK)
            {
                // Asignar la fuente seleccionada al control RichTextBox
                rtbEditor.Font = dialogoFuente.Font;
            }
        }

        private void colorDeFuenteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia del cuadro de diálogo de selección de color
            ColorDialog dialogoColor = new ColorDialog();

            // Mostrar el cuadro de diálogo y permitir al usuario seleccionar un color
            if (dialogoColor.ShowDialog() == DialogResult.OK)
            {
                // Asignar el color seleccionado al color de fuente del control RichTextBox
                rtbEditor.ForeColor = dialogoColor.Color;
            }
        }

        private void colorDeFondoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia del cuadro de diálogo de selección de color
            ColorDialog dialogoColor = new ColorDialog();

            // Mostrar el cuadro de diálogo y permitir al usuario seleccionar un color
            if (dialogoColor.ShowDialog() == DialogResult.OK)
            {
                // Asignar el color seleccionado al color de fondo del control RichTextBox
                rtbEditor.BackColor = dialogoColor.Color;
            }
        }

     
    }
}
