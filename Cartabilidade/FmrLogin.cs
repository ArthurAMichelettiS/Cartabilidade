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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public bool completo = false;
        bool primClickCadastro = true;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nomeUsuario, senha;

            if (txbNomeUsuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("O campo Nome de Usuário é obrigatório");
                return;
            }
            if (txbSenha.Text.Trim().Length == 0)
            {
                MessageBox.Show("O campo senha é obrigatório");
                return;
            }

            nomeUsuario = txbNomeUsuario.Text;
            senha = txbSenha.Text;
            string jogadorEncontrado = "";
            string senhaEncontrada = "";

            if (!File.Exists("dados.txt"))
                File.Create("dados.txt");

            string[] jogadores;
            jogadores = File.ReadAllLines("dados.txt", Encoding.UTF8);

            //Procura o nome de usuário e senha no arquivo texto
            for (int i = 0; i < jogadores.Length; i++)
            {
                string[] dadosJogador = jogadores[i].Split('|');
                if (dadosJogador[0] == nomeUsuario)
                {
                    jogadorEncontrado = dadosJogador[0];

                    if (dadosJogador[1] == senha)
                    {
                        senhaEncontrada = dadosJogador[1];
                        DadosOpcoes.dificuldade = Convert.ToInt32(dadosJogador[2]);
                        DadosOpcoes.audio = Convert.ToInt32(dadosJogador[3]);
                        break;
                    }
                }
            }

            if (jogadorEncontrado != nomeUsuario)
            {
                MessageBox.Show("Nome de usuário não encontrado");
                return;
            }

            if (senhaEncontrada != senha)
            {
                MessageBox.Show("Senha incorreta");
                return;
            }

            DadosOpcoes.usuario = nomeUsuario;
            DadosOpcoes.senha = senha;
            MessageBox.Show("Logado");
            completo = true;
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txbSenha.UseSystemPasswordChar = !cbxVerSenha.Checked;
            txtRepete.UseSystemPasswordChar = !cbxVerSenha.Checked;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txbSenha.UseSystemPasswordChar = true;
            txtRepete.UseSystemPasswordChar = true;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (txbSenha.Text == "" || txbNomeUsuario.Text == "")
            {
                MessageBox.Show("Há campos vazios");
                return;
            }

            if (txbSenha.Text.IndexOf('|') != -1 || txbNomeUsuario.Text.IndexOf('|') != -1)
            {
                MessageBox.Show(@"O caractere '|' não é permitido");
                return;
            }

            if (primClickCadastro)
            {
                lblRepete.Visible = true;
                txtRepete.Visible = true;
                primClickCadastro = false;
                
                MessageBox.Show("Repita a senha para concluir o cadastro");
                return;
            }

            if (txtRepete.Text == txbSenha.Text)
            {
                if (!File.Exists("dados.txt"))
                    File.Create("dados.txt");
                string[] cadastros = File.ReadAllLines("dados.txt");

                for (int i = 0; i < cadastros.Length; i++)
                {
                    if (cadastros[i].Split('|')[0] == txbNomeUsuario.Text)
                    {
                        MessageBox.Show("Esse nome de usuario já está sendo usado");
                        return;
                    }
                }

                File.AppendAllText("dados.txt", $"{txbNomeUsuario.Text}|{txbSenha.Text}|0|2|False" + Environment.NewLine, Encoding.UTF8);
                DadosOpcoes.usuario = txbNomeUsuario.Text;
                MessageBox.Show("Cadastrado com Sucesso");
                completo = true;
                Close();
            }
            else
            {
                MessageBox.Show("Senhas não conferem");
            }
        }
    }
}
