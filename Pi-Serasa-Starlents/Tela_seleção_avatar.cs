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
    public partial class Tela_seleção_avatar : Form
    {
        public string caminho01;
        

        Avatar avatar = new Avatar();
        public Tela_seleção_avatar()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tela_seleção_avatar_Load(object sender, EventArgs e)
        {

            pictureBox1.ImageLocation = avatar.caminho1;
            pictureBox2.ImageLocation = avatar.caminho2;
            pictureBox3.ImageLocation = avatar.caminho3;
            pictureBox4.ImageLocation = avatar.caminho4;
            pictureBox5.ImageLocation = avatar.caminho5;
            pictureBox6.ImageLocation = avatar.caminho6;
            pictureBox7.ImageLocation = avatar.caminho7;
            pictureBox8.ImageLocation = avatar.caminho8;
            pictureBox9.ImageLocation = avatar.caminho9;
            pictureBox10.ImageLocation = avatar.caminho10;
            pictureBox11.ImageLocation = avatar.caminho11;
            pictureBox12.ImageLocation = avatar.caminho12;
            pictureBox13.ImageLocation = avatar.caminho13;
            pictureBox14.ImageLocation = avatar.caminho14;
            pictureBox15.ImageLocation = avatar.caminho15;
            pictureBox16.ImageLocation = avatar.caminho16;
            pictureBox17.ImageLocation = avatar.caminho17;
            pictureBox18.ImageLocation = avatar.caminho18;
            


        }
        public string Pegacaminho()
        {
            if (radioButton1.Checked) { caminho01 = avatar.caminho1; }
            if (radioButton5.Checked) { caminho01 = avatar.caminho2; }
            if(radioButton4.Checked) { caminho01 = avatar.caminho3; }
            if (radioButton18.Checked) { caminho01 = avatar.caminho4; }
            if (radioButton8.Checked) { caminho01 = avatar.caminho5; }
            if (radioButton3.Checked) { caminho01 = avatar.caminho6; }
            if (radioButton2.Checked) { caminho01 = avatar.caminho7; }
            if (radioButton6.Checked) { caminho01 = avatar.caminho8; }
            if (radioButton17.Checked) { caminho01 = avatar.caminho9; }
            if (radioButton13.Checked) { caminho01 = avatar.caminho11; }
            if (radioButton14.Checked) { caminho01 = avatar.caminho12; }
            if (radioButton15.Checked) { caminho01 = avatar.caminho13; }
            if (radioButton16.Checked) { caminho01 = avatar.caminho14; }
            if (radioButton12.Checked) { caminho01 = avatar.caminho15; }
            if (radioButton11.Checked) { caminho01 = avatar.caminho16; }
            if (radioButton10.Checked) { caminho01 = avatar.caminho17; }
            if (radioButton9.Checked) { caminho01 = avatar.caminho18; }
            return caminho01;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }
    }
}
