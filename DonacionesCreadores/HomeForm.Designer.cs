﻿namespace DonacionesCreadores
{
    partial class HomeForm
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
            containerPosts = new FlowLayoutPanel();
            buttonProfile = new Button();
            btnPublicaciones = new Button();
            label1 = new Label();
            flowLayoutPosts = new FlowLayoutPanel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(containerPosts);
            panel1.Controls.Add(buttonProfile);
            panel1.Controls.Add(btnPublicaciones);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 526);
            panel1.TabIndex = 1;
            // 
            // containerPosts
            // 
            containerPosts.AutoScroll = true;
            containerPosts.Location = new Point(231, 78);
            containerPosts.Name = "containerPosts";
            containerPosts.Size = new Size(686, 448);
            containerPosts.TabIndex = 3;
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
            // flowLayoutPosts
            // 
            flowLayoutPosts.AutoScroll = true;
            flowLayoutPosts.Location = new Point(231, 12);
            flowLayoutPosts.Name = "flowLayoutPosts";
            flowLayoutPosts.Size = new Size(734, 503);
            flowLayoutPosts.TabIndex = 3;
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
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(977, 527);
            Controls.Add(flowLayoutPosts);
            Controls.Add(panel1);
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonProfile;
        private Button btnPublicaciones;
        private Label label1;
        private FlowLayoutPanel containerPosts;
        private FlowLayoutPanel flowLayoutPosts;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}