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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            picFotoUsuario = new WiLBiT.WiLBiTRoundedPictureBox();
            panel4 = new Panel();
            label1 = new Label();
            btnVoltaInicio = new PictureBox();
            label2 = new Label();
            panel5 = new Panel();
            wilBitPanel1 = new WiLBiT.WiLBiTPanel();
            label6 = new Label();
            wilBitRoundedPictureBox2 = new WiLBiT.WiLBiTRoundedPictureBox();
            textBox1 = new TextBox();
            btnEmoji = new PictureBox();
            btnEnviaMensagem = new PictureBox();
            wilBitPanel2 = new WiLBiT.WiLBiTPanel();
            wilBitPanel3 = new WiLBiT.WiLBiTPanel();
            btnDenunciaUsuario = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoUsuario).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnVoltaInicio).BeginInit();
            panel5.SuspendLayout();
            wilBitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wilBitRoundedPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEmoji).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEnviaMensagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDenunciaUsuario).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(64, 15, 87);
            panel1.Controls.Add(wilBitPanel1);
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 375);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(225, 209, 232);
            panel2.Controls.Add(wilBitPanel3);
            panel2.Controls.Add(wilBitPanel2);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(220, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(560, 375);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(233, 220, 246);
            panel3.Controls.Add(btnDenunciaUsuario);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(picFotoUsuario);
            panel3.Location = new Point(220, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(560, 50);
            panel3.TabIndex = 2;
            // 
            // picFotoUsuario
            // 
            picFotoUsuario.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            picFotoUsuario.BorderColor = Color.FromArgb(64, 15, 87);
            picFotoUsuario.BorderColor2 = Color.FromArgb(64, 15, 87);
            picFotoUsuario.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            picFotoUsuario.BorderSize = 2;
            picFotoUsuario.GradientAngle = 50F;
            picFotoUsuario.Location = new Point(18, 5);
            picFotoUsuario.Name = "picFotoUsuario";
            picFotoUsuario.Size = new Size(42, 42);
            picFotoUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            picFotoUsuario.TabIndex = 1;
            picFotoUsuario.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(118, 55, 148);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btnVoltaInicio);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 50);
            panel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(52, 11, 66);
            label1.Location = new Point(66, 18);
            label1.Name = "label1";
            label1.Size = new Size(70, 18);
            label1.TabIndex = 20;
            label1.Text = "Usuário";
            // 
            // btnVoltaInicio
            // 
            btnVoltaInicio.Image = (Image)resources.GetObject("btnVoltaInicio.Image");
            btnVoltaInicio.Location = new Point(12, 12);
            btnVoltaInicio.Name = "btnVoltaInicio";
            btnVoltaInicio.Size = new Size(33, 32);
            btnVoltaInicio.SizeMode = PictureBoxSizeMode.Zoom;
            btnVoltaInicio.TabIndex = 0;
            btnVoltaInicio.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(225, 209, 232);
            label2.Location = new Point(51, 5);
            label2.Name = "label2";
            label2.Size = new Size(125, 41);
            label2.TabIndex = 21;
            label2.Text = "Voltar para tela de início";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(233, 220, 246);
            panel5.Controls.Add(btnEnviaMensagem);
            panel5.Controls.Add(btnEmoji);
            panel5.Controls.Add(textBox1);
            panel5.Location = new Point(0, 314);
            panel5.Name = "panel5";
            panel5.Size = new Size(560, 61);
            panel5.TabIndex = 21;
            // 
            // wilBitPanel1
            // 
            wilBitPanel1.BackColor = Color.FromArgb(228, 193, 249);
            wilBitPanel1.BorderColor = Color.PaleVioletRed;
            wilBitPanel1.BorderRadius = 6;
            wilBitPanel1.BorderSize = 0;
            wilBitPanel1.Controls.Add(label6);
            wilBitPanel1.Controls.Add(wilBitRoundedPictureBox2);
            wilBitPanel1.ForeColor = Color.White;
            wilBitPanel1.Location = new Point(12, 17);
            wilBitPanel1.Name = "wilBitPanel1";
            wilBitPanel1.Size = new Size(174, 50);
            wilBitPanel1.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(52, 11, 66);
            label6.Location = new Point(55, 17);
            label6.Name = "label6";
            label6.Size = new Size(70, 18);
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
            // textBox1
            // 
            textBox1.Location = new Point(57, 10);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(449, 38);
            textBox1.TabIndex = 0;
            // 
            // btnEmoji
            // 
            btnEmoji.Image = (Image)resources.GetObject("btnEmoji.Image");
            btnEmoji.Location = new Point(18, 10);
            btnEmoji.Name = "btnEmoji";
            btnEmoji.Size = new Size(33, 38);
            btnEmoji.SizeMode = PictureBoxSizeMode.CenterImage;
            btnEmoji.TabIndex = 21;
            btnEmoji.TabStop = false;
            // 
            // btnEnviaMensagem
            // 
            btnEnviaMensagem.Image = (Image)resources.GetObject("btnEnviaMensagem.Image");
            btnEnviaMensagem.Location = new Point(512, 10);
            btnEnviaMensagem.Name = "btnEnviaMensagem";
            btnEnviaMensagem.Size = new Size(33, 38);
            btnEnviaMensagem.SizeMode = PictureBoxSizeMode.CenterImage;
            btnEnviaMensagem.TabIndex = 22;
            btnEnviaMensagem.TabStop = false;
            // 
            // wilBitPanel2
            // 
            wilBitPanel2.BackColor = Color.FromArgb(218, 186, 234);
            wilBitPanel2.BorderColor = Color.PaleVioletRed;
            wilBitPanel2.BorderRadius = 6;
            wilBitPanel2.BorderSize = 0;
            wilBitPanel2.ForeColor = Color.White;
            wilBitPanel2.Location = new Point(18, 20);
            wilBitPanel2.Name = "wilBitPanel2";
            wilBitPanel2.Size = new Size(226, 50);
            wilBitPanel2.TabIndex = 22;
            // 
            // wilBitPanel3
            // 
            wilBitPanel3.BackColor = Color.FromArgb(122, 71, 163);
            wilBitPanel3.BorderColor = Color.PaleVioletRed;
            wilBitPanel3.BorderRadius = 6;
            wilBitPanel3.BorderSize = 0;
            wilBitPanel3.ForeColor = Color.White;
            wilBitPanel3.Location = new Point(319, 73);
            wilBitPanel3.Name = "wilBitPanel3";
            wilBitPanel3.Size = new Size(226, 50);
            wilBitPanel3.TabIndex = 23;
            // 
            // btnDenunciaUsuario
            // 
            btnDenunciaUsuario.Image = (Image)resources.GetObject("btnDenunciaUsuario.Image");
            btnDenunciaUsuario.Location = new Point(512, 6);
            btnDenunciaUsuario.Name = "btnDenunciaUsuario";
            btnDenunciaUsuario.Size = new Size(33, 38);
            btnDenunciaUsuario.SizeMode = PictureBoxSizeMode.CenterImage;
            btnDenunciaUsuario.TabIndex = 23;
            btnDenunciaUsuario.TabStop = false;
            // 
            // TelaDeMensagens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 424);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaDeMensagens";
            Text = "TelaDeMensagens";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoUsuario).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnVoltaInicio).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            wilBitPanel1.ResumeLayout(false);
            wilBitPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)wilBitRoundedPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEmoji).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEnviaMensagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDenunciaUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private WiLBiT.WiLBiTRoundedPictureBox picFotoUsuario;
        private PictureBox btnVoltaInicio;
        private Label label1;
        private Panel panel4;
        private Label label2;
        private Panel panel5;
        private WiLBiT.WiLBiTPanel wilBitPanel1;
        private Label label6;
        private WiLBiT.WiLBiTRoundedPictureBox wilBitRoundedPictureBox2;
        private TextBox textBox1;
        private PictureBox btnEmoji;
        private PictureBox btnEnviaMensagem;
        private WiLBiT.WiLBiTPanel wilBitPanel3;
        private WiLBiT.WiLBiTPanel wilBitPanel2;
        private PictureBox btnDenunciaUsuario;
    }
}