using Pi_Serasa_Starlents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiLBiT;

namespace Pi_Serasa_Starlents
{
    public partial class Cadastro : Form
    {
        public string caminho1 = "C:/Users/DELL/source/repos/Pi-Serasa-Starlents/Pi-Serasa-Starlents/Imagens/Icon01.png";
        public string caminho2 = "C:/Users/DELL/source/repos/Pi-Serasa-Starlents/Pi-Serasa-Starlents/Imagens/Icon02.png";
        public string caminho3 = "C:/Users/DELL/source/repos/Pi-Serasa-Starlents/Pi-Serasa-Starlents/Imagens/Icon03.png";
        public string caminho4 = "C:/Users/DELL/source/repos/Pi-Serasa-Starlents/Pi-Serasa-Starlents/Imagens/Icon04.png";
        public string caminho5 = "C:/Users/DELL/source/repos/Pi-Serasa-Starlents/Pi-Serasa-Starlents/Imagens/Icon05.png";
        public string caminho6 = "C:/Users/DELL/source/repos/Pi-Serasa-Starlents/Pi-Serasa-Starlents/Imagens/Icon06.png";
        public string caminho7 = "C:/Users/DELL/source/repos/Pi-Serasa-Starlents/Pi-Serasa-Starlents/Imagens/Icon07.png";
        public string caminho8 = "C:/Users/DELL/source/repos/Pi-Serasa-Starlents/Pi-Serasa-Starlents/Imagens/Icon08.png";
        public string caminho9 = "C:/Users/DELL/source/repos/Pi-Serasa-Starlents/Pi-Serasa-Starlents/Imagens/Icon09.png";
        public string caminho10 = "C:/Users/DELL/source/repos/Pi-Serasa-Starlents/Pi-Serasa-Starlents/Imagens/Icon10.png";
        public string caminho11 = "C:/Users/DELL/source/repos/Pi-Serasa-Starlents/Pi-Serasa-Starlents/Imagens/Icon11.png";
        public string caminho12 = "C:/Users/DELL/source/repos/Pi-Serasa-Starlents/Pi-Serasa-Starlents/Imagens/Icon12.png";
        public string caminho13 = "C:/Users/DELL/source/repos/Pi-Serasa-Starlents/Pi-Serasa-Starlents/Imagens/Icon13.png";
        public string caminho14 = "C:/Users/DELL/source/repos/Pi-Serasa-Starlents/Pi-Serasa-Starlents/Imagens/Icon14.png";
        public string caminho15 = "C:/Users/DELL/source/repos/Pi-Serasa-Starlents/Pi-Serasa-Starlents/Imagens/Icon15.png";
        public string caminho16 = "C:/Users/DELL/source/repos/Pi-Serasa-Starlents/Pi-Serasa-Starlents/Imagens/Icon16.png";
        public string caminho17 = "C:/Users/DELL/source/repos/Pi-Serasa-Starlents/Pi-Serasa-Starlents/Imagens/Icon17.png";
        public string caminho18 = "C:/Users/DELL/source/repos/Pi-Serasa-Starlents/Pi-Serasa-Starlents/Imagens/Icon10.png";
        public Cadastro()
        {
            InitializeComponent();
        }
        TelaDeInicio inicio = new TelaDeInicio();
        Interesses i = new Interesses();
        Avatar avatar = new Avatar();
        Login login = new Login();





        private void Cadastro_Load(object sender, EventArgs e)
        {
            GradientPanelCadastro.Size = new Size(ClientSize.Width, ClientSize.Height);
            List<Interesses> All = i.buscaTodos();
            foreach (Interesses i in All)
            {
                comboBox1.Items.Add(i.interesse.ToString());
                comboBox2.Items.Add(i.interesse.ToString());
                comboBox3.Items.Add(i.interesse.ToString());
                comboBox4.Items.Add(i.interesse.ToString());
                comboBox5.Items.Add(i.interesse.ToString());
            }
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






        }





        public void geraform(Form form)
        {
            form.TopLevel = false;
            form.Location = new Point(form.Width / 2 - form.Height / 2);
            form.AutoSize = true;
            form.Size = new Size(ClientSize.Width, ClientSize.Height);
            form.Show();
        }

        private void wilBitComboBox3_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void wilBitButton1_Click_2(object sender, EventArgs e)
        {



        }
        public void gerapicturebox(string caminho)
        {


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            void clique(object sender, EventArgs e)
            {
                List<string> avatars = new List<string> { caminho1, caminho2, caminho3, caminho4, caminho5, caminho6, caminho7, caminho8, caminho9, caminho10, caminho11, caminho12, caminho13, caminho14, caminho15, caminho16, caminho17, caminho18 };
                Random random = new Random();

                pictureBox1.ImageLocation = avatars[random.Next(0, 18)].ToString();
            }
            pictureBox3.Click += clique;

        }

        private void wilBitButton1_Click(object sender, EventArgs e)
        {

        }

        private void wilBitButton1_Click_3(object sender, EventArgs e)
        {
            if (wilBitTextBox1.Texts == null)
            {
                MessageBox.Show("Você não digitou um email");
                return;
            }
            if (wilBitTextBox2.Texts == null)
            {
                MessageBox.Show("Você não digitou uma senha");
                return;
            }
            if (wilBitTextBox3.Texts == null)
            {
                MessageBox.Show("Você não digitou um telefone");
                return;
            }
            if (wilBitTextBox4.Texts == null)
            {
                MessageBox.Show("Você não digitou seu nome");
            }
            if (wilBitTextBox5.Texts == null)
            {
                MessageBox.Show("Sua descrição esta vazia");
            }
            if (wilBitTextBox6.Texts == null)
            {
                MessageBox.Show("Sua mensagem padrão esta vazia");
            }
            else
            {

                string nome = wilBitTextBox4.Texts;
                string email = wilBitTextBox1.Texts;
                string senha = wilBitTextBox2.Texts;
                string interesse = comboBox1.Text;
                string interesse2 = comboBox2.Text;
                string interesee3 = comboBox3.Text;
                string telefone = wilBitTextBox3.Texts;
                string avatar = pictureBox1.ImageLocation;
                string descricao = wilBitTextBox5.Texts;
                string mensagemU = wilBitTextBox6.Texts;
                string aprender = comboBox4.Text;
                string aprender2 = comboBox5.Text;
                Usuario usuariototal = new Usuario(0, interesse, interesse2, interesee3, nome, email, senha, telefone, descricao, avatar, mensagemU, aprender, aprender2);
                Program.usuario.CadastrarUsuario(usuariototal);
                MessageBox.Show("Cadastro Feito com Sucesso");
                Form1.panel1.Controls.Clear();
                login.TopLevel = false;
                login.Show();
                Form1.panel1.Controls.Add(login);


                Usuario u = new Usuario();

                Program.usuario = u;


            }
        }
    }
}











