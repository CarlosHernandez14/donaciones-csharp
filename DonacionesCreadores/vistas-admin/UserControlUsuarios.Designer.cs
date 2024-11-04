namespace DonacionesCreadores.vistas_admin
{
    partial class UserControlUsuarios
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            labelDonations = new Label();
            label2 = new Label();
            labelUsername = new Label();
            panel2 = new Panel();
            labelViews = new Label();
            label1 = new Label();
            panel3 = new Panel();
            labelLikes = new Label();
            label4 = new Label();
            panel1 = new Panel();
            btnPartner = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 15, 0, 0);
            flowLayoutPanel1.Size = new Size(602, 78);
            flowLayoutPanel1.TabIndex = 1;
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
            // panel4
            // 
            panel4.Controls.Add(labelDonations);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(labelUsername);
            panel4.Location = new Point(41, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(157, 50);
            panel4.TabIndex = 6;
            // 
            // labelDonations
            // 
            labelDonations.AutoSize = true;
            labelDonations.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDonations.Location = new Point(80, 25);
            labelDonations.Name = "labelDonations";
            labelDonations.Size = new Size(24, 15);
            labelDonations.TabIndex = 4;
            labelDonations.Text = "0.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 25);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 3;
            label2.Text = "Donaciones: $";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(3, 3);
            labelUsername.Margin = new Padding(3, 10, 3, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(151, 21);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Nombre de usuario";
            // 
            // panel2
            // 
            panel2.Controls.Add(labelViews);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(204, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(121, 40);
            panel2.TabIndex = 4;
            // 
            // labelViews
            // 
            labelViews.AutoSize = true;
            labelViews.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelViews.Location = new Point(3, 18);
            labelViews.Name = "labelViews";
            labelViews.Size = new Size(31, 19);
            labelViews.TabIndex = 1;
            labelViews.Text = "100";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Promedio de Vistas";
            // 
            // panel3
            // 
            panel3.Controls.Add(labelLikes);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(331, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(121, 40);
            panel3.TabIndex = 5;
            // 
            // labelLikes
            // 
            labelLikes.AutoSize = true;
            labelLikes.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelLikes.Location = new Point(3, 18);
            labelLikes.Name = "labelLikes";
            labelLikes.Size = new Size(31, 19);
            labelLikes.TabIndex = 1;
            labelLikes.Text = "100";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 0;
            label4.Text = "Promedio de Likes";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPartner);
            panel1.Location = new Point(458, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(138, 40);
            panel1.TabIndex = 3;
            // 
            // btnPartner
            // 
            btnPartner.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPartner.ForeColor = Color.DarkOrange;
            btnPartner.Location = new Point(5, 3);
            btnPartner.Name = "btnPartner";
            btnPartner.Size = new Size(130, 29);
            btnPartner.TabIndex = 0;
            btnPartner.Text = "Hacer partner";
            btnPartner.UseVisualStyleBackColor = true;
            btnPartner.Click += btnPartner_Click;
            // 
            // UserControlUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowLayoutPanel1);
            Name = "UserControlUsuarios";
            Size = new Size(609, 84);
            Load += UserControlUsuarios_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnPartner;
        private Panel panel2;
        private Label labelViews;
        private Label label1;
        private Panel panel3;
        private Label labelLikes;
        private Label label4;
        private Panel panel4;
        private Label labelUsername;
        private Label labelDonations;
        private Label label2;
    }
}
