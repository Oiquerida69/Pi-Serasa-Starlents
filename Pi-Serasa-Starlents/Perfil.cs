using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiLBiT;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Pi_Serasa_Starlents
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
=======
        Interesses i = new Interesses();
       

>>>>>>> db506cc00ceba627fc0706cef3a0797c4da1c76e
        public void carregaform(Form form)
        {
            form.TopLevel = false;

            wilBitGradientPanel1.Controls.Clear();
            wilBitGradientPanel1.Controls.Add(form);
            form.Show();

        }
        void rendeirizaInterface()
        {
            WindowState = FormWindowState.Maximized;

            int menuEsquerdo_largura = 63;
            int descricao_altura = 10;

            wilBitGradientPanel1.Location = new Point(0, 0);
            wilBitGradientPanel1.Size = new Size(ClientSize.Width, ClientSize.Height);
<<<<<<< HEAD

            panel1.Size = new Size(ClientSize.Width, 63);
            panelIconesPer.Location = new Point(ClientSize.Width / 2 - panelIconesPer.Width / 2);

            //label3.Location = new Point(ClientSize.Height / 2 - label3.Width / 2);
            //  label3.Location = new Point(ClientSize.Width / 2 - label3.Size.Width / 2, ClientSize.Height / 2 - label3.Size.Height / 2 - 300);

            //label1.Location = new Point(ClientSize.Height / 2 - label3.Width / 2);
            //label1.Location = new Point(ClientSize.Width / 2 - label3.Size.Width / 2, ClientSize.Height / 2 - label3.Size.Height / 2 - 100);

            // panelDescri.Location = new Point(ClientSize.Height - 100);
            // panelDescri.Location = new Point(ClientSize.Width / 2 - panelDescri.Size.Width / 2 -50 , ClientSize.Height / 2 - panelDescri.Size.Height / 2 - 30);


=======
>>>>>>> db506cc00ceba627fc0706cef3a0797c4da1c76e
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
<<<<<<< HEAD

        private void Perfil_Load(object sender, EventArgs e)
        {
            rendeirizaInterface();

            Usuario usuario = new Usuario();


            List<Usuario> usuarios = usuario.ListarUsuarios();

            foreach (Usuario u in usuarios)
            {
                label4.Text = (u.nome).ToString();
                wilBitTextBox6.Text = (u.descricao).ToString();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // botao do perfil
            carregaform(new Perfil());
        }

        private void label4_Click(object sender, EventArgs e)
        {

=======
        private void label4_Click(object sender, EventArgs e)
        {
>>>>>>> db506cc00ceba627fc0706cef3a0797c4da1c76e
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // label descricao
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //premium
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            
        }

        private void wilBitTextBox6__TextChanged(object sender, EventArgs e)
        {

            // descricao
        }

        private void wilBitGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Perfil_Load_1(object sender, EventArgs e)
        {
            lblNome.Text = Program.usuario.nome;
            wilBitTextBox6.Text = Program.usuario.descricao;
        }

        private void wilBitGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
