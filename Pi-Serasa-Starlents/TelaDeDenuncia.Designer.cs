namespace Pi_Serasa_Starlents
{
    partial class TelaDeDenuncia
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
            label1 = new Label();
            label2 = new Label();
            txtMotivoDenuncia = new TextBox();
            btnDenunciar = new WiLBiT.WiLBiTButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(119, 1, 175);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(419, 33);
            label1.TabIndex = 0;
            label1.Text = "Deseja denunciar o usuário?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(119, 1, 175);
            label2.Location = new Point(41, 81);
            label2.Name = "label2";
            label2.Size = new Size(201, 18);
            label2.TabIndex = 2;
            label2.Text = "Insira o motivo da denúncia:";
            // 
            // txtMotivoDenuncia
            // 
            txtMotivoDenuncia.Location = new Point(41, 102);
            txtMotivoDenuncia.Multiline = true;
            txtMotivoDenuncia.Name = "txtMotivoDenuncia";
            txtMotivoDenuncia.Size = new Size(366, 134);
            txtMotivoDenuncia.TabIndex = 3;
            // 
            // btnDenunciar
            // 
            btnDenunciar.BackColor = Color.FromArgb(119, 1, 175);
            btnDenunciar.BackgroundImageLayout = ImageLayout.None;
            btnDenunciar.BorderColor = Color.FromArgb(192, 0, 192);
            btnDenunciar.BorderRadius = 6;
            btnDenunciar.BorderSize = 0;
            btnDenunciar.Cursor = Cursors.Hand;
            btnDenunciar.FlatAppearance.BorderSize = 0;
            btnDenunciar.FlatStyle = FlatStyle.Flat;
            btnDenunciar.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDenunciar.ForeColor = Color.White;
            btnDenunciar.Location = new Point(41, 242);
            btnDenunciar.Name = "btnDenunciar";
            btnDenunciar.Size = new Size(366, 40);
            btnDenunciar.TabIndex = 4;
            btnDenunciar.Text = "Denunciar";
            btnDenunciar.UseVisualStyleBackColor = false;
            // 
            // TelaDeDenuncia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 210, 225);
            ClientSize = new Size(458, 304);
            Controls.Add(btnDenunciar);
            Controls.Add(txtMotivoDenuncia);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TelaDeDenuncia";
            Text = "TelaDeDenuncia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMotivoDenuncia;
        private WiLBiT.WiLBiTButton btnDenunciar;
    }
}