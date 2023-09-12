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

        Interesses i = new Interesses();
       

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

        private void Perfil_Load(object sender, EventArgs e)
        {
            rendeirizaInterface();

            lblNome.Text = Program.usuario.nome;
            wilBitTextBox6.Text = Program.usuario.descricao;
            //wilBitComboBox4.Text= Program.usuario
           // wilBitComboBox5.Text = Program.usuario
            wilBitTextBox1.Text = Program.usuario.mensagemUsuario;
        }
        private void label4_Click(object sender, EventArgs e)
        {
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
    }
}
