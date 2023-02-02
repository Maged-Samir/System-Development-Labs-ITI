using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_Task01
{
    internal class LibraryEngine
    {
        public delegate string BookDlgDT(Book B);
        public static void ProcessBooks(List<Book> bList , BookDlgDT fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr?.Invoke(B));
            }
        }
        public static void ProcessBooks(List<Book> books, Func<Book, string> funCptr)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(funCptr.Invoke(book));
            }
        }
    }
}
