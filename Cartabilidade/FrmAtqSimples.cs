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
    public partial class FrmAtqSimples : Form
    {
        public FrmAtqSimples()
        {
            InitializeComponent();

        }

        Form4 move = new Form4();
        public int vel = 30;
        int onde = 0;
        public int danoExtra = 0;
        Random gera = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            onde = move.Left;
            move.Close();
            if (onde + 68 > Left + 35 && onde + 68 < Left + 125)
            {
                if (onde + 68 > Left + 70 && onde+68 < Left + 95)
                {
                    danoExtra = 100;
                }
                danoExtra += 50;
            }

            Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            move.vel = vel;
            int inX, inY;
            inY = Top = gera.Next(100, 450);
            inX = Left = gera.Next(300, 1000);
            move.inicio = new Point(inX, inY);
            move.Show();
        }

        private void FrmAtqSimples_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!move.IsDisposed)
                move.Close();
        }
    }
}
