using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Cartabilidade
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        bool direita = true;
        public int vel;
        bool primeira = true;
        public Point inicio;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (primeira)
            {
                BringToFront();
                primeira = false;
            }
            if (direita)
                Left += 25;
            else
                Left -= 25;

            if (Left < inicio.X - 175 || Left > inicio.X + 175)
            {
                direita = !direita;
            }

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            Location = inicio;
            timer1.Interval = vel;
            timer1.Enabled = true;
        }
    }
}
