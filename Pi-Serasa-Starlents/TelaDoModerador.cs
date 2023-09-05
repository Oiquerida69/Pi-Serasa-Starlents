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
        public TelaDoModerador()
        {
            InitializeComponent();
        }

        private void TelaDoModerador_Load(object sender, EventArgs e)
        {

        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/Oiquerida69/Pi-Serasa-Starlents");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start("explorer.exe", "https://criarmeulink.com.br/u/1693942736");
        }
    }
}
