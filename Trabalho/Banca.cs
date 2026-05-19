using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho
{
    internal class Banca
    {
        private Jogador _dealer = null;

        public Banca(Carta x ,Carta y) 
        {
            this.Dealer = new Jogador(x , y);
           
        }

        public Jogador Dealer { get => _dealer; set => _dealer = value; }

    }
}
