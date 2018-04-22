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
    public partial class ShopOrderForm : Form
    {
        #region Form
        /// <summary>
        /// Dodaj nowe zamowienie
        /// </summary>
        public ShopOrderForm()
        {
            InitializeComponent();
            //Odswiez oraz zainicjalizuj combobox
            RefreshComboBox();
            this.Text = "Menager Shop - Dodaj Zamówienie";
        }

        /// <summary>
        /// Edytuj Zamowienie
        /// </summary>
        /// <param name="tmpID"></param>
        public ShopOrderForm(int tmpID) : this()
        {
            this.Text = "Menager Shop - Edytuj Zamówienie";
            // ID - Zaznaczony przez uzytkownika
            ID = tmpID;
            //Pobiera z SQLa wiersz o ID wybranym przez uzytkownika
            DataTable dtable = Connection.ReturnDataTable("SELECT [IDOrder],[IDContractor],[OrderNumber],[Date] FROM [Moj_Sklep].[dbo].[Order] WHERE [IDOrder] = " + ID + "");
            //Umieszcza w panelu uzytkownika wczytane dane
            txtNrZamowienia.Text = dtable.Rows[0]["OrderNumber"].ToString();
            //data
            dateContractor.Value = (DateTime)dtable.Rows[0]["Date"];
            //Kontrahent 
            cboxContractor.SelectedValue = (int)dtable.Rows[0]["IDContractor"];
        }

        #endregion

        #region Metody
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


        void RefreshComboBox()
        {
            //Wyslij do server SQL komende SELECT oraz wynik - Imie,ID, wyswietl na ComboBoxie
            ShowOnComboBoxContractor("SELECT Name,IDContractor FROM [Moj_Sklep].[dbo].[Contractor]");
        }

        #endregion

        #region Click

        private void btmZapisz_Click(object sender, EventArgs e)
        {


            if (txtNrZamowienia.Text != "")
            {
                if (ID > 0)
                {
                    try
                    {   
                        //Zaktualizuj dane zmienione przez uzytkownika w formatce w SQL Server
                        Connection.Execute("UPDATE [Order] SET [Date]= '"
                            + dateContractor.Value + "',[OrderNumber]='" 
                            + Protected.Apostrophe(txtNrZamowienia.Text) + "',[IDContractor]="
                            + cboxContractor.SelectedValue + " WHERE IDOrder = " 
                            + ID + " ");

                        //  [OrderNumber]='" + txtNrZamowienia.Text + "',[IDContractor]='" + cboxNazwa.SelectedValue + "'
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        Messages.ShowErrorMessage(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        //Flaga sluzy do sprawdzenie czy zamowienie istnieje w bazie, jezeli false - zamownienie nie istnieje. 
                        var hasOrderFlag = false;

                        //Sprawdz ile zamowien o numerze podanym przez uzytkownika istnieje w bazie, jezeli null - brak zamowien - dodaj nowe zamowienie. 
                        //Jezeli inaczej - popros o inni numer zamowienia
                        var QuantityOfOrder = Connection.ExecuteScalar(" SELECT OrderNumber FROM [Moj_Sklep].[dbo].[Order] WHERE OrderNumber = '"
                            + Protected.Apostrophe(txtNrZamowienia.Text) + "'  ");

                        if (QuantityOfOrder != null)
                        {
                            hasOrderFlag = true;
                        }

                        //Jezeli numer zamowienia nie jest w uzytku, zezwol na dodanie nowego zamowienia.
                        if (hasOrderFlag == false)
                        {
                            //Dodaj nowe zamowienie
                            Connection.Execute("INSERT INTO [Order] (Date,OrderNumber,IDContractor) VALUES ('" 
                                + dateContractor.Value + "','" 
                                + Protected.Apostrophe(txtNrZamowienia.Text) + "', " 
                                + cboxContractor.SelectedValue + ")");
                        }
                        else
                        {
                            Messages.ShowWarningMessage("Numer zamowienia jest w uzytku, wybierz inny.");
                        }
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        Messages.ShowErrorMessage(ex.Message);
                    }
                }
            }
            else
            {

                Messages.ShowWarningMessage("Wpisz numer zamówienia.");
            }
        }

        #endregion

        #region Zmienne Globalne
        //Sluzy do sprawdzenia czy uzytkownik edytuje czy dodaje zamowienie oraz 
        //do przekazania numeru ID
         public int ID { get; set; }
        #endregion
    }
}
