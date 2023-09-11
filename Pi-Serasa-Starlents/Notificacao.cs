using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Utilities.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiLBiT;
using static System.Net.Mime.MediaTypeNames;

namespace Pi_Serasa_Starlents
{
    public partial class Notificacao : Form
    {
        DataTable tabela;
        List<Notificacao> promocoes = new List<Notificacao>();
        List<Notificacao> todas = new List<Notificacao>();
        List<Notificacao> novosMatchs = new List<Notificacao>();
        public int id;
        public int id_usuario;
        public string conteudo;
        public string promocao;

        public Notificacao(int id, int id_usuario, string conteudo, string promocao)
        {
            this.id = id;
            this.id_usuario = id_usuario;
            this.conteudo = conteudo;
            this.promocao = promocao;
        }

        public Notificacao()
        {
            InitializeComponent();
        }

        void renderizaInterface()
        {
            WindowState = FormWindowState.Maximized;

            int menuEsquerdo_largura = 63;


            wilBitGradientPanel1.Location = new Point(0, 0);
            wilBitGradientPanel1.Size = new Size(ClientSize.Width, ClientSize.Height);

            wilBitPanel1.Location = new Point(ClientSize.Width / 2 - wilBitPanel1.Size.Width / 2, ClientSize.Height / 2 - wilBitPanel1.Size.Height / 2);

            panelIcones.Location = new Point(ClientSize.Width / 2 - panelIcones.Width / 2);

            label3.Location = new Point(ClientSize.Height / 2 - label3.Width / 2);

            label3.Location = new Point(ClientSize.Width / 2 - label3.Size.Width / 2, ClientSize.Height / 2 - label3.Size.Height / 2 - 300);

        }


        private void wilBitPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Notificacao_Load(object sender, EventArgs e)
        {
            renderizaInterface();
            Notificacao notificacao = new Notificacao();
            wilBitGradientPanel1.Controls.Add(notificacao);
            foreach(Notificacao not in todas)
            {
                geranotificaçoes(not.conteudo);
            }
            

        }

        private void wilBitGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelIcones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wilBitButton3_Click(object sender, EventArgs e)
        {

        }

        private void wilBitGradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        public Notificacao carregadados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            int id_usuario = int.Parse(linha["id_usuario"].ToString());
            string conteudo = linha["conteudo"].ToString();
            string promocoes = linha["promocao"].ToString();

            Notificacao noti = new Notificacao(id, id_usuario, conteudo, promocoes);
            return noti;

        }
        public List<Notificacao> listartodas()
        {
            string query = "SELECT * FROM notificacoes";
             tabela = Conexao.executaQuery(query);
            foreach(DataRow linha in tabela.Rows)
            {
                Notificacao not = carregadados(linha);
                todas.Add(not);
            }
            return todas;
        }
        public void geranotificaçoes(string conteudo)
        {
            WiLBiTPanel panel = new WiLBiTPanel();
            panel.Size = new Size(691, 46);
            panel.Location = new Point(30, 25);
            panel.BackColor = Color.White;

            Label label = new Label();
            label.Text = conteudo;
            label.Location = new Point(55, 18);
            label.ForeColor = Color.Black;

            PictureBox pic = new PictureBox();
            pic.Size = new Size(34, 37);
            pic.Location = new Point(15, 6);
            pic.ImageLocation = "C:/Users/daniele.asantos42/source/repos/Pi - Serasa - Starlents/Pi - Serasa - Starlents/Imagens/notificação.png";

            wilBitPanel6.Controls.Add(panel);
            wilBitPanel6.Controls.Add(label);
            wilBitPanel6.Controls.Add(pic);

        }

        private void wilBitButton1_Click(object sender, EventArgs e)
        {

        }
    }
}