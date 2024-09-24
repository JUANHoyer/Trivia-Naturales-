using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia_de_Naturales
{
    public partial class PrimeraPregunta : Form
    {
        public PrimeraPregunta()
        {
            InitializeComponent();
        }
        void respuestaBuena()
        {
            RespuestaC respuestaC = new RespuestaC();
            respuestaC.ShowDialog();
        }
        void respuestaMala()
        {
            RespuestaM respuestaM = new RespuestaM();
            respuestaM.ShowDialog();
        }
        private void Rcorrecta_Click(object sender, EventArgs e)
        {
            SegundaPregunta pp = new SegundaPregunta();
            pp.Show();
            this.Hide();
            respuestaBuena();
        }

        private void Rmal_Click(object sender, EventArgs e)
        {
            respuestaMala();
        }

        private void Rmal2_Click(object sender, EventArgs e)
        {
            respuestaMala();
        }
    }
}
