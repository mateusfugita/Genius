using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Jogo_N2
{
    public partial class frRecorde : Form
    {
        public frRecorde()
        {
            InitializeComponent();
        }

        public void Primeiro(List<Score> listaOrdenada)
        {
            lblN1.Text = listaOrdenada.ElementAt(0).Nome.ToString();
            lblP1.Text = listaOrdenada.ElementAt(0).Pontos.ToString();
            lblN1.Visible = true;
            lblP1.Visible = true;
        }

        public void Segundo(List<Score> listaOrdenada)
        {
            lblN2.Text = listaOrdenada.ElementAt(1).Nome.ToString();
            lblP2.Text = listaOrdenada.ElementAt(1).Pontos.ToString();
            lblN2.Visible = true;
            lblP2.Visible = true;
        }

        public void Terceiro(List<Score> listaOrdenada)
        {
            lblN3.Text = listaOrdenada.ElementAt(2).Nome.ToString();
            lblN3.Visible = true;
            lblP3.Text = listaOrdenada.ElementAt(2).Pontos.ToString();
            lblP3.Visible = true;
        }

        public void Quarto(List<Score> listaOrdenada)
        {
            lblN4.Text = listaOrdenada.ElementAt(3).Nome.ToString();
            lblN4.Visible = true;
            lblP4.Text = listaOrdenada.ElementAt(3).Pontos.ToString();
            lblP4.Visible = true;
        }

        public void Quinto(List<Score> listaOrdenada)
        {
            lblN5.Text = listaOrdenada.ElementAt(4).Nome.ToString();
            lblN5.Visible = true;
            lblP5.Text = listaOrdenada.ElementAt(4).Pontos.ToString();
            lblP5.Visible = true;
        }

        private void frRecorde_Load(object sender, EventArgs e)
        {
            if (File.Exists("jogadores.txt"))
            {
                List<Score> pontuacoes = new List<Score> { };
                string[] linhas = File.ReadAllLines("jogadores.txt");

                foreach (string linha in linhas)
                {
                    try
                    {
                        string[] informacoes = linha.Split('|');
                        Score pontuacao = new Score();
                        pontuacao.Nome = informacoes[0];
                        pontuacao.Pontos = int.Parse(informacoes[1]);
                        pontuacoes.Add(pontuacao);
                    }
                    catch
                    {
                        MessageBox.Show("Erro");
                    }

                }

                List<Score> listaordenada = pontuacoes.OrderBy(x => x.Pontos).Reverse().ToList();
                                               

                if (listaordenada.Count == 1)
                {
                    Primeiro(listaordenada);
                }
                else if (listaordenada.Count == 2)
                {
                    Primeiro(listaordenada);
                    Segundo(listaordenada);
                }
                else if (listaordenada.Count == 3)
                {
                    Primeiro(listaordenada);
                    Segundo(listaordenada);
                    Terceiro(listaordenada);
                }
                else if (listaordenada.Count == 4)
                {
                    Primeiro(listaordenada);
                    Segundo(listaordenada);
                    Terceiro(listaordenada);
                    Quarto(listaordenada);                    
                }
                else if (listaordenada.Count >= 5)
                {
                    Primeiro(listaordenada);
                    Segundo(listaordenada);
                    Terceiro(listaordenada);
                    Quarto(listaordenada);
                    Quinto(listaordenada);
                }
                
            }
            else
            {
                MessageBox.Show("Não há nenhum cadastro");
                this.Close();
            }
        }
    }
}
