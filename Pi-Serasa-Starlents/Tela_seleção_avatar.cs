using MetroFramework.Properties;
using Pi_Serasa_Starlents.Properties;
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
        public string caminho01 = "";
        
        
        Avatar avatar = new Avatar();
        public Tela_seleção_avatar(string caminho_avatar)
        {
            this.caminho01 = caminho_avatar;
            InitializeComponent();
        }
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
        public void gerapictures(int NDI, string caminho)
        {

            /*
            PictureBox pic = new PictureBox();
            pic.Name = "Pic";
            pic.Size = new Size()
                WiLBiT.WiLBiTRoundedPictureBox picFotoUsuario = new WiLBiT.WiLBiTRoundedPictureBox();
            picFotoUsuario.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            picFotoUsuario.BorderColor = Color.FromArgb(64, 15, 87);
            picFotoUsuario.BorderColor2 = Color.FromArgb(64, 15, 87);
            picFotoUsuario.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            picFotoUsuario.BorderSize = 2;
            picFotoUsuario.GradientAngle = 50F;
            picFotoUsuario.Location = new Point(12, 5);
            picFotoUsuario.Name = "picFotoUsuario";
            picFotoUsuario.Size = new Size(42, 42);
            picFotoUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            picFotoUsuario.TabIndex = 1;
            picFotoUsuario.TabStop = false;


            painel_Lista.Controls.Add(painel);
            painel.Controls.Add(label);
            painel.Controls.Add(picFotoUsuario);
            if (painel_Lista.Height < 500)
            {
                painel_Lista.Height += painel.Height + 10;

            }
            */
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            Tela_seleção_avatar tela = new Tela_seleção_avatar(avatar.caminho1);
            tela.Hide();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Cadastro.pictureBox1.ImageLocation = avatar.caminho2;
            Tela_seleção_avatar tela = new Tela_seleção_avatar(avatar.caminho2);
            tela.Hide();
            this.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            Tela_seleção_avatar tela = new Tela_seleção_avatar(avatar.caminho3);
            tela.Hide();
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

            Tela_seleção_avatar tela = new Tela_seleção_avatar(avatar.caminho4);
            tela.Hide();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

            Tela_seleção_avatar tela = new Tela_seleção_avatar(avatar.caminho5);
            tela.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            Tela_seleção_avatar tela = new Tela_seleção_avatar(avatar.caminho6);
            tela.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            Tela_seleção_avatar tela = new Tela_seleção_avatar(avatar.caminho7);
            tela.Hide();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

            Tela_seleção_avatar tela = new Tela_seleção_avatar(avatar.caminho8);
            tela.Hide();
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {

            Tela_seleção_avatar tela = new Tela_seleção_avatar(avatar.caminho9);
            tela.Hide();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

            Tela_seleção_avatar tela = new Tela_seleção_avatar(avatar.caminho10);
            tela.Hide();
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

            Tela_seleção_avatar tela = new Tela_seleção_avatar(avatar.caminho11);
            tela.Hide();
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

            Tela_seleção_avatar tela = new Tela_seleção_avatar(avatar.caminho12);
            tela.Hide();
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

            Tela_seleção_avatar tela = new Tela_seleção_avatar(avatar.caminho13);
            tela.Hide();
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

            Tela_seleção_avatar tela = new Tela_seleção_avatar(avatar.caminho14);
            tela.Hide();
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

            Tela_seleção_avatar tela = new Tela_seleção_avatar(avatar.caminho15);
            tela.Hide();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

            Tela_seleção_avatar tela = new Tela_seleção_avatar(avatar.caminho16);
            tela.Hide();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

            Tela_seleção_avatar tela = new Tela_seleção_avatar(avatar.caminho17);
            tela.Hide();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

            Tela_seleção_avatar tela = new Tela_seleção_avatar(avatar.caminho18);
            tela.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (caminho01 == null)
            {
                MessageBox.Show("Você não selecionou um avatar!");
                return;

            }
            else
            {
                
               
                
            }
           

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
