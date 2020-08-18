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
    public partial class FrmAtqClicks : Form
    {
        public FrmAtqClicks()
        {
            InitializeComponent();
        }
        public int danoBonus = 0;
        bool pode = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 0)
                progressBar1.Value--;
            else
                Close();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            danoBonus += 10;
            lblAtq.Text = "ATQ: " + danoBonus;

            if (danoBonus >= 450)
                DadosOpcoes.ptoExtra = true;

        }

        private void FrmClicks_KeyDown(object sender, KeyEventArgs e)
        {
            if (pode&&e.KeyCode == Keys.Space)
                danoBonus += 10;

            if(danoBonus>=450)
                DadosOpcoes.ptoExtra = true;

            lblAtq.Text = "ATQ: " + danoBonus;
            pode = false;
        }

        private void FrmClicks_KeyUp(object sender, KeyEventArgs e)
        {
            pode = true;
        }
    }
}
