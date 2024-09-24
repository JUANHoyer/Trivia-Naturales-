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
    public partial class RespuestaM : Form
    {
        public RespuestaM()
        {
            InitializeComponent();
            ReproducirAudio();
       
        }
        string RutaAudio = "C:/sonidos/incorrecto.wav";

        private void ReproducirAudio()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = RutaAudio;
            player.Play();
        }
    }
}
