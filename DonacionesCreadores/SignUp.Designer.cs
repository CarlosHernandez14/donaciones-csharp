namespace DonacionesCreadores
{
    partial class SignUp
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
            containerForm = new FlowLayoutPanel();
            containerLogin = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            fieldEmail = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            fieldPassword = new TextBox();
            pictureBox3 = new PictureBox();
            btnRegister = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label5 = new Label();
            btnLogin = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            fieldName = new TextBox();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            fieldConfirmPassword = new TextBox();
            pictureBox5 = new PictureBox();
            label7 = new Label();
            comboInfluencer = new ComboBox();
            label8 = new Label();
            containerForm.SuspendLayout();
            containerLogin.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // containerForm
            // 
            containerForm.Controls.Add(containerLogin);
            containerForm.Controls.Add(pictureBox1);
            containerForm.Dock = DockStyle.Fill;
            containerForm.Location = new Point(0, 0);
            containerForm.Name = "containerForm";
            containerForm.Size = new Size(713, 577);
            containerForm.TabIndex = 1;
            // 
            // containerLogin
            // 
            containerLogin.Controls.Add(label1);
            containerLogin.Controls.Add(label2);
            containerLogin.Controls.Add(label6);
            containerLogin.Controls.Add(flowLayoutPanel4);
            containerLogin.Controls.Add(label3);
            containerLogin.Controls.Add(flowLayoutPanel1);
            containerLogin.Controls.Add(label4);
            containerLogin.Controls.Add(flowLayoutPanel2);
            containerLogin.Controls.Add(label7);
            containerLogin.Controls.Add(flowLayoutPanel5);
            containerLogin.Controls.Add(label8);
            containerLogin.Controls.Add(comboInfluencer);
            containerLogin.Controls.Add(btnRegister);
            containerLogin.Controls.Add(flowLayoutPanel3);
            containerLogin.FlowDirection = FlowDirection.TopDown;
            containerLogin.Location = new Point(3, 3);
            containerLogin.Name = "containerLogin";
            containerLogin.Padding = new Padding(50, 40, 50, 40);
            containerLogin.Size = new Size(333, 574);
            containerLogin.TabIndex = 0;
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
            label3.Location = new Point(53, 189);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 2;
            label3.Text = "Correo";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(fieldEmail);
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Location = new Point(53, 209);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(219, 31);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // fieldEmail
            // 
            fieldEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fieldEmail.Location = new Point(3, 3);
            fieldEmail.Name = "fieldEmail";
            fieldEmail.Size = new Size(175, 23);
            fieldEmail.TabIndex = 0;
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
            label4.Location = new Point(53, 243);
            label4.Name = "label4";
            label4.Size = new Size(77, 17);
            label4.TabIndex = 4;
            label4.Text = "Contrasena";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(fieldPassword);
            flowLayoutPanel2.Controls.Add(pictureBox3);
            flowLayoutPanel2.Location = new Point(53, 263);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(219, 31);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // fieldPassword
            // 
            fieldPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fieldPassword.Location = new Point(3, 3);
            fieldPassword.Name = "fieldPassword";
            fieldPassword.Size = new Size(175, 23);
            fieldPassword.TabIndex = 0;
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
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegister.BackColor = Color.FromArgb(255, 128, 0);
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(53, 417);
            btnRegister.Margin = new Padding(3, 20, 3, 3);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(219, 51);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Crear cuenta";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel3.Controls.Add(label5);
            flowLayoutPanel3.Controls.Add(btnLogin);
            flowLayoutPanel3.Location = new Point(53, 474);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(0, 15, 0, 0);
            flowLayoutPanel3.Size = new Size(219, 53);
            flowLayoutPanel3.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(3, 15);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 8;
            label5.Text = "Ya tienes una cuenta?";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(255, 128, 0);
            btnLogin.Location = new Point(0, 30);
            btnLogin.Margin = new Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 20);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Inicia sesion";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Influencer_Marketing;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(342, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 574);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel4.Controls.Add(fieldName);
            flowLayoutPanel4.Controls.Add(pictureBox4);
            flowLayoutPanel4.Location = new Point(53, 155);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(219, 31);
            flowLayoutPanel4.TabIndex = 8;
            // 
            // fieldName
            // 
            fieldName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fieldName.Location = new Point(3, 3);
            fieldName.Name = "fieldName";
            fieldName.Size = new Size(175, 23);
            fieldName.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.password;
            pictureBox4.Location = new Point(184, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(53, 135);
            label6.Name = "label6";
            label6.Size = new Size(58, 17);
            label6.TabIndex = 9;
            label6.Text = "Nombre";
            label6.Click += label6_Click;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel5.Controls.Add(fieldConfirmPassword);
            flowLayoutPanel5.Controls.Add(pictureBox5);
            flowLayoutPanel5.Location = new Point(53, 317);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(219, 31);
            flowLayoutPanel5.TabIndex = 10;
            // 
            // fieldConfirmPassword
            // 
            fieldConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fieldConfirmPassword.Location = new Point(3, 3);
            fieldConfirmPassword.Name = "fieldConfirmPassword";
            fieldConfirmPassword.Size = new Size(175, 23);
            fieldConfirmPassword.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.password;
            pictureBox5.Location = new Point(184, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 23);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(53, 297);
            label7.Name = "label7";
            label7.Size = new Size(143, 17);
            label7.TabIndex = 11;
            label7.Text = "Confirmar Contrasena";
            // 
            // comboInfluencer
            // 
            comboInfluencer.FormattingEnabled = true;
            comboInfluencer.Items.AddRange(new object[] { "Usuario", "CreadorContenido" });
            comboInfluencer.Location = new Point(53, 371);
            comboInfluencer.Name = "comboInfluencer";
            comboInfluencer.Size = new Size(219, 23);
            comboInfluencer.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(53, 351);
            label8.Name = "label8";
            label8.Size = new Size(105, 17);
            label8.TabIndex = 13;
            label8.Text = "Eres influencer?";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(713, 577);
            Controls.Add(containerForm);
            Name = "SignUp";
            Text = "SignUp";
            containerForm.ResumeLayout(false);
            containerLogin.ResumeLayout(false);
            containerLogin.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel containerForm;
        private FlowLayoutPanel containerLogin;
        private Label label1;
        private Label label6;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel4;
        private TextBox fieldName;
        private PictureBox pictureBox4;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox fieldEmail;
        private PictureBox pictureBox2;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox fieldPassword;
        private PictureBox pictureBox3;
        private Button btnRegister;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label5;
        private Label btnLogin;
        private PictureBox pictureBox1;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanel5;
        private TextBox fieldConfirmPassword;
        private PictureBox pictureBox5;
        private ComboBox comboInfluencer;
        private Label label8;
    }
}