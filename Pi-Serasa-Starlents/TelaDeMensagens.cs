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
    public partial class TelaDeMensagens : Form
    {
        Usuario usuario = new Usuario();
        
        List<Usuario> usuarios = new List<Usuario>();
        public TelaDeMensagens()
        {
            InitializeComponent();
        }
        void geraform(Usuario usuario)
        {
            Panel painel = new Panel();
            Label label = new Label();
            label.Text = $"{usuario.nome}";
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
            void clickar(object sender , EventArgs e)
            {
                painel.BackColor = Color.Purple;

            }
            painel_Lista.Controls.Add(painel);
            painel.Location = new Point(12, painel_Lista.Height);
            if(painel_Lista.Height > 500)
            {
                painel_Lista.Height += painel.Height + 10;
            }
            

        }
        private void TelaDeMensagens_Load(object sender, EventArgs e)
        {

            
            foreach (Usuario i in usuarios)
            {
                geraform(i); 
            }





        }
    }
}
