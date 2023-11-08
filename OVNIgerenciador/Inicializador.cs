using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OVNIgerenciador
{
    public partial class Inicializador : Form
    {
        public Inicializador()
        {
            InitializeComponent();
        }

        private void lblTripulantes_Click(object sender, EventArgs e)
        {

        }

        private void Inicializador_Load(object sender, EventArgs e)
        {
            cmbPlaneta.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
        }

        private void btnInicializar_Click(object sender, EventArgs e)
        {
            //Obter as informações do form:
            int maxTripulantes = (int)nudTripulantes.Value;
            int maxAbduzidos = (int)nudAbduzidos.Value;
            string planetaOrigem = cmbPlaneta.Text;

            //Instanciar o OVNI:
            BibliotecaOVNI.OVNI ovni = new BibliotecaOVNI.OVNI(maxTripulantes, maxAbduzidos, planetaOrigem);

            //Instaciar a janela do painel:
            Painel janela = new Painel(ovni);
            //Abrir a janela:
            janela.ShowDialog();
        }
    }
}
