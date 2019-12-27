using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Jogo_N2
{
    public partial class frPrincipal : Form
    {
        public frPrincipal()
        {
            InitializeComponent();            
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            frSobre sobre = new frSobre();
            sobre.ShowDialog();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            frConfiguracao configuracao = new frConfiguracao();
            configuracao.ShowDialog();
        }

        private void btnComoJogar_Click(object sender, EventArgs e)
        {
            frComoJogar comoJogar = new frComoJogar();
            comoJogar.ShowDialog();
        }

        private void btnRecorde_Click(object sender, EventArgs e)
        {
            frRecorde recordes = new frRecorde();
            recordes.ShowDialog();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            frCadastrar cadastrar = new frCadastrar();
            cadastrar.ShowDialog();
        }
    }
}
