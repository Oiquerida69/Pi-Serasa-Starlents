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
        public void carregaform(Form form)
        {
            form.TopLevel = false;

            wilBitGradientPanel1.Controls.Clear();
            wilBitGradientPanel1.Controls.Add(form);
            form.Show();

        }
        void rendeirizaInterface()
        {
            
            this.WindowState = FormWindowState.Maximized;

            wilBitGradientPanel1.Location = new Point(0, 0);
            wilBitGradientPanel1.Size = new Size(ClientSize.Width, ClientSize.Height);
            wilBitPanelTaInt.Location = new Point(1400, 250);
            wilBitButton1.Location = new Point(1410, 590);
            panel1.Location = new Point(0, 0);
            panel1.Size = new Size(ClientSize.Width, 44);
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Size = new Size(ClientSize.Width, 50);
            label3.Location = new Point(ClientSize.Width/2 - 80 , ClientSize.Height /2 -452 );
            label3.Size = new Size(452, 100);
            wilBitPanel1Dese.Location = new Point(850, 450);
            wilBitPanel3Foto.Location = new Point(400, 250);
            wilBitTextBox6.Location = new Point(wilBitPanel3Foto.Width +150 , wilBitPanel3Foto.Height + 410);
            label5.Location = new Point(wilBitPanel3Foto.Width + 230, wilBitPanel3Foto.Height + 385);
           
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
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
        }

        private void wilBitTextBox6__TextChanged(object sender, EventArgs e)
        {
        }

        private void wilBitGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Perfil_Load_1(object sender, EventArgs e)
        {
            rendeirizaInterface();
            WindowState = FormWindowState.Maximized;
            pictureBox1.ImageLocation = Program.usuario.avatar;
            lblNome.Text = Program.usuario.nome;
            wilBitTextBox6.Texts = Program.usuario.descricao;
            wilBitTextBox1.Texts = Program.usuario.mensagemUsuario;
            wilBitTextBox2.Texts = Program.usuario.interesse01; 
            wilBitTextBox3.Texts = Program.usuario.interesse02;
            wilBitTextBox4.Texts = Program.usuario.interesse03;
            wilBitTextBox5.Texts = Program.usuario.aprender;
            wilBitTextBox7.Texts = Program.usuario.aprender2;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TelaDeInicio telaDeInicio= new TelaDeInicio();
            telaDeInicio.TopLevel = false;
            Form1.wilBitGradientPanel3.Controls.Clear();
            Form1.wilBitGradientPanel3.Controls.Add(telaDeInicio);
            telaDeInicio.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://z0l410j1jxi3uj0d.umso.co");
        }
    }
}
