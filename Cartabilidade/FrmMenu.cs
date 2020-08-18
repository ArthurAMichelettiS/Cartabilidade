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
using System.Diagnostics;

namespace Cartabilidade
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja mesmo sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Close();
            }
            else
                return;
        }
        double tempo = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            FrmJogo jogo = new FrmJogo();
            Hide();
            jogo.ShowDialog();
            tempo+=jogo.tempo.TotalMinutes;
            Show();
        }

        private void btnRecordes_Click(object sender, EventArgs e)
        {
            FrmRecordes ranking = new FrmRecordes();
            ranking.ShowDialog();
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            FrmTutorial tutorial = new FrmTutorial();
            tutorial.ShowDialog();
        }

        private void btnDificuldade_Click(object sender, EventArgs e)
        {
            FrmOpcoes opc = new FrmOpcoes();
            opc.ShowDialog();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            FrmSobre creditos = new FrmSobre();
            creditos.ShowDialog();
        }
        string[] dadosJog;
        
        private void FormMenu_Load(object sender, EventArgs e)
        {
            try
            {
                Directory.SetCurrentDirectory(Path.Combine(Directory.GetCurrentDirectory(), "cartabil"));
            }
            catch
            {
                //nada
            }

            dadosJog = File.ReadAllLines(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "jogadorAtual.txt"), Encoding.UTF7);

            if (dadosJog[1][6] == '1')
                DadosOpcoes.achv1 = true;
            if (dadosJog[1][7] == '1')
                DadosOpcoes.achv2 = true;
            if (dadosJog[1][8] == '1')
                DadosOpcoes.achv3 = true;

            tempo = Convert.ToInt32(dadosJog[0].Split('|')[1]);


            string[] jogadores = File.ReadAllLines("dados.txt", Encoding.UTF7);

            lblNomedeUsuario.Text = DadosOpcoes.usuario;
            bool encontrou = false;
            for (int i = 0; i < jogadores.Length; i++)
            {
                string[] dados = jogadores[i].Split('|');

                if (dados[0] == DadosOpcoes.usuario)
                {
                    DadosOpcoes.dificuldade = Convert.ToInt32(dados[2]);
                    DadosOpcoes.audio = Convert.ToInt32(dados[3]);
                    DadosOpcoes.tester = Convert.ToBoolean(dados[4]);
                    encontrou = true;
                    break;
                }
            }

            if (!encontrou)
            {
                File.WriteAllLines("dados.txt", jogadores);
                string nome = File.ReadAllLines(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "jogadorAtual.txt"))[0].Split('|')[0];
                File.AppendAllText("dados.txt", $"{nome}|a|0|2|False"+ Environment.NewLine);
                DadosOpcoes.usuario = nome;
            }

        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            Process.Start("Cartabilidade.exe");
            Close();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] texto = new string[2];

            dadosJog[1] = (DadosOpcoes.achv1 ? "1" : "0") + (DadosOpcoes.achv2 ? "1" : "0") + (DadosOpcoes.achv3 ? "1" : "0") +
                dadosJog[1].Substring(3, 7);

            texto[0] = dadosJog[0].Split('|')[0] + "|" + Convert.ToInt32(tempo).ToString()
                + "|" + dadosJog[1].Count(x => x == '1');
            texto[1] = dadosJog[1];

            char arquivo = '1';
            arquivo = dadosJog[2][0];

            if (arquivo == '1')
            {
                File.WriteAllLines(Path.Combine(Directory.GetParent
                    (Directory.GetCurrentDirectory()).FullName, "dadosSave1.txt"), texto);
            }
            else if (arquivo == '2')
            {
                File.WriteAllLines(Path.Combine(Directory.GetParent
                    (Directory.GetCurrentDirectory()).FullName, "dadosSave2.txt"), texto);
            }
            else
            {
                File.WriteAllLines(Path.Combine(Directory.GetParent
                    (Directory.GetCurrentDirectory()).FullName, "dadosSave3.txt"), texto);
            }
        }
    }
}
