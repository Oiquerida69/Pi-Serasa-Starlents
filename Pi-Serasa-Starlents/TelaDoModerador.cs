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

namespace Pi_Serasa_Starlents
{


    public partial class TelaDoModerador : Form
    {
        Usuario usuario = new Usuario();
        List<Usuario> usuarios = new List<Usuario>();


        public void geraForm()
        {


            Panel painel = new WiLBiT.WiLBiTPanel();
            painel.Name = "painel";
            painel.BackColor = Color.FromArgb(228, 193, 249);
            painel.ForeColor = Color.White;
            painel.Size = new Size(180, 50);
            painel.Location = new Point(12, panelListaDenuncias.Height);

            Label label = new Label();
            label.Text = usuario.nome;
            label.AutoSize = true;
            label.Size = new Size(0, 0);
            label.Location = new Point(painel.Width / 2, painel.Height / 2);
            label.ForeColor = Color.Purple;
            label.Font = new Font("Microsoft Sans Serif", 12);

            WiLBiT.WiLBiTRoundedPictureBox picFotoUsuario = new WiLBiT.WiLBiTRoundedPictureBox();
            picFotoUsuario.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            picFotoUsuario.BorderColor = Color.FromArgb(64, 15, 87);
            picFotoUsuario.BorderColor2 = Color.FromArgb(64, 15, 87);
            picFotoUsuario.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            picFotoUsuario.BorderSize = 2;
            picFotoUsuario.GradientAngle = 50F;
            picFotoUsuario.Location = new Point(12, 5);
            picFotoUsuario.Name = "picFotoUsuario";
            picFotoUsuario.Size = new Size(42, 42);
            picFotoUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            picFotoUsuario.TabIndex = 1;
            picFotoUsuario.TabStop = false;


            panelListaDenuncias.Controls.Add(painel);
            painel.Controls.Add(label);
            painel.Controls.Add(picFotoUsuario);
            if (panelListaDenuncias.Height < 10)
            {
                panelListaDenuncias.Height += painel.Height + 10;

            }



        }
        public TelaDoModerador()
        {
            InitializeComponent();

        }

        public void expandeTela()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                picFotoUsuario.Height = 500;
                picFotoUsuario.Width = 500;
            }

        }

        private void TelaDoModerador_Load(object sender, EventArgs e)
        {

            lblNomeMiniatura = new Label();
            //picFotoMiniatura = new WiLBiT.WiLBiTRoundedPictureBox();

            //picFotoUsuario = picFotoMiniatura;
            lblUsuario = lblNomeMiniatura;

            //lblBiografiaUsuario = new Label();
            //lblBiografiaMix = new Label();

            lblDetalhesDenuncia = new Label();
            //lblidUsuario = new Label();

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
            //lblidUsuario.Text = "000000000";
            lbl_idUsuario.Text = "01";
            lblDetalhesDenuncia.Text = "Detalhes da denúncia";
            txtBiografiaMix.Text = "Biografia de Mix";
            txtBiografiaUsuario.Text = "Biografia do usuário";
            txtJustificativaBanimento.Texts = "";
        }


    }
}
