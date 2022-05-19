using System;
using System.Collections.Generic;


namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> blist = new List<Book>();
            blist.Add(new Book("isbn1", "title1", new string[] { "author1", "author2" }, new DateTime(2000, 8, 25), 500.35m));
            blist.Add(new Book("isbn2", "title2", new string[] { "author3", "author4" }, new DateTime(2002, 2, 2), 240.25m));

            #region User Defined Delegate
            MyDelegate fPtr = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks_UserDefined(blist, fPtr);
            #endregion
            Console.WriteLine("-------------------------------");
            #region Built-in Delegate
            Func<Book, string> func = BookFunctions.GetPrice;
            LibraryEngine.ProcessBooks_BuiltIn(blist, func);
            #endregion
            Console.WriteLine("-------------------------------");
            #region Anonymous Method
            LibraryEngine.ProcessBooks_BuiltIn(blist, delegate (Book B)
            {
                return B.ISBN;
            });
            #endregion
            Console.WriteLine("-------------------------------");
            #region Lambda
            LibraryEngine.ProcessBooks_Date(blist, (B) => B.PublicationDate);
            #endregion
        }
    }
}
