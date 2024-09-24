namespace Trivia_de_Naturales
{
    partial class PrimeraPregunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimeraPregunta));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            Rcorrecta = new Button();
            Rmal = new Button();
            Rmal2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 17F);
            label1.Location = new Point(418, 52);
            label1.Name = "label1";
            label1.Size = new Size(267, 28);
            label1.TabIndex = 0;
            label1.Text = "¿Cual es este Animal?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(392, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 247);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-29, 387);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1149, 270);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(980, 29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // Rcorrecta
            // 
            Rcorrecta.BackColor = SystemColors.GradientActiveCaption;
            Rcorrecta.Location = new Point(320, 409);
            Rcorrecta.Name = "Rcorrecta";
            Rcorrecta.Size = new Size(97, 35);
            Rcorrecta.TabIndex = 4;
            Rcorrecta.Text = "Ajolote";
            Rcorrecta.UseVisualStyleBackColor = false;
            Rcorrecta.Click += Rcorrecta_Click;
            // 
            // Rmal
            // 
            Rmal.BackColor = SystemColors.GradientActiveCaption;
            Rmal.Location = new Point(506, 409);
            Rmal.Name = "Rmal";
            Rmal.Size = new Size(110, 35);
            Rmal.TabIndex = 5;
            Rmal.Text = "Iguana";
            Rmal.UseVisualStyleBackColor = false;
            Rmal.Click += Rmal_Click;
            // 
            // Rmal2
            // 
            Rmal2.BackColor = SystemColors.GradientActiveCaption;
            Rmal2.Location = new Point(711, 409);
            Rmal2.Name = "Rmal2";
            Rmal2.Size = new Size(116, 35);
            Rmal2.TabIndex = 6;
            Rmal2.Text = "Camaleon";
            Rmal2.UseVisualStyleBackColor = false;
            Rmal2.Click += Rmal2_Click;
            // 
            // PrimeraPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 593);
            Controls.Add(Rmal2);
            Controls.Add(Rmal);
            Controls.Add(Rcorrecta);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "PrimeraPregunta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrimeraPregunta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button Rcorrecta;
        private Button Rmal;
        private Button Rmal2;
    }
}