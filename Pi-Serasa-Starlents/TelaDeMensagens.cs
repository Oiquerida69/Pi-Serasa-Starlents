using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
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

namespace Pi_Serasa_Starlents
{
    public partial class TelaDeMensagens : Form
    {
        Usuario usuario = new Usuario();
        //List<string> usuarios = new List<string>{"wendell","Mirela","Mario"};
        List<Usuario> usuarios = new List<Usuario>();
        List<TelaDeMensagens> mensagens = new List<TelaDeMensagens>();

        public TelaDeMensagens()
        {
            InitializeComponent();
        }
        

        public void geraform(string nome, string avatar, string descricao)
        {


            Panel painel = new WiLBiT.WiLBiTPanel();
            painel.Name = "painel";
            painel.BackColor = Color.FromArgb(228, 193, 249);
            painel.ForeColor = Color.White;
            painel.Size = new Size(174, 50);
            painel.Location = new Point(12, painel_Lista.Height);
            painel.Click += clique;

            void clique(object sender, EventArgs e)
            {
                lblNome.Text = nome;
                lblDescricaoDeMatch.Text = descricao;
                fotoUsuario.ImageLocation = avatar;


                lblNome.ForeColor = Color.Black;
            }
            Label label = new Label();
            label.Text = nome;  //label.Text = $"{usuario.buscarnome(nome)}";
            label.AutoSize = true;
            label.Size = new Size(0, 0);
            label.Location = new Point(painel.Width / 2, painel.Height / 2);
            label.ForeColor = Color.Purple;
            label.Font = new Font("Microsoft Sans Serif", 12);
            label.Click += clique;

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
            picFotoUsuario.Click += clique;


            painel_Lista.Controls.Add(painel);
            painel.Controls.Add(label);
            painel.Controls.Add(picFotoUsuario);
            if (painel_Lista.Height < 500)
            {
                painel_Lista.Height += painel.Height + 10;

            }


            /*
            Panel panel = new Panel();
            panel.Name = "panel";
            panel.BackColor = Color.FromArgb(228, 193, 249);
            panel.Size = new Size(174, 50);

            Label label = new Label();
            label.Name = "label";
            label.Text = "Wendell";
            label.AutoSize = true;
            label.Location = new Point(12, panel.Height);

            panel.Controls.Add(label);
            panel.Controls.Add(panel);

            panel.Location = new Point(12, panel.Height);

            if (panel.Height < 300)
            {

                     panel.Height += panel.Height + 10;
            }
            panel.Controls.Add(panel);
            */
            
        }

        private void panel1_click(object sender, PaintEventArgs e)
        {
            atualizaInterface(usuario.nome, usuario.avatar, usuario.descricao);
           

        }
        public void atualizaInterface (string nome, string avatar, string descricao )
        {
            WiLBiTPanel panel= new WiLBiTPanel();
            panel.Size = new Size(530, 400);
            panel.Location = new Point(18, 12);
            panel.Show();
            

            WiLBiTRoundedPictureBox pic = new WiLBiTRoundedPictureBox();
            pic.Size = new Size(83, 83);
            pic.Location = new Point(19, 14);
            pic.ImageLocation = avatar;

            //NOME USUÁRIO
            Label label= new Label();
            label.Size = new Size(128,37);
            label.Location = new Point(108, 38);
            label.Text = nome;

            //DESCRIÇÃO
            Label label1= new Label();
            label1.Size = new Size(170,15);
            label1.Location = new Point(29, 112);
            label1.Text = descricao;
            
            panel.Controls.Add(label);
            panel.Controls.Add(label1);
            panel.Controls.Add(pic);

        }
        public void carregaForm(Form form)
        {
           
            form.TopLevel = false;
        }

        private void TelaDeMensagens_Load(object sender, EventArgs e)
        {

        }

        private void panelUsuarioNoChat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TelaDeMensagens_Load_1(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnDenunciaUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVoltaInicio_Click(object sender, EventArgs e)
        {

        }

        private void TelaDeMensagens_Load_2(object sender, EventArgs e)
        {
         

            

        }

        private void wilBitPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TelaDeMensagens_Load_3(object sender, EventArgs e)
        {
            
            panelUsuarioNoChat.Hide();
            List<Usuario> usuarios = usuario.ListarUsuarios();


            foreach (Usuario u in usuarios)
            {

                

                geraform(u.nome, u.avatar, u.mensagemUsuario);
            }
        }

        private void btnVoltaInicio_Click_1(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;


            //if (panel1.Visible)
            //{
            //    panel1.Visible = false;
            //}

            //if (panel2.Visible)
            //{
            //    panel2.Visible = false;
            //}

            //if (wilBitPanel2.Visible)
            //{
            //    wilBitPanel2.Visible = false;

            //}

            //if (panel4.Visible)
            //{
            //    panel4.Visible = false;
            //}

            //if (painel_Lista.Visible)
            //{
            //    painel_Lista.Visible = false;
            //}

            this.Hide ();
            TelaDeInicio telaDeInicio = new TelaDeInicio();
            panel2.Location = new Point(0, 0);
            telaDeInicio.Size = new Size(ClientSize.Width, ClientSize.Height);
            telaDeInicio.Show();
        }

        private void btnDenunciaUsuario_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;


            this.Hide();
            TelaDeDenuncia telaDeDenuncia = new TelaDeDenuncia();
            panel2.Location = new Point(0, 0);
            telaDeDenuncia.Size = new Size(ClientSize.Width, ClientSize.Height);
            telaDeDenuncia.Show();
        }
    }

}
