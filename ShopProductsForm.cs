using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenagerShop
{
    public partial class ShopProductsForm : Form
    {
        public ShopProductsForm()
        {
            InitializeComponent();
            this.Text = "Menager Shop - Dodaj Produkt";
            ID = 0;
            gridOrder = false;

        }


        public ShopProductsForm(int tmpID, bool Duplicate)
            : this()
        {
            ID = tmpID;

            this.Text = "Menager Shop - Edytuj Produkt";
            // Numer ID zaznaczony przez uzytkownika do edycji
            //Pobierz tabele z danymi z SQL
            DataTable dtable = Connection.ReturnDataTable("SELECT [ProductName],[Amount],[NetPrice] FROM [Moj_Sklep].[dbo].[OrderItem] WHERE [IDOrderItem] = " + ID + "");
            //Uzupelnia wiersze w formularzu pobranymi danymi
            txtProductsName.Text = dtable.Rows[0]["ProductName"].ToString();
            txtAmount.Text = dtable.Rows[0]["Amount"].ToString();
            txtNetPrice.Text = dtable.Rows[0]["NetPrice"].ToString();

            if (Duplicate == false)
            {
                ID = 0;
            }

        }


        #region Metody
        void AddNewProducts()
        {
            Connection.Execute("INSERT INTO [Moj_Sklep].[dbo].[OrderItem] (ProductName,Amount,NetPrice) VALUES ('" + Protected.Apostrophe(txtProductsName.Text) + "','" + Protected.Dot(Protected.Apostrophe(txtAmount.Text)) + "', " + Protected.Dot(Protected.Apostrophe(txtNetPrice.Text)) + ")");
        }



        void EditProducts(int i)
        {

            Connection.Execute("UPDATE [Moj_Sklep].[dbo].[OrderItem] SET [ProductName]= '"
          + Protected.Apostrophe(txtProductsName.Text) + "',[Amount]='"
          + Protected.Dot(Protected.Apostrophe(txtAmount.Text)) + "',[NetPrice]="
          + Protected.Dot(Protected.Apostrophe(txtNetPrice.Text)) + " WHERE IDOrderItem = "

          + ID + " ");

        }

        bool FindAmountProduct()
        {
            //Sprawdz czy nazwa produktu istnieje w bazie, jezeli null - brak produktow o takej nazwie, zezwol na dodanie
            var QuantityOfOrder = Connection.ExecuteScalar(" SELECT ProductName FROM [Moj_Sklep].[dbo].[OrderItem] WHERE ProductName = '"
           + Protected.Apostrophe(txtProductsName.Text) + "'  ");

            if (QuantityOfOrder == null)
            {
                return true;
            }
            else
            {
                Messages.ShowWarningMessage("Nazwa produktu jest w użytku, wybierz inną");
                return false;
            }
        }

        #endregion






        private void btnZapisz_Click(object sender, EventArgs e)
        {
            try
            {   //Jezeli ID>0, To Edytuj
                if (ID > 0)
                {
                    //PROBLEM Z MOZLIWOŚCIĄ UŻYCIA FUNKCJI FindAmountProduct() - BRAK MOZLIOSCI EDYCJI -
                    //MOZLIWE DO UTWORZENIA DWIE TAKIE SAME NAZWY
                        EditProducts(ID);
                        this.Close();
                }
                else
                {
                    if (FindAmountProduct())
                    {
                        AddNewProducts();
                        this.Close();
                    }
                }
            }

            catch (Exception ex)
            {
                Messages.ShowErrorMessage(ex.Message);
            }


        }

        public int ID { get; set; }
        public bool gridOrder { get; set; }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            if ((Messages.ShowQuestionMessage("Czy zakończyć?")) == "Yes")
            {
                this.Close();
            }
        }

    }


}

