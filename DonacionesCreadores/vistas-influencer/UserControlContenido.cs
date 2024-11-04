using DonacionesCreadores.clases;
using DonacionesCreadores.dao;
using DonacionesCreadores.vistas_admin;
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
    public partial class UserControlContenido : UserControl
    {
        public UserControlContenido()
        {
            InitializeComponent();
        }

        // Constructor con todos los parametros
        public UserControlContenido(string id, string titulo, string descripcion, string idCreador, List<Visualizacion> visualizacionesList, List<Like> likeList, List<string> commentsList, double donaciones, string imagePath)
        {
            InitializeComponent();
            _id = id;
            _titulo = titulo;
            _descripcion = descripcion;
            _idCreador = idCreador;
            _visualizacionesList = visualizacionesList;
            _likeList = likeList;
            _commentsList = commentsList;
            _donaciones = donaciones;
            _imagePath = imagePath;
        }


        #region Propiedades
        private string _id;
        private string _titulo;
        private string _descripcion;
        private string _imagePath;
        private string _idCreador;
        private double _donaciones;
        private List<Like> _likeList;
        private List<Visualizacion> _visualizacionesList;
        private List<string> _commentsList;
        private HomeInfluencerForm _homeInfluencerForm;
        private HomeForm _homeForm;
        private HomeAdminFrom _homeAdminForm;
        private Usuario _usuario;

        private void UserControlContenido_Load(object sender, EventArgs e)
        {
            try
            {

                CreadorContenido creador = Dao.ObtenerCreadorContenido(_idCreador);

                // Asignamos la imagen
                pictureImage.ImageLocation = _imagePath;
                // Asignamos el titulo
                labelTittle.Text = _titulo;
                // Asignamos la descripcion
                textBoxDescripcion.Text = _descripcion;
                // Asignamos el nombre del creador
                labelUsername.Text = creador.Nombre;

                // Si el usuario esta suscrito, cambiamos el texto del button a desuscribir
                if (_usuario != null)
                {
                    if (creador.Suscriptores.Contains(_usuario.Id))
                    {
                        btnSuscribe.Text = "Desuscribir";
                    }

                    // Verifiacmos si el usuario ya dio like
                    if (_likeList != null)
                    {
                        foreach (Like like in _likeList)
                        {
                            if (like.IdUsuario == _usuario.Id)
                            {
                                // Cambiamos el icono del boton
                                btnLike.Image = Properties.Resources.icon_like;
                                btnLike.Text = "UnLike";
                            }
                        }
                    }

                    // Verificamos si el usuario ya visualizo el contenido
                    if (_visualizacionesList != null)
                    {
                        foreach (Visualizacion visualizacion in _visualizacionesList)
                        {
                            if (visualizacion.IdUsuario == _usuario.Id)
                            {
                                // Ocultamos el btn de Ver
                                btnVer.Visible = false;
                            }
                        }
                    }

                    // Cargamos la cantidad de comentarios
                    if (_commentsList != null)
                    {
                        btnComment.Text = "Comentarios (" + _commentsList.Count.ToString() + ")";


                    }

                    // Ids
                    Debug.WriteLine("Id del usuario: " + _usuario.Id);
                    Debug.WriteLine("Id del creador: " + _idCreador);
                    // Si el usuario no es el creador del contenido o no es una instancia de Administrador ocultamos el btn de eliminar
                    if (_usuario.Id != _idCreador && !(_usuario is Administrador))
                    {
                        btnOptions.Visible = false;
                    }


                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine("No se pudo obtener al creador de contenido" + ex.Message);
            }

        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            try
            {
                // Si el texto del btn de like dice UnLike, eliminamos el like
                if (btnLike.Text == "UnLike")
                {
                    // Eliminamos el like
                    _likeList.RemoveAll(like => like.IdUsuario == _usuario.Id);
                    // Actualizamos el contenido
                    Contenido contenidoActualizado = new Contenido(_id, _titulo, _descripcion, _idCreador, _visualizacionesList, _likeList, _commentsList, _donaciones, _imagePath);
                    Dao.ActualizarContenido(contenidoActualizado);
                    // Cambiamos el icono del boton
                    btnLike.Image = Properties.Resources.icon_nolikeado;
                    btnLike.Text = "Like";
                }
                else
                {
                    // Agregamos el like
                    Like like = new Like(_usuario.Id, _idCreador);
                    _likeList.Add(like);
                    // Actualizamos el contenido
                    Contenido contenidoActualizado = new Contenido(_id, _titulo, _descripcion, _idCreador, _visualizacionesList, _likeList, _commentsList, _donaciones, _imagePath);
                    Dao.ActualizarContenido(contenidoActualizado);
                    // Cambiamos el icono del boton
                    btnLike.Image = Properties.Resources.icon_like;
                    btnLike.Text = "UnLike";
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error al dar like: " + ex.Message);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                // id del contenido
                Debug.WriteLine("Id del contenido a visualizar: " + _id);
                // Agregamos la visualizacion
                Visualizacion visualizacion = new Visualizacion(_usuario.Id, _id);
                _visualizacionesList.Add(visualizacion);

                // Actualizamos el contenido
                Contenido contenidoActualizado = new Contenido(_id, _titulo, _descripcion, _idCreador, _visualizacionesList, _likeList, _commentsList, _donaciones, _imagePath);

                Dao.ActualizarContenido(contenidoActualizado);

                // Ocultamos el btn de Ver
                btnVer.Visible = false;

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error al guardar la visualizacion: " + ex.Message);
            }
        }

        private void btnDonar_Click(object sender, EventArgs e)
        {
            // Solictamos el monto de la donacion
            string monto = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el monto de la donacion", "Donar", "0.0", -1, -1);

            // Verificamos que el monto sea valido
            if (monto != "")
            {
                try
                {
                    // Convertimos el monto a double
                    double montoDouble = Convert.ToDouble(monto);

                    // Sumamos el monto a las donaciones
                    _donaciones += montoDouble;

                    // Actualizamos el contenido
                    Contenido contenidoActualizado = new Contenido(_id, _titulo, _descripcion, _idCreador, _visualizacionesList, _likeList, _commentsList, _donaciones, _imagePath);
                    Dao.ActualizarContenido(contenidoActualizado);

                    // Mostramos un mensaje de exito
                    MessageBox.Show("Donacion realizada con exito", "Donacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error al convertir el monto: " + ex.Message);
                }
            }
        }

        private void btnSuscribe_Click(object sender, EventArgs e)
        {
            // Agrega las suscripciones
            try
            {
                CreadorContenido creador = Dao.ObtenerCreadorContenido(_idCreador);

                // Si el usuario esta suscrito, lo eliminamos
                if (creador.Suscriptores.Contains(_usuario.Id))
                {
                    creador.Suscriptores.Remove(_usuario.Id);
                    // Actualizamos el creador de contenido
                    Dao.ActualizarCreadorContenido(creador);
                    // Cambiamos el texto del boton
                    btnSuscribe.Text = "Suscribirse";
                }
                else
                {
                    // Si no esta suscrito, lo agregamos
                    creador.Suscriptores.Add(_usuario.Id);
                    // Actualizamos el creador de contenido
                    Dao.ActualizarCreadorContenido(creador);
                    // Cambiamos el texto del boton
                    btnSuscribe.Text = "Desuscribir";
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error al agregar la suscripcion: " + ex.Message);
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            // Abrimos el context menu strip

            contextMenuStrip1.Show(btnOptions, new Point(0, btnOptions.Height));
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Obtenemos el item seleccionado
            ToolStripItem item = e.ClickedItem;

            // Verificamos si el item es el de eliminar
            if (item.Text == "Eliminar")
            {
                // Eliminamos el contenido
                try
                {
                    Dao.EliminarContenido(_id);
                    // Actualizamos el flowLayoutPanel
                    if (HomeForm != null)
                    {
                        HomeForm.Load_Content();
                    }
                    else if (HomeInfluencerForm != null)
                    {
                        HomeInfluencerForm.LoadContent();
                    }
                    else
                    {
                        HomeAdminForm?.CargarContenido();
                    }

                    // Mostramos mensaje de exito
                    MessageBox.Show("Contenido eliminado con exito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error al eliminar el contenido: " + ex.Message);
                }
            } else if (item.Text == "Editar")
            {
                // Abrimos la ventana de editar contenido
            }

        }

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
        public string IdCreador
        {
            get { return _idCreador; }
            set { _idCreador = value; }
        }

        [Category("Custom Props")]
        public HomeInfluencerForm HomeInfluencerForm
        {
            get { return _homeInfluencerForm; }
            set { _homeInfluencerForm = value; }
        }

        [Category("Custom Props")]
        public Usuario Usuario
        {
            get { return _usuario; }
            set { _usuario = value; labelUsername.Text = value.Nombre; }
        }

        [Category("Custom Props")]
        public List<Like> LikeList
        {
            get { return _likeList; }
            set { _likeList = value; }
        }

        [Category("Custom Props")]
        public List<Visualizacion> VisualizacionesList
        {
            get { return _visualizacionesList; }
            set { _visualizacionesList = value; }
        }

        [Category("Custom Props")]
        public List<string> CommentsList
        {
            get { return _commentsList; }
            set { _commentsList = value; }
        }

        [Category("Custom Props")]
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Custom Props")]
        public double Donaciones
        {
            get { return _donaciones; }
            set { _donaciones = value; }
        }

        [Category("Custom Props")]
        public HomeForm HomeForm
        {
            get { return _homeForm; }
            set { _homeForm = value; }
        }

        [Category("Custom Props")]
        public HomeAdminFrom HomeAdminForm
        {
            get { return _homeAdminForm; }
            set { _homeAdminForm = value; }
        }



        #endregion

    }
}
