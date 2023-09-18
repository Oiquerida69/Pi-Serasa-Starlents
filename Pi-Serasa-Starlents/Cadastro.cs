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
using static System.Net.WebRequestMethods;

namespace Pi_Serasa_Starlents
{
    public partial class Cadastro : Form
    {

        public void rendizatela()
        {
            int painelprincipalaltura = ClientSize.Height;
            int painelprincipallargura = ClientSize.Width;

            WindowState = FormWindowState.Maximized;
            GradientPanelCadastro.Location = new Point(0, 0);

        }
        public string caminho1 = "https://i.imgur.com/Uqamx5Q.png";
        public string caminho2 = "https://i.imgur.com/MJeq7KG.png";
        public string caminho3 = "https://i.imgur.com/hGZfrfT.png";
        public string caminho4 = "https://i.imgur.com/6G3KaBG.png";
        public string caminho5 = "https://i.imgur.com/7QNYR4q.png";
        public string caminho6 = "https://i.imgur.com/961Yv3F.png";
        public string caminho7 = "https://i.imgur.com/2aoeof2.png";
        public string caminho8 = "https://i.imgur.com/CSJ66va.png";
        public string caminho9 = "https://i.imgur.com/ragZuSZ.png";
        public string caminho10 = "https://i.imgur.com/cpUIqvH.png";
        public string caminho11 = "https://i.imgur.com/CwKUseL.png";
        public string caminho12 = "https://i.imgur.com/UAgNct5.png";
        public string caminho13 = "https://i.imgur.com/Wg9LbVB.png";
        public string caminho14 = "https://i.imgur.com/qbZVfpi.png";
        public string caminho15 = "https://i.imgur.com/vwQwnFI.png";
        public string caminho16 = "https://i.imgur.com/kr875VF.png";
        public string caminho17 = "https://i.imgur.com/3uIn7uY.png";
        public string caminho18 = "https://i.imgur.com/6UNFMHE.png";
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
            rendizatela();
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
                Usuario usuariototal = new Usuario(0, interesse, interesse2, interesee3, nome, email, senha, telefone, descricao, avatar, mensagemU, aprender, aprender2,false);
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1.panel1.Controls.Clear();
            Form1.panel1.Controls.Add(login);
            login.TopLevel = false;
            login.Show();
        }
    }
}











