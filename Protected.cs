using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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

        public static string Dot(string message)
        {
            return message.Replace(",", ".");
        }

    }
}
