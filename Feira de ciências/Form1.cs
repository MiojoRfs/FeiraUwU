using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feira_de_ciências
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_iniciar_Click(object sender, EventArgs e)
        {
          this.Hide();
            Tela_Perguntas Telaperg = new Tela_Perguntas();
            Telaperg.Show();
        }
    }
}
