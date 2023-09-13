using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
                wilBitComboBox1.Items.Add(i.interesse.ToString());
                wilBitComboBox2.Items.Add(i.interesse.ToString());
                wilBitComboBox3.Items.Add(i.interesse.ToString());
                wilBitComboBox4.Items.Add(i.aprender.ToString());
                wilBitComboBox5.Items.Add(i.aprender.ToString());
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
                string interesse = wilBitComboBox1.Texts;
                string interesse2 = wilBitComboBox2.Texts;
                string interesee3 = wilBitComboBox3.Texts;
                string telefone = wilBitTextBox3.Texts;
                string avatar = pictureBox1.ImageLocation;
                string descricao = wilBitTextBox5.Texts;
                string mensagemU = wilBitTextBox6.Texts;

                Usuario usuariototal = new Usuario(0,interesse,interesse2,interesee3, nome, email, senha, telefone, descricao, avatar, mensagemU);
                Program.usuario.CadastrarUsuario(usuariototal);
                MessageBox.Show("Cadastro Feito com Sucesso");
                geraform(login);


                Usuario u = new Usuario();

                Program.usuario = u;

                //TelaDeInicio telaDeInicio = new TelaDeInicio();
                Perfil perfil = new Perfil();
                perfil.TopLevel = false;
                Form1.panel1.Controls.Clear();
                Form1.panel1.Controls.Add(perfil);
                perfil.Show();

            }
        }
        public void gerapicturebox(string caminho)
        {
            PictureBox pic = new PictureBox();
            pic.Size = new Size(150, 140);
            pic.Location = new Point(623, 301);
            pic.ImageLocation = caminho;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            List<string> avatars = new List<string> { avatar.caminho1, avatar.caminho2, avatar.caminho3, avatar.caminho4, avatar.caminho5, avatar.caminho6, avatar.caminho7, avatar.caminho8, avatar.caminho9, avatar.caminho10, avatar.caminho11, avatar.caminho12, avatar.caminho13, avatar.caminho14, avatar.caminho15, avatar.caminho16, avatar.caminho17, avatar.caminho18 };
            for (int i = 0; i < avatars.Count; i++)
            {
                gerapicturebox(avatars[i]);


            }
        }
    }
}



