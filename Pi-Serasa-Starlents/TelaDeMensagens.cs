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
        List<Usuario> usuarios = new List<Usuario>();
        
        public TelaDeMensagens()
        {
            InitializeComponent();
        }
        void geraform(string nome)
        {
            Panel painel = new Panel();
            Label label = new Label();
            label.Text = $"{nome}";
            label.AutoSize = true;
            label.Size = new Size(0, 0);
            label.ForeColor = Color.White;

            painel = new WiLBiT.WiLBiTPanel();
            painel.BackColor = Color.FromArgb(228, 193, 249);
            painel.Controls.Add(label);
            painel.Controls.Add(wilBitRoundedPictureBox2);
            painel.ForeColor = Color.White;
            painel.Name = "painel";
            painel.Size = new Size(174, 50);
            void clickar(object sender, EventArgs e)
            {
                painel.BackColor = Color.Purple;

            }
            painel_Lista.Controls.Add(painel);
            painel.Location = new Point(12, painel_Lista.Height);
            if (painel_Lista.Height > 500)
            {
                painel_Lista.Height += painel.Height + 10;
            }


        }
        private void TelaDeMensagens_Load(object sender, EventArgs e)
        {

            Usuario u1 = new Usuario(1,"wendell","micvcb1026@gmail.com","wendell","16-9999999","oi","c/masowdm/cmoamd");
            Usuario u2 = new Usuario(1,"wendell","micvcb1026@gmail.com","wendell","16-9999999","oi","c/masowdm/cmoamd");
            Usuario u3 = new Usuario(1,"wendell","micvcb1026@gmail.com","wendell","16-9999999","oi","c/masowdm/cmoamd");
            usuarios.Add(u1);
            usuarios.Add(u2);
            usuarios.Add(u3);

            foreach (Usuario u in usuarios  )
            {
                geraform(u.nome);
            }





        }
    }
        
}
