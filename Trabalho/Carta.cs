using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Trabalho
{
    internal class Carta
    {
        private string _name = "";
        private string _naipe = "";
        private int _value = 0;

        List<string> nome_v = new List<string>() { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        public Carta(string name, string naipe, Image image)
        {
            this.Naipe = naipe;
            this.Name = name;
            this.ImagemCarta = image;
            Verificação(name);

        }
        public void Verificação(string name)
        {
            if (nome_v.Contains(name))
            {
                if (name == "A")
                {
                    this.Value = 11;
                }
                else if (name == "J" || name == "Q" || name == "K")
                {
                    this.Value = 10;
                }
                else
                {
                    this.Value = int.Parse(name);
                }
            }
            else
            {
                throw new Exception("Nome da carta inválido. Deve ser A, 2-10, J, Q ou K.");
            }
        }
        public string Name { get => _name; set => _name = value; }
        public string Naipe { get => _naipe; set => _naipe = value; }
        public int Value { get => _value; set => _value = value; }
        public Image ImagemCarta { get; set; }

    }
}
