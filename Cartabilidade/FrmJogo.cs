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
using System.Media;

namespace Cartabilidade
{
    public partial class FrmJogo : Form
    {
        public FrmJogo()
        {
            InitializeComponent();
        }
        FrmCarta[] cartas = new FrmCarta[10]; //as cartas que o jogador tem na mão
        bool[] jaForam; //para saber quais cartas foram compradas e evitar repetições depois
        int ptsMagicos = 15;
        Random gera = new Random();
        Random geraDano = new Random();
        bool derrota = false;
        bool vitoria = false;
        int ataque = 1;//1 para normal ou 2 como dano dobrado
        int ultimoDano = 0; //para a carta "loop temporal", que refaz o último dano
        int cartasJaJogadas = 0; //para a carta "cina sempre melhor", que dá dano por carta ativada
        bool amuletoRosas = false;
        bool amuletoDesfesa = false;
        bool amuletoVinganca = false;
        int envenenado = 0; //diferente de 0 se o jogador está envenenado
        int inimigoEnvenenado = 0;
        DateTime momentoInicio; //para o tempo do jogo
        int contador = 0;//para dar o ponto magico a cada 2 rodadas
        int dobro = 0;//para a carta de dano em dobro
        int vidaDoInimigo; //dapende da dificuldade
        public TimeSpan tempo; //tempo para usar na pontuação

        private void AlteraVidaInimigo(int danoOuCura)
        {
           
            Label lbl = new Label();
            lbl.Top = 45;
            lbl.Left = gera.Next(288, 278 + 288);
            lbl.Tag = "temp";
            lbl.Text = danoOuCura.ToString();
            if (danoOuCura < 0)
            {
                lbl.ForeColor = Color.Red;
            }
            else
            {
                lbl.ForeColor = Color.Green;
            }
            lbl.AutoSize = true;
            Controls.Add(lbl);
            lbl.BringToFront();
            if (pbInimigo.Value + danoOuCura < 0)
            {
                vitoria = true;
                pbInimigo.Value = 0;
            }
            else if (pbInimigo.Value + danoOuCura > vidaDoInimigo)
            {
                pbInimigo.Value = vidaDoInimigo;
            }
            else
            {
                pbInimigo.Value += danoOuCura;
            }
            lblInimigo.Text = pbInimigo.Value.ToString() + "/" + vidaDoInimigo.ToString();
        }

        private void AlteraVidaJogador(int danoOuCura)
        {
            Label lbl = new Label();
            lbl.Top = 435;
            lbl.Left = gera.Next(363, 363 + 174);
            lbl.Tag = "temp";
            lbl.Text = danoOuCura.ToString();
            if (danoOuCura < 0)
            {
                lbl.ForeColor = Color.Red;
            }
            else
            {
                lbl.ForeColor = Color.Green;
            }
            lbl.AutoSize = true;
            Controls.Add(lbl);
            lbl.BringToFront();
            if (pbVida.Value + danoOuCura <= 0)
            {
                derrota = true;
                pbVida.Value = 0;
            }
            else if (pbVida.Value + danoOuCura > 1000)
            {
                pbVida.Value = 1000;
            }
            else
            {
                pbVida.Value += danoOuCura;
            }
            lblVida.Text = pbVida.Value.ToString() + "/1000";
        }

        private int GeraCartaNaoRepetida()
        {
            bool reset = true;
            for (int j = 0; j < jaForam.Length; j++)
            {
                if (!jaForam[j])
                {
                    reset = false;
                    break;
                }
            }

            if (reset)
            {
                for (int j = 0; j < jaForam.Length; j++)
                {
                    jaForam[j] = false;
                }
            }

            int aux;
            bool repete = false;
            do
            {
                aux = gera.Next(1, 26);
                if (jaForam[aux - 1])
                    repete = true;
                else
                    repete = false;
            }
            while (repete);
            jaForam[aux - 1] = true;
            return aux;
        }

        private void FazEfeitoDaCarta(int codigo)
        {
            if (codigo == 1)
            {
                AlteraVidaJogador(100);
            }
            else if (codigo == 2)
            {
                AlteraVidaJogador(300);
            }
            else if (codigo == 3)
            {
                AlteraVidaJogador(600);
            }
            else if (codigo == 4)
            {
                btnAtaque2.Enabled = true;
                btnAtaque2.Text = "Atirador Infital";
            }
            else if (codigo == 5)
            {
                btnAtaque3.Enabled = true;
                btnAtaque3.Text = "Missil Seguidor";
            }
            else if (codigo == 6)
            {
                btnAtaque4.Enabled = true;
                btnAtaque4.Text = "Destruidor Ordenado";
            }
            else if (codigo == 7)
            {
                btnAtaque5.Enabled = true;
                btnAtaque5.Text = "Golpeador Infital";
            }
            else if (codigo == 8)
            {
                int vidaFaltante = 1000 - pbVida.Value;
                pbVida.Value = 1000;
                lblVida.Text = pbVida.Value.ToString() + "/1000";
                AlteraVidaInimigo(-vidaFaltante);
            }
            else if (codigo == 9)
            {
                ataque = 2;
                dobro = 1;
            }
            else if (codigo == 10)
            {
                AlteraVidaJogador(-400);
                AlteraVidaInimigo(-600);
            }
            else if (codigo == 11)
            {
                ptsMagicos += 3;
            }
            else if (codigo == 12)
            {
                ptsMagicos += 5;
            }
            else if (codigo == 13)
            {
                ptsMagicos += 4;
                btnCarta_Click(this, new EventArgs());
                btnCarta_Click(this, new EventArgs());
            }
            else if (codigo == 14)
            {
                ptsMagicos += 6;
                for (int i = 0; i < 3; i++)
                    btnCarta_Click(this, new EventArgs());
            }
            else if (codigo == 15)
            {
                int qtdCartas = 0;
                for (int i = 0; i < cartas.Length; i++)
                {
                    if (!cartas[i].IsDisposed)
                    {
                        qtdCartas++;
                        cartas[i].Dispose();
                        cartas[i].Location = new Point(0, 0);
                    }
                }
                ptsMagicos += 2 * qtdCartas;
                for (int i = 0; i < qtdCartas; i++)
                {
                    btnCarta_Click(this, new EventArgs());
                }
            }
            else if (codigo == 16)
            {
                AlteraVidaInimigo(ultimoDano);
            }
            else if (codigo == 17)
            {
                Random aleat = new Random();
                if (aleat.Next(0, 2) == 0)
                    AlteraVidaInimigo(150);
                else
                    AlteraVidaJogador(150);
            }
            else if (codigo == 18)
            {
                AlteraVidaInimigo(-50 * cartasJaJogadas);
            }
            else if (codigo == 19)
            {
                int qtdCartas = 1;
                for (int i = 0; i < cartas.Length; i++)
                {
                    if (!cartas[i].IsDisposed)
                    {
                        qtdCartas++;
                        cartas[i].Dispose();
                        cartas[i].Location = new Point(0, 0);
                    }
                }
                AlteraVidaJogador(qtdCartas * 75);
            }
            else if (codigo == 20)
            {
                int qtdCartas = 1;
                for (int i = 0; i < cartas.Length; i++)
                {
                    if (!cartas[i].IsDisposed)
                    {
                        qtdCartas++;
                        cartas[i].Dispose();
                        cartas[i].Location = new Point(0, 0);
                    }
                }
                AlteraVidaInimigo(-250 * qtdCartas);
            }
            else if (codigo == 21)
            {
                amuletoVinganca = true;
                pbxAmuletoCura.Visible = true;
            }
            else if (codigo == 22)
            {
                amuletoRosas = true;
                pbxAmuletoEspinhos.Visible = true;
            }
            else if (codigo == 23)
            {
                amuletoDesfesa = true;
                pbxAmuletoDefesa.Visible = true;
            }
            else if (codigo == 24)
            {
                envenenado = 0;
                lblVida.BackColor = Color.White;
            }
            else if (codigo == 25)
            {
                inimigoEnvenenado = 5;
                lblInimigo.BackColor = Color.DarkViolet;
            }
        }

        private void AtivaCarta(FrmCarta cart)
        {
            int codigo = cart.codigoDaCarta;
            string pastaEXE = Path.GetDirectoryName(Application.ExecutablePath);
            string[] valores = File.ReadAllLines(Path.Combine(pastaEXE, "Cartas.txt"), Encoding.UTF7)[codigo].Split('|');
            if (ptsMagicos - Convert.ToInt32(valores[3]) >= 0)
            {
                cartasJaJogadas++;
                ptsMagicos -= Convert.ToInt32(valores[3]);
                cart.Close();
                cart.Location = new Point(0, 0);

                if (DadosOpcoes.audio == 2)
                {
                    var p2 = new System.Windows.Media.MediaPlayer();
                    p2.Open(new Uri(Path.Combine(Directory.GetCurrentDirectory(),
                        "efeitos sonoros", "ativa.wav")));
                    p2.Play();
                }

                FazEfeitoDaCarta(codigo);
            }
            else
            {
                cart.Location = new Point(cart.Location.X - 50, cart.Location.Y + 250);
                MessageBox.Show("Pontos insuficientes");
            }

        }

        private void GeraPontuacao()
        {
            double pontos = 0;

            if (vitoria)
            {
                if (tempo.TotalSeconds >= 1000)
                {
                    pontos = 5000;
                }
                else
                {
                    pontos = 5000 + (1 - (tempo.TotalSeconds / 1000.0)) * 10000;
                }

            }
            else
            {
                if (tempo.TotalSeconds >= 1000)
                {
                    pontos = (1 - ((pbInimigo.Value / 1.0) / vidaDoInimigo)) * 10000;
                }
                else
                {
                    pontos = (1 - ((tempo.TotalSeconds) / 1000.0)) * (1 - ((pbInimigo.Value / 1.0) / vidaDoInimigo)) * 10000;
                }
            }

            pontos *= (DadosOpcoes.dificuldade + 1);

            if (vitoria)
                MessageBox.Show("Venceu!");

            MessageBox.Show("Pontuação: " + Math.Truncate(pontos));

            if (Math.Truncate(pontos) >= 30000 && !DadosOpcoes.achv1)
            {
                MessageBox.Show("Você conquistou um Achievement", "Achivo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                DadosOpcoes.achv1 = true;
            }

            if (btnAtaque2.Enabled && btnAtaque3.Enabled && btnAtaque4.Enabled && btnAtaque5.Enabled && !DadosOpcoes.achv2)
            {
                MessageBox.Show("Você conquistou um Achievement", "Achivo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                DadosOpcoes.achv2 = true;
            }

            if (tempo.TotalMinutes < 2&& vitoria && !DadosOpcoes.achv3)
            {
                MessageBox.Show("Você conquistou um Achievement", "Achivo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                DadosOpcoes.achv3 = true;
            }

            string dificuldade;

            if (DadosOpcoes.dificuldade == 0)
            {
                dificuldade = "Medio";
            }
            else if (DadosOpcoes.dificuldade == 1)
            {
                dificuldade = "Difícil";
            }
            else
            {
                dificuldade = "Extremo";
            }

            string[] recordes = File.ReadAllLines("Recordes.txt", Encoding.UTF7);

            for (int i = 0; i < recordes.Length; i++)
            {
                string[] dados = recordes[i].Split('|');
                if (dados[0] == DadosOpcoes.usuario)
                {
                    if (Convert.ToInt32(dados[1]) < pontos)
                    {
                        recordes[i] = $"{DadosOpcoes.usuario}|{Math.Truncate(pontos)}|{dificuldade}";
                        File.WriteAllLines("Recordes.txt", recordes);
                    }
                    return;
                }
            }

            File.AppendAllText("Recordes.txt", $"{DadosOpcoes.usuario}|{Math.Truncate(pontos)}|{dificuldade}" + Environment.NewLine);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan tempo = DateTime.Now - momentoInicio;
            lblPtos.Text = "Pontos Magicos: " + ptsMagicos.ToString();
            foreach (FrmCarta carta in cartas)
            {
                if (carta.Location.X > Left + 625 && carta.Location.X < Left + 625 + 115 &&
                    carta.Location.Y > Top + 220 + 20 && carta.Location.Y < Top + 220 + 20 + 85 &&
                    (MouseButtons & MouseButtons.Left) == 0)
                {
                    AtivaCarta(carta);
                }
                else if (carta.Location.X > Left + 625 && carta.Location.X < Left + 625 + 115 &&
                    carta.Location.Y > Top - 10 + 20 && carta.Location.Y < Top - 10 + 20 + 85 &&
                    (MouseButtons & MouseButtons.Left) == 0)
                {

                    if (DadosOpcoes.audio == 2)
                    {
                        var som = new System.Windows.Media.MediaPlayer();
                        som.Open(new Uri(Path.Combine(Directory.GetCurrentDirectory(),
                            "efeitos sonoros", "ativa.wav")));
                        som.Play();
                    }

                    ptsMagicos++;
                    carta.Close();
                    carta.Location = new Point(0, 0);
                }
            }

            if (vitoria || derrota)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                if (!DadosOpcoes.tester)
                    GeraPontuacao();
                else
                    MessageBox.Show("A pontuação não é armazenada no mode de testes");

                Close();
            }

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            tempo = DateTime.Now - momentoInicio;
            lblTempo.Text = $"Tempo: {tempo.Minutes.ToString("00")}:{tempo.Seconds.ToString("00")}:{tempo.Milliseconds.ToString("000")}";
        }

        private void FrmControle_Load(object sender, EventArgs e)
        {
            momentoInicio = DateTime.Now;

            if (DadosOpcoes.tester)
            {
                FazEfeitoDaCarta(4);
                FazEfeitoDaCarta(5);
                FazEfeitoDaCarta(6);
                FazEfeitoDaCarta(7);
                ptsMagicos += 100;
            }
            
            if (DadosOpcoes.dificuldade == 0)
            {
                vidaDoInimigo = 9000;
            }
            else if (DadosOpcoes.dificuldade == 1)
            {
                vidaDoInimigo = 12000;
            }
            else if (DadosOpcoes.dificuldade == 2)
            {
                vidaDoInimigo = 18000;
            }

            pbInimigo.Maximum = vidaDoInimigo;
            pbInimigo.Value = vidaDoInimigo;
            lblInimigo.Text = pbInimigo.Value.ToString() + "/" + vidaDoInimigo.ToString();

            for (int i = 0; i < 10; i++)
            {
                cartas[i] = new FrmCarta();
                cartas[i].Dispose();
            }

            jaForam = new bool[25];

            for (int i = 0; i < jaForam.Length; i++)
            {
                jaForam[i] = false;
            }

            Top -= 120;
            ptsMagicos -= DadosOpcoes.dificuldade * 2;
            for (int i = 0; i < 5 - DadosOpcoes.dificuldade; i++)
            {
                btnCarta_Click(this, e);
            }

            SoundPlayer som = new SoundPlayer("NO 190.wav");
            if (DadosOpcoes.dificuldade == 2)
                som = new SoundPlayer("hard.wav");
            if (DadosOpcoes.audio != 0)
                som.PlayLooping();

        }

        private void FazVenenoEAtqDobro()
        {
            if (dobro-- == 0)
            {
                ataque = 1;
            }

            if (inimigoEnvenenado != 0)
            {
                lblInimigo.BackColor = Color.DarkViolet;
                inimigoEnvenenado--;
                AlteraVidaInimigo(-100);
                if (inimigoEnvenenado == 0)
                    lblInimigo.BackColor = Color.White;
            }

            if (envenenado != 0)
            {
                lblVida.BackColor = Color.DarkViolet;
                envenenado--;
                AlteraVidaJogador(-25);
                if (envenenado == 0)
                    lblVida.BackColor = Color.White;
            }
        }

        private void TurnoInimigo(int dano)
        {
            if (DadosOpcoes.ptoExtra)
                ptsMagicos++;
            ultimoDano = dano;
            AlteraVidaInimigo(dano);
            geraDano = new Random();
            int ataqueInimigo = geraDano.Next(25 * (DadosOpcoes.dificuldade + 1), 50 * (DadosOpcoes.dificuldade + 1));

            int acao = geraDano.Next(0, 5);

            if (amuletoVinganca)
                AlteraVidaJogador(3 * dano / 20);
            if (amuletoRosas&&acao>=2)
                AlteraVidaInimigo(-ataqueInimigo);
            if (amuletoDesfesa)
                ataqueInimigo = ataqueInimigo / 2;


            if (contador++ % 2 == 0)
                ptsMagicos++;

            if (ptsMagicos < 3-2*DadosOpcoes.dificuldade && DadosOpcoes.dificuldade != 2)
                ptsMagicos++;

            FazVenenoEAtqDobro();

            


            if (acao == 0)
                envenenado = 4;
            else if (acao == 1)
                AlteraVidaInimigo(150*(DadosOpcoes.dificuldade+1));
            else
                AlteraVidaJogador(-ataqueInimigo);
        }

        private void FrmControle_FormClosing(object sender, FormClosingEventArgs e)
        {
            SoundPlayer som = new SoundPlayer("NO 190.wav");
            som.Play();
            som.Stop();
            for (int i = 0; i < 10; i++)
            {
                cartas[i].Dispose();
            }
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            bool cabeCarta = false;
            gera = new Random();
            for (int i = 0; i < 10; i++)
            {
                if (cartas[i].IsDisposed == true)
                {
                    cabeCarta = true;
                    if (ptsMagicos >= 2)
                    {
                        ptsMagicos -= 2;
                        cartas[i] = new FrmCarta();

                        cartas[i].codigoDaCarta = GeraCartaNaoRepetida();

                        cartas[i].Show();
                        cartas[i].Top += 250;
                        cartas[i].Left += (5 - i) * 50;
                    }
                    else
                        MessageBox.Show("Pontos insuficientes");

                    break;
                }
            }

            if (!cabeCarta)
            {
                MessageBox.Show("Número máximo de cartas atingido");
            }
        }

        private void btnAtaque1_Click(object sender, EventArgs e)
        {
            DadosOpcoes.ptoExtra = false;
            FrmAtqSimples atq = new FrmAtqSimples();
            atq.vel = 40;
            atq.ShowDialog();

            if (DadosOpcoes.audio == 2)
            {
                var p2 = new System.Windows.Media.MediaPlayer();
                p2.Open(new Uri(Path.Combine(Directory.GetCurrentDirectory(),
                    "efeitos sonoros", "corte.wav")));
                p2.Play();
            }

            AlteraVidaInimigo(-(50 + atq.danoExtra) * ataque);
            ultimoDano = -(50 + atq.danoExtra) * ataque;
            TurnoInimigo(-(50 + atq.danoExtra) * ataque);
        }

        private void btnAtque2_MouseClick(object sender, MouseEventArgs e)
        {
            DadosOpcoes.ptoExtra = false;
            FrmAtqClicks clic = new FrmAtqClicks();
            clic.ShowDialog();

            if (DadosOpcoes.audio == 2)
            {
                var p2 = new System.Windows.Media.MediaPlayer();
                p2.Open(new Uri(Path.Combine(Directory.GetCurrentDirectory(),
                    "efeitos sonoros", "tiros.wav")));
                p2.Play();
            }

            TurnoInimigo(-(100 + clic.danoBonus) * ataque);
        }

        private void btnAtaque3_Click(object sender, EventArgs e)
        {
            DadosOpcoes.ptoExtra = false;
            FrmAtqSegue segue = new FrmAtqSegue();
            segue.ShowDialog();

            if (DadosOpcoes.audio == 2)
            {
                var p2 = new System.Windows.Media.MediaPlayer();
                p2.Open(new Uri(Path.Combine(Directory.GetCurrentDirectory(),
                    "efeitos sonoros", "explose.wav")));
                p2.Play();
            }

            TurnoInimigo(-(100 + segue.danoExtra * 3) * ataque);
        }

        private void btnAtaque4_Click(object sender, EventArgs e)
        {
            DadosOpcoes.ptoExtra = false;
            FrmAtqSetas setas = new FrmAtqSetas();
            setas.ShowDialog();

            if (DadosOpcoes.audio == 2)
            {
                var p2 = new System.Windows.Media.MediaPlayer();
                p2.Open(new Uri(Path.Combine(Directory.GetCurrentDirectory(),
                    "efeitos sonoros", "Dordenado.wav")));
                p2.Play();
            }

            TurnoInimigo(-(200 + setas.danoExtra) * ataque);
        }

        private void btnAtaque5_Click(object sender, EventArgs e)
        {
            DadosOpcoes.ptoExtra = false;
            DadosOpcoes.auxDanoExtraAtq5 = 0;
            DadosOpcoes.auxAutoDanoAtq5 = 0;
            FrmAtq5 geraEspadas = new FrmAtq5();
            geraEspadas.ShowDialog();



            AlteraVidaJogador(-DadosOpcoes.auxAutoDanoAtq5);
            TurnoInimigo(-(300 + DadosOpcoes.auxDanoExtraAtq5) * ataque);
        }

        private void btnInfo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aperte em atacar quando a janela que se " +
                "move estiver alinhada com o meio");
        }

        private void btnInfo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clique o maximo que puder no botão ou aperte a barra de espaço\n\n" +
                "Se você clicar no botão não será mais possível usar espaço\n\n" +
                "Você recebe um ponto bonus se o atq for maior que 450");
        }

        private void btnInfo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siga a janela em movimento (estar na parte preta é suficiente), " +
                "a barra representa o quão perto está do dano máximo desse ataque\n\n" +
                "Você recebe um ponto bonus se encher o ataque antes do movimento acabar");
        }

        private void btnInfo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aperte as teclas W, A, S e D na direção correspondente " +
                "da seta, cada acerto o ataque aumenta\n\n" +
                "Você recebe um ponto bonus se o atq for maior que 800");
        }

        private void btnInfo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desvie das laminas das espadas e gere muito dano por cada uma," +
                " mas cuidado, você perde 100 de vida a cada uma que te acerta\n\n" +
                "E o cursor está preso em uma caixa invisivel durante o ataque\n\n" +
                "Você recebe um ponto bonus se desviar de todas as espadas");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            foreach(Control lbl in Controls)
            {
                if(lbl is Label&&lbl.Tag != null&&lbl.Tag.ToString() == "temp")
                {
                    lbl.Top += 3;
                    if (lbl.Top<200&&lbl.Top > 65)
                    {
                        lbl.Dispose();
                    }
                    else if (lbl.Top > 450)
                    {
                        lbl.Dispose();
                    }
                }
            }
        }
    }
}
