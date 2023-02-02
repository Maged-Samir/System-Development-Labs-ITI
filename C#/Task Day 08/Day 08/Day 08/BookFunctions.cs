using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_Task01
{
    internal class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static string GetAuthors(Book B)
        {
            //List<string> Autlist = new List<string>();
            //for(int i = 0; i< B.Authors.Length; i++)
            //{
            //    Autlist.Add(B.Authors[i]);
            //}
            //return Convert.ToString(Autlist);
            string authors = "";
            for (int i = 0; i < B.Authors.Length; i++)
            {
                authors += $"{i + 1}-{B.Authors[i]}\t";
            }
            return authors;

        }
        public static string GetPrice(Book B)
        {
            return B.Price.ToString() ;
        }

    }
}
