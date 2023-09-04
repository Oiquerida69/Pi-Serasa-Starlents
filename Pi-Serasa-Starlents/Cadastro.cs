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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }


        private void Cadastro_Load(object sender, EventArgs e)
        {


        }

        private void wilBitButton1_Click(object sender, EventArgs e)
        {
            string nome = wilBitTextBox4.Text;
            string emmail = wilBitTextBox1.Text;
            string senha = wilBitTextBox2.Text;
            string telefone = wilBitTextBox3.Text;


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
