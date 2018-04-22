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
            this.btnUtworzZamowienie = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridOrder = new System.Windows.Forms.DataGridView();
            this.lblIlosc = new System.Windows.Forms.Label();
            this.gridProduct = new System.Windows.Forms.DataGridView();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.nbQuantity = new System.Windows.Forms.NumericUpDown();
            this.nbQuantityEdit = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbQuantityEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxContractor
            // 
            this.cboxContractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxContractor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboxContractor.FormattingEnabled = true;
            this.cboxContractor.Location = new System.Drawing.Point(442, 15);
            this.cboxContractor.Name = "cboxContractor";
            this.cboxContractor.Size = new System.Drawing.Size(200, 28);
            this.cboxContractor.TabIndex = 0;
            // 
            // txtNrZamowienia
            // 
            this.txtNrZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNrZamowienia.Location = new System.Drawing.Point(136, 15);
            this.txtNrZamowienia.Name = "txtNrZamowienia";
            this.txtNrZamowienia.Size = new System.Drawing.Size(181, 26);
            this.txtNrZamowienia.TabIndex = 1;
            // 
            // dateContractor
            // 
            this.dateContractor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateContractor.Location = new System.Drawing.Point(707, 19);
            this.dateContractor.Name = "dateContractor";
            this.dateContractor.Size = new System.Drawing.Size(229, 26);
            this.dateContractor.TabIndex = 2;
            // 
            // lblKontrahent
            // 
            this.lblKontrahent.AutoSize = true;
            this.lblKontrahent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKontrahent.Location = new System.Drawing.Point(337, 19);
            this.lblKontrahent.Name = "lblKontrahent";
            this.lblKontrahent.Size = new System.Drawing.Size(92, 20);
            this.lblKontrahent.TabIndex = 3;
            this.lblKontrahent.Text = "Kontrahent:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblData.Location = new System.Drawing.Point(652, 21);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(48, 20);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data:";
            // 
            // lblNrZamówienia
            // 
            this.lblNrZamówienia.AutoSize = true;
            this.lblNrZamówienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNrZamówienia.Location = new System.Drawing.Point(12, 17);
            this.lblNrZamówienia.Name = "lblNrZamówienia";
            this.lblNrZamówienia.Size = new System.Drawing.Size(118, 20);
            this.lblNrZamówienia.TabIndex = 5;
            this.lblNrZamówienia.Text = "Nr.Zamówienia:";
            // 
            // btnUtworzZamowienie
            // 
            this.btnUtworzZamowienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUtworzZamowienie.Location = new System.Drawing.Point(736, 613);
            this.btnUtworzZamowienie.Name = "btnUtworzZamowienie";
            this.btnUtworzZamowienie.Size = new System.Drawing.Size(200, 50);
            this.btnUtworzZamowienie.TabIndex = 6;
            this.btnUtworzZamowienie.Text = "OK";
            this.btnUtworzZamowienie.UseVisualStyleBackColor = true;
            this.btnUtworzZamowienie.Click += new System.EventHandler(this.btmZapisz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Produkty:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(501, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Zamówienie:";
            // 
            // gridOrder
            // 
            this.gridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrder.Location = new System.Drawing.Point(489, 92);
            this.gridOrder.Name = "gridOrder";
            this.gridOrder.Size = new System.Drawing.Size(447, 374);
            this.gridOrder.TabIndex = 17;
            // 
            // lblIlosc
            // 
            this.lblIlosc.AutoSize = true;
            this.lblIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIlosc.Location = new System.Drawing.Point(21, 490);
            this.lblIlosc.Name = "lblIlosc";
            this.lblIlosc.Size = new System.Drawing.Size(46, 20);
            this.lblIlosc.TabIndex = 16;
            this.lblIlosc.Text = "Ilość:";
            // 
            // gridProduct
            // 
            this.gridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduct.Location = new System.Drawing.Point(17, 92);
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.Size = new System.Drawing.Size(446, 374);
            this.gridProduct.TabIndex = 15;
            this.gridProduct.DoubleClick += new System.EventHandler(this.gridProduct_DoubleClick);
            // 
            // btnUsun
            // 
            this.btnUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsun.Location = new System.Drawing.Point(489, 529);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(447, 50);
            this.btnUsun.TabIndex = 12;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(16, 529);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(447, 50);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.Text = "Dodaj ";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnuluj.Location = new System.Drawing.Point(489, 613);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(216, 50);
            this.btnAnuluj.TabIndex = 21;
            this.btnAnuluj.Text = "ANULUJ";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // nbQuantity
            // 
            this.nbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nbQuantity.Location = new System.Drawing.Point(73, 486);
            this.nbQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nbQuantity.Name = "nbQuantity";
            this.nbQuantity.Size = new System.Drawing.Size(379, 26);
            this.nbQuantity.TabIndex = 22;
            this.nbQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nbQuantityEdit
            // 
            this.nbQuantityEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nbQuantityEdit.Location = new System.Drawing.Point(548, 486);
            this.nbQuantityEdit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nbQuantityEdit.Name = "nbQuantityEdit";
            this.nbQuantityEdit.Size = new System.Drawing.Size(379, 26);
            this.nbQuantityEdit.TabIndex = 25;
            this.nbQuantityEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQuantity.Location = new System.Drawing.Point(496, 490);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 20);
            this.lblQuantity.TabIndex = 24;
            this.lblQuantity.Text = "Ilość:";
            // 
            // ShopOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 675);
            this.Controls.Add(this.nbQuantityEdit);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.nbQuantity);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridOrder);
            this.Controls.Add(this.lblIlosc);
            this.Controls.Add(this.gridProduct);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnUtworzZamowienie);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbQuantityEdit)).EndInit();
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
        private System.Windows.Forms.Button btnUtworzZamowienie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridOrder;
        private System.Windows.Forms.Label lblIlosc;
        private System.Windows.Forms.DataGridView gridProduct;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.NumericUpDown nbQuantity;
        private System.Windows.Forms.NumericUpDown nbQuantityEdit;
        private System.Windows.Forms.Label lblQuantity;
    }
}