namespace MenagerShop
{
    partial class ShopProductsForm
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
            this.txtProductsName = new System.Windows.Forms.TextBox();
            this.lblProductsName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblNetPrice = new System.Windows.Forms.Label();
            this.txtNetPrice = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProductsName
            // 
            this.txtProductsName.Location = new System.Drawing.Point(107, 6);
            this.txtProductsName.Name = "txtProductsName";
            this.txtProductsName.Size = new System.Drawing.Size(175, 20);
            this.txtProductsName.TabIndex = 0;
            // 
            // lblProductsName
            // 
            this.lblProductsName.AutoSize = true;
            this.lblProductsName.Location = new System.Drawing.Point(12, 9);
            this.lblProductsName.Name = "lblProductsName";
            this.lblProductsName.Size = new System.Drawing.Size(89, 13);
            this.lblProductsName.TabIndex = 1;
            this.lblProductsName.Text = "Nazwa Produktu:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 36);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(32, 13);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Ilość:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(50, 33);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(232, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // lblNetPrice
            // 
            this.lblNetPrice.AutoSize = true;
            this.lblNetPrice.Location = new System.Drawing.Point(12, 64);
            this.lblNetPrice.Name = "lblNetPrice";
            this.lblNetPrice.Size = new System.Drawing.Size(62, 13);
            this.lblNetPrice.TabIndex = 5;
            this.lblNetPrice.Text = "Cena netto:";
            // 
            // txtNetPrice
            // 
            this.txtNetPrice.Location = new System.Drawing.Point(80, 61);
            this.txtNetPrice.Name = "txtNetPrice";
            this.txtNetPrice.Size = new System.Drawing.Size(202, 20);
            this.txtNetPrice.TabIndex = 4;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(159, 101);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(123, 29);
            this.btnZapisz.TabIndex = 6;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(12, 101);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(123, 29);
            this.btnAnuluj.TabIndex = 7;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // ShopProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 142);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.lblNetPrice);
            this.Controls.Add(this.txtNetPrice);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblProductsName);
            this.Controls.Add(this.txtProductsName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShopProductsForm";
            this.Text = "Menager Shop - Dodaj nowy produkt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductsName;
        private System.Windows.Forms.Label lblProductsName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblNetPrice;
        private System.Windows.Forms.TextBox txtNetPrice;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnAnuluj;
    }
}