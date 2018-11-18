using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class FormLogarTreinador : Form
    {
        Treinador treinadores = new Treinador();
        public FormLogarTreinador()
        {
            InitializeComponent();
        }

        private void btnescolha_Click(object sender, EventArgs e)
        {
            FormTreinadorPokes ftp = new FormTreinadorPokes();
            ftp.ShowDialog();
        }

        private void FormLogarTreinador_Load(object sender, EventArgs e)
        {   
            // Carrega a lista de treinadores no List Box
            List<Treinador> listaTreinadores = new List<Treinador>();
            listaTreinadores = treinadores.criaListaTreinadores();
            string[] nomes = new string[listaTreinadores.Count];

            for (int i = 0; i < listaTreinadores.Count(); i++)
            {
                nomes[i] = listaTreinadores[i].Nome;
            }           
            listBTreinadores.Items.AddRange(nomes);
        }

       
    }
}
