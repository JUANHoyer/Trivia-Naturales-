using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia_de_Naturales
{
    public partial class RespuestaC : Form
    {
        public RespuestaC()
        {
            InitializeComponent();
            ReproducirAudio();
           
        }
        string RutaAudio = "C:/sonidos/correcto.wav";

        private void ReproducirAudio()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = RutaAudio;
            player.Play();
        }
     
    }
}
