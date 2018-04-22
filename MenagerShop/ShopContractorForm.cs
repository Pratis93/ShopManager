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
        }

        /// <summary>
        /// Edytuj zamowienie
        /// </summary>
        /// <param name="tmpID"></param>
        public ShopContractorForm(string tmpID) : this()
        {
            this.Text = "Menager Shop - Edytuj Kontrahenta";
            // Numer ID zaznaczony przez uzytkownika do edycji
            ID = tmpID;
            //Pobierz tabele z danymi z SQL
            DataTable dtable = Connection.ReturnDataTable("SELECT [IDContractor],[Name],[Address],[NIP],[E-Mail] FROM [Moj_Sklep].[dbo].[Contractor] WHERE [IDContractor] = " + ID + "");
            //Uzupelnia wiersze w formularzu pobranymi danymi
            txtImie.Text = dtable.Rows[0]["Name"].ToString();
            txtNIP.Text = dtable.Rows[0]["NIP"].ToString();
            txtEmail .Text = dtable.Rows[0]["E-Mail"].ToString();
            txtAdres.Text = dtable.Rows[0]["Address"].ToString();
        }

        #endregion

        #region Click
        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (ID != null)
            {
                try
                {
                    Connection.Execute("UPDATE [Contractor] SET [Name]= '" + txtImie.Text + "',[Address]='" + txtAdres.Text + "',[NIP]='" + txtNIP.Text + "',[E-Mail]='" + txtEmail.Text + "' WHERE IDContractor = '" + ID + "' ");
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
                    Connection.Execute("INSERT INTO Contractor (Name,Address,NIP,[E-Mail]) VALUES ('" +

                     Protected.Apostrophe(txtImie.Text) + "','" +
                     Protected.Apostrophe(txtAdres.Text) + "', '" +
                     Protected.Apostrophe(txtNIP.Text) + "', '" +
                     Protected.Apostrophe(txtEmail.Text) + "')");

                    this.Close();
                }
                catch (Exception ex)
                {
                    Messages.ShowErrorMessage(ex.Message);
                }
            }

        }
        #endregion 

        #region Global 
        public string ID { get; set; }
        #endregion
    }
}
