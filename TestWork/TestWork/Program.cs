using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork
{
    class Book
    {
        public string Name;
        public int Year;

    }
    class Program
    {
        /// <summary>
        /// TASK 1.1
        /// </summary>
      
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
                {
                    new Book {Name = "Lord of the rings", Year = 1972  },
                    new Book {Name = "Harry Potter 1", Year = 2000  },
                    new Book {Name = "LINQ TODAY", Year = 2016  },
                    new Book {Name = "Lord of LINQ", Year = 1972  }
                };
            IEnumerable<Book> rezBook = books.Where(b => b.Name.Contains("LINQ")).Where(y => y.Year % 4 == 0 && y.Year % 100 != 0 || y.Year % 400 == 0);
            foreach (var item in rezBook)
            {
                Console.WriteLine(item.Name + item.Year + " ");
            }

            /// <summary>
            /// TASK 1.2
            /// </summary>

            string[] names = { "Sasha", "Katya", "Petya"};



            /// <summary>
            /// TASK 1.3
            /// </summary>

            int[] numbers = { 14, 12, 23, 20, 33, 32 };
            var orderedNumbers = from i in numbers
                                 orderby i
                                 select i;
            foreach (int i in orderedNumbers)
                Console.WriteLine(i);
            /// <summary>
            /// TASK 1.4
            /// </summary>


            Console.ReadKey();
        }
    }
}
