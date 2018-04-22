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

            gridMain.ReadOnly = true;
            gridMain.AllowUserToAddRows = false;
        }

    #endregion

        #region Load
        private void ShopMainForm_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshGrid();
            }
            catch (Exception ex)
            {
                Messages.ShowErrorMessage(ex.Message);
            }
        }
        #endregion

        #region Metody

        /// <summary>
        /// Usuń wiersz z tabeli
        /// </summary>
        private void DeleteRowFromDataBase()
        {
            if ((Messages.ShowQuestionMessage("Czy na pewno chcesz usunąć?")) == "Yes")
            {
                try
                {
                    //Pobierz zawartość komórki ID, w wierszu zaznaczonym przez użytkownika
                    var rowIndex = gridMain.CurrentCell.RowIndex;
                    var ID = gridMain.Rows[rowIndex].Cells["ID"].Value;


                    if (lblTitle.Text == Title.Orders)
                    {
                        Connection.Execute("DELETE FROM [Moj_Sklep].[dbo].[Order] WHERE IDOrder = " + ID);
                    }
                    else if (lblTitle.Text == Title.Contractor)
                    {
                        var hasOrderFlag = false;

                        var scalarValue = Connection.ExecuteScalar(" SELECT IDOrder FROM [Order] WHERE IDContractor = '" + ID + "'");


                        if (scalarValue != null)
                        {
                            hasOrderFlag = true;
                        }

                        if (hasOrderFlag != true)
                        {
                            Connection.Execute("DELETE FROM [Moj_Sklep].[dbo].[Contractor] WHERE IDContractor = " + ID);
                        }
                        else
                        {
                            Messages.ShowWarningMessage(" Użytkownik którego próbujesz usunąć ma zamówienia.");
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
        /// Edytuj wiersz w tabeli
        /// </summary>
        public void EditRowInDataBase()
        {
            var row = gridMain.CurrentCell.RowIndex;
            int ID = (int)gridMain.Rows[row].Cells["ID"].Value;

            string sID = ID.ToString();


            if (lblTitle.Text == Title.Orders)
            {
                using (ShopOrderForm ShopOrderForm = new ShopOrderForm(ID))
                {
                    try
                    {   //wyswielt nowa forme
                        ShopOrderForm.ShowDialog();
                    }
                    catch (Exception ee)
                    {
                        Messages.ShowErrorMessage(ee.Message);
                    }
                }
            }
            else if (lblTitle.Text == Title.Contractor)
            {
                using (ShopContractorForm ShopContractorForm = new ShopContractorForm(sID))
                {
                    try
                    {   //wyswielt nowa forme
                        ShopContractorForm.ShowDialog();
                    }
                    catch (Exception ee)
                    {
                        Messages.ShowErrorMessage(ee.Message);
                    }
                }
            }
            RefreshGrid();

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
                    using (ShopOrderForm ShopOrderForm = new ShopOrderForm())
                    {
                        ShopOrderForm.ShowDialog();
                    }
                }
                else if (lblTitle.Text == Title.Contractor)
                {
                    using (ShopContractorForm ShopContractorForm = new ShopContractorForm())
                    {
                        ShopContractorForm.ShowDialog();
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
            gridMain.Columns.Clear();
            //Pobierz tabelkę z Sql Server wykorzystując komendę SELECT
            DataTable dtable = Connection.ReturnDataTable(command);
            //Odebrane dane przekaż do Tabeli
            gridMain.DataSource = dtable.DefaultView;
        }

        /// <summary>
        /// Odśwież Tabelę
        /// </summary>
        void RefreshGrid()
        {
            if (lblTitle.Text == Title.Orders)
            {
                ShowOnGrid("SELECT IDOrder AS 'ID',[Date] as 'Data', OrderNumber AS 'Numer Zamówienia',Name AS 'Nazwa' FROM  [Moj_Sklep].[dbo].[Contractor], [Moj_Sklep].[dbo].[Order] WHERE Contractor.IDContractor = [Order].IDContractor");
            }
            else if (lblTitle.Text == Title.Contractor)
            {
                ShowOnGrid("SELECT IDContractor AS 'ID',Name AS 'Nazwa', Address AS 'Adres', NIP , [e-mail]   FROM [Moj_Sklep].[dbo].[Contractor]");
            }
        }


        #endregion

        #region Click

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
            if (gridMain.RowCount == 0)
            {
                return;
            }

            EditRowInDataBase();
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
            if (gridMain.RowCount == 0)
            {
                return;
            }

            EditRowInDataBase();
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

    }//Main form
}
