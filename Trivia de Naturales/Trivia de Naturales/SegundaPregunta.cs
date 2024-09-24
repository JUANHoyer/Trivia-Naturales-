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
    public partial class SegundaPregunta : Form
    {
        public SegundaPregunta()
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
        private void Rmal1_Click(object sender, EventArgs e)
        {
            respuestaMala();
        }

        private void Rcorrecta_Click(object sender, EventArgs e)
        {
            respuestaBuena();
            this.Close();

        }

        private void Rmal2_Click(object sender, EventArgs e)
        {
            respuestaMala();
        }
    }
}
