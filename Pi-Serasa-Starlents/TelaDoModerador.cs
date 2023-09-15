using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Net.Mail;
using WiLBiT;
using System.Security.Cryptography.X509Certificates;

namespace Pi_Serasa_Starlents
{


    public partial class TelaDoModerador : Form
    {
        Usuario usuario = new Usuario();
        List<Usuario> usuarios = new List<Usuario>();
        List<TelaDoModerador> denuncias = new List<TelaDoModerador>();


        public void geraForm(string nome, string avatar, string descricao)
        {
            // Painel que fica listado o usuário.
            Panel painel = new Panel();
            painel.Name = "painel";
            painel.BackColor = Color.FromArgb(228, 193, 249);
            painel.ForeColor = Color.White;
            painel.Size = new Size(174, 50);
            painel.Location = new Point(12, panelListaDenuncias.Height);
            painel.Click += clique;
            painel.Cursor = Cursors.Hand;

            // A cada clique ele muda as seguintes informações na tela principal
            void clique(object sender, EventArgs e)
            {
                lblUsuario.Text = nome;
                txtBiografiaMix.Text = descricao;

                lblUsuario.ForeColor = Color.FromArgb(52, 11, 66);


            }
            // Esse é o label que contém o nome do usuário na min
            Label label = new Label();
            label.Text = nome;  //label.Text = $"{usuario.buscarnome(nome)}";
            label.AutoSize = true;
            label.Size = new Size(0, 0);
            label.Location = new Point(painel.Width / 2, painel.Height / 2);
            label.ForeColor = Color.Purple;
            label.Font = new Font("Microsoft Sans Serif", 12);
            label.Click += clique;

            PictureBox picFotoUsuario = new PictureBox();
            picFotoUsuario.Location = new Point(painel.Width / 2, painel.Height /2);
            picFotoUsuario.Name = "picFotoUsuario";
            picFotoUsuario.Size = new Size(42, 42);
            picFotoUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            //picFotoUsuario.BackgroundImage = uavatar;
            picFotoUsuario.TabIndex = 1;
            picFotoUsuario.TabStop = false;
            picFotoUsuario.Click += clique;


            panelListaDenuncias.Controls.Add(painel);
            painel.Controls.Add(label);
            painel.Controls.Add(picFotoUsuario);
            if (panelListaDenuncias.Height < 500)
            {
                panelListaDenuncias.Height += painel.Height + 5;

            }



        }
        public TelaDoModerador()
        {
            InitializeComponent();
            this.SizeChanged += new EventHandler(TelaDoModerador_SizeChanged);
            // Faz com que o comando de maximizar funcione

        }



        private void TelaDoModerador_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // A janela está maximizada, faça algo aqui
                picFotoUsuario.Height = ClientSize.Width / 5;
                picFotoUsuario.Width = ClientSize.Width / 5;

                lblUsuario.AutoSize = true;
                lblUsuario.Font = new Font("Microsoft Sans Serif", 26);
                lblUsuario.Location = new Point(ClientSize.Width / 6, ClientSize.Height / 2);


                lblBiografiaDeMix.Location = new Point(ClientSize.Width / 6, ClientSize.Height / 2 + 50);
                txtBiografiaMix.Location = new Point(ClientSize.Width / 6, ClientSize.Height / 2 + 80);
                txtBiografiaMix.Height = ClientSize.Height / 6;
                txtBiografiaMix.Width = ClientSize.Width / 5;

            }

        }


        private void TelaDoModerador_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            //panelPerfilDenunciado.Hide();
            List<Usuario> usuarios = usuario.ListarUsuarios();


            foreach (Usuario u in usuarios)
            {
                geraForm(u.nome, u.avatar, u.mensagemUsuario);
            }

        }


        // Esse botão é o de acessar código. Ele direciona o moderador ao github dos Devs onde existe o código completo.
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/Oiquerida69/Pi-Serasa-Starlents");
        }

        // Esse botão é o de enviar relatório. Ele direciona o moderador para um link que envia e-mails direto para os Devs principais.
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://criarmeulink.com.br/u/1693942736");
        }

        private void panelPerfilDenunciado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wilBitPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSuspendeDenuncia_Click(object sender, EventArgs e)
        {


        }

        private void picFotoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnSuspendeDenuncia_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("A denúncia foi suspensa.");
            lblUsuario.Text = "Usuario";
            lbl_idUsuario.Text = "01";
            txtBiografiaMix.Text = "Biografia de Mix";
            txtBiografiaUsuario.Text = "Biografia do usuário";
            txtDetalhesDenuncia.Text = "Detalhes da denúncia";
            txtJustificativaBanimento.Texts = "";
        }

        private void btnBanirUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
