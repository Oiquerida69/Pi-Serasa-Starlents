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
            WindowState= FormWindowState.Maximized;


            panelCima.Location = new Point(63, 0);
            panelCima.Size = new Size(ClientSize.Width, 63);

        }


        private void wilBitPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Notificacao_Load(object sender, EventArgs e)
        {
            renderizaInterface();
        }
    }
}
