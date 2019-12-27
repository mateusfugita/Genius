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
    public partial class frConfiguracao : Form
    {
        public frConfiguracao()
        {
            InitializeComponent();            
            if (Jogo.somLigado == true)
            {
                btnSomOn.Enabled = false;
                btnSomOff.Enabled = true;
            }
            else
            {
                btnSomOn.Enabled = true;
                btnSomOff.Enabled = false;
            }
        }
                
        private void rdFacil_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFacil.Checked == true)
                Jogo.dificuldade = 'f';
            else if (rdMedio.Checked == true)
                Jogo.dificuldade = 'm';
            else if (rdDificil.Checked)
                Jogo.dificuldade = 'd';
        }

        private void frConfiguracao_Load(object sender, EventArgs e)
        {
            if (Jogo.dificuldade == 'f')
                rdFacil.Checked = true;
            else if (Jogo.dificuldade == 'm')
                rdMedio.Checked = true;
            else if (Jogo.dificuldade == 'd')
                rdDificil.Checked = true;
        }

        private void btnSomOff_Click(object sender, EventArgs e)
        {
            Jogo.somLigado = false;
            btnSomOff.Enabled = false;
            btnSomOn.Enabled = true;
        }

        private void btnSomOn_Click(object sender, EventArgs e)
        {
            Jogo.somLigado = true;
            btnSomOn.Enabled = false;
            btnSomOff.Enabled = true;
        }
    }
}
