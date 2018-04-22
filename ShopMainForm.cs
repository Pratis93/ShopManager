using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenagerShop
{

    #region MainForm
    public partial class ShopMainForm : Form
    {
        public ShopMainForm()
        {
            InitializeComponent();
            //Ustaw wersje bazy danych na 2
            DataBaseVersion = 2;
            //Tabelka tylko do odczytu
            gridMain.ReadOnly = true;
            //Nie wyswietlaj ostatniego "pustego" wiersza
            gridMain.AllowUserToAddRows = false;

            gridMain.AutoGenerateColumns = false;

            AddOrderColumn();

            // gridMain.Columns[0].Visible = false; 
        }

    #endregion

        #region ColumnInMainGrid


        void AddOrderColumn()
        {
            gridMain.Columns.Clear();

            // Initialize and add a text box column.
            DataGridViewColumn IDColumn = new DataGridViewTextBoxColumn();
            IDColumn.DataPropertyName = Title.OrderNumber;
            IDColumn.Name = Title.OrderNumber;
            gridMain.Columns.Add(IDColumn);

            // Initialize and add a text box column.
            DataGridViewColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.DataPropertyName = Title.Data;
            dateColumn.Name = Title.Data;
            gridMain.Columns.Add(dateColumn);

            // Initialize and add a text box column.
            DataGridViewColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = Title.Name;
            nameColumn.Name = Title.Name;
            gridMain.Columns.Add(nameColumn);

        }


        void AddZoomColumn()
        {
            gridMain.Columns.Clear();

            // Initialize and add a text box column.
            DataGridViewColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = Title.nameProduct;
            nameColumn.Name = Title.nameProduct;
            gridMain.Columns.Add(nameColumn);


            // Initialize and add a text box column.
            DataGridViewColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.DataPropertyName = Title.amount;
            amountColumn.Name = Title.amount;
            gridMain.Columns.Add(amountColumn);

            // Initialize and add a text box column.
            DataGridViewColumn netPrice = new DataGridViewTextBoxColumn();
            netPrice.DataPropertyName = Title.netPrice;
            netPrice.Name = Title.netPrice;
            gridMain.Columns.Add(netPrice);




        }


        void AddContractorColumn()
        {

            gridMain.Columns.Clear();


            // Initialize and add a text box column.
            DataGridViewColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = Title.Name;
            nameColumn.Name = Title.Name;
            gridMain.Columns.Add(nameColumn);

            // Initialize and add a text box column.
            DataGridViewColumn NIPColumn = new DataGridViewTextBoxColumn();
            NIPColumn.DataPropertyName = Title.NIP;
            NIPColumn.Name = Title.NIP;
            gridMain.Columns.Add(NIPColumn);

            // Initialize and add a text box column.
            DataGridViewColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.DataPropertyName = Title.Email;
            emailColumn.Name = Title.Email;
            gridMain.Columns.Add(emailColumn);


            // Initialize and add a text box column.
            DataGridViewColumn adresColumn = new DataGridViewTextBoxColumn();
            adresColumn.DataPropertyName = Title.Adress;
            adresColumn.Name = Title.Adress;
            gridMain.Columns.Add(adresColumn);
        }


        void AddProductsColumn()
        {

            gridMain.Columns.Clear();


            // ShowOnGrid("SELECT [IDOrderItem] AS 'ID',[ProductName] as ["+Title.nazwaProduktu+"],[Amount] as 'Ilość',[NetPrice] as 'Cena Netto'FROM [Moj_Sklep].[dbo].[OrderItem]");
            //}

            // Initialize and add a text box column.
            DataGridViewColumn nameProductColumn = new DataGridViewTextBoxColumn();
            nameProductColumn.DataPropertyName = Title.nameProduct;
            nameProductColumn.Name = Title.nameProduct;
            gridMain.Columns.Add(nameProductColumn);

            // Initialize and add a text box column.
            DataGridViewColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.DataPropertyName = Title.amount;
            amountColumn.Name = Title.amount;
            gridMain.Columns.Add(amountColumn);

            // Initialize and add a text box column.
            DataGridViewColumn netColumn = new DataGridViewTextBoxColumn();
            netColumn.DataPropertyName = Title.netPrice;
            netColumn.Name = Title.netPrice;
            gridMain.Columns.Add(netColumn);


        }




        #endregion


        #region Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShopMainForm_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshGrid();
                CheckDataBaseVersion();
            }
            catch (Exception ex)
            {
                Messages.ShowErrorMessage(ex.Message);
            }
        }
        #endregion

        #region Metody

        /// <summary>
        /// Aktualizuje bade danych.
        /// </summary>
        private void CheckDataBaseVersion()
        {
            int lastVersion;
            //Pobierz aktualna wersje bazy danych
            DataTable dtable = Connection.ReturnDataTable("SELECT Max([Version]) FROM [Moj_Sklep].[dbo].[Settings]");
            lastVersion = (int)dtable.Rows[0][0];
            if (lastVersion < DataBaseVersion)
            {

                Connection.Execute("CREATE TABLE [Moj_Sklep].[dbo].[OrderItem]" +
                    "(IDOrderItem int IDENTITY(1,1) PRIMARY KEY NOT NULL," +  
                    "ProductName nvarchar(50) NOT NULL,Amount real NOT NULL,NetPrice money NOT NULL)");


                Connection.Execute("CREATE TABLE [Moj_Sklep].[dbo].[Package]"+
                    "(IDPackage int IDENTITY(1,1) PRIMARY KEY NOT NULL,"+
                    "IDOrder int references [Moj_Sklep].[dbo].[Order](IDOrder) NOT NULL,"+
                    "IDOrderItem int references [Moj_Sklep].[dbo].[OrderItem](IDOrderItem) NOT NULL," +
                    "NetPrice money NOT NULL,"+
                    "Amount real NOT NULL)");


                //Wersja bazy danych = 2
                Connection.Execute("UPDATE [Moj_Sklep].[dbo].[Settings] SET Version = 2");

            }
        }




        /// <summary>
        /// Usuń wiersz z tabeli
        /// </summary>
        private void DeleteRowFromDataBase()
        {
            if (gridMain.RowCount == 0)
            {
                return;
            }


            if ((lblTitle.Text == Title.Orders || lblTitle.Text == Title.Contractor || lblTitle.Text == Title.Products)==false)
            {
                return;
            }


            if ((Messages.ShowQuestionMessage("Czy na pewno chcesz usunąć?")) == "Yes")
            {
                try
                {
                    //Pobierz zawartość komórki ID, w wierszu zaznaczonym przez użytkownika
                    int rowIndex = gridMain.CurrentCell.RowIndex;
                    int ID = (int)dtableOrder.Rows[rowIndex]["ID"];

                    //Jezeli zakladka Zamowienia - skasuj zamowienie
                    if (lblTitle.Text == Title.Orders)
                    {
                        //Sprawdz czy zamowienie jest puste, jezeli nie odmów skasowania. 
                        DataTable dtablerows = Connection.ReturnDataTable("SELECT MAX(IDPackage) FROM [Moj_Sklep].[dbo].[Package] WHERE IDOrder = " + ID + " ");

                        if (dtablerows.Rows[0][0].ToString()== "")
                        {
                            Connection.Execute("DELETE FROM [Moj_Sklep].[dbo].[Order] WHERE IDOrder = " + ID);
                        }
                        else
                        {
                            Messages.ShowWarningMessage("Odmowa. Zamówienie nie jest puste");
                        }
                    }
                    //Jezeli zakladka Kontrahent- sprawdz czy nie ma zamowienie
                    else if (lblTitle.Text == Title.Contractor)
                    {
                        object scalarValue = Connection.ExecuteScalar(" SELECT IDOrder FROM [Order] WHERE IDContractor = '" + ID + "'");

                        if (scalarValue == null)
                        {
                            Connection.Execute("DELETE FROM [Moj_Sklep].[dbo].[Contractor] WHERE IDContractor = " + ID);
                        }
                        else
                        {
                            Messages.ShowWarningMessage(" Użytkownik którego próbujesz usunąć ma zamówienia.");
                        }
                    }
                    else if (lblTitle.Text == Title.Products)
                    {
                        object scalarValue = Connection.ExecuteScalar(" SELECT IDOrderItem FROM [Moj_Sklep].[dbo].[Package] WHERE IDOrderItem = '" + ID + "'");

                        if (scalarValue == null)
                        {
                            Connection.Execute("DELETE FROM [Moj_Sklep].[dbo].[OrderItem] WHERE IDOrderItem = " + ID);
                        }
                        else
                        {
                            Messages.ShowWarningMessage(" Produkt który próbujesz usunąć, został wykorzystany w zamówieniu.");
                        }
                    }

                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    Messages.ShowErrorMessage(ex.Message);
                }
            }
            else
            {
                Messages.ShowInformationMessage("Operacja Anulowana");
            }
        }
        /// <summary>
        /// Edytuje wiersz w tabeli gdy argument - True, Duplikuje wiersz z Tabeli gdy argument - False
        /// </summary> 
        public void EditRowInDataBase(bool Duplicate)
        {
            try
            {
                if (gridMain.RowCount == 0)
                {
                    return;
                }

                if ((lblTitle.Text == Title.Orders || lblTitle.Text == Title.Contractor || lblTitle.Text == Title.Products) == false)
                {
                    return;
                }

                int row = gridMain.CurrentCell.RowIndex;
                int ID = (int)dtableOrder.Rows[row]["ID"];

                if (lblTitle.Text == Title.Orders)
                {
                    using (ShopOrderForm ShopOrderForm = new ShopOrderForm(ID, Duplicate))
                    {
                        //wyswielt nowa forme
                        ShopOrderForm.ShowDialog();
                    }
                }
                else if (lblTitle.Text == Title.Contractor)
                {
                    using (ShopContractorForm ShopContractorForm = new ShopContractorForm(ID, Duplicate))
                    {
                        //wyswielt nowa forme
                        ShopContractorForm.ShowDialog();
                    }
                }
                else if (lblTitle.Text == Title.Products)
                {
                    using (ShopProductsForm ShopProductsForm = new ShopProductsForm(ID, Duplicate))
                    {
                        //wyswielt nowa forme
                        ShopProductsForm.ShowDialog();
                    }

                }
                RefreshGrid();
            }
            catch (Exception ex)
            {
                Messages.ShowErrorMessage(ex.Message);
            }
        }

        /// <summary>
        /// Sprawdz czy istnieje produkt oraz kontrahent
        /// </summary>
        /// <returns></returns>
        bool CheckValueOrder()
        {
            bool Check = false;

            object scalarValue = Connection.ExecuteScalar("SELECT [IDContractor] FROM [Moj_Sklep].[dbo].[Contractor] ");

            if (scalarValue != null)
            {
                Check = true;
            }
            else
            {
                Messages.ShowInformationMessage("Dodaj Kontrahenta - baza jest pusta");
                Check = false;
            }

            if (Check)
            {
                scalarValue = Connection.ExecuteScalar("SELECT [IDOrderItem] FROM [Moj_Sklep].[dbo].[OrderItem]");
                if (scalarValue != null)
                {
                    Check = true;
                }
                else
                {
                    Messages.ShowInformationMessage("Dodaj Produkt - baza jest pusta");
                    Check = false;
                }
            }

            return Check;
        }

        /// <summary>
        /// Dodaj nowy wiersz do Tabeli
        /// </summary>
        private void AddNewRowToDataBase()
        {
            try
            {
                if (lblTitle.Text == Title.Orders)
                {
                    //Jeżeli istnieje
                    if (CheckValueOrder())
                    {
                        using (ShopOrderForm ShopOrderForm = new ShopOrderForm())
                        {
                            ShopOrderForm.ShowDialog();
                        }
                    }

                }
                else if (lblTitle.Text == Title.Contractor)
                {
                    using (ShopContractorForm ShopContractorForm = new ShopContractorForm())
                    {
                        ShopContractorForm.ShowDialog();
                    }
                }
                else if (lblTitle.Text == Title.Products)
                {
                    using (ShopProductsForm ShopProductsForm = new ShopProductsForm())
                    {
                        ShopProductsForm.ShowDialog();
                    }
                }

                RefreshGrid();
            }
            catch (Exception ex)
            {
                Messages.ShowErrorMessage(ex.Message);
            }
        }
        void ShowOnGrid(string command)
        {
            //Wyczyść źródło danych oraz Tabelę
            gridMain.DataSource = null;
            //gridMain.Columns.Clear();
            //Pobierz tabelkę z Sql Server wykorzystując komendę SELECT
            dtableOrder = Connection.ReturnDataTable(command);
            //Odebrane dane przekaż do Tabeli
            gridMain.DataSource = dtableOrder.DefaultView;
        }

        /// <summary>
        /// Odśwież Tabelę
        /// </summary>
        void RefreshGrid()
        {
            if (lblTitle.Text == Title.Orders)
            {
                AddOrderColumn();
                ShowOnGrid("SELECT IDOrder AS 'ID',[Date] as 'Data', OrderNumber AS 'Numer Zamówienia',Name AS 'Nazwa' FROM  [Moj_Sklep].[dbo].[Contractor], [Moj_Sklep].[dbo].[Order] WHERE Contractor.IDContractor = [Order].IDContractor");
            }
            else if (lblTitle.Text == Title.Contractor)
            {
                AddContractorColumn();
                ShowOnGrid("SELECT IDContractor AS 'ID',Name AS 'Nazwa', Address AS 'Adres', NIP , [e-mail]   FROM [Moj_Sklep].[dbo].[Contractor]");
            }
            else if (lblTitle.Text == Title.Products)
            {
                AddProductsColumn();
                ShowOnGrid("SELECT [IDOrderItem] AS 'ID',[ProductName] as ["+Title.nameProduct+"],[Amount] as 'Ilość',[NetPrice] as 'Cena Netto'FROM [Moj_Sklep].[dbo].[OrderItem]");
            }
        }

        #endregion

        #region Click
        /// <summary>
        /// Wyswietl zaklade Produkty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProducts_Click(object sender, EventArgs e)
        {
            lblTitle.Text = Title.Products;
            RefreshGrid();
        }


        /// <summary>
        /// Wyswietl zaklade kontrahenci 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKontrahenci_Click(object sender, EventArgs e)
        {
            lblTitle.Text = Title.Contractor;
            RefreshGrid();
        }
        /// <summary>
        /// Wyswietl zakladke zamowienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZamowienia_Click(object sender, EventArgs e)
        {
            lblTitle.Text = Title.Orders;
            AddOrderColumn();
            RefreshGrid();
        }
        /// <summary>
        /// Odswiez Tabele
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        /// <summary>
        /// Dodaj nowa pozycje do Tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            AddNewRowToDataBase();
        }

        /// <summary>
        /// Dodaj nowa pozycje do Tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void MenuStripAkcjeDodaj_Click(object sender, EventArgs e)
        {
            AddNewRowToDataBase();
        }

        /// <summary>
        /// Edytuj pozycje w Tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            EditRowInDataBase(true);
        }





        /// <summary>
        /// Usun pozycje z Tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUsun_Click(object sender, EventArgs e)
        {
            DeleteRowFromDataBase();
        }

        /// <summary>
        /// Usun pozycje z Tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuStripAkcjeUsun_Click(object sender, EventArgs e)
        {
            DeleteRowFromDataBase();
        }
        /// <summary>
        /// Edytuj pozycje z Tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuStripAkcjeEdytuj_Click(object sender, EventArgs e)
        {
            EditRowInDataBase(true);
        }
        /// <summary>
        /// Wyswietl zakladke Kontrahenci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuStripTabeleKontrahenci_Click(object sender, EventArgs e)
        {
            lblTitle.Text = Title.Contractor;
            RefreshGrid();
        }


        /// <summary>
        /// Wyswietl zakladke zamowienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuStripTabeleZamowienia_Click(object sender, EventArgs e)
        {
            lblTitle.Text = Title.Orders;
            RefreshGrid();
        }


        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            EditRowInDataBase(false);
        }
        #endregion

        #region KeyDown

        /// <summary>
        /// Usun wiersz po nacisnieciu przycisku Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteRowFromDataBase();
            }
        }

        #endregion

        #region DoubleClick

        private void gridMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditRowInDataBase(true);
        }

        #endregion

        #region Context

        private void contectDodaj_Click(object sender, EventArgs e)
        {
            AddNewRowToDataBase();
        }

        private void contextEdytuj_Click(object sender, EventArgs e)
        {
            EditRowInDataBase(true);
        }

        private void contextPowiel_Click(object sender, EventArgs e)
        {
            EditRowInDataBase(false);
        }

        private void contextUsun_Click(object sender, EventArgs e)
        {
            DeleteRowFromDataBase();
        }

        #endregion

        #region Global
        public int DataBaseVersion { get; set; }
        #endregion

        private void btnZoom_Click(object sender, EventArgs e)
        {
          

            if (lblTitle.Text == Title.Orders)
            {
                AddZoomColumn();

                int row = gridMain.CurrentCell.RowIndex;
                int ID = (int)dtableOrder.Rows[row][Title.ID];

                DataTable dtable = Connection.ReturnDataTable("SELECT MAX(OrderNumber)  FROM [Moj_Sklep].[dbo].[Order] WHERE IDOrder = " + ID + " ");
            
                lblTitle.Text = "Zamówienie nr: "+dtable.Rows[0][0].ToString()+"";

                ShowOnGrid("SELECT m.ProductName as ["+Title.nameProduct+"],p.Amount as ["+Title.amount+"],p.NetPrice as ["+Title.netPrice+"]  FROM [Moj_Sklep].[dbo].[Package] p  FULL JOIN [Moj_Sklep].[dbo].[Order] o ON o.IDOrder=p.IDOrder FULL JOIN [Moj_Sklep].[dbo].[OrderItem] m ON m.IDOrderItem=p.IDOrderItem WHERE o.IDOrder = "+ID+"");
            }
           // RefreshGrid();

        }

        public DataTable dtableOrder = new DataTable();
        public DataTable dtableContactor = new DataTable();
        public DataTable dtableProduct = new DataTable();

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }//Main form
}
