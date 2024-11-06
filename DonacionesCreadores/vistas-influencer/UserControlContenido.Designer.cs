namespace DonacionesCreadores.vistas_influencer
{
    partial class UserControlContenido
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            labelUsername = new Label();
            btnSuscribe = new Button();
            panel1 = new Panel();
            btnOptions = new Button();
            labelTittle = new Label();
            pictureImage = new PictureBox();
            textBoxDescripcion = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnLike = new Button();
            btnComment = new Button();
            btnVer = new Button();
            btnDonar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureImage).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(labelUsername);
            flowLayoutPanel1.Controls.Add(btnSuscribe);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 15, 0, 0);
            flowLayoutPanel1.Size = new Size(471, 78);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_usuario;
            pictureBox1.Location = new Point(3, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(41, 25);
            labelUsername.Margin = new Padding(3, 10, 3, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(151, 21);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Nombre de usuario";
            // 
            // btnSuscribe
            // 
            btnSuscribe.BackColor = Color.Orange;
            btnSuscribe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuscribe.ForeColor = Color.White;
            btnSuscribe.Location = new Point(198, 20);
            btnSuscribe.Margin = new Padding(3, 5, 3, 3);
            btnSuscribe.Name = "btnSuscribe";
            btnSuscribe.Size = new Size(111, 30);
            btnSuscribe.TabIndex = 2;
            btnSuscribe.Text = "Suscribirse";
            btnSuscribe.UseVisualStyleBackColor = false;
            btnSuscribe.Click += btnSuscribe_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOptions);
            panel1.Location = new Point(315, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(147, 40);
            panel1.TabIndex = 3;
            // 
            // btnOptions
            // 
            btnOptions.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOptions.Location = new Point(107, 3);
            btnOptions.Name = "btnOptions";
            btnOptions.Size = new Size(37, 29);
            btnOptions.TabIndex = 0;
            btnOptions.Text = "...";
            btnOptions.UseVisualStyleBackColor = true;
            btnOptions.Click += btnOptions_Click;
            // 
            // labelTittle
            // 
            labelTittle.AutoSize = true;
            labelTittle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTittle.Location = new Point(6, 84);
            labelTittle.Name = "labelTittle";
            labelTittle.Size = new Size(64, 25);
            labelTittle.TabIndex = 1;
            labelTittle.Text = "Titulo";
            // 
            // pictureImage
            // 
            pictureImage.Image = Properties.Resources.default_image;
            pictureImage.Location = new Point(6, 122);
            pictureImage.Name = "pictureImage";
            pictureImage.Size = new Size(468, 186);
            pictureImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureImage.TabIndex = 2;
            pictureImage.TabStop = false;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.BackColor = Color.White;
            textBoxDescripcion.ForeColor = SystemColors.WindowFrame;
            textBoxDescripcion.Location = new Point(6, 314);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.ReadOnly = true;
            textBoxDescripcion.Size = new Size(468, 132);
            textBoxDescripcion.TabIndex = 3;
            textBoxDescripcion.Text = "Descripcion de la publicacion";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnLike);
            flowLayoutPanel2.Controls.Add(btnComment);
            flowLayoutPanel2.Controls.Add(btnVer);
            flowLayoutPanel2.Controls.Add(btnDonar);
            flowLayoutPanel2.Location = new Point(6, 452);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(0, 5, 0, 0);
            flowLayoutPanel2.Size = new Size(468, 60);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // btnLike
            // 
            btnLike.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLike.Image = Properties.Resources.icon_nolikeado;
            btnLike.ImageAlign = ContentAlignment.MiddleLeft;
            btnLike.Location = new Point(3, 8);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(95, 47);
            btnLike.TabIndex = 0;
            btnLike.Text = "Like";
            btnLike.TextAlign = ContentAlignment.MiddleRight;
            btnLike.UseVisualStyleBackColor = true;
            btnLike.Click += btnLike_Click;
            // 
            // btnComment
            // 
            btnComment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComment.Image = Properties.Resources.icon_comentar;
            btnComment.ImageAlign = ContentAlignment.MiddleLeft;
            btnComment.Location = new Point(104, 8);
            btnComment.Name = "btnComment";
            btnComment.Size = new Size(151, 47);
            btnComment.TabIndex = 1;
            btnComment.Text = "Comentarios(0)";
            btnComment.TextAlign = ContentAlignment.MiddleRight;
            btnComment.UseVisualStyleBackColor = true;
            btnComment.Click += btnComment_Click;
            // 
            // btnVer
            // 
            btnVer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVer.ForeColor = Color.DarkOrange;
            btnVer.ImageAlign = ContentAlignment.MiddleLeft;
            btnVer.Location = new Point(261, 8);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(77, 47);
            btnVer.TabIndex = 2;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnDonar
            // 
            btnDonar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDonar.ForeColor = Color.DarkOrange;
            btnDonar.Image = Properties.Resources.icon_donar;
            btnDonar.ImageAlign = ContentAlignment.MiddleLeft;
            btnDonar.Location = new Point(344, 8);
            btnDonar.Name = "btnDonar";
            btnDonar.Size = new Size(92, 47);
            btnDonar.TabIndex = 3;
            btnDonar.Text = "Donar";
            btnDonar.TextAlign = ContentAlignment.MiddleRight;
            btnDonar.UseVisualStyleBackColor = true;
            btnDonar.Click += btnDonar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem, editarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(118, 48);
            contextMenuStrip1.ItemClicked += contextMenuStrip1_ItemClicked;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(117, 22);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // UserControlContenido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowLayoutPanel2);
            Controls.Add(textBoxDescripcion);
            Controls.Add(pictureImage);
            Controls.Add(labelTittle);
            Controls.Add(flowLayoutPanel1);
            Name = "UserControlContenido";
            Size = new Size(479, 521);
            Load += UserControlContenido_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureImage).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Label labelUsername;
        private Button btnSuscribe;
        private Panel panel1;
        private Button btnOptions;
        private Label labelTittle;
        private PictureBox pictureImage;
        private TextBox textBoxDescripcion;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnLike;
        private Button btnComment;
        private Button btnVer;
        private Button btnDonar;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
    }
}
