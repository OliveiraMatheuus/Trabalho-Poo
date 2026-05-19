namespace Trabalho
{
    public partial class Form1 : Form
    {
        
        private Baralho baralho = null!;
        private Jogador jogador = null!;
        private Banca banca = null!;

        public Form1()
        {
            InitializeComponent();
            IniciarNovoJogo();
        }

        private void IniciarNovoJogo()
        {
            baralho = new Baralho();

            baralho.qtd_cartas();

            jogador = new Jogador(baralho.distribuir(), baralho.distribuir());
            banca = new Banca(baralho.distribuir(), baralho.distribuir());

            baralho.qtd_cartas();

        }

        
    }
}