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


      

        }
        public TelaDoModerador()
        {
            InitializeComponent();

        }

     

        private void TelaDoModerador_Load(object sender, EventArgs e)
        {

           

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
            lblDetalhesDenuncia.Text = "Detalhes da denúncia";
            txtBiografiaMix.Text = "Biografia de Mix";
            txtBiografiaUsuario.Text = "Biografia do usuário";
            txtJustificativaBanimento.Texts = "";

            picFotoUsuario.ImageLocation = "https://imgur.com/6A1TpCB";
        }

        private void panelListaDenuncias_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TelaDoModerador_Load_1(object sender, EventArgs e)
        {

        }

        private void panel01_Click(object sender, EventArgs e)
        {
            lblUsuario.Text = "Nicolas";
            txtBiografiaMix.Text = "quem leu eh otariokkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk";
            txtBiografiaUsuario.Text = "oi! sou um cara legal, gosto de jogar lol e ficar em call com meus amigos no discord. :3";
            txtDetalhesDenuncia.Text = "Olha a bio desse cara moderador, não preciso nem falar nada né...";

            picFotoUsuario.ImageLocation = "https://imgur.com/CwKUseL";
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            lblUsuario.Text = "Junior";
            txtBiografiaMix.Text = "@JuniorDoces no Instagram, Juju Doces no YouTube, no meu último reels tem a receita" +
                "perfeita de chokito caseiro, me segue para aprender isso e muito mais!";
            txtBiografiaUsuario.Text = "Eu vou te ensinar a fazer os melhores doces da região!";
            txtDetalhesDenuncia.Text = "Olha só, venho aqui em nome da melhor empresa de Chokitos do Brasil," +
                "para DENUNCIAR esse homem, pois essa receita que ele citou está prejudicando meus negócios, só pode existir um!!!" +
                " - Com carinho, da melhor empresa de chokitos.";

            picFotoUsuario.ImageLocation = "https://imgur.com/ragZuSZ";
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            lblUsuario.Text = "Conradito";
            txtBiografiaMix.Text = "A MELHOR LINHA DE PRODUÇÃO DE CHOKITOS!!!! " +
                "@ConraditoChokito no YouTube, @melhoreschokitosdomundo no Instagram." +
                "COMPRE NOSSOS PRODUTOS!!!!!!!!!!";
            txtBiografiaUsuario.Text = "Olá! ^^ Sou uma pessoa muito gentil, e nada competitiva, amo compartilhar minhas" +
                " receitas e etc... Vamos dar um mix para trocarmos conhecimentos!";
            txtDetalhesDenuncia.Text = "OLHA SÓ SEU MODERADOR, ESSE CARA TA PREJUDICANDO MEU INSTAGRAM DE RECEITAS" +
                " SÓ PORQUE EU FIZ UMA RECEITA DE CHOKITO, NAO SABE COMPETIR!!!!!!!!!!!";

            picFotoUsuario.ImageLocation = "https://imgur.com/UAgNct5";
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            lblUsuario.Text = "Bianca";
            txtBiografiaMix.Text = "Oii! Gosto de desenhar e dançar, @BiaDance é meu Instagram de dança, eu costumo dançar KPOP, vou te ensinar sobre" +
                " alongamentos, estilos de dança e etc....";
            txtBiografiaUsuario.Text = "Oiii, eu danço e desenho!!";
            txtDetalhesDenuncia.Text = "não gosto de kpoper.";

            picFotoUsuario.ImageLocation = "https://imgur.com/Uqamx5Q";
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            lblUsuario.Text = "Julia";
            txtBiografiaMix.Text = "Me manda uma mensagem no whats para aprender sobre tecnicas de desenho (16)01100011-00100011 ";
            txtBiografiaUsuario.Text = "olá! eu trabalho com pintura em óleo profissional, e realismo!!!";
            txtDetalhesDenuncia.Text = "Fez um post com apologias racistas....";

            
            picFotoUsuario.ImageLocation = "https://imgur.com/Wg9LbVB";
        }

        private void panel01_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBanirUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario banido com sucesso!");
            lblUsuario.Text = "Usuario";
            lblDetalhesDenuncia.Text = "Detalhes da denúncia";
            txtBiografiaMix.Text = "Biografia de Mix";
            txtBiografiaUsuario.Text = "Biografia do usuário";
            txtJustificativaBanimento.Texts = "";

            picFotoUsuario.ImageLocation = "https://imgur.com/6A1TpCB";
        }
    }
}
