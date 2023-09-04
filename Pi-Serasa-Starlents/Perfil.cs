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
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        void rendeirizaInterface()
        {
            WindowState = FormWindowState.Maximized;

            int menuEsquerdo_largura = 63;

            wilBitGradientPanel1.Location = new Point(0, 0);
            wilBitGradientPanel1.Size = new Size(ClientSize.Width, ClientSize.Height);

            panel1.Size = new Size(ClientSize.Width,63);
            panelIconesPer.Location = new Point(ClientSize.Width / 2 - panelIconesPer.Width / 2);

            label3.Location = new Point(ClientSize.Height / 2 - label3.Width / 2);
            label3.Location = new Point(ClientSize.Width / 2 - label3.Size.Width / 2, ClientSize.Height / 2 - label3.Size.Height / 2 - 300);

            
            pictureBox1.Location = new Point(ClientSize.Width / 2, 0 );
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            rendeirizaInterface();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
