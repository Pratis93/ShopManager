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
    public partial class ShopAddProductToOrder : Form
    {
        public ShopAddProductToOrder() 
        {
            InitializeComponent();

            //Tabelka tylko do odczytu
            gridOrder.ReadOnly = true;
            //Nie wyswietlaj ostatniego "pustego" wiersza
            gridOrder.AllowUserToAddRows = false;

            //Tabelka tylko do odczytu
            gridProduct.ReadOnly = true;
            //Nie wyswietlaj ostatniego "pustego" wiersza
            gridProduct.AllowUserToAddRows = false;

        }


        public ShopAddProductToOrder(int _orderNumber):this()
        {
            orderNumber = _orderNumber;

            //Pobierz numer zamowienia
            DataTable dtable = Connection.ReturnDataTable("SELECT OrderNumber FROM [Moj_Sklep].[dbo].[Order] WHERE IDOrder = " + orderNumber + " ");
            string IDOrder = dtable.Rows[0][0].ToString();

            lblOrderNumber.Text = IDOrder.ToString();

            RefreshGrid();
        }


        void ShowOnProductGrid(string command)
        {
            //Wyczyść źródło danych oraz Tabelę
            gridProduct.DataSource = null;
            gridProduct.Columns.Clear();
            //Pobierz tabelkę z Sql Server wykorzystując komendę SELECT
            DataTable dtable = Connection.ReturnDataTable(command);
            //Odebrane dane przekaż do Tabeli
            gridProduct.DataSource = dtable.DefaultView;
        }

        void ShowOnOrderGrid(string command)
        {
            //Wyczyść źródło danych oraz Tabelę
            gridOrder.DataSource = null;
            gridOrder.Columns.Clear();
            //Pobierz tabelkę z Sql Server wykorzystując komendę SELECT
            DataTable dtable = Connection.ReturnDataTable(command);
            //Odebrane dane przekaż do Tabeli
            gridOrder.DataSource = dtable.DefaultView;
        }





        void RefreshGrid()
        {
           ShowOnProductGrid("SELECT [IDOrderItem] AS 'ID',[ProductName] as 'Nazwa Produktu',[Amount] as 'Ilość',[NetPrice] as 'Cena Netto'FROM [Moj_Sklep].[dbo].[OrderItem]");
           ShowOnOrderGrid("SELECT m.ProductName,p.Amount,p.NetPrice  FROM [Moj_Sklep].[dbo].[Package] p  FULL JOIN [Moj_Sklep].[dbo].[Order] o ON o.IDOrder=p.IDOrder FULL JOIN [Moj_Sklep].[dbo].[OrderItem] m ON m.IDOrderItem=p.IDOrderItem WHERE o.IDOrder = " + orderNumber + " ");
        }


        private void ShopAddProductToOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            //Pobierz wartosc ID wskazana przez uzytkownika
            int row = gridProduct.CurrentCell.RowIndex;
            int ID = (int)gridProduct.Rows[row].Cells["ID"].Value;


            DataTable dtable = Connection.ReturnDataTable("SELECT [NetPrice],[Amount] FROM [Moj_Sklep].[dbo].[OrderItem] WHERE IDOrderItem = "+ID+"   ");

            string netPrice = dtable.Rows[0]["NetPrice"].ToString();
            string amount = txtAmout.Text.ToString();

            


            Connection.Execute("INSERT INTO [Moj_Sklep].[dbo].[Package] (IDOrder,IDOrderItem,NetPrice,Amount) VALUES ('" + orderNumber + "','" + ID + "','" + netPrice + "','" + amount + "'      ) ");

            RefreshGrid();
        }




        #region Global
        public int orderNumber { get; set; }
        #endregion

    }
}
