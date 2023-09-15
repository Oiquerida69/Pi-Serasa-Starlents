using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiLBiT;

namespace Pi_Serasa_Starlents
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        Tela_seleção_avatar telaselecao = new Tela_seleção_avatar();


        private void Cadastro_Load(object sender, EventArgs e)
        {


        }


        private void GradientPanelCadastro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wilBitButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            telaselecao.Show();
            pictureBox1.ImageLocation = telaselecao.caminho01;

        }

        private void wilBitComboBox3_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void wilBitButton1_Click_2(object sender, EventArgs e)
        {
            string nome = wilBitTextBox4.Texts;
            string email = wilBitTextBox1.Texts;
            string senha = wilBitTextBox2.Texts;
            string telefone = wilBitTextBox3.Texts;
            string avatar = telaselecao.caminho01;
            string descricao = wilBitTextBox5.Texts;
            Usuario usuariototal = new Usuario(nome, email, senha, telefone, descricao, avatar);
            Program.usuario.CadastrarUsuario(usuariototal);
        }

    }
}

