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
            textBox1 = new TextBox();
            wilBitButton1 = new WiLBiT.WiLBiTButton();
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
            // textBox1
            // 
            textBox1.Location = new Point(41, 102);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(366, 134);
            textBox1.TabIndex = 3;
            // 
            // wilBitButton1
            // 
            wilBitButton1.BackColor = Color.FromArgb(119, 1, 175);
            wilBitButton1.BackgroundImageLayout = ImageLayout.None;
            wilBitButton1.BorderColor = Color.FromArgb(72, 116, 245);
            wilBitButton1.BorderRadius = 6;
            wilBitButton1.BorderSize = 0;
            wilBitButton1.Cursor = Cursors.Hand;
            wilBitButton1.FlatAppearance.BorderSize = 0;
            wilBitButton1.FlatStyle = FlatStyle.Flat;
            wilBitButton1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            wilBitButton1.ForeColor = Color.White;
            wilBitButton1.Location = new Point(41, 242);
            wilBitButton1.Name = "wilBitButton1";
            wilBitButton1.Size = new Size(366, 40);
            wilBitButton1.TabIndex = 4;
            wilBitButton1.Text = "Denunciar";
            wilBitButton1.UseVisualStyleBackColor = false;
            // 
            // TelaDeDenuncia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 210, 225);
            ClientSize = new Size(458, 304);
            Controls.Add(wilBitButton1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "TelaDeDenuncia";
            Text = "TelaDeDenuncia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private WiLBiT.WiLBiTButton wilBitButton1;
    }
}