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

namespace Cartabilidade
{
    public partial class FrmAtqSegue : Form
    {
        public FrmAtqSegue()
        {
            InitializeComponent();
        }

        public int danoExtra = 0;
        public int vel;
        string[] arquivos;
        string[] linhas;
        bool venceu = false;
        int qualLinha = 0;
        bool primeiro = true;
        int cont = 0;
        string ondeImgOn = Path.Combine(Directory.GetCurrentDirectory(), "para ataque", "alvo on.png");
        string ondeImgOff = Path.Combine(Directory.GetCurrentDirectory(), "para ataque", "alvo off.png");
        private void timer1_Tick(object sender, EventArgs e)
        {
            Left = Convert.ToInt32(linhas[qualLinha].Split(' ')[0]) - 60;
            Top = Convert.ToInt32(linhas[qualLinha].Split(' ')[1]) - 60;

            if (primeiro)
            {
                Cursor.Position = new Point(Convert.ToInt32(linhas[qualLinha].Split(' ')[0]),
                    Convert.ToInt32(linhas[qualLinha].Split(' ')[1]));
                primeiro = false;
                BringToFront();
            }

            if (qualLinha + 1 < linhas.Length)
                qualLinha++;
            else
                Close();


            if (!(Cursor.Position.X < Left + 130 && Cursor.Position.X > Left - 5 &&
                Cursor.Position.Y > Top - 5 & Cursor.Position.Y < Top + 130) || venceu)
            {
                if (pictureBox1.ImageLocation != ondeImgOff)
                    pictureBox2.ImageLocation = ondeImgOff;
            }
            else
            {
                if(cont++%3==0)
                    danoExtra+=5;

                if (cont % 16 == 0&& DadosOpcoes.audio == 2)
                {
                    var p2 = new System.Windows.Media.MediaPlayer();
                    p2.Open(new Uri(Path.Combine(Directory.GetCurrentDirectory(),
                        "efeitos sonoros", "segue.wav")));
                    p2.Volume *= 1.8;
                    p2.Play();
                }

                if (pictureBox1.ImageLocation != ondeImgOn)
                    pictureBox2.ImageLocation = ondeImgOn;
            }

            if (danoExtra > 255)
            {
                DadosOpcoes.ptoExtra = true;
                Close();
            }
            else
                progressBar1.Value = danoExtra;
        }

        private void FrmSegue_Load(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            TransparencyKey = Color.DarkOrange;
            Size = new Size(130, 130);
            Random gera = new Random();
            arquivos = "movimento1|movimento2|movimento3".Split('|');
            linhas = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(),"para ataque" , arquivos[gera.Next(0,3)] + ".txt"));
        }
    }
}
