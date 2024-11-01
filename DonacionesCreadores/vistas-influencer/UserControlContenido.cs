using DonacionesCreadores.clases;
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
    public partial class UserControlContenido : UserControl
    {
        public UserControlContenido()
        {
            InitializeComponent();
        }

        #region Propiedades
        private string _titulo;
        private string _descripcion;
        private string _imagePath;
        private CreadorContenido _influencer;
        private HomeInfluencerForm _homeInfluencerForm;

        [Category("Custom Props")]
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; labelTittle.Text = value; }
        }

        [Category("Custom Props")]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; textBoxDescripcion.Text = value; }
        }

        [Category("Custom Props")]
        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; pictureImage.ImageLocation = value; }
        }

        [Category("Custom Props")]
        public CreadorContenido Influencer
        {
            get { return _influencer; }
            set { _influencer = value; labelUsername.Text = value.Nombre; }
        }

        [Category("Custom Props")]
        public HomeInfluencerForm HomeInfluencerForm
        {
            get { return _homeInfluencerForm; }
            set { _homeInfluencerForm = value; }
        }

        #endregion

    }
}
