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
            panelListaDenuncias = new Panel();
            panelPerfilDenunciado = new WiLBiT.WiLBiTPanel();
            pictureBox1 = new PictureBox();
            lblNomeMiniatura = new Label();
            panel3 = new Panel();
            wilBitPanel3 = new WiLBiT.WiLBiTPanel();
            linkLabel2 = new LinkLabel();
            wilBitPanel2 = new WiLBiT.WiLBiTPanel();
            linkLabel1 = new LinkLabel();
            picFotoUsuario = new PictureBox();
            lblUsuario = new Label();
            label3 = new Label();
            wilBitPanel10 = new WiLBiT.WiLBiTPanel();
            lblDetalhesDenuncia = new Label();
            label4 = new Label();
            btnSuspendeDenuncia = new WiLBiT.WiLBiTButton();
            label5 = new Label();
            btnBanirUsuario = new WiLBiT.WiLBiTButton();
            txtJustificativaBanimento = new WiLBiT.WiLBiTTextBox();
            label2 = new Label();
            label7 = new Label();
            txtBiografiaMix = new TextBox();
            txtBiografiaUsuario = new TextBox();
            txtDetalhesDenuncia = new TextBox();
            lbl_idUsuario = new Label();
            panel1.SuspendLayout();
            panelListaDenuncias.SuspendLayout();
            panelPerfilDenunciado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            wilBitPanel3.SuspendLayout();
            wilBitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoUsuario).BeginInit();
            wilBitPanel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(101, 80, 105);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 51);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(231, 189, 255);
            label1.Location = new Point(35, 13);
            label1.Name = "label1";
            label1.Size = new Size(140, 24);
            label1.TabIndex = 2;
            label1.Text = "DENÚNCIAS";
            // 
            // panelListaDenuncias
            // 
            panelListaDenuncias.AllowDrop = true;
            panelListaDenuncias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelListaDenuncias.AutoScroll = true;
            panelListaDenuncias.BackColor = Color.FromArgb(163, 142, 167);
            panelListaDenuncias.Controls.Add(panelPerfilDenunciado);
            panelListaDenuncias.Location = new Point(0, 51);
            panelListaDenuncias.Name = "panelListaDenuncias";
            panelListaDenuncias.Size = new Size(210, 483);
            panelListaDenuncias.TabIndex = 1;
            // 
            // panelPerfilDenunciado
            // 
            panelPerfilDenunciado.Anchor = AnchorStyles.None;
            panelPerfilDenunciado.BackColor = Color.FromArgb(228, 193, 249);
            panelPerfilDenunciado.BorderColor = Color.PaleVioletRed;
            panelPerfilDenunciado.BorderRadius = 6;
            panelPerfilDenunciado.BorderSize = 0;
            panelPerfilDenunciado.Controls.Add(pictureBox1);
            panelPerfilDenunciado.Controls.Add(lblNomeMiniatura);
            panelPerfilDenunciado.Cursor = Cursors.Hand;
            panelPerfilDenunciado.ForeColor = Color.White;
            panelPerfilDenunciado.Location = new Point(12, 6);
            panelPerfilDenunciado.Name = "panelPerfilDenunciado";
            panelPerfilDenunciado.Size = new Size(180, 50);
            panelPerfilDenunciado.TabIndex = 6;
            panelPerfilDenunciado.Paint += panelPerfilDenunciado_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.FromArgb(228, 193, 249);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // lblNomeMiniatura
            // 
            lblNomeMiniatura.Anchor = AnchorStyles.None;
            lblNomeMiniatura.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeMiniatura.ForeColor = Color.FromArgb(52, 11, 66);
            lblNomeMiniatura.Location = new Point(55, 17);
            lblNomeMiniatura.Name = "lblNomeMiniatura";
            lblNomeMiniatura.Size = new Size(70, 18);
            lblNomeMiniatura.TabIndex = 19;
            lblNomeMiniatura.Text = "Usuário";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoSize = true;
            panel3.BackColor = Color.FromArgb(162, 136, 167);
            panel3.Controls.Add(wilBitPanel3);
            panel3.Controls.Add(wilBitPanel2);
            panel3.Location = new Point(208, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(596, 51);
            panel3.TabIndex = 1;
            // 
            // wilBitPanel3
            // 
            wilBitPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            wilBitPanel3.BackColor = Color.FromArgb(216, 196, 215);
            wilBitPanel3.BorderColor = Color.PaleVioletRed;
            wilBitPanel3.BorderRadius = 6;
            wilBitPanel3.BorderSize = 0;
            wilBitPanel3.Controls.Add(linkLabel2);
            wilBitPanel3.ForeColor = Color.White;
            wilBitPanel3.Location = new Point(433, 3);
            wilBitPanel3.Name = "wilBitPanel3";
            wilBitPanel3.Size = new Size(150, 40);
            wilBitPanel3.TabIndex = 25;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.FromArgb(118, 1, 224);
            linkLabel2.Anchor = AnchorStyles.None;
            linkLabel2.BackColor = Color.FromArgb(216, 196, 215);
            linkLabel2.Cursor = Cursors.Hand;
            linkLabel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.FromArgb(52, 11, 66);
            linkLabel2.Location = new Point(16, 11);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(131, 28);
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
            wilBitPanel2.Location = new Point(13, 3);
            wilBitPanel2.Name = "wilBitPanel2";
            wilBitPanel2.Size = new Size(150, 40);
            wilBitPanel2.TabIndex = 24;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(118, 1, 224);
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.BackColor = Color.FromArgb(216, 196, 215);
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(52, 11, 66);
            linkLabel1.Location = new Point(14, 11);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(133, 28);
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
            picFotoUsuario.Location = new Point(224, 64);
            picFotoUsuario.Name = "picFotoUsuario";
            picFotoUsuario.Size = new Size(193, 178);
            picFotoUsuario.TabIndex = 0;
            picFotoUsuario.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.FromArgb(52, 11, 66);
            lblUsuario.Location = new Point(265, 245);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(117, 32);
            lblUsuario.TabIndex = 12;
            lblUsuario.Text = "Usuário";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(52, 11, 66);
            label3.Location = new Point(468, 70);
            label3.Name = "label3";
            label3.Size = new Size(186, 18);
            label3.TabIndex = 13;
            label3.Text = "Detalhes da denúncia:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // wilBitPanel10
            // 
            wilBitPanel10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            wilBitPanel10.BackColor = Color.FromArgb(240, 208, 255);
            wilBitPanel10.BorderColor = Color.PaleVioletRed;
            wilBitPanel10.BorderRadius = 0;
            wilBitPanel10.BorderSize = 0;
            wilBitPanel10.Controls.Add(lblDetalhesDenuncia);
            wilBitPanel10.ForeColor = Color.White;
            wilBitPanel10.Location = new Point(468, 88);
            wilBitPanel10.Name = "wilBitPanel10";
            wilBitPanel10.Size = new Size(0, 0);
            wilBitPanel10.TabIndex = 12;
            wilBitPanel10.Paint += wilBitPanel10_Paint;
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
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(52, 11, 66);
            label4.Location = new Point(481, 224);
            label4.Name = "label4";
            label4.Size = new Size(118, 18);
            label4.TabIndex = 14;
            label4.Text = "ID do usuário:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSuspendeDenuncia
            // 
            btnSuspendeDenuncia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSuspendeDenuncia.BackColor = Color.FromArgb(131, 84, 169);
            btnSuspendeDenuncia.BorderColor = Color.FromArgb(72, 116, 245);
            btnSuspendeDenuncia.BorderRadius = 6;
            btnSuspendeDenuncia.BorderSize = 0;
            btnSuspendeDenuncia.Cursor = Cursors.Hand;
            btnSuspendeDenuncia.FlatAppearance.BorderSize = 0;
            btnSuspendeDenuncia.FlatStyle = FlatStyle.Flat;
            btnSuspendeDenuncia.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuspendeDenuncia.ForeColor = Color.White;
            btnSuspendeDenuncia.Location = new Point(635, 227);
            btnSuspendeDenuncia.Name = "btnSuspendeDenuncia";
            btnSuspendeDenuncia.Size = new Size(144, 36);
            btnSuspendeDenuncia.TabIndex = 0;
            btnSuspendeDenuncia.Text = "Suspender a denúncia";
            btnSuspendeDenuncia.UseVisualStyleBackColor = false;
            btnSuspendeDenuncia.Click += btnSuspendeDenuncia_Click_1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(52, 11, 66);
            label5.Location = new Point(468, 285);
            label5.Name = "label5";
            label5.Size = new Size(282, 24);
            label5.TabIndex = 17;
            label5.Text = "Justificativa de banimento:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnBanirUsuario
            // 
            btnBanirUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBanirUsuario.BackColor = Color.FromArgb(95, 40, 123);
            btnBanirUsuario.BorderColor = Color.FromArgb(72, 116, 245);
            btnBanirUsuario.BorderRadius = 6;
            btnBanirUsuario.BorderSize = 0;
            btnBanirUsuario.Cursor = Cursors.Hand;
            btnBanirUsuario.FlatAppearance.BorderSize = 0;
            btnBanirUsuario.FlatStyle = FlatStyle.Flat;
            btnBanirUsuario.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBanirUsuario.ForeColor = Color.White;
            btnBanirUsuario.Location = new Point(468, 489);
            btnBanirUsuario.Name = "btnBanirUsuario";
            btnBanirUsuario.Size = new Size(311, 26);
            btnBanirUsuario.TabIndex = 18;
            btnBanirUsuario.Text = "Banir usuário";
            btnBanirUsuario.UseVisualStyleBackColor = false;
            // 
            // txtJustificativaBanimento
            // 
            txtJustificativaBanimento.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtJustificativaBanimento.BackColor = Color.FromArgb(240, 208, 255);
            txtJustificativaBanimento.BorderColor = Color.FromArgb(52, 11, 66);
            txtJustificativaBanimento.BorderFocusColor = Color.Indigo;
            txtJustificativaBanimento.BorderRadius = 4;
            txtJustificativaBanimento.BorderSize = 2;
            txtJustificativaBanimento.Cursor = Cursors.IBeam;
            txtJustificativaBanimento.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtJustificativaBanimento.ForeColor = Color.FromArgb(64, 64, 64);
            txtJustificativaBanimento.Location = new Point(468, 313);
            txtJustificativaBanimento.Margin = new Padding(4);
            txtJustificativaBanimento.Multiline = true;
            txtJustificativaBanimento.Name = "txtJustificativaBanimento";
            txtJustificativaBanimento.Padding = new Padding(10, 7, 10, 7);
            txtJustificativaBanimento.PasswordChar = false;
            txtJustificativaBanimento.PlaceholderColor = Color.DarkGray;
            txtJustificativaBanimento.PlaceholderText = "";
            txtJustificativaBanimento.Size = new Size(311, 169);
            txtJustificativaBanimento.TabIndex = 0;
            txtJustificativaBanimento.Texts = "";
            txtJustificativaBanimento.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(52, 11, 66);
            label2.Location = new Point(224, 403);
            label2.Name = "label2";
            label2.Size = new Size(186, 27);
            label2.TabIndex = 19;
            label2.Text = "Biografia do usuário";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(52, 11, 66);
            label7.Location = new Point(231, 281);
            label7.Name = "label7";
            label7.Size = new Size(186, 27);
            label7.TabIndex = 20;
            label7.Text = "Biografia de mix";
            // 
            // txtBiografiaMix
            // 
            txtBiografiaMix.BackColor = Color.FromArgb(240, 208, 255);
            txtBiografiaMix.BorderStyle = BorderStyle.None;
            txtBiografiaMix.ForeColor = Color.FromArgb(52, 11, 66);
            txtBiografiaMix.Location = new Point(224, 301);
            txtBiografiaMix.Multiline = true;
            txtBiografiaMix.Name = "txtBiografiaMix";
            txtBiografiaMix.ReadOnly = true;
            txtBiografiaMix.ScrollBars = ScrollBars.Vertical;
            txtBiografiaMix.Size = new Size(193, 86);
            txtBiografiaMix.TabIndex = 21;
            // 
            // txtBiografiaUsuario
            // 
            txtBiografiaUsuario.BackColor = Color.FromArgb(240, 208, 255);
            txtBiografiaUsuario.BorderStyle = BorderStyle.None;
            txtBiografiaUsuario.ForeColor = Color.FromArgb(52, 11, 66);
            txtBiografiaUsuario.Location = new Point(224, 429);
            txtBiografiaUsuario.Multiline = true;
            txtBiografiaUsuario.Name = "txtBiografiaUsuario";
            txtBiografiaUsuario.ReadOnly = true;
            txtBiografiaUsuario.ScrollBars = ScrollBars.Vertical;
            txtBiografiaUsuario.Size = new Size(193, 86);
            txtBiografiaUsuario.TabIndex = 22;
            // 
            // txtDetalhesDenuncia
            // 
            txtDetalhesDenuncia.BackColor = Color.FromArgb(240, 208, 255);
            txtDetalhesDenuncia.Location = new Point(468, 91);
            txtDetalhesDenuncia.Multiline = true;
            txtDetalhesDenuncia.Name = "txtDetalhesDenuncia";
            txtDetalhesDenuncia.ReadOnly = true;
            txtDetalhesDenuncia.Size = new Size(311, 130);
            txtDetalhesDenuncia.TabIndex = 23;
            // 
            // lbl_idUsuario
            // 
            lbl_idUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_idUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_idUsuario.ForeColor = Color.FromArgb(52, 11, 66);
            lbl_idUsuario.Location = new Point(481, 245);
            lbl_idUsuario.Name = "lbl_idUsuario";
            lbl_idUsuario.Size = new Size(118, 18);
            lbl_idUsuario.TabIndex = 24;
            lbl_idUsuario.Text = "00";
            lbl_idUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TelaDoModerador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(213, 192, 220);
            ClientSize = new Size(803, 531);
            Controls.Add(lbl_idUsuario);
            Controls.Add(txtDetalhesDenuncia);
            Controls.Add(txtBiografiaUsuario);
            Controls.Add(txtBiografiaMix);
            Controls.Add(panel1);
            Controls.Add(panelListaDenuncias);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(txtJustificativaBanimento);
            Controls.Add(btnBanirUsuario);
            Controls.Add(label5);
            Controls.Add(btnSuspendeDenuncia);
            Controls.Add(label4);
            Controls.Add(wilBitPanel10);
            Controls.Add(label3);
            Controls.Add(lblUsuario);
            Controls.Add(picFotoUsuario);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(819, 570);
            Name = "TelaDoModerador";
            Text = "TelaDoModerador";
            Load += TelaDoModerador_Load;
            panel1.ResumeLayout(false);
            panelListaDenuncias.ResumeLayout(false);
            panelPerfilDenunciado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            wilBitPanel3.ResumeLayout(false);
            wilBitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picFotoUsuario).EndInit();
            wilBitPanel10.ResumeLayout(false);
            wilBitPanel10.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panelListaDenuncias;
        private Panel panel3;
        private PictureBox picFotoUsuario;
        private Label label1;
        private WiLBiT.WiLBiTPanel panelPerfilDenunciado;
        private Label lblUsuario;
        private Label label3;
        private WiLBiT.WiLBiTPanel wilBitPanel10;
        private Label label4;
        private WiLBiT.WiLBiTButton btnSuspendeDenuncia;
        private Label label5;
        private Label lblNomeMiniatura;
        private WiLBiT.WiLBiTButton btnBanirUsuario;
        private Label lblDetalhesDenuncia;
        private WiLBiT.WiLBiTTextBox txtJustificativaBanimento;
        private WiLBiT.WiLBiTPanel wilBitPanel2;
        private LinkLabel linkLabel1;
        private WiLBiT.WiLBiTPanel wilBitPanel3;
        private LinkLabel linkLabel2;
        private Label label2;
        private Label label7;
        private PictureBox pictureBox1;
        private TextBox txtBiografiaMix;
        private TextBox txtBiografiaUsuario;
        private TextBox txtDetalhesDenuncia;
        private Label lbl_idUsuario;
    }
}