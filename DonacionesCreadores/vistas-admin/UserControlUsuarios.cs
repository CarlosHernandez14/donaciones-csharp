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

namespace DonacionesCreadores.vistas_admin
{
    public partial class UserControlUsuarios : UserControl
    {
        public UserControlUsuarios()
        {
            InitializeComponent();
        }

        // Constructor con parametros
        public UserControlUsuarios(CreadorContenido influencer)
        {
            InitializeComponent();
            this.Influencer = influencer;
        }

        #region Propiedades
        private CreadorContenido _influencer;


        private void btnPartner_Click(object sender, EventArgs e)
        {

        }

        // Metodo para calcular el total de donaciones
        private double CalculateTotalDonations()
        {
            try
            {
                // Obtenemos los contenidos del influencer
                List<Contenido> contenidos = Dao.ObtenerContenidos();

                // Variable para almacenar el total de donaciones
                double totalDonations = 0;

                // Recorremos los contenidos
                foreach (Contenido contenido in contenidos)
                {
                    // Verificamos si el contenido pertenece al influencer
                    if (contenido.IdCreador == _influencer.Id)
                    {
                        // Sumamos el total de donaciones
                        totalDonations += contenido.Donaciones;
                    }
                }

                return totalDonations;

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error al calcular el total de donaciones: " + ex.Message);
                MessageBox.Show("Error al calcular el total de donaciones");
            }
            return 0;
        }

        // Metodo para calcular el promedio de likes de los contenidos del influencer
        private double CalculateAverageLikes()
        {
            try
            {
                // Obtenemos los contenidos del influencer
                List<Contenido> contenidos = Dao.ObtenerContenidos();

                // FIltramos los contenidos del influencer
                List<Contenido> influencerContents = contenidos.Where(c => c.IdCreador == _influencer.Id).ToList();

                for (int i = 0; i < influencerContents.Count;  i++)
                {
                    Debug.WriteLine(influencerContents[i].ToString());
                }

                // Variable para almacenar el total de likes
                double totalLikes = 0;

                // Recorremos los contenidos
                foreach (Contenido contenido in influencerContents)
                {
                    // Sumamos el total de likes
                    totalLikes += contenido.Likes.Count;
                }


                return totalLikes / influencerContents.Count;

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error al calcular el promedio de likes: " + ex.Message);
                MessageBox.Show("Error al calcular el promedio de likes");
            }
            return 0;
        }

        // Metodo para calcular el promedio de visualizaciones de los contenidos del influencer
        private double CalculateAverageViews()
        {
            try
            {

                // Obtenemos los contenidos del influencer
                List<Contenido> contenidos = Dao.ObtenerContenidos();

                // FIltramos los contenidos del influencer
                List<Contenido> influencerContents = contenidos.Where(c => c.IdCreador == _influencer.Id).ToList();

                // Variable para almacenar el total de visualizaciones
                double totalViews = 0;

                // Recorremos los contenidos
                foreach (Contenido contenido in influencerContents)
                {
                    // Sumamos el total de visualizaciones
                    totalViews += contenido.Visualizaciones.Count;
                }



                return totalViews / influencerContents.Count;

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error al calcular el promedio de visualizaciones: " + ex.Message);
                MessageBox.Show("Error al calcular el promedio de visualizaciones");
            }
            return 0;
        }

        private void UserControlUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos el total de donaciones
                double totalDonations = CalculateTotalDonations();
                labelDonations.Text = totalDonations.ToString();

                // Obtenemos el promedio de likes
                double averageLikes = CalculateAverageLikes();
                labelLikes.Text = averageLikes.ToString();

                // Obtenemos el promedio de visualizaciones
                double averageViews = CalculateAverageViews();
                labelViews.Text = averageViews.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }

        }

        [Category("Custom Props")]
        public CreadorContenido Influencer
        {
            get { return _influencer; }
            set
            {
                _influencer = value;
                labelUsername.Text = _influencer.Nombre;

                // Calculamos el total de donaciones
                double totalDonations = CalculateTotalDonations();
                labelDonations.Text = totalDonations.ToString();

                // Calculamos el promedio de likes
                double averageLikes = CalculateAverageLikes();
                labelLikes.Text = averageLikes.ToString();

                // Calculamos el promedio de visualizaciones
                double averageViews = CalculateAverageViews();
                labelViews.Text = averageViews.ToString();

            }
        }
        #endregion

    }
}
