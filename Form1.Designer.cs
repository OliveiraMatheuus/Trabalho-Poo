namespace _21
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.pnlBanca = new System.Windows.Forms.Panel();
            this.pnlJogador = new System.Windows.Forms.Panel();
            this.lblPontosBanca = new System.Windows.Forms.Label();
            this.lblPontosJogador = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // painel das cartas da banca
            this.pnlBanca.Location = new System.Drawing.Point(12, 40);
            this.pnlBanca.Size = new System.Drawing.Size(760, 130);
            this.pnlBanca.BackColor = System.Drawing.Color.DarkGreen;

            // painel das cartas do jogador
            this.pnlJogador.Location = new System.Drawing.Point(12, 230);
            this.pnlJogador.Size = new System.Drawing.Size(760, 130);
            this.pnlJogador.BackColor = System.Drawing.Color.DarkGreen;

            // label pontos da banca
            this.lblPontosBanca.Text = "Banca: ?";
            this.lblPontosBanca.ForeColor = System.Drawing.Color.White;
            this.lblPontosBanca.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.lblPontosBanca.Location = new System.Drawing.Point(12, 15);
            this.lblPontosBanca.Size = new System.Drawing.Size(200, 20);

            // label pontos do jogador
            this.lblPontosJogador.Text = "Jogador: 0 pts";
            this.lblPontosJogador.ForeColor = System.Drawing.Color.White;
            this.lblPontosJogador.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.lblPontosJogador.Location = new System.Drawing.Point(12, 205);
            this.lblPontosJogador.Size = new System.Drawing.Size(200, 20);

            // label resultado
            this.lblResultado.Text = "";
            this.lblResultado.ForeColor = System.Drawing.Color.Yellow;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Location = new System.Drawing.Point(12, 175);
            this.lblResultado.Size = new System.Drawing.Size(760, 30);

            // botão Comprar
            this.btnComprar.Text = "Comprar";
            this.btnComprar.Location = new System.Drawing.Point(150, 380);
            this.btnComprar.Size = new System.Drawing.Size(120, 35);
            this.btnComprar.Click += new System.EventHandler(this.button1_Click);

            // botão Parar
            this.btnParar.Text = "Parar";
            this.btnParar.Location = new System.Drawing.Point(330, 380);
            this.btnParar.Size = new System.Drawing.Size(120, 35);
            this.btnParar.Click += new System.EventHandler(this.button2_Click);

            // botão Reiniciar
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.Location = new System.Drawing.Point(510, 380);
            this.btnReiniciar.Size = new System.Drawing.Size(120, 35);
            this.btnReiniciar.Click += new System.EventHandler(this.button3_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.BackColor = System.Drawing.Color.FromArgb(34, 100, 34);
            this.Text = "Jogo de 21";

            this.Controls.Add(this.pnlBanca);
            this.Controls.Add(this.pnlJogador);
            this.Controls.Add(this.lblPontosBanca);
            this.Controls.Add(this.lblPontosJogador);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnReiniciar);

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Panel pnlBanca;
        private System.Windows.Forms.Panel pnlJogador;
        private System.Windows.Forms.Label lblPontosBanca;
        private System.Windows.Forms.Label lblPontosJogador;
        private System.Windows.Forms.Label lblResultado;
    }
}