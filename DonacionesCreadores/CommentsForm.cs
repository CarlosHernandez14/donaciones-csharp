using DonacionesCreadores.clases;
using DonacionesCreadores.dao;
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

namespace DonacionesCreadores
{
    public partial class CommentsForm : Form
    {

        private Contenido Content { get; set; }
        private Usuario User { get; set; }

        public CommentsForm()
        {
            InitializeComponent();
        }

        // Constructor con parametros
        public CommentsForm(Contenido contenido, Usuario usuario)
        {
            InitializeComponent();

            this.Content = contenido;
            this.User = usuario;
        }

        private void CommentsForm_Load(object sender, EventArgs e)
        {
            // Cargar los comentarios
            LoadComments();
        }

        // Funcion para cargar los comentarios
        public void LoadComments()
        {

            // Limpiamos el panel
            flowContainerComments.Controls.Clear();

            // Recorremos los comentarios
            foreach (string comment in this.Content.Comentarios)
            {
                // Creamos un nuevo UserControlComment
                UserControlComment userControlComment = new(comment);

                // Agregamos el control al panel
                flowContainerComments.Controls.Add(userControlComment);
            }

            // Refrescamos el panel
            flowContainerComments.Refresh();
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            // Obtenemos el comentario
            string comment = textBoxAddComment.Text;

            // Verificamos que el comentario no este vacio o diga "Agregar comentario..."
            if (string.IsNullOrEmpty(comment) || comment == "Agregar comentario...")
            {
                MessageBox.Show("Por favor, ingrese un comentario.");
                return;
            }

            // Agregamos el comentario
            try
            {
                this.Content.AgregarComentario(comment, this.User);

                // Actualizamos el contenido
                Dao.ActualizarContenido(this.Content);

                // Recargamos los comentarios
                LoadComments();

                // Limpiamos el textbox
                textBoxAddComment.Text = "Agregar comentario...";

                MessageBox.Show("Comentario agregado correctamente.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error al agregar el comentario: " + ex.Message);
                MessageBox.Show("Error al agregar el comentario.");
            }
        }
    }
}
