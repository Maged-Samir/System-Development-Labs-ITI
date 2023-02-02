using static Delegat_Task01.LibraryEngine;

namespace Delegat_Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("101", "OOP", new string[] { "MAged", "Mohamed" }, new DateTime(1996, 3, 13), 5000);
            List<Book> BookListt = new List<Book> { book1 };




            BookDlgDT fptr = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(BookListt, fptr);

            fptr = BookFunctions.GetPrice;
            LibraryEngine.ProcessBooks(BookListt, fptr);


            fptr = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(BookListt, fptr);

            
            Console.WriteLine(" funC");
            #region funC
            Func<Book, string> funCptr = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(BookListt, funCptr);
            #endregion

            #region Anonymous Method 
            funCptr = delegate (Book b) { return b.ISBN; };
            LibraryEngine.ProcessBooks(BookListt, funCptr);
            #endregion


            #region Lambda Expression 
            funCptr = b =>  b.PublicationDate.ToString();
            LibraryEngine.ProcessBooks(BookListt, funCptr);
            #endregion




        }

    } 
}