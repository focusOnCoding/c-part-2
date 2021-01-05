using System;
using System.Collections.Generic;
using System.Linq;

namespace Links
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookReposisory().GetBook();

            // Display list of books cheaper then $10 without list
            var cheapBooks = new List<Book>();
            foreach (var book in books)
            {
                if (book.Price < 10)
                    cheapBooks.Add(book);
            }

            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title + " " + book.Price);

            // Display list of books cheaper then $10 with {LINQS}

            var bookLinq = new BookReposisory().GetBook();
            
            // LINQ Extension Methods
            // i can use where() to filter collections    {{ CHANNING }} Select can be used for transformations or projections 
            var cheapBookLinks = bookLinq
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            foreach (var book in cheapBookLinks)
                Console.WriteLine(book/*book.Title + " " + book.Price*/);

            //BookLinqs.OrderBy(b => b.Title);

            // argument => expression === annuonimas function on the fly {Lambder Expression}

            // LINQ Query Operators always start with from and end with Select
            var cheaperBooks = from b in bookLinq
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;
            // or return the list of books (b)

            // return single element from list
            var singlebook = bookLinq.Single(b => b.Title == "ADO.Net MVC");
            Console.WriteLine(singlebook.Title);

            // if im not sure if element is there i can use {singleOrDefault} method
            var singlebookOrDefaut = bookLinq.SingleOrDefault(b => b.Title == "ASP.Net MVC");
            // null if not found

            var first = bookLinq.FirstOrDefault(b => b.Title == "C# Advanced");

            // paing DATA
            var pageData = bookLinq.Skip(2).Take(3); // skip 3 elements and return 3
            //when an Enumerable is returned i need to etarate through it to get its values npt just console log it
            foreach (var page in pageData)
                Console.WriteLine(page.Title);

            // Count 
            var count = bookLinq.Count();

            // Max Price
            var max = bookLinq.Max(b => b.Price);
        }
    }
}
