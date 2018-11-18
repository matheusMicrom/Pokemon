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
    public partial class FormTreinadores : Form
    {
        Treinador coach = new Treinador();

        public FormTreinadores()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormTreinadorCadastro formTreinadorCadastro = new FormTreinadorCadastro();
            formTreinadorCadastro.StartPosition = FormStartPosition.CenterScreen;
            formTreinadorCadastro.ShowDialog();
        }

        //private void MostraNoDataGrid(List<Treinador> mostraCoach)
        //{
        //    // Limpa o que existe no data grid view
        //    dataGridView1.DataSource = null;
        //    // Mostra o que tem no list no dataGridView
        //    dataGridView1.DataSource = mostraCoach;

        //    // For para mostrar as colunas de editar e excluir
        //    for (int i = 0; i < dataGridView1.RowCount; i++)
        //    {
        //        dataGridView1.Rows[i].Cells[0].Value = "Editar";
        //        dataGridView1.Rows[i].Cells[1].Value = "Excluir";

        //    }
        //    dataGridView1.ClearSelection();

        //}
    }
}
