namespace Pi_Serasa_Starlents
{
    partial class Notificacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notificacao));
            wilBitGradientPanel1 = new WiLBiT.WiLBiTGradientPanel();
            wilBitPanel1 = new WiLBiT.WiLBiTPanel();
            wilBitPanel2 = new WiLBiT.WiLBiTPanel();
            btnNovosMatchs = new WiLBiT.WiLBiTButton();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            wilBitGradientPanel1.SuspendLayout();
            wilBitPanel1.SuspendLayout();
            wilBitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // wilBitGradientPanel1
            // 
            wilBitGradientPanel1.Anchor = AnchorStyles.None;
            wilBitGradientPanel1.BackColor = Color.FromArgb(64, 15, 87);
            wilBitGradientPanel1.BackColor2 = Color.FromArgb(153, 47, 240);
            wilBitGradientPanel1.BorderColor = Color.PaleVioletRed;
            wilBitGradientPanel1.BorderRadius = 6;
            wilBitGradientPanel1.BorderSize = 0;
            wilBitGradientPanel1.Controls.Add(wilBitPanel1);
            wilBitGradientPanel1.Controls.Add(label3);
            wilBitGradientPanel1.ForeColor = Color.White;
            wilBitGradientPanel1.Location = new Point(-5, -6);
            wilBitGradientPanel1.Name = "wilBitGradientPanel1";
            wilBitGradientPanel1.Size = new Size(1082, 626);
            wilBitGradientPanel1.TabIndex = 0;
            wilBitGradientPanel1.Paint += wilBitGradientPanel1_Paint;
            // 
            // wilBitPanel1
            // 
            wilBitPanel1.Anchor = AnchorStyles.None;
            wilBitPanel1.AutoScroll = true;
            wilBitPanel1.BackColor = Color.FromArgb(232, 218, 235);
            wilBitPanel1.BorderColor = Color.PaleVioletRed;
            wilBitPanel1.BorderRadius = 6;
            wilBitPanel1.BorderSize = 0;
            wilBitPanel1.Controls.Add(wilBitPanel2);
            wilBitPanel1.Controls.Add(btnNovosMatchs);
            wilBitPanel1.ForeColor = Color.White;
            wilBitPanel1.Location = new Point(136, 175);
            wilBitPanel1.Name = "wilBitPanel1";
            wilBitPanel1.Size = new Size(854, 411);
            wilBitPanel1.TabIndex = 28;
            wilBitPanel1.Paint += wilBitPanel1_Paint;
            // 
            // wilBitPanel2
            // 
            wilBitPanel2.Anchor = AnchorStyles.None;
            wilBitPanel2.BackColor = Color.FromArgb(244, 231, 250);
            wilBitPanel2.BorderColor = Color.PaleVioletRed;
            wilBitPanel2.BorderRadius = 6;
            wilBitPanel2.BorderSize = 0;
            wilBitPanel2.Controls.Add(pictureBox1);
            wilBitPanel2.Controls.Add(label1);
            wilBitPanel2.ForeColor = Color.White;
            wilBitPanel2.Location = new Point(81, 105);
            wilBitPanel2.Name = "wilBitPanel2";
            wilBitPanel2.Size = new Size(691, 53);
            wilBitPanel2.TabIndex = 3;
         
            // 
            // btnNovosMatchs
            // 
            btnNovosMatchs.Anchor = AnchorStyles.None;
            btnNovosMatchs.BackColor = Color.FromArgb(64, 15, 87);
            btnNovosMatchs.BorderColor = Color.BlueViolet;
            btnNovosMatchs.BorderRadius = 6;
            btnNovosMatchs.BorderSize = 2;
            btnNovosMatchs.FlatAppearance.BorderSize = 0;
            btnNovosMatchs.FlatStyle = FlatStyle.Flat;
            btnNovosMatchs.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovosMatchs.ForeColor = Color.White;
            btnNovosMatchs.Location = new Point(81, 22);
            btnNovosMatchs.Name = "btnNovosMatchs";
            btnNovosMatchs.Size = new Size(215, 50);
            btnNovosMatchs.TabIndex = 0;
            btnNovosMatchs.Text = "Novos matchs";
            btnNovosMatchs.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(404, 117);
            label3.Name = "label3";
            label3.Size = new Size(319, 55);
            label3.TabIndex = 27;
            label3.Text = "Notificações";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(78, 24, 120);
            label1.Location = new Point(45, 15);
            label1.Name = "label1";
            label1.Size = new Size(152, 14);
            label1.TabIndex = 4;
            label1.Text = "Descrição da Notificação";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Notificacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 592);
            Controls.Add(wilBitGradientPanel1);
            Name = "Notificacao";
            Text = "Notificacao";
            Load += Notificacao_Load;
            wilBitGradientPanel1.ResumeLayout(false);
            wilBitGradientPanel1.PerformLayout();
            wilBitPanel1.ResumeLayout(false);
            wilBitPanel2.ResumeLayout(false);
            wilBitPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private WiLBiT.WiLBiTGradientPanel wilBitGradientPanel1;
        private Panel panelCima;
        private PictureBox pictureBox6;
        private PictureBox pictureBox9;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private WiLBiT.WiLBiTPanel wilBitPanel1;
        private WiLBiT.WiLBiTPanel wilBitPanel2;
        private WiLBiT.WiLBiTPanel wilBitPanel3;
        private WiLBiT.WiLBiTButton wilBitButton3;
        private WiLBiT.WiLBiTButton wilBitButton2;
        private WiLBiT.WiLBiTButton btnNovosMatchs;
        private PictureBox pictureBox1;
        private Label label1;
        private WiLBiT.WiLBiTPanel wilBitPanel4;
        private WiLBiT.WiLBiTPanel wilBitPanel5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private Panel panel6;
        private Panel panelIcones;
    }
}