namespace DonacionesCreadores.vistas_admin
{
    partial class HomeAdminFrom
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnUsers = new Button();
            buttonProfile = new Button();
            btnPublicaciones = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            btnExcel = new Button();
            label2 = new Label();
            btnPDF = new Button();
            containerPosts = new FlowLayoutPanel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(btnUsers);
            panel1.Controls.Add(buttonProfile);
            panel1.Controls.Add(btnPublicaciones);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 526);
            panel1.TabIndex = 1;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.Orange;
            btnUsers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.White;
            btnUsers.Image = Properties.Resources.icon_usuario;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(0, 166);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(20, 0, 0, 0);
            btnUsers.Size = new Size(225, 57);
            btnUsers.TabIndex = 3;
            btnUsers.Text = "Usuarios";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // buttonProfile
            // 
            buttonProfile.BackColor = Color.Orange;
            buttonProfile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProfile.ForeColor = Color.White;
            buttonProfile.Image = Properties.Resources.icon_profile_big;
            buttonProfile.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProfile.Location = new Point(0, 450);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(225, 76);
            buttonProfile.TabIndex = 2;
            buttonProfile.Text = "Perfil";
            buttonProfile.UseVisualStyleBackColor = false;
            buttonProfile.Click += buttonProfile_Click;
            // 
            // btnPublicaciones
            // 
            btnPublicaciones.BackColor = Color.Orange;
            btnPublicaciones.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPublicaciones.ForeColor = Color.White;
            btnPublicaciones.Image = Properties.Resources.icon_publicaciones;
            btnPublicaciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnPublicaciones.Location = new Point(0, 103);
            btnPublicaciones.Name = "btnPublicaciones";
            btnPublicaciones.Padding = new Padding(20, 0, 0, 0);
            btnPublicaciones.Size = new Size(225, 57);
            btnPublicaciones.TabIndex = 1;
            btnPublicaciones.Text = "Publicaciones";
            btnPublicaciones.UseVisualStyleBackColor = false;
            btnPublicaciones.Click += btnPublicaciones_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 58);
            label1.Name = "label1";
            label1.Size = new Size(150, 30);
            label1.TabIndex = 0;
            label1.Text = "Instafluencers";
            // 
            // panel2
            // 
            panel2.AccessibleRole = AccessibleRole.IpAddress;
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnExcel);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnPDF);
            panel2.Location = new Point(225, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(696, 88);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(258, 8);
            label3.Name = "label3";
            label3.Size = new Size(190, 17);
            label3.TabIndex = 3;
            label3.Text = "Usuarios con mas donaciones";
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.Orange;
            btnExcel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcel.ForeColor = Color.White;
            btnExcel.Location = new Point(258, 29);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(187, 39);
            btnExcel.TabIndex = 2;
            btnExcel.Text = "Descargar Excel";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(482, 8);
            label2.Name = "label2";
            label2.Size = new Size(185, 17);
            label2.TabIndex = 1;
            label2.Text = "Ficha Tecnica de los Partners";
            // 
            // btnPDF
            // 
            btnPDF.BackColor = Color.Orange;
            btnPDF.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPDF.ForeColor = Color.White;
            btnPDF.Location = new Point(478, 29);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(207, 39);
            btnPDF.TabIndex = 0;
            btnPDF.Text = "Descargar PDF";
            btnPDF.UseVisualStyleBackColor = false;
            btnPDF.Click += btnPDF_Click;
            // 
            // containerPosts
            // 
            containerPosts.AutoScroll = true;
            containerPosts.Location = new Point(231, 94);
            containerPosts.Name = "containerPosts";
            containerPosts.Size = new Size(686, 432);
            containerPosts.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(143, 26);
            contextMenuStrip1.ItemClicked += contextMenuStrip1_ItemClicked;
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(142, 22);
            cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            // 
            // HomeAdminFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(922, 527);
            Controls.Add(containerPosts);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HomeAdminFrom";
            Text = "HomeAdminFrom";
            Load += HomeAdminFrom_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonProfile;
        private Button btnPublicaciones;
        private Label label1;
        private Panel panel2;
        private Button btnPDF;
        private Label label3;
        private Button btnExcel;
        private Label label2;
        private FlowLayoutPanel containerPosts;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private Button btnUsers;
    }
}