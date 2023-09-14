using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiLBiT;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Pi_Serasa_Starlents
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        Interesses i = new Interesses();
       
        public void gerarTalents()
        {
            wilBitPanel1.Hide();
            WiLBiTPanel panel = new WiLBiTPanel();
            panel.Size = new Size(225, 114);
            panel.Location = new Point(676, 89);
            panel.BackColor = Color.Transparent;

            ComboBox combobox = new ComboBox();
            combobox.Size = new Size(189, 23);
            combobox.Location = new Point(24,16);

            ComboBox combox1= new ComboBox();
            combox1.Size = new Size(189, 23);
            combox1.Location = new Point(24, 45);

            ComboBox combox2 = new ComboBox();
            combox2.Size = new Size(189, 23);
            combox2.Location = new Point(24, 74);

            wilBitGradientPanel1.Controls.Add(panel);
            panel.Show();
            panel.Controls.Add(combobox);
            panel.Controls.Add(combox1);
            panel.Controls.Add(combox2);

            List<Interesses> all = i.buscaTodos();
            foreach (Interesses i in all)
            {
                combobox.Items.Add(i.interesse.ToString());
                combox1.Items.Add(i.interesse.ToString());
                combox2.Items.Add(i.interesse.ToString());
            }
        }
        public void gerarAprender()
        {
            wilBitPanel2.Hide();
            WiLBiTPanel panel = new WiLBiTPanel();
            panel.Size = new Size(221, 86);
            panel.Location = new Point(676, 259);
            panel.BackColor = Color.Transparent;

            ComboBox comboBox= new ComboBox();
            comboBox.Size = new Size(199, 23);
            comboBox.Location = new Point(19, 17);

            ComboBox comboBox2= new ComboBox();
            comboBox2.Size = new Size(199, 23);
            comboBox2.Location = new Point(19, 46);

            wilBitGradientPanel1.Controls.Add(panel);
            panel.Show();
            panel.Controls.Add(comboBox);
            panel.Controls.Add(comboBox2);
            List<Interesses> all = i.buscaTodos();
            for (int i = 0; i < all.Count; i++)
            {



                comboBox.Items.Add(all[i].interesse.ToString());
                comboBox2.Items.Add(all[i].interesse.ToString());
            

            }
            }
        public void carregaform(Form form)
        {
            form.TopLevel = false;

            wilBitGradientPanel1.Controls.Clear();
            wilBitGradientPanel1.Controls.Add(form);
            form.Show();

        }
        void rendeirizaInterface()
        {
            WindowState = FormWindowState.Maximized;

            int menuEsquerdo_largura = 63;
            int descricao_altura = 10;

            wilBitGradientPanel1.Location = new Point(0, 0);
            wilBitGradientPanel1.Size = new Size(ClientSize.Width, ClientSize.Height);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // label descricao
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //premium
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            
        }

        private void wilBitTextBox6__TextChanged(object sender, EventArgs e)
        {

            // descricao
        }

        private void wilBitGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Perfil_Load_1(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Program.usuario.avatar;
            lblNome.Text = Program.usuario.nome;
            wilBitTextBox6.Texts = Program.usuario.descricao;
            wilBitTextBox1.Texts = Program.usuario.mensagemUsuario;
            comboBox1.Text = Program.usuario.interesse01; 
            comboBox2.Text = Program.usuario.interesse02;
            comboBox3.Text = Program.usuario.interesse03;
            comboBox4.Text = Program.usuario.aprender;
            comboBox5.Text = Program.usuario.aprender2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //botao alterar talentos
           string interesse = comboBox1.Text;
           string interesse2 = comboBox2.Text;
          string interesse3 = comboBox3.Text;
            Usuario usuario= new Usuario();
            usuario.alterarTalentos(Program.usuario.id, interesse, interesse2, interesse3);
            wilBitPanel1.Show();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            string aprender = comboBox4.Text;
            string aprender2 = comboBox5.Text;
            Usuario usuario= new Usuario();
            usuario.alteraInteresse(Program.usuario.id, aprender, aprender2);
            wilBitPanel2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Interesses> all = i.buscaTodos();
            foreach (Interesses t in all)
            {
                comboBox1.Items.Add(t.interesse.ToString());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Interesses> all = i.buscaTodos();
            foreach (Interesses t in all)
            {
                comboBox2.Items.Add(t.interesse.ToString());
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Interesses> all = i.buscaTodos();
            foreach (Interesses t in all)
            {
                comboBox3.Items.Add(t.interesse.ToString());
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Interesses> all = i.buscaTodos();
            foreach (Interesses t in all)
            {
                comboBox4.Items.Add(t.interesse.ToString());
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Interesses> all = i.buscaTodos();
            foreach (Interesses t in all)
            {
                comboBox5.Items.Add(t.interesse.ToString());
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TelaDeInicio telaDeInicio= new TelaDeInicio();
            telaDeInicio.TopLevel= false;
            telaDeInicio.Show();
            Form1.panel1.Controls.Clear();
            Form1.panel1.Controls.Add(telaDeInicio);
        }

        private void button3_Click(object sender, EventArgs e)
        {


            gerarTalents();
            
                button1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            gerarAprender();
            
                button2.Show();
        }
    }
}
