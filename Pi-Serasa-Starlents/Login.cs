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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void carregaForm(Form form)
        {


            form.TopLevel = false;
            Form1.panel1.Controls.Clear();
            Form1.panel1.Controls.Add(form);
            form.Size = new Size(ClientSize.Width, ClientSize.Height);
            form.Show();
        }

        void rendeirizaInterface()
        {
            WindowState = FormWindowState.Maximized;

            wilBitGradientPanel1.Location = new Point(10, 0);
            wilBitGradientPanel1.Size = new Size(ClientSize.Width, ClientSize.Height);

            wilBitGradientPanel1.Location = new Point(ClientSize.Width / 2 - wilBitGradientPanel1.Size.Width / 2, ClientSize.Height / 2 - wilBitGradientPanel1.Size.Height / 2);

            wilBitGradientPanel2.Location = new Point(ClientSize.Width / 2 - wilBitGradientPanel2.Size.Width / 2 + 700, ClientSize.Height / 2 - wilBitGradientPanel2.Size.Height / 2);


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void wilBitButton2_Click(object sender, EventArgs e)
        {



        }

        private void wilBitGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void wilBitButton1_Click(object sender, EventArgs e)
        {

        }
        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void wilBitButton2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void wilBitButton1_Click_2(object sender, EventArgs e)
        {
                try
                {

                    string email = wilBitTextBox1.Texts;
                    string senha = wilBitTextBox2.Texts;
                    if (email == "admin" && senha == "admin")
                    {
                        TelaDoModerador tela = new TelaDoModerador();
                        this.Close();
                        tela.Show();
                        
                       
                    }
                    else
                    {
                        Usuario u = new Usuario();
                        u = u.login(email, senha);

                        if (u == null)
                        {
                            MessageBox.Show("email ou senha incorretos");
                            return;
                        }

                        Program.usuario = u;

                        TelaDeInicio telaDeInicio = new TelaDeInicio();
                        telaDeInicio.TopLevel = false;
                        Form1.panel1.Controls.Clear();
                        Form1.panel1.Controls.Add(telaDeInicio);
                        telaDeInicio.Show();
                    }
                }
                catch (Exception erro)
                {

                    MessageBox.Show("O email ou senha ainda não existe no sistema");
                }
            }

        private void wilBitButton2_Click_2(object sender, EventArgs e)
        {
            carregaForm(new Cadastro());
            pictureBox1.Location = new Point(700, 100);
        }
    }
    }

