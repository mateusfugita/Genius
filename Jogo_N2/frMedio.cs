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
    public partial class frMedio : Form
    {
        public int[] cores = new int[50]; //Sequência máxima de cores
        public int corAtual = 0; //Cor que está piscando no momento
        public int ultimaAtual = 0; //Última cor da sequência atual
        public int maxAmarelo = 415, maxAzul = 415, maxVerde = 158, maxVermelho = 158;
        public int minAmarelo = 285, minAzul = 285, minVerde = 0, minVermelho = 0;

        public frMedio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sorteia as cores
        /// </summary>
        public void Sortear()
        {
            int i = 1;
            Random sorteio = new Random();
            cores[0] = sorteio.Next(1, 5);
            
            while (i < cores.Length)
            {                
                int numeroSorteado = sorteio.Next(1, 5);
                if (numeroSorteado != cores[i - 1])
                {
                    cores[i] = numeroSorteado;
                    i++;
                }
            }

            corAtual = 0;
            lblPontuacao.Focus();
            timer1.Enabled = true;
            tmrMovimento.Enabled = true;
        }

        /// <summary>
        /// Verifica se o jogador está acertando ou não
        /// </summary>
        /// <param name="corPressionada"></param>
        public void HoraDeClicar(int corPressionada)
        {
            if (corPressionada != cores[corAtual]) //Perdeu
            {
                tmrMovimento.Enabled = false;
                MessageBox.Show("Você perdeu! Sua pontuação foi de " + lblPontuacao.Text + " pontos.");
                Jogo.pontuacao = Convert.ToInt32(lblPontuacao.Text);
                string conteudo = Jogo.jogador + "|" + Jogo.pontuacao + Environment.NewLine;
                File.AppendAllText("jogadores.txt", conteudo);
                ultimaAtual = 0;
                btnAmarelo.Enabled = false;
                btnAzul.Enabled = false;
                btnVerde.Enabled = false;
                btnVermelho.Enabled = false;
                this.Close();

            }
            else if (corPressionada == cores[corAtual] && corAtual < ultimaAtual) //Ainda não terminou a sequência
            {
                corAtual++;
            }
            else if (corPressionada == cores[corAtual] && corAtual >= ultimaAtual)
            {
                if (corPressionada == cores[corAtual] && corAtual + 1 == 50) //Venceu tudo
                {
                    tmrMovimento.Enabled = false;
                    MessageBox.Show("Parabéns! Você venceu!");
                    Jogo.pontuacao = Convert.ToInt32(lblPontuacao.Text);
                    string conteudo = Jogo.jogador + "|" + Jogo.pontuacao + Environment.NewLine;
                    File.AppendAllText("jogadores.txt", conteudo);
                    ultimaAtual = 0;
                    btnAmarelo.Enabled = false;
                    btnAzul.Enabled = false;
                    btnVerde.Enabled = false;
                    btnVermelho.Enabled = false;
                    this.Close();
                }
                else //Venceu essa sequência
                {
                    ultimaAtual++;
                    corAtual = 0;
                    timer1.Enabled = true;
                }
            }

            lblPontuacao.Text = (2 * ultimaAtual).ToString();
        }

        public void Som()
        {
            if (Jogo.somLigado == true)
                Jogo.beep.Play();
        }

        /// <summary>
        /// Piscar as cores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            btnAmarelo.Enabled = false;
            btnAzul.Enabled = false;
            btnVerde.Enabled = false;
            btnVermelho.Enabled = false;

            btnAmarelo.BackColor = Color.Yellow;
            btnAzul.BackColor = Color.Blue;
            btnVerde.BackColor = Color.Green;
            btnVermelho.BackColor = Color.Red;
            lblPontuacao.Focus();

            //responder
            if (corAtual > ultimaAtual)
            {
                btnAmarelo.Enabled = true;
                btnAzul.Enabled = true;
                btnVerde.Enabled = true;
                btnVermelho.Enabled = true;
                corAtual = 0;
                timer1.Enabled = false;
            }
            //continuar piscando
            else
            {
                switch (cores[corAtual])
                {
                    case 1:
                        {
                            btnAmarelo.BackColor = Color.FromArgb(192, 192, 0);
                            Som();
                            break;
                        }
                    case 2:
                        {
                            btnAzul.BackColor = Color.Navy;
                            Som();
                            break;
                        }
                    case 3:
                        {
                            btnVerde.BackColor = Color.DarkGreen;
                            Som();
                            break;
                        }
                    case 4:
                        {
                            btnVermelho.BackColor = Color.DarkRed;
                            Som();
                            break;
                        }
                }
                corAtual++;
            }
        }

        private void btnAmarelo_MouseDown(object sender, MouseEventArgs e)
        {
            btnAmarelo.BackColor = Color.FromArgb(192, 192, 0);
            Som();
        }

        private void btnAmarelo_MouseUp(object sender, MouseEventArgs e)
        {
            btnAmarelo.BackColor = Color.Yellow;
            HoraDeClicar(1);
        }

        private void btnVermelho_MouseDown(object sender, MouseEventArgs e)
        {
            btnVermelho.BackColor = Color.DarkRed;
            Som();
        }
                
        private void btnVermelho_MouseUp(object sender, MouseEventArgs e)
        {
            btnVermelho.BackColor = Color.Red;
            HoraDeClicar(4);
        }               

        private void btnAzul_MouseDown(object sender, MouseEventArgs e)
        {
            btnAzul.BackColor = Color.Navy;
            Som();
        }

        private void frMedio_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            tmrMovimento.Enabled = false;
        }

        private void btnAzul_MouseUp(object sender, MouseEventArgs e)
        {
            btnAzul.BackColor = Color.Blue;
            HoraDeClicar(2);
        }

        private void btnVerde_MouseDown(object sender, MouseEventArgs e)
        {
            btnVerde.BackColor = Color.DarkGreen;
            Som();
        }

        private void btnVerde_MouseUp(object sender, MouseEventArgs e)
        {
            btnVerde.BackColor = Color.Green;
            HoraDeClicar(3);
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            btnComecar.Enabled = false;
            btnComecar.Visible = false;
            lblPontuacao.Focus();

            Sortear();
        }

        /// <summary>
        /// Movimenta os botões
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrMovimento_Tick(object sender, EventArgs e)
        {
            //Movimenta amarelo
            if (btnAmarelo.Left >= 285)
            {
                if (btnAmarelo.Left == maxAmarelo)
                {
                    if (maxAmarelo == minAmarelo)
                    {
                        maxAmarelo = 415;
                    }
                    else
                    {
                        btnAmarelo.Left -= 1;
                        maxAmarelo -= 1;
                    }
                }
                else
                {
                    btnAmarelo.Left += 1;
                }
            }
            else
                btnAmarelo.Left = 285;

            //Movimenta azul
            if (btnAzul.Left >= 285)
            {
                if (btnAzul.Left == maxAzul)
                {
                    if (maxAzul == minAzul)
                    {
                        maxAzul = 415;
                    }
                    else
                    {
                        btnAzul.Left -= 1;
                        maxAzul -= 1;
                    }
                }
                else
                {
                    btnAzul.Left += 1;
                }
            }
            else
                btnAzul.Left = 285;

            //Movimenta vermelho
            if (btnVermelho.Left >= 0)
            {
                if (btnVermelho.Left == maxVermelho)
                {
                    if (maxVermelho == minVermelho)
                    {
                        maxVermelho = 158;
                    }
                    else
                    {
                        btnVermelho.Left -= 1;
                        maxVermelho -= 1;
                    }
                }
                else
                {
                    btnVermelho.Left += 1;
                }
            }
            else
                btnVermelho.Left = 158;

            //Movimenta verde
            if (btnVerde.Left >= 0)
            {
                if (btnVerde.Left == maxVerde)
                {
                    if (maxVerde == minVerde)
                    {
                        maxVerde = 158;
                    }
                    else
                    {
                        btnVerde.Left -= 1;
                        maxVerde -= 1;
                    }
                }
                else
                {
                    btnVerde.Left += 1;
                }
            }
            else
                btnVerde.Left = 158;
        }

        private void frMedio_Load(object sender, EventArgs e)
        {
            Jogo.beep.SoundLocation = "Beep.wav";
            Jogo.beep.Load();
        }
    }
}
