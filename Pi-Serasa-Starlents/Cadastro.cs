﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiLBiT;

namespace Pi_Serasa_Starlents
{
    public partial class Cadastro : Form
    {
        string caminhoprincipal;
        public Cadastro()
        {
            InitializeComponent();
        }
        Tela_seleção_avatar tela_Seleção_Avatar = new Tela_seleção_avatar();
        TelaDeInicio inicio = new TelaDeInicio();
        
        

        

        private void Cadastro_Load(object sender, EventArgs e)
        {
            GradientPanelCadastro.Size = new Size(ClientSize.Width, ClientSize.Height);

        }


        private void GradientPanelCadastro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wilBitButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Tela_seleção_avatar tela_Seleção_Avatar = new Tela_seleção_avatar();
            tela_Seleção_Avatar.Show();




        }
        public void geraform(Form form)
        {
            form.TopLevel = false;
            GradientPanelCadastro.Controls.Clear();
            GradientPanelCadastro.Controls.Add(form);
            form.Location = new Point(form.Width / 2 - form.Height / 2);
            form.AutoSize = true;
            form.Size = new Size(ClientSize.Width, ClientSize.Height);
            form.Show();
        }

        private void wilBitComboBox3_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void wilBitButton1_Click_2(object sender, EventArgs e)
        {
            int id = 0;
            string caminho = tela_Seleção_Avatar.caminho01;
            string nome = wilBitTextBox4.Texts;
            string email = wilBitTextBox1.Texts;
            string senha = wilBitTextBox2.Texts;
            string telefone = wilBitTextBox3.Texts;
            string avatar = pictureBox1.ImageLocation;
            string descricao = wilBitTextBox5.Texts;
            Usuario usuariototal = new Usuario(id,nome, email, senha, telefone, descricao, avatar);
            Program.usuario.CadastrarUsuario(usuariototal);
            MessageBox.Show("Cadastro Feito com Sucesso");
            geraform(inicio);

        }

    }
}

