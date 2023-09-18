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
    public partial class TelaDeInicio : Form
    {

        List<Usuario> usuarios;
        int mostrando = 0;
        int id_mostrando = 0;

        public TelaDeInicio()
        {
            InitializeComponent();
        }

        void mostraPerfil()
        {

            if (usuarios == null)
            {
                MessageBox.Show("Ninguem para dar match com voce");
                return;
            }

            Usuario usuario = usuarios[mostrando];
            id_mostrando = usuario.id;
            lblNomeUsuario.Text = usuario.nome;
            lblDescricao.Text = usuario.descricao;
            lblTalento01.Text = usuario.interesse01;
            lblTalento02.Text = usuario.interesse02;
            lblTalento03.Text = usuario.interesse03;
            picFotoUsuario.ImageLocation = usuario.avatar;

            if (mostrando + 1 > usuarios.Count - 1)
            {
                MessageBox.Show("Você visualizou todos os perfis compativeis com você ");
            }
            else
            {
                mostrando += 1;
            }

        }

        void expandetela()
        {
            WindowState = FormWindowState.Maximized;
            panel1.Size = new Size(ClientSize.Width, 70);
            pictureBox1.Location = new Point(panel1.Size.Width / 2, 0);
            pictureBox2.Location = new Point(panel1.Size.Width / 4, 0);
            pictureBox4.Location = new Point(panel1.Size.Width / 2 + 300, 0);
            picFotoUsuario.Location = new Point(ClientSize.Width / 6, ClientSize.Height / 3);
            panel6.Location = new Point(picFotoUsuario.Width + 280, ClientSize.Height / 3);
            panel6.Size = new Size(300,245);
            btnDescurtida.Location = new Point(picFotoUsuario.Width + 280, panel6.Height + 260);
            btnCurtida.Location = new Point(picFotoUsuario.Width + 520, panel6.Height + 260);
            wilBitGradientPanel1.Size = new Size(ClientSize.Width, ClientSize.Height);
            label2.Location = new Point(ClientSize.Width - 500, ClientSize.Height / 2 - 200);
            lblNomeUsuario.Location = new Point(ClientSize.Width / 6, ClientSize.Height / 2 - 200);
            lblTalento01.Location = new Point(ClientSize.Width - 500, ClientSize.Height / 2 - 150);
            lblTalento02.Location = new Point(ClientSize.Width - 500, ClientSize.Height / 2 - 50);
            lblTalento03.Location = new Point(ClientSize.Width - 500, ClientSize.Height / 2 - (-50) );

            wilBitGradientPanel1.Location = new Point(ClientSize.Width / 2 - wilBitGradientPanel1.Size.Width / 2, ClientSize.Height / 2 - wilBitGradientPanel1.Size.Height / 2);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.Show();
            Form1.panel1.Controls.Clear();
            perfil.TopLevel = false;
            Form1.panel1.Controls.Add(perfil);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TelaDeMensagens tela = new TelaDeMensagens();
            Form1.panel1.Controls.Clear();
            tela.Show();
            tela.TopLevel = false;
            Form1.panel1.Controls.Add(tela);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Notificacao not = new Notificacao();
            Form1.panel1.Controls.Clear();
            not.Show();
            not.TopLevel = false;
            Form1.panel1.Controls.Add(not);
        }

        private void TelaDeInicio_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuarios = usuario.buscaPerfil(Program.usuario.id, Program.usuario.interesse01, Program.usuario.interesse02, Program.usuario.interesse03);
            mostraPerfil();
            expandetela();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCurtida_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Curtida(Program.usuario.id, id_mostrando, true);
            mostraPerfil();
        }

        private void btnDescurtida_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Curtida(Program.usuario.id, id_mostrando, false);
            mostraPerfil();
        }
    }
}
