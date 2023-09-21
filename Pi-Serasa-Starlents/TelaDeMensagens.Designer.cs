namespace Pi_Serasa_Starlents
{
    partial class TelaDeMensagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeMensagens));
            painel_Lista = new Panel();
            panelUsuarioNoChat = new WiLBiT.WiLBiTPanel();
            label6 = new Label();
            wilBitRoundedPictureBox2 = new WiLBiT.WiLBiTRoundedPictureBox();
            panel2 = new Panel();
            wilBitPanel2 = new WiLBiT.WiLBiTPanel();
            lblDescricaoDeMatch = new Label();
            btnDenunciaUsuario = new PictureBox();
            lblNome = new Label();
            fotoUsuario = new WiLBiT.WiLBiTRoundedPictureBox();
            panel4 = new Panel();
            label2 = new Label();
            btnVoltaInicio = new PictureBox();
            panel1 = new Panel();
            painel_Lista.SuspendLayout();
            panelUsuarioNoChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wilBitRoundedPictureBox2).BeginInit();
            panel2.SuspendLayout();
            wilBitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDenunciaUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fotoUsuario).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVoltaInicio).BeginInit();
            SuspendLayout();
            // 
            // painel_Lista
            // 
            painel_Lista.Anchor = AnchorStyles.None;
            painel_Lista.AutoScroll = true;
            painel_Lista.BackColor = Color.FromArgb(64, 15, 87);
            painel_Lista.Controls.Add(panelUsuarioNoChat);
            painel_Lista.Location = new Point(50, 88);
            painel_Lista.Name = "painel_Lista";
            painel_Lista.Size = new Size(220, 0);
            painel_Lista.TabIndex = 0;
            // 
            // panelUsuarioNoChat
            // 
            panelUsuarioNoChat.BackColor = Color.FromArgb(228, 193, 249);
            panelUsuarioNoChat.BorderColor = Color.PaleVioletRed;
            panelUsuarioNoChat.BorderRadius = 0;
            panelUsuarioNoChat.BorderSize = 0;
            panelUsuarioNoChat.Controls.Add(label6);
            panelUsuarioNoChat.Controls.Add(wilBitRoundedPictureBox2);
            panelUsuarioNoChat.ForeColor = Color.White;
            panelUsuarioNoChat.Location = new Point(12, 17);
            panelUsuarioNoChat.Name = "panelUsuarioNoChat";
            panelUsuarioNoChat.Size = new Size(174, 50);
            panelUsuarioNoChat.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(52, 11, 66);
            label6.Location = new Point(55, 17);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 19;
            label6.Text = "Usuário";
            // 
            // wilBitRoundedPictureBox2
            // 
            wilBitRoundedPictureBox2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            wilBitRoundedPictureBox2.BorderColor = Color.FromArgb(64, 23, 72);
            wilBitRoundedPictureBox2.BorderColor2 = Color.FromArgb(64, 23, 72);
            wilBitRoundedPictureBox2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            wilBitRoundedPictureBox2.BorderSize = 2;
            wilBitRoundedPictureBox2.GradientAngle = 50F;
            wilBitRoundedPictureBox2.Location = new Point(7, 3);
            wilBitRoundedPictureBox2.Name = "wilBitRoundedPictureBox2";
            wilBitRoundedPictureBox2.Size = new Size(42, 42);
            wilBitRoundedPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            wilBitRoundedPictureBox2.TabIndex = 0;
            wilBitRoundedPictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(225, 209, 232);
            panel2.Controls.Add(wilBitPanel2);
            panel2.Location = new Point(220, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(661, 503);
            panel2.TabIndex = 1;
            // 
            // wilBitPanel2
            // 
            wilBitPanel2.BackColor = Color.FromArgb(218, 186, 234);
            wilBitPanel2.BorderColor = Color.PaleVioletRed;
            wilBitPanel2.BorderRadius = 6;
            wilBitPanel2.BorderSize = 0;
            wilBitPanel2.Controls.Add(lblDescricaoDeMatch);
            wilBitPanel2.Controls.Add(btnDenunciaUsuario);
            wilBitPanel2.Controls.Add(lblNome);
            wilBitPanel2.Controls.Add(fotoUsuario);
            wilBitPanel2.ForeColor = Color.White;
            wilBitPanel2.Location = new Point(18, 12);
            wilBitPanel2.Name = "wilBitPanel2";
            wilBitPanel2.Size = new Size(629, 476);
            wilBitPanel2.TabIndex = 22;
            wilBitPanel2.Paint += wilBitPanel2_Paint;
            // 
            // lblDescricaoDeMatch
            // 
            lblDescricaoDeMatch.AutoSize = true;
            lblDescricaoDeMatch.ForeColor = Color.FromArgb(44, 18, 52);
            lblDescricaoDeMatch.Location = new Point(29, 112);
            lblDescricaoDeMatch.MaximumSize = new Size(530, 400);
            lblDescricaoDeMatch.Name = "lblDescricaoDeMatch";
            lblDescricaoDeMatch.Size = new Size(170, 15);
            lblDescricaoDeMatch.TabIndex = 24;
            lblDescricaoDeMatch.Text = "Descrição de match do usuário";
            // 
            // btnDenunciaUsuario
            // 
            btnDenunciaUsuario.Cursor = Cursors.Hand;
            btnDenunciaUsuario.Image = (Image)resources.GetObject("btnDenunciaUsuario.Image");
            btnDenunciaUsuario.Location = new Point(578, 12);
            btnDenunciaUsuario.Name = "btnDenunciaUsuario";
            btnDenunciaUsuario.Size = new Size(31, 26);
            btnDenunciaUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            btnDenunciaUsuario.TabIndex = 23;
            btnDenunciaUsuario.TabStop = false;
            btnDenunciaUsuario.Click += btnDenunciaUsuario_Click_1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.ForeColor = Color.FromArgb(52, 11, 66);
            lblNome.Location = new Point(108, 38);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(128, 37);
            lblNome.TabIndex = 20;
            lblNome.Text = "Usuário";
            // 
            // fotoUsuario
            // 
            fotoUsuario.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            fotoUsuario.BorderColor = Color.FromArgb(64, 15, 87);
            fotoUsuario.BorderColor2 = Color.FromArgb(64, 15, 87);
            fotoUsuario.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            fotoUsuario.BorderSize = 2;
            fotoUsuario.GradientAngle = 50F;
            fotoUsuario.Location = new Point(19, 14);
            fotoUsuario.Name = "fotoUsuario";
            fotoUsuario.Size = new Size(83, 83);
            fotoUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            fotoUsuario.TabIndex = 1;
            fotoUsuario.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(118, 55, 148);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btnVoltaInicio);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 50);
            panel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(225, 209, 232);
            label2.Location = new Point(51, 5);
            label2.Name = "label2";
            label2.Size = new Size(125, 41);
            label2.TabIndex = 21;
            label2.Text = "Voltar para tela de início";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVoltaInicio
            // 
            btnVoltaInicio.Cursor = Cursors.Hand;
            btnVoltaInicio.Image = (Image)resources.GetObject("btnVoltaInicio.Image");
            btnVoltaInicio.Location = new Point(12, 12);
            btnVoltaInicio.Name = "btnVoltaInicio";
            btnVoltaInicio.Size = new Size(33, 32);
            btnVoltaInicio.SizeMode = PictureBoxSizeMode.Zoom;
            btnVoltaInicio.TabIndex = 0;
            btnVoltaInicio.TabStop = false;
            btnVoltaInicio.Click += btnVoltaInicio_Click_1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(64, 15, 87);
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 450);
            panel1.TabIndex = 3;
            // 
            // TelaDeMensagens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(879, 500);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(painel_Lista);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaDeMensagens";
            Text = "Tela de Mix";
            Load += TelaDeMensagens_Load_3;
            painel_Lista.ResumeLayout(false);
            panelUsuarioNoChat.ResumeLayout(false);
            panelUsuarioNoChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)wilBitRoundedPictureBox2).EndInit();
            panel2.ResumeLayout(false);
            wilBitPanel2.ResumeLayout(false);
            wilBitPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnDenunciaUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)fotoUsuario).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnVoltaInicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel painel_Lista;
        private Panel panel2;
        private WiLBiT.WiLBiTRoundedPictureBox fotoUsuario;
        private PictureBox btnVoltaInicio;
        private Label lblNome;
        private Panel panel4;
        private Label label2;
        private WiLBiT.WiLBiTPanel panelUsuarioNoChat;
        private Label label6;
        private WiLBiT.WiLBiTRoundedPictureBox wilBitRoundedPictureBox2;
        private PictureBox btnDenunciaUsuario;
        private Panel panel1;
        private WiLBiT.WiLBiTPanel wilBitPanel2;
        private Label lblDescricaoDeMatch;
    }
}