﻿namespace Trivia_de_Naturales
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TextoBienvenida = new Label();
            pictureBox1 = new PictureBox();
            BotenIniciar = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // TextoBienvenida
            // 
            TextoBienvenida.AutoSize = true;
            TextoBienvenida.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            TextoBienvenida.Location = new Point(424, 78);
            TextoBienvenida.Name = "TextoBienvenida";
            TextoBienvenida.Size = new Size(243, 31);
            TextoBienvenida.TabIndex = 0;
            TextoBienvenida.Text = "Ciencias Naturales ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(361, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BotenIniciar
            // 
            BotenIniciar.BackColor = SystemColors.GradientActiveCaption;
            BotenIniciar.Font = new Font("Arial", 12F);
            BotenIniciar.Location = new Point(491, 410);
            BotenIniciar.Name = "BotenIniciar";
            BotenIniciar.Size = new Size(110, 42);
            BotenIniciar.TabIndex = 2;
            BotenIniciar.Text = "Iniciar Trivia";
            BotenIniciar.UseVisualStyleBackColor = false;
            BotenIniciar.Click += BotenIniciar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(953, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(135, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-31, 394);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1156, 259);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.MenuBar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 593);
            Controls.Add(pictureBox2);
            Controls.Add(BotenIniciar);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(TextoBienvenida);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trivia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextoBienvenida;
        private PictureBox pictureBox1;
        private Button BotenIniciar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
