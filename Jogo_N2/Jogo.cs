using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Jogo_N2
{
    static class Jogo
    {
        static public string jogador;
        static public int pontuacao;        
        static public char dificuldade = 'f';
        static public SoundPlayer beep = new SoundPlayer();
        static public bool somLigado = true;
    }
}
