using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenagerShop
{
    class Protected
    {
        /// <summary>
        /// Chroni przed iniekcja przez podstawienie drugiego apostrofu. 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string Apostrophe(string message)
        {
            return message.Replace("'", "''");
        }
    }
}
