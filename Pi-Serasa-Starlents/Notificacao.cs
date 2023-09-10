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
    public partial class Notificacao : Form
    {
        public Notificacao()
        {
            InitializeComponent();
        }

        void renderizaInterface()
        {
            WindowState = FormWindowState.Maximized;

            int menuEsquerdo_largura = 63;


            wilBitGradientPanel1.Location = new Point(0, 0);
            wilBitGradientPanel1.Size = new Size(ClientSize.Width, ClientSize.Height);

            wilBitPanel1.Location = new Point(ClientSize.Width / 2 - wilBitPanel1.Size.Width / 2, ClientSize.Height / 2 - wilBitPanel1.Size.Height / 2);

            panelIcones.Location = new Point(ClientSize.Width / 2 - panelIcones.Width / 2);

            label3.Location = new Point(ClientSize.Height / 2 - label3.Width / 2);

            label3.Location = new Point(ClientSize.Width / 2 - label3.Size.Width / 2, ClientSize.Height / 2 - label3.Size.Height / 2 - 300);

        }


        private void wilBitPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Notificacao_Load(object sender, EventArgs e)
        {
            renderizaInterface();
        }

        private void wilBitGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelIcones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wilBitButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
