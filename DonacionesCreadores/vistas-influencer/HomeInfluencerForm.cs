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

namespace DonacionesCreadores.vistas_influencer
{
    public partial class HomeInfluencerForm : Form
    {
        // Instancia de influencer
        private CreadorContenido influencer;
        public HomeInfluencerForm()
        {
            InitializeComponent();
        }
        public HomeInfluencerForm(CreadorContenido influencer)
        {
            InitializeComponent();

            this.influencer = influencer;
        }

        private void btnAddContent_Click(object sender, EventArgs e)
        {
            // Abrimos la ventana de agregar contenido
            CreatePostForm createPostForm = new CreatePostForm(this.influencer, this);

            // Mostramos la ventana
            createPostForm.ShowDialog();
        }

        private void HomeInfluencerForm_Load(object sender, EventArgs e)
        {
            LoadContent();
        }

        // Metodo para cargar los contenidos
        public void LoadContent()
        {
            // Limpiamos los controles
            containerPosts.Controls.Clear();
            try
            {

                // Obtenemos lo contenidos
                List<Contenido> contenidos = Dao.ObtenerContenidos();

                // Recorremos los contenidos del influencer
                foreach (Contenido contenido in contenidos)
                {
                    // Creamos un nuevo control de usuario
                    UserControlContenido userControlContenido = new()
                    {
                        // Asignamos los valores
                        Titulo = contenido.Titulo,
                        Descripcion = contenido.Descripcion,
                        ImagePath = contenido.ImagePath,
                        Influencer = influencer,
                        HomeInfluencerForm = this
                    };

                    // Agregamos el control al flowLayoutPanel
                    containerPosts.Controls.Add(userControlContenido);
                }

            }catch(Exception ex)
            {
                Debug.WriteLine("Error al cargar los contenidos: " + ex.Message);
                MessageBox.Show("Error al cargar los contenidos");
            }

        }
    }
}
