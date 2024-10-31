using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonacionesCreadores.vistas_influencer
{
    public partial class HomeInfluencerForm : Form
    {
        public HomeInfluencerForm()
        {
            InitializeComponent();
        }

        private void btnAddContent_Click(object sender, EventArgs e)
        {
            // Abrimos la ventana de agregar contenido
            CreatePostForm createPostForm = new CreatePostForm();

            // Mostramos la ventana
            createPostForm.ShowDialog();
        }
    }
}
