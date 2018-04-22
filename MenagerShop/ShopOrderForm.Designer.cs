namespace MenagerShop
{
    partial class ShopOrderForm
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
            this.cboxContractor = new System.Windows.Forms.ComboBox();
            this.txtNrZamowienia = new System.Windows.Forms.TextBox();
            this.dateContractor = new System.Windows.Forms.DateTimePicker();
            this.lblKontrahent = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNrZamówienia = new System.Windows.Forms.Label();
            this.btmZapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxContractor
            // 
            this.cboxContractor.FormattingEnabled = true;
            this.cboxContractor.Location = new System.Drawing.Point(80, 6);
            this.cboxContractor.Name = "cboxContractor";
            this.cboxContractor.Size = new System.Drawing.Size(200, 21);
            this.cboxContractor.TabIndex = 0;
            // 
            // txtNrZamowienia
            // 
            this.txtNrZamowienia.Location = new System.Drawing.Point(99, 59);
            this.txtNrZamowienia.Name = "txtNrZamowienia";
            this.txtNrZamowienia.Size = new System.Drawing.Size(181, 20);
            this.txtNrZamowienia.TabIndex = 1;
            // 
            // dateContractor
            // 
            this.dateContractor.Location = new System.Drawing.Point(51, 33);
            this.dateContractor.Name = "dateContractor";
            this.dateContractor.Size = new System.Drawing.Size(229, 20);
            this.dateContractor.TabIndex = 2;
            // 
            // lblKontrahent
            // 
            this.lblKontrahent.AutoSize = true;
            this.lblKontrahent.Location = new System.Drawing.Point(12, 9);
            this.lblKontrahent.Name = "lblKontrahent";
            this.lblKontrahent.Size = new System.Drawing.Size(62, 13);
            this.lblKontrahent.TabIndex = 3;
            this.lblKontrahent.Text = "Kontrahent:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 36);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data:";
            // 
            // lblNrZamówienia
            // 
            this.lblNrZamówienia.AutoSize = true;
            this.lblNrZamówienia.Location = new System.Drawing.Point(12, 62);
            this.lblNrZamówienia.Name = "lblNrZamówienia";
            this.lblNrZamówienia.Size = new System.Drawing.Size(81, 13);
            this.lblNrZamówienia.TabIndex = 5;
            this.lblNrZamówienia.Text = "Nr.Zamówienia:";
            // 
            // btmZapisz
            // 
            this.btmZapisz.Location = new System.Drawing.Point(12, 85);
            this.btmZapisz.Name = "btmZapisz";
            this.btmZapisz.Size = new System.Drawing.Size(268, 33);
            this.btmZapisz.TabIndex = 6;
            this.btmZapisz.Text = "Zapisz";
            this.btmZapisz.UseVisualStyleBackColor = true;
            this.btmZapisz.Click += new System.EventHandler(this.btmZapisz_Click);
            // 
            // ShopOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 126);
            this.Controls.Add(this.btmZapisz);
            this.Controls.Add(this.lblNrZamówienia);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblKontrahent);
            this.Controls.Add(this.dateContractor);
            this.Controls.Add(this.txtNrZamowienia);
            this.Controls.Add(this.cboxContractor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShopOrderForm";
            this.Text = "Menager Shop - Zamówienia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxContractor;
        private System.Windows.Forms.TextBox txtNrZamowienia;
        private System.Windows.Forms.DateTimePicker dateContractor;
        private System.Windows.Forms.Label lblKontrahent;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblNrZamówienia;
        private System.Windows.Forms.Button btmZapisz;
    }
}