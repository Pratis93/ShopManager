using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridViewNumericUpDownElements;

namespace MenagerShop
{
    public partial class ShopOrderForm : Form
    {
        #region Form
        /// <summary>
        /// Dodaj nowe zamowienie
        /// </summary>
        public ShopOrderForm()
        {
            InitializeComponent();

            gridOrder.AutoGenerateColumns = false;
            gridProduct.AutoGenerateColumns = false;

            InitializeOrderForm();
            RefreshComboBox();
            InitializeDataGridView();
            AddNewDataTable();
            AddColumnsToGridOrder();
            AddColumnsToGridProduct();
            FillOrderNumber();
            RefreshProductGrid();
            InitializeVariable();
        }


        /// <summary>
        /// Edytuj Zamowienie
        /// </summary>
        /// <param name="tmpID"></param>
        public ShopOrderForm(int tmpID, bool Duplicate)
            : this()
        {
            //Odbierz ID zamówienia
            ID = tmpID;
            //AddNewRowToOrderEdit();
            InitializeOrderFormEdit();
            FillFiled();
            CheckDuplicate(Duplicate);
        }

        #endregion

        #region Metody

        /// <summary>
        /// Dodaje kolumne IDPacage do tabeli. 
        /// </summary>
        void AddNewRowToOrderEdit()
        {
            dtableOrder.Columns.Add(new DataColumn("IDPackage", typeof(int)));
        }


        /// <summary>
        /// Aktualizuje ilość produktów w bazie danych
        /// </summary>
        void UpgradeProducts()
        {
            //Pobierz ID pierwszego produktu
            while (stack.Count != 0)
            {
                int orderID = (int)stack.Pop();

                //Pobierz z tabelki produkty ilość produktu 
                DataTable tblFiltered = dtableProducts.AsEnumerable().Where(r => r.Field<int>("ID") == orderID).CopyToDataTable();

                float quantityWarehouse = (float)tblFiltered.Rows[0]["Ilość"];

                Connection.Execute("UPDATE [Moj_Sklep].[dbo].[OrderItem] SET Amount = " + quantityWarehouse + " WHERE IDOrderItem = " + orderID + " ");
            }
        }


        /// <summary>
        /// Usuń produkt z zamówienia
        /// </summary>
        void RemoweRowFromOrder()
        {
            //Jezeli brak produktow, wyjdz z funkcji
            if (gridOrder.ColumnCount == 0) return;

            //Pobierz numer wiersza wskazanego przez użytkownika
            int row = gridOrder.CurrentCell.RowIndex;

            ////Pobierz ID produktu wskazanego przez użytnownika
            //int orderID = (int)dtableOrder.Rows[row]["ID"];

            ////Zapisz na stosie ID produktu - potrzebne do aktualizacji ilosci produktu w magazynie.
            //stack.Push(orderID);


            if (dtableOrder.Rows[row][Title.IDPackage].ToString() != "")
            {
                int _IDPackage = (int)dtableOrder.Rows[row][Title.IDPackage];
                stackIDPackage.Push(_IDPackage);
            }



            //Pobierz ilość produktu wskazanego przez użytnownika
           // float quantityOrder = (float)dtableOrder.Rows[row]["Ilość"];

            //Pobierz z magazynu ilość zaznaczonego produktu 
          //  DataTable tblFiltered = dtableProducts.AsEnumerable()
          //             .Where(r => r.Field<int>("ID") == orderID)
          //             .CopyToDataTable();
          //  float quantityWarehouse = (float)tblFiltered.Rows[0]["Ilość"];

            //Nowa wartość ilości produktu
         //   float newQuantity = quantityWarehouse + quantityOrder;

            //Pobierz numer wiersza z Tabeli Produkty przedmiodu o określonym ID
          //  DataRow[] result = dtableProducts.Select("ID = " + orderID + " ");
           // if (result.Length > 0)
           // {
          //      //Wpisz do komórki nową wartość 
          //      int SelectedIndex = dtableProducts.Rows.IndexOf(result[0]);
          //      gridProduct.Rows[SelectedIndex].Cells["Ilość"].Value = newQuantity;
         //   }



            //Skasuj wybrany wiersz
            gridOrder.Rows.RemoveAt(row);
        }


        /// <summary>
        /// Wypełnia Tabelkę Zamówienia nowymi kolumnami
        /// </summary>
        void AddNewDataTable()
        {
            dtableOrder.Columns.Add(new DataColumn("ID", typeof(int)));
            dtableOrder.Columns.Add(new DataColumn(Title.nameProduct, typeof(string)));
            dtableOrder.Columns.Add(new DataColumn("Ilość", typeof(float)));
            dtableOrder.Columns.Add(new DataColumn("Cena Netto", typeof(float)));
            dtableOrder.Columns.Add(new DataColumn(Title.IDPackage, typeof(int)));
        }





        ///// <summary>
        ///// Sprawdz czy wpisana "Ilość" jest liczbą.
        ///// </summary>
        //bool CheckQuantity()
        //{
        //    bool check = false;
        //    string quantity = Protected.Dot(txtAmout.Text.ToString());

        //    Regex regOrder;
        //    regOrder = new Regex(@"^[0-9]*$");

        //    //sprawdz czy zamowienie ma format bez kropki
        //    check = regOrder.IsMatch(quantity);

        //    if (check == false)
        //    {
        //        regOrder = new Regex(@"^[0-9]*\.[0-9]*$");
        //        check = regOrder.IsMatch(quantity);
        //    }

        //    if (check == false)
        //    {
        //        Messages.ShowWarningMessage("Ilość musi być liczbą np. 12.4054");
        //    }

        //    return check;
        //}

        private DataRow GetProductRowById(int id)
        {
            DataTable tableProduct = (gridProduct.DataSource as DataView).Table;

            //for (int i = 0; i < tableProduct.Rows.Count; i++)
            //{
            //    if ((int)tableProduct.Rows[i]["ID"] == id)
            //    {
            //        return tableProduct.Rows[i];
            //    }
            //}

            foreach (DataRow row in tableProduct.Rows)
            {
                if ((int)row["ID"] == id) //     tableProduct.Rows[i]    =>   row
                {
                    return row;
                }
            }

            return null;

            //return (gridProduct.DataSource as DataView).Table.AsEnumerable().Where(x => (int)x["ID"] == id).FirstOrDefault();


        }

        /// <summary>
        /// Dodaj wybrany produkt do zamowienia
        /// </summary>
        void EditRowinOrder()
        {
            if (nbQuantity.Value == 0) return;
            if (gridOrder.SelectedCells.Count == 0) return;

            //pobierz ilość towaru do pobrania
            int GetQuantity = (int)nbQuantityEdit.Value;

            //Pobierz numer wiersza wskazanego przez użytkownika
            DataRow row = (gridOrder.CurrentCell.OwningRow.DataBoundItem as DataRowView).Row;

            int _ID = (int)row["ID"];

            DataRow rowProduct = GetProductRowById(_ID);
            if (rowProduct == null)
            {
                Messages.ShowInformationMessage("Nie znaleziono towaru.");
                return;
            }

            DataRow rowOrder = (gridOrder.SelectedCells[0].OwningRow.DataBoundItem as DataRowView).Row;


            //Pobierz ilość dostępnego towaru
            float Quantity = (float)rowProduct["Ilość"] + (float)rowOrder["Ilość"];

            if (Quantity >= GetQuantity)
            {
                rowOrder["Ilość"] = GetQuantity;
                rowProduct["Ilość"] = Quantity - GetQuantity;
            }
            else
            {
                Messages.ShowInformationMessage("Brak żądanej ilości towaru ");
            }

            ////Zapisz na stosie Edytowany produkt. 
            //stack.Push(_ID);

            ////pobierz ilość towaru do pobrania
            //int GetQuantity = (int)nbQuantityEdit.Value;

            ////Sprawdz czy ilość dostępnego towaru jest większa od ilości towaru do pobrania
            //if (Quantity >= GetQuantity)
            //{
            //    //Utwurz nowy wiersz w tabeli
            //    DataRow newRow = dtableOrder.NewRow();

            //    //Przepisz wartość z Tabelki produkty do Tabelki Zamówienia
            //    //ID Produktu
            //    newRow["ID"] = (int)gridOrder.Rows[row].Cells["ID"].Value;
            //    //Nazwa Produktu
            //    newRow[Title.NazwaProduktu] = gridOrder.Rows[row].Cells[Title.NazwaProduktu].Value.ToString();
            //    //Ilość
            //    newRow["Ilość"] = GetQuantity;
            //    //Cena netto
            //    string stNetto = gridOrder.Rows[row].Cells["Cena Netto"].Value.ToString();
            //    newRow["Cena Netto"] = float.Parse(stNetto);

            //    newRow[Title.IDPackage] = (int)gridOrder.Rows[row].Cells[Title.IDPackage].Value;

            //    //Dodaj nowy wiersz do tablicy. 
            //    dtableOrder.Rows.Add(newRow);

            //    //umiesc element w tablicy zamowienia
            //    gridOrder.DataSource = dtableOrder.DefaultView;

            //    //Wprowadz zmiany w tabelce produkty 
            //    float newQuantity = Quantity - GetQuantity;
            //    //zmien ilosc produktu

            //  //  int _IDProduct = (int)gridProduct.Rows[row].Cells[Title.Products].Value;

            //    //Pobierz numer wiersza z Tabeli Produkty przedmiodu o określonym ID
            //    DataRow[] result = dtableProducts.Select("ID = "+_ID +" ");
            //    if (result.Length > 0)
            //    {
            //        //Wpisz do komórki nową wartość 
            //        int SelectedIndex = dtableProducts.Rows.IndexOf(result[0]);
            //        gridProduct.Rows[SelectedIndex].Cells["Ilość"].Value = newQuantity;
            //    }


            //    //Wyczyść dane z tabeli i wstaw nowe
            //    gridProduct.DataSource = null;
            //    gridProduct.Columns.Clear();
            //    gridProduct.DataSource = dtableProducts.DefaultView;

            //    RemoweRowFromOrder();



            //}
            //else
            //{
            //    Messages.ShowInformationMessage("Brak żądanej ilości towaru ");
            //}

        }


        /// <summary>
        /// Dodaj wybrany produkt do zamowienia
        /// </summary>
        void AddNewRowToOrder()
        {
            if (nbQuantity.Value == 0) return;




            //Pobierz numer wiersza wskazanego przez użytkownika
            int row = gridProduct.CurrentCell.RowIndex;

            int ID = (int)dtableProducts.Rows[row][Title.ID];

            float Quantity = 10000;

          //  //Pobierz ilość dostępnego towaru
           // float Quantity = (float)table.Rows[row].Cells["Ilość"].Value;

            //Zapisz na stosie dodany produkt. 
            stack.Push(ID);

            //pobierz ilość towaru do pobrania
            int GetQuantity = (int)nbQuantity.Value;

            //Sprawdz czy ilość dostępnego towaru jest większa od ilości towaru do pobrania

                //Utwurz nowy wiersz w tabeli
                DataRow newRow = dtableOrder.NewRow();

                //Przepisz wartość z Tabelki produkty do Tabelki Zamówienia
                //ID Produktu
                newRow[Title.ID] = ID;
                //Nazwa Produktu
                newRow[Title.nameProduct] = dtableProducts.Rows[row][Title.nameProduct];
                //Ilość
                newRow["Ilość"] = GetQuantity;
                //Cena netto
               // string stNetto = gridProduct.Rows[row].Cells["Cena Netto"].Value.ToString();
                newRow["Cena Netto"] = dtableProducts.Rows[row][Title.netPrice];

                //Dodaj nowy wiersz do tablicy. 
                dtableOrder.Rows.Add(newRow);


                //umiesc element w tablicy zamowienia
                gridOrder.DataSource = dtableOrder;

                //Wprowadz zmiany w tabelce produkty 
                float newQuantity = Quantity - GetQuantity;

                
                //zmien ilosc produktu
               // dtableProducts.Rows[row]["Ilość"] = newQuantity;

                //Wyczyść dane z tabeli i wstaw nowe
             //   gridProduct.DataSource = null;
               gridProduct.DataSource = dtableProducts;


            


        }

        /// <summary>
        /// Wypełnij tabelkę zamówienia edytowanymi danymi.
        /// </summary>
        void FillOrderGrid()
        {
            DataTable dtabletmp = Connection.ReturnDataTable("SELECT m.IDOrderItem as [ID],p.IDPackage as [IDPackage], m.ProductName as[Nazwa Produktu] ,p.Amount as [Ilość],p.NetPrice as [Cena Netto]  FROM [Moj_Sklep].[dbo].[Package] p  FULL JOIN [Moj_Sklep].[dbo].[Order] o ON o.IDOrder=p.IDOrder FULL JOIN [Moj_Sklep].[dbo].[OrderItem] m ON m.IDOrderItem=p.IDOrderItem WHERE o.IDOrder = " + ID + "");

            if (dtabletmp.Rows[0][0].ToString() == "") return;

            int rows = dtabletmp.Rows.Count;
            rows--;

            for (; rows >= 0; rows--)
            {
                //Utwurz nowy wiersz w tabeli
                DataRow newRow = dtableOrder.NewRow();

                //Przepisz wartość z Tabelki produkty do Tabelki Zamówienia
                //ID Produktu
                newRow["ID"] = dtabletmp.Rows[rows][Title.ID];
                //Nazwa Produktu
                newRow[Title.nameProduct] = dtabletmp.Rows[rows][Title.nameProduct];
                //Ilość
                newRow["Ilość"] = dtabletmp.Rows[rows][Title.amount];
                //Cena netto

                newRow["Cena Netto"] = dtabletmp.Rows[rows][Title.netPrice];

                newRow["IDPackage"] = dtabletmp.Rows[rows]["IDPackage"];

                //Dodaj nowy wiersz do tablicy. 
                dtableOrder.Rows.Add(newRow);

            }


            //umiesc element w tablicy zamowienia
            gridOrder.DataSource = dtableOrder;

          //  AddColumnsToGridOrder();


            // ShowOnOrderGrid("SELECT m.IDOrderItem as ["+ Title.ID + "], m.ProductName as["+ Title.NazwaProduktu + "] ,p.Amount as [" + Title.ilosc + "],p.NetPrice as [" + Title.CenaNetto + "]  FROM [Moj_Sklep].[dbo].[Package] p  FULL JOIN [Moj_Sklep].[dbo].[Order] o ON o.IDOrder=p.IDOrder FULL JOIN [Moj_Sklep].[dbo].[OrderItem] m ON m.IDOrderItem=p.IDOrderItem WHERE o.IDOrder = " + ID + "");
        }

        private void AddColumnsToGridOrder()
        {
            gridOrder.Columns.Clear();

            // Initialize and add a text box column.
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = Title.nameProduct;
            column.Name = Title.nameProduct;
            gridOrder.Columns.Add(column);

            try
            {
                DataGridViewNumericUpDownColumn updownColumn = new DataGridViewNumericUpDownColumn();
                updownColumn.DataPropertyName = Title.amount;
                updownColumn.Name = Title.amount;
                gridOrder.Columns.Add(updownColumn);
            }
            catch (Exception ex)
            {
                Messages.ShowErrorMessage(ex.Message);
            }


            //DataGridViewTextBoxColumn IDPackagecolumn = new DataGridViewTextBoxColumn();
            //IDPackagecolumn.DataPropertyName = Title.IDPackage;
            //IDPackagecolumn.Name = Title.IDPackage;
            //IDPackagecolumn.ReadOnly = true;
            //gridOrder.Columns.Add(IDPackagecolumn);

        }



        private void AddColumnsToGridProduct()
        {

            gridProduct.Columns.Clear();

            // Initialize and add a text box column.
            DataGridViewColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = Title.nameProduct;
            nameColumn.Name = Title.nameProduct;
            gridProduct.Columns.Add(nameColumn);



            // Initialize and add a text box column.
            DataGridViewColumn netColumn = new DataGridViewTextBoxColumn();
            netColumn.DataPropertyName = Title.netPrice;
            netColumn.Name = Title.netPrice;
            gridProduct.Columns.Add(netColumn);


        }

        /// <summary>
        /// Wypelnia pole nr. zamowienia, kontrahenta, date, oraz tabelke zamówienia edytowanymi danymi
        /// </summary>
        void FillFiled()
        {
            //Pobiera z SQLa wiersz o ID wybranym przez uzytkownika
            DataTable dtable = Connection.ReturnDataTable("SELECT [IDOrder],[IDContractor],[OrderNumber],[Date] FROM [Moj_Sklep].[dbo].[Order] WHERE [IDOrder] = " + ID + "");
            //Umieszcza w panelu uzytkownika wczytane dane
            txtNrZamowienia.Text = dtable.Rows[0]["OrderNumber"].ToString();
            //data
            dateContractor.Value = (DateTime)dtable.Rows[0]["Date"];
            //Kontrahent 
            cboxContractor.SelectedValue = (int)dtable.Rows[0]["IDContractor"];

            FillOrderGrid();
            // ShowOnOrderGrid("SELECT m.IDOrderItem as ["+Title.ID+"], m.ProductName as["+Title.NazwaProduktu+"] ,p.Amount as ["+Title.ilosc+"],p.NetPrice as ["+Title.CenaNetto+"]  FROM [Moj_Sklep].[dbo].[Package] p  FULL JOIN [Moj_Sklep].[dbo].[Order] o ON o.IDOrder=p.IDOrder FULL JOIN [Moj_Sklep].[dbo].[OrderItem] m ON m.IDOrderItem=p.IDOrderItem WHERE o.IDOrder = " + ID + "");

        }

        /// <summary>
        /// Ustaw podstawowe parametry formatki podczas edytowania
        /// </summary>
        void InitializeOrderFormEdit()
        {
            this.Text = "Menager Shop - Edytuj Zamówienie";
        }
        /// <summary>
        /// Sprawdz czy użytkownik duplikuje pozycję czy ją edytuje. TRUE - EDYCJA
        /// </summary>
        void CheckDuplicate(bool Duplicate)
        {
            if (Duplicate == false)
            {
                ID = 0;
                //wpisz nowy numer zamowienia
                FillOrderNumber();
            }
        }

        /// <summary>
        /// Ustaw parametry Data Grid View
        /// </summary>
        void InitializeDataGridView()
        {
            //Tabelka tylko do odczytu
            // gridOrder.ReadOnly = true;
            gridProduct.ReadOnly = true;
            //Nie wyswietlaj ostatniego "pustego" wiersza
            gridOrder.AllowUserToAddRows = false;
            gridProduct.AllowUserToAddRows = false;

        }
        /// <summary>
        /// Ustaw podstaowe parametry formatki
        /// </summary>
        void InitializeOrderForm()
        {
            this.Text = "Menager Shop - Dodaj Zamówienie";
        }
        /// <summary>
        /// Inicjalizuje zmienne
        /// </summary>
        void InitializeVariable()
        {
            ID = 0;
        }

        /// <summary>
        /// Wyswietl dane na Produkt Grid
        /// </summary>
        /// <param name="command"></param>
        void ShowOnProductGrid(string command)
        {
            //Wyczyść źródło danych oraz Tabelę
            //gridProduct.DataSource = null;
           // gridProduct.Columns.Clear();
            //Pobierz tabelkę z Sql Server wykorzystując komendę SELECT
            dtableProducts = Connection.ReturnDataTable(command);
            //Odebrane dane przekaż do Tabeli
            gridProduct.DataSource = dtableProducts;
        }

        /// <summary>
        /// Wyswietl dane na Order Grid
        /// </summary>
        /// <param name="command"></param>
        void ShowOnOrderGrid(string command)
        {
            //Wyczyść źródło danych oraz Tabelę
            gridOrder.DataSource = null;
           // gridOrder.Columns.Clear();
            //Pobierz tabelkę z Sql Server wykorzystując komendę SELECT
            dtableOrder = Connection.ReturnDataTable(command);
            //Odebrane dane przekaż do Tabeli
            gridOrder.DataSource = dtableOrder;
        }

        /// <summary>
        /// Wczytaj dane do tabelki Produkty
        /// </summary>
        void RefreshProductGrid()
        {
            ShowOnProductGrid("SELECT [IDOrderItem] AS [" + Title.ID + "],[ProductName] AS [" + Title.nameProduct + "] ,[Amount] as [" + Title.amount + "],[NetPrice] as [" + Title.netPrice + "] FROM [Moj_Sklep].[dbo].[OrderItem]");
        }

        /// <summary>
        /// Wypelnij pole numer zamowienia
        /// </summary>
        void FillOrderNumber()
        {
            //Pobierz biezaca date
            DateTime thisDay = DateTime.Today;
            string year = thisDay.Year.ToString();


            string strNumber;
            int value;
            string OrderNumber;
            //Pobierz najwiekszy numer ID zamowienia
            DataTable dtable = Connection.ReturnDataTable("SELECT MAX(IDOrder) FROM [Moj_Sklep].[dbo].[Order]");
            string maxID = dtable.Rows[0][0].ToString();


            if (maxID == "")
            {
                OrderNumber = "1";
            }
            else
            {
                //Pobierz ostatnio dodany numer zamowienia
                dtable = Connection.ReturnDataTable("SELECT MAX(OrderNumber) FROM [Moj_Sklep].[dbo].[Order] Where IDOrder = " + maxID + " ");

                strNumber = dtable.Rows[0][0].ToString();
                //znajdz pozycje \
                int pos = strNumber.IndexOf("\\");
                //Usun piec ostatnich znakow zaczynaja od \
                strNumber = strNumber.Remove(pos, 5);
                //zamien string na int 
                value = Convert.StingToInt(strNumber);
                //Inkrementuj int
                value++;
                //zamien int na string
                OrderNumber = value.ToString();
            }

            //polacz numer zamowienia z rokiem
            string Order = OrderNumber + "\\" + year;

            //Wyswietl numer zamowienia oraz rok na textboxie. 
            txtNrZamowienia.Text = Order;
        }

        void ShowOnComboBoxContractor(string command)
        {
            //Wyczysc zrodlo danych oraz itemy w combobox
            cboxContractor.DataSource = null;
            cboxContractor.Items.Clear();
            //Pobierz dane z tabelki
            DataTable dtable = Connection.ReturnDataTable(command);
            //Okresl zrodlo danych w combobox
            cboxContractor.DataSource = dtable.DefaultView;
            //Wyswietl Nazwe w ComboBox
            cboxContractor.DisplayMember = "Name";
            //Ukryj pod nazwa wartosc IDContractor
            cboxContractor.ValueMember = "IDContractor";
        }

        /// <summary>
        /// Wczytaj dane o Kontrahentach do ComboBox
        /// </summary>
        void RefreshComboBox()
        {
            //Wyslij do server SQL komende SELECT oraz wynik - Imie,ID, wyswietl na ComboBoxie
            ShowOnComboBoxContractor("SELECT Name,IDContractor FROM [Moj_Sklep].[dbo].[Contractor]");
        }

        /// <summary>
        ///   Sprawdz czy numer zamowienia ma poprawny format. 
        /// </summary>
        /// <param name="OrderNumber"></param>
        /// <returns></returns>
        bool CheckOrderNumber()
        {

            if (txtNrZamowienia.Text != "")
            {
                bool check;
                Regex regOrder;
                regOrder = new Regex(@"^[0-9]*\\\d\d\d\d$");
                //sprawdz czy zamowienie ma foramt NumerZamowienia\Rok
                check = regOrder.IsMatch(txtNrZamowienia.Text.ToString());

                if (check)
                {
                    //poprawny format
                    return true;
                }
                else
                {   //niepoprawny format zamowienia
                    Messages.ShowInformationMessage("Niepoprawny format numeru zamówienia. Wprowadź: NumerZamowienia\\Rok np. 1234\\2017 ");
                    return false;
                }
            }
            else
            {
                Messages.ShowInformationMessage("Wpisz numer zamówienia.");
                return false;
            }
        }


        /// <summary>
        /// Dodaj Nowe zamowienie
        /// </summary>
        void AddNewOrder()
        {
            Connection.Execute("INSERT INTO [Order] (Date,OrderNumber,IDContractor) VALUES ('"
            + dateContractor.Value + "','"
            + Protected.Apostrophe(txtNrZamowienia.Text) + "', "
            + cboxContractor.SelectedValue + ")");

        }

        /// <summary>
        /// Zaktualizuj dane zmienione przez uzytkownika, podaj ID uzytkownika
        /// </summary>
        /// <param name="ID"></param>
        void EditOrder(int ID)
        {
            Connection.Execute("UPDATE [Order] SET [Date]= '"
          + dateContractor.Value + "',[OrderNumber]='"
          + Protected.Apostrophe(txtNrZamowienia.Text) + "',[IDContractor]="
          + cboxContractor.SelectedValue + " WHERE IDOrder = "
          + ID + " ");
        }

        /// <summary>
        /// Sprawdz czy zamowienie istneje w bazie, jezeli brak - TRUE
        /// </summary>
        /// <returns></returns>
        bool FindAmountOrder()
        {
            //Sprawdz czy zamowienie istnieje w bazie, jezeli null - brak zamowien o takim numerze, zezwol na dodanie
            var QuantityOfOrder = Connection.ExecuteScalar(" SELECT OrderNumber FROM [Moj_Sklep].[dbo].[Order] WHERE OrderNumber = '"
           + Protected.Apostrophe(txtNrZamowienia.Text) + "'  ");

            if (QuantityOfOrder == null)
            {
                return true;
            }
            else
            {
                Messages.ShowWarningMessage("Numer zamowienia jest w uzytku, wybierz inny.");
                return false;
            }
        }

        /// <summary>
        /// Wprowadź do bazy danych nowe dane pochodzącę z Tabe
        /// </summary>
        void FillDataBase(int ID)
        {
            string _IDPackage = dtableOrder.Rows[0][Title.IDPackage].ToString();

            //Jezeli brak IDPackage - Insert Jezeli IDPackage =! 0 - Update
            if (_IDPackage == "")
            {
                int _IDOrderItem = (int)dtableOrder.Rows[0][Title.ID];
                string _netPrice = dtableOrder.Rows[0][Title.netPrice].ToString();
                _netPrice = Protected.Dot(_netPrice);
                string _amount = dtableOrder.Rows[0][Title.amount].ToString();
                _amount = Protected.Dot(_amount);

                //Stworz nowe zamowienie
                Connection.Execute("INSERT INTO  [Moj_Sklep].[dbo].[Package] (IDOrder, IDOrderItem, NetPrice,Amount)  VALUES (" + ID + "," + _IDOrderItem + "," + _netPrice + "," + _amount + ");");
                //Usun przepisany wiersz
                gridOrder.Rows.RemoveAt(0);

            }
            else
            {
                int _intIDPackage = (int)dtableOrder.Rows[0][Title.IDPackage];
                //Edytuj 
                int _IDOrderItem = (int)dtableOrder.Rows[0][Title.ID];

                string _netPrice = dtableOrder.Rows[0][Title.netPrice].ToString();
                _netPrice = Protected.Dot(_netPrice);
                string _amount = dtableOrder.Rows[0][Title.amount].ToString();
                _amount = Protected.Dot(_amount);

                Connection.Execute("UPDATE [Moj_Sklep].[dbo].[Package] SET Amount=" + _amount + " WHERE IDPackage =" + _intIDPackage + "    ");
                gridOrder.Rows.RemoveAt(0);
            }






        }


        /// <summary>
        /// Przenieś dane z tabeli zamówienia do bazy danych
        /// </summary>
        void FillOrder()
        {
            if (gridOrder.RowCount != 0)
            {
                while (gridOrder.RowCount != 0)
                {
                    //Pobierz ostatnio dodany numer zamówienia. 
                    DataTable dtable = Connection.ReturnDataTable("SELECT MAX(IDOrder) FROM [Moj_Sklep].[dbo].[Order]");
                    int ID = (int)dtable.Rows[0][0];

                    FillDataBase(ID);
                }
            }
        }

        /// <summary>
        /// Przenieś dane z tabeli zamówienia do bazy danych
        /// </summary>
        void EditFillOrder(int ID)
        {
            if (gridOrder.RowCount != 0)
            {
                while (gridOrder.RowCount != 0)
                {
                    FillDataBase(ID);
                }
            }

        }

        #endregion

        #region Click


        /// <summary>
        /// Dodaj nowa pozycje do zamówienia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewRowToOrder();
            }
            catch (Exception ex)
            {
                Messages.ShowErrorMessage(ex.Message);
            }
        }

        /// <summary>
        ///  sprawdz czy pole zamowienia jest puste- jezeli tak, nie "dodawaj" nowych zamowien.
        /// </summary>
        /// <returns></returns>

        bool CheckNullOrder()
        {
            if (gridOrder.Rows.Count == 0)
            {
                return false;
            }
            return true;

        }

        void DeleteRowbyIDPackage()
        {
            while (stackIDPackage.Count > 0)
            {
                int _IDPackage = (int)stackIDPackage.Pop();
                Connection.Execute("DELETE FROM [Moj_Sklep].[dbo].[Package] WHERE IDPackage =" + _IDPackage + " ");
            }

        }

        /// <summary>
        /// Zapisz w bazie danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btmZapisz_Click(object sender, EventArgs e)
        {
            try
            {   //Jezeli ID>0, To Edytuj
                if (ID > 0)
                {
                    if (CheckOrderNumber())
                    {
                        DeleteRowbyIDPackage();

                        EditOrder(ID);
                        //skasuj stare zamowienie i stworz nowe na podstawie Tablic. 
                        //   Connection.Execute("DELETE FROM [Moj_Sklep].[dbo].[Package] WHERE IDOrder = " + ID + "   ");

                        if (CheckNullOrder())
                        {
                            EditFillOrder(ID);
                        }
                        // UpgradeProducts();

                        this.Close();
                    }
                }
                else
                {
                    if (CheckOrderNumber())
                    {
                        if (FindAmountOrder())
                        {
                            AddNewOrder();
                            FillOrder();
                            UpgradeProducts();

                            this.Close();
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Messages.ShowErrorMessage(ex.Message);
            }
        }


        /// <summary>
        /// Przycisk usuń produkt z zamówienia. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUsun_Click(object sender, EventArgs e)
        {
            try
            {
                RemoweRowFromOrder();
            }
            catch (Exception ex)
            {
                Messages.ShowErrorMessage(ex.Message);
            }
        }


        /// <summary>
        /// Anuluj zamowienie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            if ((Messages.ShowQuestionMessage("Czy na pewno chcesz anulować zamówienie?")) == "Yes")
            {

                gridOrder.Columns.Clear();
                gridProduct.Columns.Clear();
                this.Close();
            }
        }

        #endregion

        #region Zmienne
        //Sluzy do sprawdzenia czy uzytkownik edytuje czy dodaje zamowienie oraz 
        //do przekazania numeru ID
        public int ID { get; set; }

        public DataTable dtableOrder = new DataTable();
        public DataTable dtableProducts = new DataTable();
        public Stack stack = new Stack();
        public Stack stackIDPackage = new Stack();



        #endregion


        private void btnEdytuj_Click_1(object sender, EventArgs e)
        {

            EditRowinOrder();






        }


        private void gridProduct_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                AddNewRowToOrder();
            }
            catch (Exception ex)
            {
                Messages.ShowErrorMessage(ex.Message);
            }
        }



    }
}
