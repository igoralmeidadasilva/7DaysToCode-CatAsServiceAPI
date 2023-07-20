using model;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            controlMeusFavoritos.Visible = false;
            controlBuscarRacas.Visible = false;
        }

        private void buttonBuscarRaca_Click(object sender, EventArgs e)
        {
            controlMeusFavoritos.Visible = false;
            controlBuscarRacas.Visible = true;
        }

        private void buttonMeusFavoritos_Click(object sender, EventArgs e)
        {
            controlBuscarRacas.Visible = false;
            controlMeusFavoritos.Visible = true;
            controlMeusFavoritos.refreshFavortios();
        }
    }
}