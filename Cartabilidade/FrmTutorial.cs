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
    public partial class FrmTutorial : Form
    {
        public FrmTutorial()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }
    }
}
