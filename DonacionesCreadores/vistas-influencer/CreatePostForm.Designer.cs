namespace DonacionesCreadores.vistas_influencer
{
    partial class CreatePostForm
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            labelTittle = new Label();
            fieldTittle = new TextBox();
            label2 = new Label();
            fieldDescripcion = new TextBox();
            label3 = new Label();
            btnSelectFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBoxPreview = new PictureBox();
            btnCancelar = new Button();
            btnAddContent = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 30);
            label1.Name = "label1";
            label1.Size = new Size(170, 30);
            label1.TabIndex = 0;
            label1.Text = "Crear contenido";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.icon_profile_big;
            pictureBox1.Location = new Point(41, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelTittle
            // 
            labelTittle.AutoSize = true;
            labelTittle.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold);
            labelTittle.Location = new Point(22, 156);
            labelTittle.Name = "labelTittle";
            labelTittle.Size = new Size(46, 19);
            labelTittle.TabIndex = 2;
            labelTittle.Text = "Titulo";
            // 
            // fieldTittle
            // 
            fieldTittle.Location = new Point(176, 145);
            fieldTittle.Multiline = true;
            fieldTittle.Name = "fieldTittle";
            fieldTittle.Size = new Size(247, 41);
            fieldTittle.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold);
            label2.Location = new Point(22, 223);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 4;
            label2.Text = "Descripion";
            // 
            // fieldDescripcion
            // 
            fieldDescripcion.Location = new Point(176, 211);
            fieldDescripcion.Multiline = true;
            fieldDescripcion.Name = "fieldDescripcion";
            fieldDescripcion.ScrollBars = ScrollBars.Vertical;
            fieldDescripcion.Size = new Size(247, 41);
            fieldDescripcion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold);
            label3.Location = new Point(22, 292);
            label3.Name = "label3";
            label3.Size = new Size(153, 19);
            label3.TabIndex = 6;
            label3.Text = "Selecciona una imagen";
            // 
            // btnSelectFile
            // 
            btnSelectFile.Cursor = Cursors.Hand;
            btnSelectFile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectFile.ForeColor = Color.DarkOrange;
            btnSelectFile.Location = new Point(226, 282);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(164, 36);
            btnSelectFile.TabIndex = 7;
            btnSelectFile.Text = "Seleccionar";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.Location = new Point(22, 336);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(225, 158);
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPreview.TabIndex = 8;
            pictureBoxPreview.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(126, 527);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 36);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAddContent
            // 
            btnAddContent.BackColor = Color.DarkOrange;
            btnAddContent.Cursor = Cursors.Hand;
            btnAddContent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddContent.ForeColor = Color.White;
            btnAddContent.Location = new Point(233, 527);
            btnAddContent.Name = "btnAddContent";
            btnAddContent.Size = new Size(190, 36);
            btnAddContent.TabIndex = 10;
            btnAddContent.Text = "Agregar contenido";
            btnAddContent.UseVisualStyleBackColor = false;
            btnAddContent.Click += btnAddContent_Click;
            // 
            // CreatePostForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(438, 575);
            Controls.Add(btnAddContent);
            Controls.Add(btnCancelar);
            Controls.Add(pictureBoxPreview);
            Controls.Add(btnSelectFile);
            Controls.Add(label3);
            Controls.Add(fieldDescripcion);
            Controls.Add(label2);
            Controls.Add(fieldTittle);
            Controls.Add(labelTittle);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "CreatePostForm";
            Text = "CreatePostForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label labelTittle;
        private TextBox fieldTittle;
        private Label label2;
        private TextBox fieldDescripcion;
        private Label label3;
        private Button btnSelectFile;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBoxPreview;
        private Button btnCancelar;
        private Button btnAddContent;
    }
}