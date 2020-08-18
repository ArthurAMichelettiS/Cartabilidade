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
    public partial class FrmRecordes : Form
    {
        public FrmRecordes()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmRecordes_Load(object sender, EventArgs e)
        {
            string[] jogadores = File.ReadAllLines("Recordes.txt",Encoding.UTF8);

            for (int i = 0; i < jogadores.Length-1; i++)
            {
                for (int j = 0; j < jogadores.Length-1; j++)
                {
                    if(Convert.ToInt32(jogadores[j].Split('|')[1]) <
                        Convert.ToInt32(jogadores[j+1].Split('|')[1]))
                    {
                        string aux = jogadores[j];
                        jogadores[j] = jogadores[j + 1];
                        jogadores[j + 1] = aux;
                    }
                }
            }

            foreach (string dado in jogadores)
                dgvRecordes.Rows.Add(dado.Split('|'));
           
            dgvRecordes.RowHeadersVisible = false;
            dgvRecordes.DefaultCellStyle.SelectionBackColor = dgvRecordes.DefaultCellStyle.BackColor;
            dgvRecordes.DefaultCellStyle.SelectionForeColor = dgvRecordes.DefaultCellStyle.ForeColor;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
