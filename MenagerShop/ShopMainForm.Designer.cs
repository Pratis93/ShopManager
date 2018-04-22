namespace MenagerShop
{
    partial class ShopMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopMainForm));
            this.gridMain = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuStripAkcje = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripAkcjeDodaj = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripAkcjeUsun = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripAkcjeEdytuj = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripTabele = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripTabeleKontrahenci = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripTabeleZamowienia = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnKontrahenci = new System.Windows.Forms.ToolStripButton();
            this.btnZamowienia = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDodaj = new System.Windows.Forms.ToolStripButton();
            this.btnEdytuj = new System.Windows.Forms.ToolStripButton();
            this.btnUsun = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOdswiez = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridMain
            // 
            this.gridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(3, 53);
            this.gridMain.Name = "gridMain";
            this.gridMain.Size = new System.Drawing.Size(821, 386);
            this.gridMain.TabIndex = 0;
            this.gridMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridMain_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripAkcje,
            this.MenuStripTabele});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuStripAkcje
            // 
            this.MenuStripAkcje.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripAkcjeDodaj,
            this.MenuStripAkcjeUsun,
            this.MenuStripAkcjeEdytuj});
            this.MenuStripAkcje.Name = "MenuStripAkcje";
            this.MenuStripAkcje.Size = new System.Drawing.Size(45, 20);
            this.MenuStripAkcje.Text = "&Akcje";
            // 
            // MenuStripAkcjeDodaj
            // 
            this.MenuStripAkcjeDodaj.Name = "MenuStripAkcjeDodaj";
            this.MenuStripAkcjeDodaj.Size = new System.Drawing.Size(105, 22);
            this.MenuStripAkcjeDodaj.Text = "&Dodaj";
            this.MenuStripAkcjeDodaj.Click += new System.EventHandler(this.MenuStripAkcjeDodaj_Click);
            // 
            // MenuStripAkcjeUsun
            // 
            this.MenuStripAkcjeUsun.Name = "MenuStripAkcjeUsun";
            this.MenuStripAkcjeUsun.Size = new System.Drawing.Size(105, 22);
            this.MenuStripAkcjeUsun.Text = "&Usuń";
            this.MenuStripAkcjeUsun.Click += new System.EventHandler(this.MenuStripAkcjeUsun_Click);
            // 
            // MenuStripAkcjeEdytuj
            // 
            this.MenuStripAkcjeEdytuj.Name = "MenuStripAkcjeEdytuj";
            this.MenuStripAkcjeEdytuj.Size = new System.Drawing.Size(105, 22);
            this.MenuStripAkcjeEdytuj.Text = "&Edytuj";
            this.MenuStripAkcjeEdytuj.Click += new System.EventHandler(this.MenuStripAkcjeEdytuj_Click);
            // 
            // MenuStripTabele
            // 
            this.MenuStripTabele.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripTabeleKontrahenci,
            this.MenuStripTabeleZamowienia});
            this.MenuStripTabele.Name = "MenuStripTabele";
            this.MenuStripTabele.Size = new System.Drawing.Size(51, 20);
            this.MenuStripTabele.Text = "&Tabele";
            // 
            // MenuStripTabeleKontrahenci
            // 
            this.MenuStripTabeleKontrahenci.Name = "MenuStripTabeleKontrahenci";
            this.MenuStripTabeleKontrahenci.Size = new System.Drawing.Size(131, 22);
            this.MenuStripTabeleKontrahenci.Text = "&Kontrahenci";
            this.MenuStripTabeleKontrahenci.Click += new System.EventHandler(this.MenuStripTabeleKontrahenci_Click);
            // 
            // MenuStripTabeleZamowienia
            // 
            this.MenuStripTabeleZamowienia.Name = "MenuStripTabeleZamowienia";
            this.MenuStripTabeleZamowienia.Size = new System.Drawing.Size(131, 22);
            this.MenuStripTabeleZamowienia.Text = "&Zamówienia";
            this.MenuStripTabeleZamowienia.Click += new System.EventHandler(this.MenuStripTabeleZamowienia_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKontrahenci,
            this.btnZamowienia,
            this.toolStripSeparator1,
            this.btnDodaj,
            this.btnEdytuj,
            this.btnUsun,
            this.toolStripSeparator2,
            this.btnOdswiez});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(839, 55);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnKontrahenci
            // 
            this.btnKontrahenci.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKontrahenci.Image = ((System.Drawing.Image)(resources.GetObject("btnKontrahenci.Image")));
            this.btnKontrahenci.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnKontrahenci.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKontrahenci.Name = "btnKontrahenci";
            this.btnKontrahenci.Size = new System.Drawing.Size(52, 52);
            this.btnKontrahenci.Text = "Kontrahenci";
            this.btnKontrahenci.Click += new System.EventHandler(this.btnKontrahenci_Click);
            // 
            // btnZamowienia
            // 
            this.btnZamowienia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZamowienia.Image = ((System.Drawing.Image)(resources.GetObject("btnZamowienia.Image")));
            this.btnZamowienia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnZamowienia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZamowienia.Name = "btnZamowienia";
            this.btnZamowienia.Size = new System.Drawing.Size(52, 52);
            this.btnZamowienia.Text = "Zamowienia";
            this.btnZamowienia.Click += new System.EventHandler(this.btnZamowienia_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // btnDodaj
            // 
            this.btnDodaj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDodaj.Image = ((System.Drawing.Image)(resources.GetObject("btnDodaj.Image")));
            this.btnDodaj.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDodaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(52, 52);
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdytuj.Image = ((System.Drawing.Image)(resources.GetObject("btnEdytuj.Image")));
            this.btnEdytuj.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEdytuj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(52, 52);
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUsun.Image = ((System.Drawing.Image)(resources.GetObject("btnUsun.Image")));
            this.btnUsun.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUsun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(52, 52);
            this.btnUsun.Text = "Usuń";
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOdswiez.Image = ((System.Drawing.Image)(resources.GetObject("btnOdswiez.Image")));
            this.btnOdswiez.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOdswiez.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(30, 52);
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gridMain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.53846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.46154F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(827, 442);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 39);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Zamówienia";
            // 
            // ShopMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 545);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ShopMainForm";
            this.Text = "Menager Shop ";
            this.Load += new System.EventHandler(this.ShopMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuStripAkcje;
        private System.Windows.Forms.ToolStripMenuItem MenuStripAkcjeDodaj;
        private System.Windows.Forms.ToolStripMenuItem MenuStripAkcjeUsun;
        private System.Windows.Forms.ToolStripMenuItem MenuStripAkcjeEdytuj;
        private System.Windows.Forms.ToolStripMenuItem MenuStripTabele;
        private System.Windows.Forms.ToolStripMenuItem MenuStripTabeleKontrahenci;
        private System.Windows.Forms.ToolStripMenuItem MenuStripTabeleZamowienia;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnKontrahenci;
        private System.Windows.Forms.ToolStripButton btnZamowienia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnDodaj;
        private System.Windows.Forms.ToolStripButton btnEdytuj;
        private System.Windows.Forms.ToolStripButton btnUsun;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnOdswiez;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
    }
}

