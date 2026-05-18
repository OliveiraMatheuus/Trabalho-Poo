using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing; 
using System.IO;      
using System.Windows.Forms;

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
                    
                    Carta carta = new Carta(nome, naipe , Image.FromFile(Path.Combine(pastaDebug, "deck_1", $"{naipe} ({nome}).png")));
                    this.Cartas.Add(carta);
                }
            }


        }

        public void Embaralhar()
        {
            Random random = new Random();
            int n = Cartas.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                Carta temp = Cartas[i];
                Cartas[i] = Cartas[j];
                Cartas[j] = temp;
            }
        }

        public Carta distribuir()
        {
            if (Cartas.Count == 0)
            {
                throw new InvalidOperationException("Não há mais cartas para distribuir.");
            }
            Carta carta = Cartas[Cartas.Count - 1];
            Cartas.RemoveAt(Cartas.Count - 1);
            return carta;
        }

        public List<Carta> Cartas { get => _cartas; set => _cartas = value; }
    }
}
