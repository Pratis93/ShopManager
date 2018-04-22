namespace MenagerShop
{
    partial class ShopContractorForm
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
            this.lblImie = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNIP = new System.Windows.Forms.Label();
            this.lbleMail = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtNIP = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Location = new System.Drawing.Point(4, 15);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(29, 13);
            this.lblImie.TabIndex = 0;
            this.lblImie.Text = "Imie:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(4, 41);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(37, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Adres:";
            // 
            // lblNIP
            // 
            this.lblNIP.AutoSize = true;
            this.lblNIP.Location = new System.Drawing.Point(5, 65);
            this.lblNIP.Name = "lblNIP";
            this.lblNIP.Size = new System.Drawing.Size(28, 13);
            this.lblNIP.TabIndex = 2;
            this.lblNIP.Text = "NIP:";
            // 
            // lbleMail
            // 
            this.lbleMail.AutoSize = true;
            this.lbleMail.Location = new System.Drawing.Point(4, 94);
            this.lbleMail.Name = "lbleMail";
            this.lbleMail.Size = new System.Drawing.Size(39, 13);
            this.lbleMail.TabIndex = 3;
            this.lbleMail.Text = "E-Mail:";
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(39, 12);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(233, 20);
            this.txtImie.TabIndex = 4;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(39, 38);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(233, 20);
            this.txtAdres.TabIndex = 5;
            // 
            // txtNIP
            // 
            this.txtNIP.Location = new System.Drawing.Point(39, 64);
            this.txtNIP.Name = "txtNIP";
            this.txtNIP.Size = new System.Drawing.Size(233, 20);
            this.txtNIP.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(47, 91);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(12, 117);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(260, 40);
            this.btnZapisz.TabIndex = 8;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // ShopContractorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 163);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNIP);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.lbleMail);
            this.Controls.Add(this.lblNIP);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblImie);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShopContractorForm";
            this.Text = "Menager Shop - Kontrahenci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNIP;
        private System.Windows.Forms.Label lbleMail;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtNIP;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnZapisz;
    }
}