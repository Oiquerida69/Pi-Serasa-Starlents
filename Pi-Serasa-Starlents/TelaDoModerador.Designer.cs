namespace Pi_Serasa_Starlents
{
    partial class TelaDoModerador
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panelPerfilDenunciado = new WiLBiT.WiLBiTPanel();
            lblNomeMiniatura = new Label();
            picFotoMiniatura = new WiLBiT.WiLBiTRoundedPictureBox();
            panel3 = new Panel();
            wilBitPanel3 = new WiLBiT.WiLBiTPanel();
            linkLabel2 = new LinkLabel();
            wilBitPanel2 = new WiLBiT.WiLBiTPanel();
            linkLabel1 = new LinkLabel();
            picFotoUsuario = new PictureBox();
            label2 = new Label();
            wilBitPanel8 = new WiLBiT.WiLBiTPanel();
            wilBitPanel13 = new WiLBiT.WiLBiTPanel();
            wilBitPanel12 = new WiLBiT.WiLBiTPanel();
            wilBitPanel9 = new WiLBiT.WiLBiTPanel();
            lblUsuario = new Label();
            label3 = new Label();
            wilBitPanel10 = new WiLBiT.WiLBiTPanel();
            lblDetalhesDenuncia = new Label();
            label4 = new Label();
            btnSuspendeDenuncia = new WiLBiT.WiLBiTButton();
            lblidUsuario = new Label();
            label5 = new Label();
            btnBanirUsuario = new WiLBiT.WiLBiTButton();
            txtJustificativaBanimento = new WiLBiT.WiLBiTTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelPerfilDenunciado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoMiniatura).BeginInit();
            panel3.SuspendLayout();
            wilBitPanel3.SuspendLayout();
            wilBitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoUsuario).BeginInit();
            wilBitPanel8.SuspendLayout();
            wilBitPanel9.SuspendLayout();
            wilBitPanel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(101, 80, 105);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 55);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(231, 189, 255);
            label1.Location = new Point(35, 15);
            label1.Name = "label1";
            label1.Size = new Size(140, 24);
            label1.TabIndex = 2;
            label1.Text = "DENÚNCIAS";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.FromArgb(163, 142, 167);
            panel2.Controls.Add(panelPerfilDenunciado);
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 389);
            panel2.TabIndex = 1;
            // 
            // panelPerfilDenunciado
            // 
            panelPerfilDenunciado.BackColor = Color.FromArgb(228, 193, 249);
            panelPerfilDenunciado.BorderColor = Color.PaleVioletRed;
            panelPerfilDenunciado.BorderRadius = 6;
            panelPerfilDenunciado.BorderSize = 0;
            panelPerfilDenunciado.Controls.Add(lblNomeMiniatura);
            panelPerfilDenunciado.Controls.Add(picFotoMiniatura);
            panelPerfilDenunciado.Cursor = Cursors.Hand;
            panelPerfilDenunciado.ForeColor = Color.White;
            panelPerfilDenunciado.Location = new Point(5, 5);
            panelPerfilDenunciado.Name = "panelPerfilDenunciado";
            panelPerfilDenunciado.Size = new Size(180, 50);
            panelPerfilDenunciado.TabIndex = 6;
            // 
            // lblNomeMiniatura
            // 
            lblNomeMiniatura.AutoSize = true;
            lblNomeMiniatura.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeMiniatura.ForeColor = Color.FromArgb(52, 11, 66);
            lblNomeMiniatura.Location = new Point(55, 17);
            lblNomeMiniatura.Name = "lblNomeMiniatura";
            lblNomeMiniatura.Size = new Size(70, 18);
            lblNomeMiniatura.TabIndex = 19;
            lblNomeMiniatura.Text = "Usuário";
            // 
            // picFotoMiniatura
            // 
            picFotoMiniatura.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            picFotoMiniatura.BorderColor = Color.FromArgb(64, 23, 72);
            picFotoMiniatura.BorderColor2 = Color.FromArgb(64, 23, 72);
            picFotoMiniatura.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            picFotoMiniatura.BorderSize = 2;
            picFotoMiniatura.GradientAngle = 50F;
            picFotoMiniatura.Location = new Point(7, 3);
            picFotoMiniatura.Name = "picFotoMiniatura";
            picFotoMiniatura.Size = new Size(42, 42);
            picFotoMiniatura.SizeMode = PictureBoxSizeMode.StretchImage;
            picFotoMiniatura.TabIndex = 0;
            picFotoMiniatura.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(162, 136, 167);
            panel3.Controls.Add(wilBitPanel3);
            panel3.Controls.Add(wilBitPanel2);
            panel3.Location = new Point(210, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(613, 55);
            panel3.TabIndex = 1;
            // 
            // wilBitPanel3
            // 
            wilBitPanel3.BackColor = Color.FromArgb(216, 196, 215);
            wilBitPanel3.BorderColor = Color.PaleVioletRed;
            wilBitPanel3.BorderRadius = 6;
            wilBitPanel3.BorderSize = 0;
            wilBitPanel3.Controls.Add(linkLabel2);
            wilBitPanel3.ForeColor = Color.White;
            wilBitPanel3.Location = new Point(436, 8);
            wilBitPanel3.Name = "wilBitPanel3";
            wilBitPanel3.Size = new Size(150, 40);
            wilBitPanel3.TabIndex = 25;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.FromArgb(118, 1, 224);
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.FromArgb(216, 196, 215);
            linkLabel2.Cursor = Cursors.Hand;
            linkLabel2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.FromArgb(52, 11, 66);
            linkLabel2.Location = new Point(9, 11);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(131, 18);
            linkLabel2.TabIndex = 0;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Enviar relatório";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // wilBitPanel2
            // 
            wilBitPanel2.BackColor = Color.FromArgb(216, 196, 215);
            wilBitPanel2.BorderColor = Color.PaleVioletRed;
            wilBitPanel2.BorderRadius = 6;
            wilBitPanel2.BorderSize = 0;
            wilBitPanel2.Controls.Add(linkLabel1);
            wilBitPanel2.ForeColor = Color.White;
            wilBitPanel2.Location = new Point(21, 8);
            wilBitPanel2.Name = "wilBitPanel2";
            wilBitPanel2.Size = new Size(150, 40);
            wilBitPanel2.TabIndex = 24;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(118, 1, 224);
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(216, 196, 215);
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(52, 11, 66);
            linkLabel1.Location = new Point(9, 11);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(133, 18);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Acessar código";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // picFotoUsuario
            // 
            picFotoUsuario.BackColor = Color.FromArgb(228, 193, 249);
            picFotoUsuario.BackgroundImageLayout = ImageLayout.None;
            picFotoUsuario.BorderStyle = BorderStyle.FixedSingle;
            picFotoUsuario.Location = new Point(240, 69);
            picFotoUsuario.Name = "picFotoUsuario";
            picFotoUsuario.Size = new Size(211, 185);
            picFotoUsuario.TabIndex = 0;
            picFotoUsuario.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(52, 11, 66);
            label2.Location = new Point(9, 12);
            label2.Name = "label2";
            label2.Size = new Size(211, 18);
            label2.TabIndex = 2;
            label2.Text = "Mensagens denunciadas:";
            // 
            // wilBitPanel8
            // 
            wilBitPanel8.BackColor = Color.FromArgb(47, 5, 67);
            wilBitPanel8.BorderColor = Color.PaleVioletRed;
            wilBitPanel8.BorderRadius = 6;
            wilBitPanel8.BorderSize = 0;
            wilBitPanel8.Controls.Add(wilBitPanel13);
            wilBitPanel8.Controls.Add(wilBitPanel12);
            wilBitPanel8.ForeColor = Color.White;
            wilBitPanel8.Location = new Point(231, 314);
            wilBitPanel8.Name = "wilBitPanel8";
            wilBitPanel8.Size = new Size(226, 117);
            wilBitPanel8.TabIndex = 11;
            // 
            // wilBitPanel13
            // 
            wilBitPanel13.BackColor = Color.FromArgb(228, 193, 249);
            wilBitPanel13.BorderColor = Color.PaleVioletRed;
            wilBitPanel13.BorderRadius = 6;
            wilBitPanel13.BorderSize = 0;
            wilBitPanel13.ForeColor = Color.White;
            wilBitPanel13.Location = new Point(18, 58);
            wilBitPanel13.Name = "wilBitPanel13";
            wilBitPanel13.Size = new Size(146, 40);
            wilBitPanel13.TabIndex = 23;
            // 
            // wilBitPanel12
            // 
            wilBitPanel12.BackColor = Color.FromArgb(228, 193, 249);
            wilBitPanel12.BorderColor = Color.PaleVioletRed;
            wilBitPanel12.BorderRadius = 6;
            wilBitPanel12.BorderSize = 0;
            wilBitPanel12.ForeColor = Color.White;
            wilBitPanel12.Location = new Point(18, 11);
            wilBitPanel12.Name = "wilBitPanel12";
            wilBitPanel12.Size = new Size(191, 40);
            wilBitPanel12.TabIndex = 22;
            // 
            // wilBitPanel9
            // 
            wilBitPanel9.BackColor = Color.FromArgb(228, 193, 249);
            wilBitPanel9.BorderColor = Color.PaleVioletRed;
            wilBitPanel9.BorderRadius = 6;
            wilBitPanel9.BorderSize = 0;
            wilBitPanel9.Controls.Add(label2);
            wilBitPanel9.ForeColor = Color.White;
            wilBitPanel9.Location = new Point(231, 260);
            wilBitPanel9.Name = "wilBitPanel9";
            wilBitPanel9.Size = new Size(226, 43);
            wilBitPanel9.TabIndex = 9;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.FromArgb(52, 11, 66);
            lblUsuario.Location = new Point(580, 80);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(117, 32);
            lblUsuario.TabIndex = 12;
            lblUsuario.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(52, 11, 66);
            label3.Location = new Point(549, 112);
            label3.Name = "label3";
            label3.Size = new Size(186, 18);
            label3.TabIndex = 13;
            label3.Text = "Detalhes da denúncia:";
            // 
            // wilBitPanel10
            // 
            wilBitPanel10.BackColor = Color.FromArgb(240, 208, 255);
            wilBitPanel10.BorderColor = Color.PaleVioletRed;
            wilBitPanel10.BorderRadius = 6;
            wilBitPanel10.BorderSize = 0;
            wilBitPanel10.Controls.Add(lblDetalhesDenuncia);
            wilBitPanel10.ForeColor = Color.White;
            wilBitPanel10.Location = new Point(485, 133);
            wilBitPanel10.Name = "wilBitPanel10";
            wilBitPanel10.Size = new Size(311, 100);
            wilBitPanel10.TabIndex = 12;
            // 
            // lblDetalhesDenuncia
            // 
            lblDetalhesDenuncia.AutoSize = true;
            lblDetalhesDenuncia.ForeColor = Color.FromArgb(85, 47, 87);
            lblDetalhesDenuncia.Location = new Point(11, 9);
            lblDetalhesDenuncia.Name = "lblDetalhesDenuncia";
            lblDetalhesDenuncia.Size = new Size(120, 15);
            lblDetalhesDenuncia.TabIndex = 0;
            lblDetalhesDenuncia.Text = "Detalhes da denúncia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(52, 11, 66);
            label4.Location = new Point(498, 236);
            label4.Name = "label4";
            label4.Size = new Size(118, 18);
            label4.TabIndex = 14;
            label4.Text = "ID do usuário:";
            // 
            // btnSuspendeDenuncia
            // 
            btnSuspendeDenuncia.BackColor = Color.FromArgb(131, 84, 169);
            btnSuspendeDenuncia.BorderColor = Color.FromArgb(72, 116, 245);
            btnSuspendeDenuncia.BorderRadius = 6;
            btnSuspendeDenuncia.BorderSize = 0;
            btnSuspendeDenuncia.Cursor = Cursors.Hand;
            btnSuspendeDenuncia.FlatAppearance.BorderSize = 0;
            btnSuspendeDenuncia.FlatStyle = FlatStyle.Flat;
            btnSuspendeDenuncia.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuspendeDenuncia.ForeColor = Color.White;
            btnSuspendeDenuncia.Location = new Point(658, 236);
            btnSuspendeDenuncia.Name = "btnSuspendeDenuncia";
            btnSuspendeDenuncia.Size = new Size(138, 36);
            btnSuspendeDenuncia.TabIndex = 0;
            btnSuspendeDenuncia.Text = "Suspender a denúncia";
            btnSuspendeDenuncia.UseVisualStyleBackColor = false;
            // 
            // lblidUsuario
            // 
            lblidUsuario.AutoSize = true;
            lblidUsuario.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblidUsuario.ForeColor = Color.FromArgb(52, 11, 66);
            lblidUsuario.Location = new Point(540, 257);
            lblidUsuario.Name = "lblidUsuario";
            lblidUsuario.Size = new Size(28, 18);
            lblidUsuario.TabIndex = 16;
            lblidUsuario.Text = "01";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(52, 11, 66);
            label5.Location = new Point(485, 287);
            label5.Name = "label5";
            label5.Size = new Size(282, 24);
            label5.TabIndex = 17;
            label5.Text = "Justificativa de banimento:";
            // 
            // btnBanirUsuario
            // 
            btnBanirUsuario.BackColor = Color.FromArgb(95, 40, 123);
            btnBanirUsuario.BorderColor = Color.FromArgb(72, 116, 245);
            btnBanirUsuario.BorderRadius = 6;
            btnBanirUsuario.BorderSize = 0;
            btnBanirUsuario.Cursor = Cursors.Hand;
            btnBanirUsuario.FlatAppearance.BorderSize = 0;
            btnBanirUsuario.FlatStyle = FlatStyle.Flat;
            btnBanirUsuario.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBanirUsuario.ForeColor = Color.White;
            btnBanirUsuario.Location = new Point(476, 415);
            btnBanirUsuario.Name = "btnBanirUsuario";
            btnBanirUsuario.Size = new Size(320, 26);
            btnBanirUsuario.TabIndex = 18;
            btnBanirUsuario.Text = "Banir usuário";
            btnBanirUsuario.UseVisualStyleBackColor = false;
            // 
            // txtJustificativaBanimento
            // 
            txtJustificativaBanimento.BackColor = Color.FromArgb(240, 208, 255);
            txtJustificativaBanimento.BorderColor = Color.FromArgb(143, 20, 184);
            txtJustificativaBanimento.BorderFocusColor = Color.Indigo;
            txtJustificativaBanimento.BorderRadius = 4;
            txtJustificativaBanimento.BorderSize = 2;
            txtJustificativaBanimento.Cursor = Cursors.IBeam;
            txtJustificativaBanimento.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtJustificativaBanimento.ForeColor = Color.FromArgb(64, 64, 64);
            txtJustificativaBanimento.Location = new Point(485, 314);
            txtJustificativaBanimento.Margin = new Padding(4);
            txtJustificativaBanimento.Multiline = true;
            txtJustificativaBanimento.Name = "txtJustificativaBanimento";
            txtJustificativaBanimento.Padding = new Padding(10, 7, 10, 7);
            txtJustificativaBanimento.PasswordChar = false;
            txtJustificativaBanimento.PlaceholderColor = Color.DarkGray;
            txtJustificativaBanimento.PlaceholderText = "";
            txtJustificativaBanimento.Size = new Size(311, 98);
            txtJustificativaBanimento.TabIndex = 0;
            txtJustificativaBanimento.Texts = "";
            txtJustificativaBanimento.UnderlinedStyle = false;
            // 
            // TelaDoModerador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(213, 192, 220);
            ClientSize = new Size(820, 446);
            Controls.Add(txtJustificativaBanimento);
            Controls.Add(btnBanirUsuario);
            Controls.Add(label5);
            Controls.Add(lblidUsuario);
            Controls.Add(btnSuspendeDenuncia);
            Controls.Add(label4);
            Controls.Add(wilBitPanel10);
            Controls.Add(label3);
            Controls.Add(lblUsuario);
            Controls.Add(wilBitPanel9);
            Controls.Add(wilBitPanel8);
            Controls.Add(picFotoUsuario);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "TelaDoModerador";
            Text = "TelaDoModerador";
            Load += TelaDoModerador_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panelPerfilDenunciado.ResumeLayout(false);
            panelPerfilDenunciado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoMiniatura).EndInit();
            panel3.ResumeLayout(false);
            wilBitPanel3.ResumeLayout(false);
            wilBitPanel3.PerformLayout();
            wilBitPanel2.ResumeLayout(false);
            wilBitPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoUsuario).EndInit();
            wilBitPanel8.ResumeLayout(false);
            wilBitPanel9.ResumeLayout(false);
            wilBitPanel9.PerformLayout();
            wilBitPanel10.ResumeLayout(false);
            wilBitPanel10.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox picFotoUsuario;
        private Label label1;
        private WiLBiT.WiLBiTPanel panelPerfilDenunciado;
        private Label label2;
        private WiLBiT.WiLBiTPanel wilBitPanel8;
        private WiLBiT.WiLBiTPanel wilBitPanel9;
        private Label lblUsuario;
        private Label label3;
        private WiLBiT.WiLBiTPanel wilBitPanel10;
        private Label label4;
        private WiLBiT.WiLBiTButton btnSuspendeDenuncia;
        private Label lblidUsuario;
        private Label label5;
        private Label lblNomeMiniatura;
        private WiLBiT.WiLBiTRoundedPictureBox picFotoMiniatura;
        private WiLBiT.WiLBiTButton btnBanirUsuario;
        private WiLBiT.WiLBiTPanel wilBitPanel13;
        private WiLBiT.WiLBiTPanel wilBitPanel12;
        private Label lblDetalhesDenuncia;
        private WiLBiT.WiLBiTTextBox txtJustificativaBanimento;
        private WiLBiT.WiLBiTPanel wilBitPanel2;
        private LinkLabel linkLabel1;
        private WiLBiT.WiLBiTPanel wilBitPanel3;
        private LinkLabel linkLabel2;
    }
}