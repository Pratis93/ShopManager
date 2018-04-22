using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenagerShop
{
    class Messages
    {
        /// <summary>
        /// WyŚwietl błąd 
        /// </summary>
        /// <param name="message"></param>
        public static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        ///WyŚwietl Ostrzeżenie 
        /// </summary>
        /// <param name="message"></param>
        public static void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// WyŚwietl Informacje
        /// </summary>
        /// <param name="message"></param>
        public static void ShowInformationMessage(string message)
        {
            MessageBox.Show(message, "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Wyświetl Zapytanie
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string ShowQuestionMessage(string message)
        {
            //TODO: zobacz jaki typ zwraca MessegeBox.Show i użyj w swojej funkcji tego typu, poszukaj przykładów na necie

            string reply;
            reply = (MessageBox.Show(message, "Zapytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question)).ToString();

            return reply;
        }
    }
}
