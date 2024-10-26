namespace DonacionesCreadores
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            containerForm = new FlowLayoutPanel();
            containerLogin = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textEmail = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            textPassword = new TextBox();
            pictureBox3 = new PictureBox();
            btnLogin = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label5 = new Label();
            labelRegister = new Label();
            containerForm.SuspendLayout();
            containerLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // containerForm
            // 
            containerForm.Controls.Add(containerLogin);
            containerForm.Controls.Add(pictureBox1);
            containerForm.Dock = DockStyle.Fill;
            containerForm.Location = new Point(0, 0);
            containerForm.Name = "containerForm";
            containerForm.Size = new Size(722, 442);
            containerForm.TabIndex = 0;
            // 
            // containerLogin
            // 
            containerLogin.Controls.Add(label1);
            containerLogin.Controls.Add(label2);
            containerLogin.Controls.Add(label3);
            containerLogin.Controls.Add(flowLayoutPanel1);
            containerLogin.Controls.Add(label4);
            containerLogin.Controls.Add(flowLayoutPanel2);
            containerLogin.Controls.Add(btnLogin);
            containerLogin.Controls.Add(flowLayoutPanel3);
            containerLogin.FlowDirection = FlowDirection.TopDown;
            containerLogin.Location = new Point(3, 3);
            containerLogin.Name = "containerLogin";
            containerLogin.Padding = new Padding(50, 40, 50, 40);
            containerLogin.Size = new Size(333, 439);
            containerLogin.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Influencer_Marketing;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(342, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 439);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(53, 40);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(219, 50);
            label1.TabIndex = 0;
            label1.Text = "Apoya a tus influencers favoritos ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(53, 90);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 10, 0, 10);
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(219, 45);
            label2.TabIndex = 1;
            label2.Text = "Iniciar sesion";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 135);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 2;
            label3.Text = "Correo";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(textEmail);
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Location = new Point(53, 155);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(219, 31);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // textEmail
            // 
            textEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textEmail.Location = new Point(3, 3);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(175, 23);
            textEmail.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.correo_electronico;
            pictureBox2.Location = new Point(184, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 189);
            label4.Name = "label4";
            label4.Size = new Size(77, 17);
            label4.TabIndex = 4;
            label4.Text = "Contrasena";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(textPassword);
            flowLayoutPanel2.Controls.Add(pictureBox3);
            flowLayoutPanel2.Location = new Point(53, 209);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(219, 31);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // textPassword
            // 
            textPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textPassword.Location = new Point(3, 3);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(175, 23);
            textPassword.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password;
            pictureBox3.Location = new Point(184, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.FromArgb(255, 128, 0);
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(53, 273);
            btnLogin.Margin = new Padding(3, 30, 3, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(219, 51);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Iniciar sesion";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel3.Controls.Add(label5);
            flowLayoutPanel3.Controls.Add(labelRegister);
            flowLayoutPanel3.Location = new Point(53, 330);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(0, 15, 0, 0);
            flowLayoutPanel3.Size = new Size(219, 50);
            flowLayoutPanel3.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(3, 15);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 8;
            label5.Text = "No tienes una cuenta?";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRegister.ForeColor = Color.FromArgb(255, 128, 0);
            labelRegister.Location = new Point(130, 15);
            labelRegister.Margin = new Padding(0);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(81, 20);
            labelRegister.TabIndex = 9;
            labelRegister.Text = "Regsitrate";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 442);
            Controls.Add(containerForm);
            Name = "LoginForm";
            Text = "Iniciar sesion";
            Load += Form1_Load;
            containerForm.ResumeLayout(false);
            containerLogin.ResumeLayout(false);
            containerLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel containerForm;
        private FlowLayoutPanel containerLogin;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textEmail;
        private PictureBox pictureBox2;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox textPassword;
        private PictureBox pictureBox3;
        private Button btnLogin;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label5;
        private Label labelRegister;
    }
}
