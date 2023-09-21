namespace Pi_Serasa_Starlents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load_1(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {


            Login login = new Login();
            login.Show();

            login.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(login);
            login.Location = new Point(0, 0);
            login.Show();


        }
    }
}