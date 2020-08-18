using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartabilidade
{
    public partial class FrmAtq5Espada : Form
    {
        public FrmAtq5Espada()
        {
            InitializeComponent();
        }
        public Random gera = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            TransparencyKey = Color.Red;
            BackColor = Color.Red;
            pxbImg.BringToFront();
            Top = gera.Next(200, 400);
            Left = 180;
        }
        private void pxbImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (pxbHitbox.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                DadosOpcoes.ptoExtra = false;
                DadosOpcoes.auxAutoDanoAtq5 += 100;
                Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Left+=30;

            if (Left > 800)
            {
                DadosOpcoes.auxDanoExtraAtq5 += 45;
                Close();
            }
        }        
    }
}
