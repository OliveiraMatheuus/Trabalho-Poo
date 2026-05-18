using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho
{
    internal class Jogador
    {
        private List<Carta> mao = null;
        private int _pontos = 0;

        public Jogador() 
        {
            this.Pontos = 0;
            this.Mao = new List<Carta>();
        }

        public void pontuar()
        {
            int pontos_aux = 0;
            foreach (Carta carta in Mao)
            {
                if (carta.Name == "A" && this.Pontos <= 21)
                {
                    pontos_aux += 11;
                }
                else if (carta.Name == "A" && this.Pontos > 21)
                {
                    pontos_aux += 1;
                }
                else if (carta.Name == "J" || carta.Name == "Q" || carta.Name == "K")
                {
                    pontos_aux += carta.Value;
                }
                else
                {
                    pontos_aux += carta.Value;
                }
            }
            this.Pontos = pontos_aux;
        }

        public List<Carta> Mao { get => mao; set => mao = value; }
        public int Pontos { get => _pontos; set => _pontos = value; }

    }
}
