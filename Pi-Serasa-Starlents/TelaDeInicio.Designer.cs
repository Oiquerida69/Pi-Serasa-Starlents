namespace Pi_Serasa_Starlents
{
    partial class TelaDeInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeInicio));
            wilBitGradientPanel1 = new WiLBiT.WiLBiTGradientPanel();
            btnCurtida = new PictureBox();
            btnDescurtida = new PictureBox();
            label2 = new Label();
            panel6 = new Panel();
            lblDescricao = new Label();
            lblNomeUsuario = new Label();
            picFotoUsuario = new PictureBox();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblTalento01 = new Button();
            lblTalento02 = new Button();
            lblTalento03 = new Button();
            wilBitGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCurtida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDescurtida).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoUsuario).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // wilBitGradientPanel1
            // 
            wilBitGradientPanel1.AutoSize = true;
            wilBitGradientPanel1.BackColor = Color.FromArgb(129, 1, 214);
            wilBitGradientPanel1.BackColor2 = Color.FromArgb(219, 191, 223);
            wilBitGradientPanel1.BorderColor = Color.PaleVioletRed;
            wilBitGradientPanel1.BorderRadius = 6;
            wilBitGradientPanel1.BorderSize = 0;
            wilBitGradientPanel1.Controls.Add(lblTalento03);
            wilBitGradientPanel1.Controls.Add(lblTalento02);
            wilBitGradientPanel1.Controls.Add(lblTalento01);
            wilBitGradientPanel1.Controls.Add(btnCurtida);
            wilBitGradientPanel1.Controls.Add(btnDescurtida);
            wilBitGradientPanel1.Controls.Add(label2);
            wilBitGradientPanel1.Controls.Add(panel6);
            wilBitGradientPanel1.Controls.Add(lblNomeUsuario);
            wilBitGradientPanel1.Controls.Add(picFotoUsuario);
            wilBitGradientPanel1.Controls.Add(panel1);
            wilBitGradientPanel1.ForeColor = Color.White;
            wilBitGradientPanel1.Location = new Point(-8, -4);
            wilBitGradientPanel1.Name = "wilBitGradientPanel1";
            wilBitGradientPanel1.Size = new Size(839, 460);
            wilBitGradientPanel1.TabIndex = 0;
            // 
            // btnCurtida
            // 
            btnCurtida.BackColor = Color.Transparent;
            btnCurtida.Cursor = Cursors.Hand;
            btnCurtida.Image = (Image)resources.GetObject("btnCurtida.Image");
            btnCurtida.Location = new Point(463, 311);
            btnCurtida.Name = "btnCurtida";
            btnCurtida.Size = new Size(64, 64);
            btnCurtida.SizeMode = PictureBoxSizeMode.CenterImage;
            btnCurtida.TabIndex = 14;
            btnCurtida.TabStop = false;
            btnCurtida.Click += btnCurtida_Click;
            // 
            // btnDescurtida
            // 
            btnDescurtida.BackColor = Color.Transparent;
            btnDescurtida.Cursor = Cursors.Hand;
            btnDescurtida.Image = (Image)resources.GetObject("btnDescurtida.Image");
            btnDescurtida.Location = new Point(337, 311);
            btnDescurtida.Name = "btnDescurtida";
            btnDescurtida.Size = new Size(64, 64);
            btnDescurtida.SizeMode = PictureBoxSizeMode.CenterImage;
            btnDescurtida.TabIndex = 13;
            btnDescurtida.TabStop = false;
            btnDescurtida.Click += btnDescurtida_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(74, 5, 112);
            label2.Location = new Point(607, 135);
            label2.Name = "label2";
            label2.Size = new Size(131, 36);
            label2.TabIndex = 9;
            label2.Text = "Talentos";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(lblDescricao);
            panel6.Location = new Point(315, 196);
            panel6.Name = "panel6";
            panel6.Size = new Size(229, 104);
            panel6.TabIndex = 5;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescricao.ForeColor = Color.Black;
            lblDescricao.Location = new Point(9, 11);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(129, 16);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Descrição do usuário";
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.BackColor = Color.Transparent;
            lblNomeUsuario.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeUsuario.Location = new Point(362, 156);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(128, 37);
            lblNomeUsuario.TabIndex = 8;
            lblNomeUsuario.Text = "Usuário";
            // 
            // picFotoUsuario
            // 
            picFotoUsuario.BackColor = Color.Transparent;
            picFotoUsuario.BackgroundImageLayout = ImageLayout.Center;
            picFotoUsuario.BorderStyle = BorderStyle.Fixed3D;
            picFotoUsuario.Location = new Point(41, 135);
            picFotoUsuario.Name = "picFotoUsuario";
            picFotoUsuario.Size = new Size(240, 240);
            picFotoUsuario.TabIndex = 7;
            picFotoUsuario.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 5, 112);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(836, 70);
            panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(555, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(414, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(258, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lblTalento01
            // 
            lblTalento01.BackColor = Color.Purple;
            lblTalento01.FlatStyle = FlatStyle.Popup;
            lblTalento01.Location = new Point(607, 174);
            lblTalento01.Name = "lblTalento01";
            lblTalento01.Size = new Size(184, 38);
            lblTalento01.TabIndex = 15;
            lblTalento01.Text = "button1";
            lblTalento01.UseVisualStyleBackColor = false;
            // 
            // lblTalento02
            // 
            lblTalento02.BackColor = Color.Purple;
            lblTalento02.FlatStyle = FlatStyle.Popup;
            lblTalento02.Location = new Point(607, 218);
            lblTalento02.Name = "lblTalento02";
            lblTalento02.Size = new Size(184, 38);
            lblTalento02.TabIndex = 16;
            lblTalento02.Text = "button2";
            lblTalento02.UseVisualStyleBackColor = false;
            // 
            // lblTalento03
            // 
            lblTalento03.BackColor = Color.Purple;
            lblTalento03.FlatStyle = FlatStyle.Popup;
            lblTalento03.Location = new Point(607, 262);
            lblTalento03.Name = "lblTalento03";
            lblTalento03.Size = new Size(184, 38);
            lblTalento03.TabIndex = 17;
            lblTalento03.Text = "button3";
            lblTalento03.UseVisualStyleBackColor = false;
            // 
            // TelaDeInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 450);
            Controls.Add(wilBitGradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaDeInicio";
            Text = "TelaDeInicio";
            Load += TelaDeInicio_Load;
            wilBitGradientPanel1.ResumeLayout(false);
            wilBitGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCurtida).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDescurtida).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoUsuario).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WiLBiT.WiLBiTGradientPanel wilBitGradientPanel1;
        private PictureBox picFotoUsuario;
        private Panel panel6;
        private Label lblNomeUsuario;
        private Label label2;
        private PictureBox btnDescurtida;
        private PictureBox btnCurtida;
        private Label lblDescricao;
        private Panel panel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button lblTalento03;
        private Button lblTalento02;
        private Button lblTalento01;
    }
}