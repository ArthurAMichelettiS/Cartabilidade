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
    public partial class FrmAtqSetas : Form
    {
        public FrmAtqSetas()
        {
            InitializeComponent();
        }
        Random gera = new Random();
        int dir = 0;
        public int danoExtra = 0;
        int cont = 0;
        string[] imagens = "SeterA|SeterW|SeterD|SeterS".Split('|');

        private void FrmAtqSetas_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A|| e.KeyCode == Keys.W|| 
                e.KeyCode == Keys.S|| e.KeyCode == Keys.D)
            {
                if (e.KeyCode == Keys.A && dir == 0)
                    danoExtra += 40;
                else if (e.KeyCode == Keys.W && dir == 1)
                    danoExtra += 40;
                else if (e.KeyCode == Keys.D && dir == 2)
                    danoExtra += 40;
                else if (e.KeyCode == Keys.S && dir == 3)
                    danoExtra += 40;
                lblDano.Text = "Dano: " + danoExtra.ToString();
                if (danoExtra >= 800)
                    DadosOpcoes.ptoExtra = true;
                gera = new Random();
                if (cont++ > 50)
                    Close();
                int aux = dir;
                do
                {
                    dir = gera.Next(0, 4);
                }
                while (dir == aux);
                pictureBox1.ImageLocation = Path.Combine(Directory.GetCurrentDirectory(), "para ataque", imagens[dir] + ".jpeg");
            }
        }
        
        private void FrmAtqSetas_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            dir = gera.Next(0, 4);
            pictureBox1.ImageLocation = Path.Combine(Directory.GetCurrentDirectory(), "para ataque", imagens[dir] + ".jpeg");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
                progressBar1.Value--;
            if (progressBar1.Value == 0)
                Close();
        }
    }
}
