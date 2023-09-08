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
        public void geraform(string nome)
        {

            Panel painel = new WiLBiT.WiLBiTPanel();
            painel.Name = "painel";
            painel.BackColor = Color.FromArgb(228, 193, 249);
            painel.ForeColor = Color.White;
            painel.Name = "painel";
            painel.Size = new Size(174, 50);
            painel.Location = new Point(12, painel_Lista.Height);

            Label label = new Label();
            label.Text = nome;  //label.Text = $"{usuario.buscarnome(nome)}";
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

        public void carregaForm(Form form)
        {

            form.TopLevel = false;



        }
        private void TelaDeMensagens_Load(object sender, EventArgs e)
        {
            panelUsuarioNoChat.Hide();
            List<Usuario> usuarios = usuario.ListarUsuarios();


            foreach (Usuario u in usuarios)
            {

                geraform(u.nome);
            }

        }

        private void panelUsuarioNoChat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEnviaMensagem_Click(object sender, EventArgs e)
        {

        }

        private void btnDenunciaUsuario_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wilBitPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TelaDeMensagens_Load_1(object sender, EventArgs e)
        {
            panelUsuarioNoChat.Hide();
            List<Usuario> usuarios = usuario.ListarUsuarios();


            foreach (Usuario u in usuarios)
            {

                geraform(u.nome);
            }
        }
    }

}
