namespace DonacionesCreadores
{
    partial class CommentsForm
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
            label1 = new Label();
            flowContainerComments = new FlowLayoutPanel();
            textBoxAddComment = new RichTextBox();
            btnAddComment = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(161, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 30);
            label1.TabIndex = 0;
            label1.Text = "Comentarios";
            // 
            // flowContainerComments
            // 
            flowContainerComments.AutoScroll = true;
            flowContainerComments.FlowDirection = FlowDirection.TopDown;
            flowContainerComments.Location = new Point(12, 42);
            flowContainerComments.Name = "flowContainerComments";
            flowContainerComments.Size = new Size(452, 369);
            flowContainerComments.TabIndex = 1;
            // 
            // textBoxAddComment
            // 
            textBoxAddComment.Location = new Point(12, 417);
            textBoxAddComment.Name = "textBoxAddComment";
            textBoxAddComment.Size = new Size(313, 71);
            textBoxAddComment.TabIndex = 2;
            textBoxAddComment.Text = "Agregar comentario...";
            // 
            // btnAddComment
            // 
            btnAddComment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddComment.ForeColor = Color.DarkOrange;
            btnAddComment.Location = new Point(331, 426);
            btnAddComment.Name = "btnAddComment";
            btnAddComment.Size = new Size(133, 45);
            btnAddComment.TabIndex = 3;
            btnAddComment.Text = "Agregar";
            btnAddComment.UseVisualStyleBackColor = true;
            btnAddComment.Click += btnAddComment_Click;
            // 
            // CommentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(476, 493);
            Controls.Add(btnAddComment);
            Controls.Add(textBoxAddComment);
            Controls.Add(flowContainerComments);
            Controls.Add(label1);
            Name = "CommentsForm";
            Text = "Comentarios";
            Load += CommentsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowContainerComments;
        private RichTextBox textBoxAddComment;
        private Button btnAddComment;
    }
}