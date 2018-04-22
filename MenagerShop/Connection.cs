using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenagerShop
{
    class Connection
    {
        /// <summary>
        /// Zwraca tablicę z danymi określonymi w komendzie SELECT
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static DataTable ReturnDataTable(string command)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = Settings.ConnectionString;

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = connection;
                    sqlCommand.CommandText = command;

                    using (SqlDataAdapter dadapter = new SqlDataAdapter())
                    {
                        dadapter.SelectCommand = sqlCommand;

                        using (DataSet dset = new DataSet())
                        {
                            //Wypelnij dset danymi
                            dadapter.Fill(dset);
                            connection.Close();
                            //przeslij tabele
                            return dset.Tables[0];

                        }
                    }
                }
            }
        }
        /// <summary>
        /// Wykonuje polecenie bez zwracania
        /// </summary>
        /// <param name="command"></param>
        public static void Execute(string command)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(command, connection);
                sqlCommand.ExecuteNonQuery();

                connection.Close();
            }
        }
        /// <summary>
        ///Zwraca obiekt z iloscia kolumn w tabeli
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string command)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(command, connection);

                //Jezeli numer zamowienia jest w uzytku, funkcja zwraca wartosc rozna od  NULL
                object NumberOfRow = sqlCommand.ExecuteScalar();

                connection.Close();

                return NumberOfRow;


            }
        }
    }
}
