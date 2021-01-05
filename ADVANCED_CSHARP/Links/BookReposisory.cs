using System.Collections.Generic;

namespace Links
{
    public class BookReposisory
    {
        public IEnumerable<Book> GetBook()
        {
            return new List<Book>
            {
                new Book() {Title = "ADO.Net Step by step", Price = 5 },
                new Book() {Title = "ADO.Net MVC", Price = .99f },
                new Book() {Title = "ASP.Net web API ", Price = 12 },
                new Book() {Title = "C# Advanced Topics part 2 ", Price = 7 },
                new Book() {Title = "C# Advanced Topics ", Price = 9 }
            };
        }
    }
}
