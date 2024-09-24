namespace Trivia_de_Naturales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotenIniciar_Click(object sender, EventArgs e)
        {
            PrimeraPregunta PP = new PrimeraPregunta();
            PP.Show();
            this.Hide();
        }
    }
}
