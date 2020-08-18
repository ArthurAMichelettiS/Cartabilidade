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
    public partial class FrmCarta : Form
    {
        public FrmCarta()
        {
            InitializeComponent();
        }
        Color[] cores = new Color[5];
        public int codigoDaCarta;
        
        private void FrmCarta_Load(object sender, EventArgs e)
        {
            cores[0] = Color.Gold;
            cores[1] = Color.DarkMagenta;
            cores[2] = Color.Lime;
            cores[3] = Color.DodgerBlue;
            cores[4] = Color.DimGray;
            
            string pastaEXE = Path.GetDirectoryName(Application.ExecutablePath);
            string[] valores = File.ReadAllLines(Path.Combine(pastaEXE,"Cartas.txt"), Encoding.UTF7)[codigoDaCarta].Split('|');
            string imgs = "";
            foreach(string img in Directory.EnumerateFiles(Path.Combine(pastaEXE, "imagensCartas")))
            {
                imgs += img +"|";
            }
            string[] imagens = imgs.Trim('|').Split('|');
            imgCarta.ImageLocation = imagens[codigoDaCarta];
            Text = valores[0];
            lblDescr.Text = valores[1];
            BackColor = cores[Convert.ToInt32(valores[2])];
            lblCusto.Text = "Custo:" + valores[3];
        }

        private void FrmCarta_MouseDown(object sender, MouseEventArgs e)
        {
            mouseApertado = true;
            ultimoLugar = e.Location;
        }
        bool mouseApertado = false;
        Point ultimoLugar;
        private void FrmCarta_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseApertado)
            {
                this.Location = new Point(
                    (this.Location.X - ultimoLugar.X) + e.X, (this.Location.Y - ultimoLugar.Y) + e.Y);

                this.Update();
            }
        }

        private void FrmCarta_MouseUp(object sender, MouseEventArgs e)
        {
            mouseApertado = false;
        }
    }
}
