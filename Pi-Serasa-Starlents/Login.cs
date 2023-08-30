using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiLBiT;

namespace Pi_Serasa_Starlents
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void carregaForm(Form form)
        {
            form.TopLevel = false;
            wilBitGradientPanel1.Controls.Clear();
            wilBitGradientPanel1.Controls.Add(form);
            form.Show();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void wilBitButton2_Click(object sender, EventArgs e)
        {
            carregaForm(new Cadastro());
        }
    }
}
