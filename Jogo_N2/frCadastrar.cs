using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_N2
{
    public partial class frCadastrar : Form
    {
        public frCadastrar()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {            
            if (txtNome.Text.Trim().Length == 0)
            {                
                MessageBox.Show("Digite alguma coisa");
                return;
            }
            
            Jogo.jogador = txtNome.Text;

            if (Jogo.dificuldade == 'f')
            {
                this.Hide();
                frFacil facil = new frFacil();
                facil.ShowDialog();
            }
            else if (Jogo.dificuldade == 'm')
            {
                this.Hide();
                frMedio medio = new frMedio();
                medio.ShowDialog();
            }
            else if (Jogo.dificuldade == 'd')
            {
                this.Hide();
                frDificil dificil = new frDificil();
                dificil.ShowDialog();
            }
        }
    }
}
