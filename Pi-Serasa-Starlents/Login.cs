﻿using System;
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

         void rendeirizaInterface()
        {
            WindowState = FormWindowState.Maximized;

            wilBitGradientPanel1.Location = new Point(10, 0);
            wilBitGradientPanel1.Size = new Size(ClientSize.Width, ClientSize.Height);

            wilBitGradientPanel1.Location = new Point(ClientSize.Width / 2 - wilBitGradientPanel1.Size.Width / 2, ClientSize.Height / 2 - wilBitGradientPanel1.Size.Height / 2 );

            wilBitGradientPanel2.Location = new Point(ClientSize.Width / 2 - wilBitGradientPanel2.Size.Width / 2 + 700, ClientSize.Height / 2 - wilBitGradientPanel2.Size.Height / 2 );
           

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            rendeirizaInterface();
        }

        private void wilBitButton2_Click(object sender, EventArgs e)
        {

            carregaForm(new Cadastro());
            pictureBox1.Location = new Point (700, 100 );
        }

        private void wilBitGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}