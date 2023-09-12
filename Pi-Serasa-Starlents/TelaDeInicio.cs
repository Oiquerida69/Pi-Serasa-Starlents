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




        public TelaDeInicio()
        {
            InitializeComponent();
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
            List<Usuario> usuarios = usuario.buscaPerfil(Program.usuario.interesse);


        }
    }
}
