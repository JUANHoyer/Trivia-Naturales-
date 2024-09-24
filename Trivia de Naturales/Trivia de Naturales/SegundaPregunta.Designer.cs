namespace Trivia_de_Naturales
{
    partial class SegundaPregunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SegundaPregunta));
            Rmal2 = new Button();
            Rcorrecta = new Button();
            Rmal1 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Rmal2
            // 
            Rmal2.BackColor = SystemColors.GradientActiveCaption;
            Rmal2.Location = new Point(700, 412);
            Rmal2.Name = "Rmal2";
            Rmal2.Size = new Size(116, 35);
            Rmal2.TabIndex = 13;
            Rmal2.Text = "Romero";
            Rmal2.UseVisualStyleBackColor = false;
            Rmal2.Click += Rmal2_Click;
            // 
            // Rcorrecta
            // 
            Rcorrecta.BackColor = SystemColors.GradientActiveCaption;
            Rcorrecta.Location = new Point(508, 412);
            Rcorrecta.Name = "Rcorrecta";
            Rcorrecta.Size = new Size(110, 35);
            Rcorrecta.TabIndex = 12;
            Rcorrecta.Text = "Petunias";
            Rcorrecta.UseVisualStyleBackColor = false;
            Rcorrecta.Click += Rcorrecta_Click;
            // 
            // Rmal1
            // 
            Rmal1.BackColor = SystemColors.GradientActiveCaption;
            Rmal1.Location = new Point(286, 412);
            Rmal1.Name = "Rmal1";
            Rmal1.Size = new Size(130, 35);
            Rmal1.TabIndex = 11;
            Rmal1.Text = "Rosa de Alabastro";
            Rmal1.UseVisualStyleBackColor = false;
            Rmal1.Click += Rmal1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(978, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-30, 396);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1149, 270);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(391, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 247);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 17F);
            label1.Location = new Point(431, 41);
            label1.Name = "label1";
            label1.Size = new Size(260, 28);
            label1.TabIndex = 7;
            label1.Text = "¿Cual es esta Planta?";
            // 
            // SegundaPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 593);
            Controls.Add(Rmal2);
            Controls.Add(Rcorrecta);
            Controls.Add(Rmal1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "SegundaPregunta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SegundaPregunta";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Rmal2;
        private Button Rcorrecta;
        private Button Rmal1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
    }
}