using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static string GetAuthors(Book B)
        {
            string authors = B.Authors[0];
            for (int i = 1; i < B.Authors?.Length; i++)
            {
                authors += ", " + B.Authors[i];
            }
            return authors;
        }
        public static string GetPrice(Book B)
        {
            return $"{B.Price:c}";
        }
    }
}
