using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonacionesCreadores
{
    public partial class UserControlComment : UserControl
    {
        public UserControlComment()
        {
            InitializeComponent();
        }

        // Constructor con parametros
        public UserControlComment(string comment)
        {
            InitializeComponent();
            this.Comment = comment;

            // Seteamos el comentario
            textBoxComment.Text = comment;
        }

        #region Propiedades

        private string _comment;

        [Category("Custom Props")]
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; textBoxComment.Text = value; }
        }

        #endregion
    }
}
