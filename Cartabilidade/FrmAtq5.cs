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
    public partial class FrmAtq5 : Form
    {
        public FrmAtq5()
        {
            InitializeComponent();
            DadosOpcoes.ptoExtra = true;
        }
        Random gera = new Random();
        int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor.Clip = new Rectangle(220, 220, 580, 230);
            if (cont++ > 37)
            {
                Cursor.Clip = new Rectangle(0,0,10000,10000);
                Close();
            }
            FrmAtq5Espada espd = new FrmAtq5Espada();
            espd.gera = new Random(gera.Next(0, 500));
            espd.Show();
            lblDano.Text = "Dano: " + DadosOpcoes.auxDanoExtraAtq5.ToString();
            lblAuto.Text = "Auto dano: " + DadosOpcoes.auxAutoDanoAtq5.ToString();
        }
    }
}
