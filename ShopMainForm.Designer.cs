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
            this.components = new System.ComponentModel.Container();
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
            this.btnProducts = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDodaj = new System.Windows.Forms.ToolStripButton();
            this.btnEdytuj = new System.Windows.Forms.ToolStripButton();
            this.btnDuplicate = new System.Windows.Forms.ToolStripButton();
            this.btnUsun = new System.Windows.Forms.ToolStripButton();
            this.btnZoom = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOdswiez = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contectDodaj = new System.Windows.Forms.ToolStripMenuItem();
            this.contextEdytuj = new System.Windows.Forms.ToolStripMenuItem();
            this.contextPowiel = new System.Windows.Forms.ToolStripMenuItem();
            this.contextUsun = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridMain
            // 
            this.gridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(4, 90);
            this.gridMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridMain.Name = "gridMain";
            this.gridMain.Size = new System.Drawing.Size(1171, 571);
            this.gridMain.TabIndex = 0;
            this.gridMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMain_CellDoubleClick);
            this.gridMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridMain_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripAkcje,
            this.MenuStripTabele});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1192, 28);
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
            this.MenuStripAkcje.Size = new System.Drawing.Size(57, 24);
            this.MenuStripAkcje.Text = "&Akcje";
            // 
            // MenuStripAkcjeDodaj
            // 
            this.MenuStripAkcjeDodaj.Name = "MenuStripAkcjeDodaj";
            this.MenuStripAkcjeDodaj.Size = new System.Drawing.Size(181, 26);
            this.MenuStripAkcjeDodaj.Text = "&Dodaj";
            this.MenuStripAkcjeDodaj.Click += new System.EventHandler(this.MenuStripAkcjeDodaj_Click);
            // 
            // MenuStripAkcjeUsun
            // 
            this.MenuStripAkcjeUsun.Name = "MenuStripAkcjeUsun";
            this.MenuStripAkcjeUsun.Size = new System.Drawing.Size(181, 26);
            this.MenuStripAkcjeUsun.Text = "&Usuń";
            this.MenuStripAkcjeUsun.Click += new System.EventHandler(this.MenuStripAkcjeUsun_Click);
            // 
            // MenuStripAkcjeEdytuj
            // 
            this.MenuStripAkcjeEdytuj.Name = "MenuStripAkcjeEdytuj";
            this.MenuStripAkcjeEdytuj.Size = new System.Drawing.Size(181, 26);
            this.MenuStripAkcjeEdytuj.Text = "&Edytuj";
            this.MenuStripAkcjeEdytuj.Click += new System.EventHandler(this.MenuStripAkcjeEdytuj_Click);
            // 
            // MenuStripTabele
            // 
            this.MenuStripTabele.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripTabeleKontrahenci,
            this.MenuStripTabeleZamowienia});
            this.MenuStripTabele.Name = "MenuStripTabele";
            this.MenuStripTabele.Size = new System.Drawing.Size(64, 24);
            this.MenuStripTabele.Text = "&Tabele";
            // 
            // MenuStripTabeleKontrahenci
            // 
            this.MenuStripTabeleKontrahenci.Name = "MenuStripTabeleKontrahenci";
            this.MenuStripTabeleKontrahenci.Size = new System.Drawing.Size(181, 26);
            this.MenuStripTabeleKontrahenci.Text = "&Kontrahenci";
            this.MenuStripTabeleKontrahenci.Click += new System.EventHandler(this.MenuStripTabeleKontrahenci_Click);
            // 
            // MenuStripTabeleZamowienia
            // 
            this.MenuStripTabeleZamowienia.Name = "MenuStripTabeleZamowienia";
            this.MenuStripTabeleZamowienia.Size = new System.Drawing.Size(181, 26);
            this.MenuStripTabeleZamowienia.Text = "&Zamówienia";
            this.MenuStripTabeleZamowienia.Click += new System.EventHandler(this.MenuStripTabeleZamowienia_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKontrahenci,
            this.btnZamowienia,
            this.btnProducts,
            this.toolStripSeparator1,
            this.btnDodaj,
            this.btnEdytuj,
            this.btnDuplicate,
            this.btnUsun,
            this.btnZoom,
            this.toolStripSeparator2,
            this.btnOdswiez,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1192, 57);
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
            this.btnKontrahenci.Size = new System.Drawing.Size(52, 54);
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
            this.btnZamowienia.Size = new System.Drawing.Size(52, 54);
            this.btnZamowienia.Text = "Zamowienia";
            this.btnZamowienia.Click += new System.EventHandler(this.btnZamowienia_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(54, 54);
            this.btnProducts.Text = "Produkty";
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // btnDodaj
            // 
            this.btnDodaj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDodaj.Image = ((System.Drawing.Image)(resources.GetObject("btnDodaj.Image")));
            this.btnDodaj.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDodaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(52, 54);
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
            this.btnEdytuj.Size = new System.Drawing.Size(52, 54);
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDuplicate.Image = ((System.Drawing.Image)(resources.GetObject("btnDuplicate.Image")));
            this.btnDuplicate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDuplicate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(52, 54);
            this.btnDuplicate.Text = "Powiel";
            this.btnDuplicate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDuplicate.Click += new System.EventHandler(this.btnDuplicate_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUsun.Image = ((System.Drawing.Image)(resources.GetObject("btnUsun.Image")));
            this.btnUsun.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUsun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(52, 54);
            this.btnUsun.Text = "Usuń";
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnZoom
            // 
            this.btnZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoom.Image = ((System.Drawing.Image)(resources.GetObject("btnZoom.Image")));
            this.btnZoom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(52, 54);
            this.btnZoom.Text = "Szczegóły Zamówienia";
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // btnOdswiez
            // 
            this.btnOdswiez.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOdswiez.Image = ((System.Drawing.Image)(resources.GetObject("btnOdswiez.Image")));
            this.btnOdswiez.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOdswiez.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdswiez.Name = "btnOdswiez";
            this.btnOdswiez.Size = new System.Drawing.Size(30, 54);
            this.btnOdswiez.Text = "Odśwież";
            this.btnOdswiez.Click += new System.EventHandler(this.btnOdswiez_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 57);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gridMain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 89);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.93233F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.06767F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1179, 665);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(4, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(259, 52);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Zamówienia";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // contextMainMenu
            // 
            this.contextMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contectDodaj,
            this.contextEdytuj,
            this.contextPowiel,
            this.contextUsun});
            this.contextMainMenu.Name = "contextMainMenu";
            this.contextMainMenu.Size = new System.Drawing.Size(126, 108);
            // 
            // contectDodaj
            // 
            this.contectDodaj.Image = global::MenagerShop.Properties.Resources.Add_File_49;
            this.contectDodaj.Name = "contectDodaj";
            this.contectDodaj.Size = new System.Drawing.Size(125, 26);
            this.contectDodaj.Text = "Dodaj";
            this.contectDodaj.Click += new System.EventHandler(this.contectDodaj_Click);
            // 
            // contextEdytuj
            // 
            this.contextEdytuj.Image = global::MenagerShop.Properties.Resources.Edit_File_48;
            this.contextEdytuj.Name = "contextEdytuj";
            this.contextEdytuj.Size = new System.Drawing.Size(125, 26);
            this.contextEdytuj.Text = "Edytuj";
            this.contextEdytuj.Click += new System.EventHandler(this.contextEdytuj_Click);
            // 
            // contextPowiel
            // 
            this.contextPowiel.Image = global::MenagerShop.Properties.Resources.Copy_48;
            this.contextPowiel.Name = "contextPowiel";
            this.contextPowiel.Size = new System.Drawing.Size(125, 26);
            this.contextPowiel.Text = "Powiel";
            this.contextPowiel.Click += new System.EventHandler(this.contextPowiel_Click);
            // 
            // contextUsun
            // 
            this.contextUsun.Image = global::MenagerShop.Properties.Resources.Delete_File_51;
            this.contextUsun.Name = "contextUsun";
            this.contextUsun.Size = new System.Drawing.Size(125, 26);
            this.contextUsun.Text = "Usuń";
            this.contextUsun.Click += new System.EventHandler(this.contextUsun_Click);
            // 
            // ShopMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 848);
            this.ContextMenuStrip = this.contextMainMenu;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
            this.contextMainMenu.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripButton btnDuplicate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contectDodaj;
        private System.Windows.Forms.ToolStripMenuItem contextEdytuj;
        private System.Windows.Forms.ToolStripMenuItem contextPowiel;
        private System.Windows.Forms.ToolStripMenuItem contextUsun;
        private System.Windows.Forms.ContextMenuStrip contextMainMenu;
        private System.Windows.Forms.ToolStripButton btnProducts;
        private System.Windows.Forms.ToolStripButton btnZoom;
    }
}

