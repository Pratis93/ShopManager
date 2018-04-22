using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace MenagerShop
{
    public partial class ShopContractorForm : Form
    {
        #region Form
        /// <summary>
        /// Dodaj nowe zamowienie
        /// </summary>
        public ShopContractorForm()
        {
            InitializeComponent();
            this.Text = "Menager Shop - Dodaj Kontrahenta";
            ID = 0;
            
        }

        /// <summary>
        /// Edytuj zamowienie
        /// </summary>
        /// <param name="tmpID"></param>
        public ShopContractorForm(int tmpID, bool Duplicate)
            : this()
        {
            ID = tmpID;

            this.Text = "Menager Shop - Edytuj Kontrahenta";
            // Numer ID zaznaczony przez uzytkownika do edycji
            //Pobierz tabele z danymi z SQL
            DataTable dtable = Connection.ReturnDataTable("SELECT [IDContractor],[Name],[Address],[NIP],[E-Mail] FROM [Moj_Sklep].[dbo].[Contractor] WHERE [IDContractor] = " + ID + "");
            //Uzupelnia wiersze w formularzu pobranymi danymi
            txtImie.Text = dtable.Rows[0]["Name"].ToString();
            txtNIP.Text = dtable.Rows[0]["NIP"].ToString();
            txtEmail.Text = dtable.Rows[0]["E-Mail"].ToString();
            txtAdres.Text = dtable.Rows[0]["Address"].ToString();

            if (Duplicate == false)
            {
                ID = 0;
            }
        }

        /// <summary>
        /// Sprawdz czy NIP ma prawidlowy format
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool CheckNIP(string NIPNumber)
        {
            Regex regOrder;
            regOrder = new Regex(@"^\d\d\d\d\d\d\d\d\d\d$");

            if (regOrder.IsMatch(NIPNumber))
            {
                return true;
            }
            else
            {
                Messages.ShowInformationMessage("Błędny format NIPu. Poprawny format: XXXXXXXXXX");
                return false;
            }
        }



        /// <summary>
        /// Sprawdz poprawnosc wprowadzanego adresu e-mail.
        /// </summary>
        /// <param name="emailaddress"></param>
        /// <returns></returns>
        public bool MailIsValid()
        {
            try
            {
                MailAddress m = new MailAddress(txtEmail.Text.ToString());
                return true;

            }
            catch (FormatException)
            {
                Messages.ShowInformationMessage("Niepoprawna składnia adresu E-mail");

                return false;
            }
        }

        public bool CheckData()
        {
            //sprawdz czy dane sa prawidlowe. 
            bool Check = false;

            //Jezeli adres jest prawidlowy - zwroc True;
            Check = MailIsValid();
            
            //Jezeli NIP jest prawidlowy - zwroc True;
            if(Check)
            {
                Check = CheckNIP(txtNIP.Text.ToString());
            }

            return Check;
        }

        #endregion

        #region Click
        private void btnZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                //Jezeli ID>0 to znaczy ,ze uzytkownik edytuje kontrahenta. 
                if (ID > 0)
                {

                    if (CheckData())
                    {
                        Connection.Execute("UPDATE [Contractor] SET [Name]= '"
                       + Protected.Apostrophe(txtImie.Text) + "',[Address]='"
                       + Protected.Apostrophe(txtAdres.Text) + "',[NIP]='"
                       + Protected.Apostrophe(txtNIP.Text) + "',[E-Mail]='"
                       + Protected.Apostrophe(txtEmail.Text) + "' WHERE IDContractor = '" + ID + "' ");
                        this.Close();
                    }
                }
                else
                {
                    //Sprawdz czy adres email ma poprawna skladnie, jezeli tak zezwol na zapis. 
                    if (CheckData())
                    {
                        Connection.Execute("INSERT INTO Contractor (Name,Address,NIP,[E-Mail]) VALUES ('"
                       + Protected.Apostrophe(txtImie.Text) + "','"
                       + Protected.Apostrophe(txtAdres.Text) + "', '"
                       + Protected.Apostrophe(txtNIP.Text) + "', '"
                       + Protected.Apostrophe(txtEmail.Text) + "')");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Messages.ShowErrorMessage(ex.Message);
            }

        }
        #endregion

        #region Global
        public int ID { get; set; }
        #endregion
    }
}
