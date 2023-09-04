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
        public string caminho02;
        public string caminho03;
        public string caminho04;
        public string caminho05;
        public string caminho06;
        public string caminho07;
        public string caminho08;
        public string caminho09;
        public string caminho10;
        public string caminho11;
        public string caminho12;
        public string caminho13;
        public string caminho14;
        public string caminho15;
        public string caminho16;
        public string caminho17;
        public string caminho18;

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { caminho01 = avatar.caminho1; }
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked) { caminho02 = avatar.caminho2; }
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) { caminho03 = avatar.caminho3; }
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton18.Checked) { caminho04 = avatar.caminho4; }
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked) { caminho05 = avatar.caminho5; }
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) { caminho06 = avatar.caminho6; }
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) { caminho07 = avatar.caminho7; }
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked) { caminho08 = avatar.caminho8; }
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton17.Checked) { caminho09 = avatar.caminho9; }
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked) { caminho10 = avatar.caminho10; }
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked) { caminho11 = avatar.caminho11; }
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked) { caminho12 = avatar.caminho12; }
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked) { caminho13 = avatar.caminho13; }
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked) { caminho14 = avatar.caminho14; }
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked) { caminho15 = avatar.caminho15; }
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked) { caminho16 = avatar.caminho16; }
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked) { caminho17 = avatar.caminho17; }
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked) { caminho18 = avatar.caminho18; }
            Tela_seleção_avatar tela = new Tela_seleção_avatar();
            tela.Hide();
        }
    }
}
