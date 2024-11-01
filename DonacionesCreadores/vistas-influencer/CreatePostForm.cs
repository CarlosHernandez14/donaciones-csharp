using DonacionesCreadores.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonacionesCreadores.vistas_influencer
{
    public partial class CreatePostForm : Form
    {

        // Variable para guardar la ruta de la imagen seleccionada
        private string imagePath;
        // Usuario actual
        private CreadorContenido influencer;
        // Recibimos instancia de HomeInfluencerForm
        private HomeInfluencerForm homeInfluencerForm;

        public CreatePostForm()
        {
            InitializeComponent();
        }

        public CreatePostForm(CreadorContenido influencer, HomeInfluencerForm homeInfluencerForm)
        {
            InitializeComponent();

            this.influencer = influencer;
            this.homeInfluencerForm = homeInfluencerForm;
        }

        private void btnAddContent_Click(object sender, EventArgs e)
        {
            // Obtenemos los valores de los campos
            string title = fieldTittle.Text;
            string description = fieldDescripcion.Text;

            // Validamos que los campos no estén vacíos
            if (title == "" || description == "")
            {
                MessageBox.Show("Por favor, llena todos los campos");
                return;
            }

            // Verificamos que se haya seleccionado una imagen
            if (this.imagePath == null)
            {
                MessageBox.Show("Por favor, selecciona una imagen");
                return;
            }

            //Contenido nuevoContenido = new Contenido(title, description, this.influencer.Id, this.imagePath);

            try
            {
                // Guardamos la imagen en la carpeta de imagenes
                string fileName = System.IO.Path.GetFileName(this.imagePath);
                string destPath = System.IO.Path.Combine("imagenes", fileName);
                
                
                // Creamos el contenido
                this.influencer.CrearContenido(title, description, "imagenes/" + fileName);



                System.IO.File.Copy(this.imagePath, destPath, true);

                // Mostramos un mensaje de éxito
                MessageBox.Show("Contenido creado con éxito");

                // Cerramos la ventana
                this.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error al crear el contenido: " + ex.Message);
                // Mostramos un mensaje de error
                MessageBox.Show("Ocurrió un error al crear el contenido");
            }

            //Actualizamos la interfaz

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            // Abrimos el dialogo para seleccionar la imagen
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";
            dialog.Title = "Selecciona una imagen";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Obtenemos la ruta de la imagen seleccionada
                this.imagePath = dialog.FileName;
                Debug.WriteLine("Ruta de la imagen: " + this.imagePath);

                // Mostramos la imagen seleccionada en el picture box de la interfaz
                pictureBoxPreview.Image = Image.FromFile(this.imagePath);
            }

        }
    }
}
