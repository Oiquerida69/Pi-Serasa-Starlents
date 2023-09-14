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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMotivoDenuncia = new System.Windows.Forms.TextBox();
            this.btnDenunciar = new WiLBiT.WiLBiTButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(1)))), ((int)(((byte)(175)))));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deseja denunciar o usuário?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(1)))), ((int)(((byte)(175)))));
            this.label2.Location = new System.Drawing.Point(41, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insira o motivo da denúncia:";
            // 
            // txtMotivoDenuncia
            // 
            this.txtMotivoDenuncia.Location = new System.Drawing.Point(41, 102);
            this.txtMotivoDenuncia.Multiline = true;
            this.txtMotivoDenuncia.Name = "txtMotivoDenuncia";
            this.txtMotivoDenuncia.Size = new System.Drawing.Size(366, 134);
            this.txtMotivoDenuncia.TabIndex = 3;
            // 
            // btnDenunciar
            // 
            this.btnDenunciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(1)))), ((int)(((byte)(175)))));
            this.btnDenunciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDenunciar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDenunciar.BorderRadius = 6;
            this.btnDenunciar.BorderSize = 0;
            this.btnDenunciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDenunciar.FlatAppearance.BorderSize = 0;
            this.btnDenunciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDenunciar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDenunciar.ForeColor = System.Drawing.Color.White;
            this.btnDenunciar.Location = new System.Drawing.Point(41, 242);
            this.btnDenunciar.Name = "btnDenunciar";
            this.btnDenunciar.Size = new System.Drawing.Size(366, 40);
            this.btnDenunciar.TabIndex = 4;
            this.btnDenunciar.Text = "Denunciar";
            this.btnDenunciar.UseVisualStyleBackColor = false;
            // 
            // TelaDeDenuncia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(458, 304);
            this.Controls.Add(this.btnDenunciar);
            this.Controls.Add(this.txtMotivoDenuncia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaDeDenuncia";
            this.Text = "TelaDeDenuncia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMotivoDenuncia;
        private WiLBiT.WiLBiTButton btnDenunciar;
    }
}