using System;
using System.Collections.Generic;

namespace Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // args => expression // => lambda oparetor
            // () => ....
            // x => .....
            // (x, y, z) => ....
            //number => number * number;
            // this must be asgined to a delegate {Func<> or Action<>}

            Func<int, int> squareEG = Square;
            // lambda
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(2));

            const int factor = 5;
            Func<int, int> multiplor = n => n * factor;
            var result = multiplor(10);

            Console.WriteLine(result);

            // getting list of books not using a lambda expss
            var books = new BookRepository().GetBooks();
            // find method thakes a pradicate
            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

            // the above using a lambda expertion
            var cheapBookLE = books.FindAll(book => book.Price < 10);
        }

        // i can do this with less code using lambda experssions
        static int Square(int number)
        {
            return number * number;
        }

        // pradica function (funtion that returns true if condition is sattified)
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
