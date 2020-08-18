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
    public partial class FrmOpcoes : Form
    {
        public FrmOpcoes()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (radTodoAudio.Checked)
                DadosOpcoes.audio = 2;
            else if (radMus.Checked)
                DadosOpcoes.audio = 1;
            else
                DadosOpcoes.audio = 0;

            if (radMedio.Checked)
                DadosOpcoes.dificuldade = 0;
            else if (radDificil.Checked)
                DadosOpcoes.dificuldade = 1;
            else
                DadosOpcoes.dificuldade = 2;

            string[] jogadores = File.ReadAllLines("dados.txt", Encoding.UTF7);

            for (int i = 0; i < jogadores.Length; i++)
            {
                string[] dados = jogadores[i].Split('|');
                if(dados[0] == DadosOpcoes.usuario)
                {
                    jogadores[i] = $"{dados[0]}|{dados[1]}|" +
                        $"{DadosOpcoes.dificuldade}|{DadosOpcoes.audio}|false";
                    File.WriteAllLines("dados.txt",jogadores);
                    break;
                }
            }

            Close();
        }

        private void FrmOpcoes_Load(object sender, EventArgs e)
        {
            if(DadosOpcoes.audio == 0)
                radSemSom.Checked = true;
            else if (DadosOpcoes.audio == 1)
                radMus.Checked = true;
            else
                radTodoAudio.Checked = true;

            if (DadosOpcoes.dificuldade == 0)
                radMedio.Checked = true;
            else if (DadosOpcoes.dificuldade == 1)
                radDificil.Checked = true;
            else
                radExtremo.Checked = true;

            //cbxTester.Checked = DadosOpcoes.tester;
        }        

        private void cbxTester_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbxTester.Checked&&!DadosOpcoes.tester)
            //    MessageBox.Show("No modo de testes todos os ataques estão desbloqueados" +
            //        " e 100 pontos extras são dados\n\nNão é salva sua pontuação");
            //DadosOpcoes.tester = cbxTester.Checked;
        }
    }
}
