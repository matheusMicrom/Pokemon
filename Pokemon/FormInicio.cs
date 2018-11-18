using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"..\..\..\pokemons.txt"))
            {
                File.Create(@"..\..\..\pokemons.txt");
            }
            if (!File.Exists(@"..\..\..\treinadores.txt"))
            {
                File.Create(@"..\..\..\treinadores.txt");
            }
            if (!File.Exists(@"..\..\..\relacao.txt"))
            {
                File.Create(@"..\..\..\relacao.txt");
            }
        }

        
        private void btnPokemons_Click(object sender, EventArgs e)
        {
            FormPokemons formPoke = new FormPokemons();
            formPoke.StartPosition = FormStartPosition.CenterScreen;
            formPoke.ShowDialog();
            
        }

        private void btnPokemons_Click_1(object sender, EventArgs e)
        {
            FormTreinadores formTrei = new FormTreinadores();
            formTrei.StartPosition = FormStartPosition.CenterScreen;
            formTrei.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRelacionaPokeTrei frpt = new FormRelacionaPokeTrei();
            frpt.ShowDialog();
        }

        private void bntTreinador_Click(object sender, EventArgs e)
        {
            FormLogarTreinador flt = new FormLogarTreinador();
            flt.ShowDialog();
        }
    }
}
