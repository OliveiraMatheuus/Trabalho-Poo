using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho
{
    internal class Baralho
    {
        private List<Carta> _cartas = new List<Carta>();
        public Baralho()
        {
            string[] naipes = { "Copas", "Paus", "Ouros", "Espadas" };
            string[] nomes = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            string pastaDebug = Application.StartupPath;

            foreach (string naipe in naipes)
            {
                foreach (string nome in nomes)
                {
                    ;
                    Carta carta = new Carta(nome, naipe , Image.FromFile(Path.Combine(pastaDebug, "deck_1", $"{nome} ({naipe}).png")));
                    _cartas.Add(carta);
                }
            }
        }
    }
}
