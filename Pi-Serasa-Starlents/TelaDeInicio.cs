using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pi_Serasa_Starlents
{
    public partial class TelaDeInicio : Form
    {

        List<Usuario> usuarios;
        int mostrando = 0;

        public TelaDeInicio()
        {
            InitializeComponent();
        }

        void mostraPerfil()
        {

            Usuario usuario = usuarios[mostrando];
            lblNomeUsuario.Text = usuario.nome;
            lblDescricao.Text = usuario.descricao;
            lblTalento01.Text = usuario.interesse01;
            lblTalento02.Text = usuario.interesse02;

            if (mostrando + 1 > usuarios.Count-1)
            {
                MessageBox.Show("Você ´visuaouzlou aishdaosdoa jds");
            }
            else
            {
                mostrando += 1;
            }

        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            Form1.panel1.Controls.Clear();
            perfil.TopLevel = false;
            Form1.panel1.Controls.Add(perfil);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TelaDeMensagens tela = new TelaDeMensagens();
            Form1.panel1.Controls.Clear();
            tela.TopLevel = false;
            Form1.panel1.Controls.Add(tela);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Notificacao not = new Notificacao();
            Form1.panel1.Controls.Clear();
            not.TopLevel = false;
            Form1.panel1.Controls.Add(not);
        }

        private void TelaDeInicio_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuarios = usuario.buscaPerfil( Program.usuario.id, Program.usuario.interesse01, Program.usuario.interesse02, Program.usuario.interesse03);
            mostraPerfil();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCurtida_Click(object sender, EventArgs e)
        {
            mostraPerfil();
        }
    }
}
