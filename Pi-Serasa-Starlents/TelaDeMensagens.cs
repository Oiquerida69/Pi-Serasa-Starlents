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

namespace Pi_Serasa_Starlents
{
    public partial class TelaDeMensagens : Form
    {
        Usuario usuario = new Usuario();
        //List<string> usuarios = new List<string>{"wendell","Mirela","Mario"};
        List<Usuario> usuarios = new List<Usuario>();

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
            painel.Location = new Point(12, painel.Height);


            Label label = new Label();
            label.Text = nome;  //label.Text = $"{usuario.buscarnome(nome)}";
            label.AutoSize = true;
            label.Size = new Size(0, 0);
            label.ForeColor = Color.White;



            painel_Lista.Controls.Add(painel);
            painel.Controls.Add(label);
            painel.Controls.Add(wilBitRoundedPictureBox2);
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
        private void TelaDeMensagens_Load(object sender, EventArgs e)
        {
            /*
            foreach (string usuario in  usuarios )
            {
                geraform(usuario);
            }
            */
            
            foreach (Usuario u in usuarios)
            {
                MessageBox.Show($"{usuario.nome}");
                geraform(u.nome);
            }
           
        }

        private void panelUsuarioNoChat_Paint(object sender, PaintEventArgs e)
        {






        }
    }

}
