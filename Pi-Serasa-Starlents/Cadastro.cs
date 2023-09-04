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

<<<<<<< HEAD
        private void GradientPanelCadastro_Paint(object sender, PaintEventArgs e)
        {

        }
=======
        private void wilBitButton1_Click(object sender, EventArgs e)
        {
           
            string nome = wilBitTextBox4.Text;
            string email = wilBitTextBox1.Text;
            string senha = wilBitTextBox2.Text;
            string telefone = wilBitTextBox3.Text;
            string avatar = telaselecao.caminho01;
            Usuario usuario = new Usuario(nome,email,senha,telefone,avatar)

        }

        private void wilBitButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

       
>>>>>>> c9763f5771cf133c976cf3bb35c357d2bc9425f7
    }
}
