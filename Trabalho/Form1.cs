namespace Trabalho
{
    public partial class Form1 : Form
    {
        
        private int quantidadeJogadores;
        private Baralho meuBaralho = new Baralho();

        public Form1()
        {
            InitializeComponent();
            ConfigurarMenuPrincipal();

            this.Load += (sender, e) => AjustarPosicoesMenu();
            this.Resize += (sender, e) => AjustarPosicoesMenu();
            AjustarPosicoesMenu();
        }

        private void ConfigurarMenuPrincipal()
        {
            this.panelmenu.Dock = DockStyle.Fill;
            this.panelmenu.BackColor = Color.DarkGreen;

            this.button1.Text = "2 Jogadores";
            this.button2.Text = "4 Jogadores";
            this.label1.Text = "Selecione a Quantidade de Jogadores";

            this.button1.Size = new Size(180, 45);
            this.button2.Size = new Size(180, 45);

            this.button1.Click += (sender, e) => IniciarJogo(2);
            this.button2.Click += (sender, e) => IniciarJogo(4);
        }

        private void AjustarPosicoesMenu()
        {
            if (this.panelmenu != null && this.panelmenu.Visible)
            {
                int centroX = this.ClientSize.Width / 2;
                
                this.label1.Location = new Point(centroX - (this.label1.Width / 2), (int)(this.ClientSize.Height * 0.20));
                this.button1.Location = new Point(centroX - (this.button1.Width / 2), this.label1.Bottom + 40);
                this.button2.Location = new Point(centroX - (this.button2.Width / 2), this.button1.Bottom + 20);
            }
        }
        private void IniciarJogo(int numeroDeJogadores)
        {
            this.quantidadeJogadores = numeroDeJogadores;
            this.panelmenu.Visible = false; 
            this.meuBaralho = new Baralho();

            PictureBox b = new PictureBox();
            b.Image = meuBaralho.Cartas[0].ImagemCarta;
            b.Location = new System.Drawing.Point(100, 100);
            b.Width = 100;
            b.Height = 150;
            b.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Controls.Add(b);

            MessageBox.Show($"O jogo começou com {quantidadeJogadores} jogadores!");
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}