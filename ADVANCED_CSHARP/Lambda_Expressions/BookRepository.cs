using System.Collections.Generic;
using System;

namespace Lambda_Expressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            { // this is a flooed example error title and Price
                new Book() {Title = "Title 1", Price = 5},
                new Book() {Title = "Title 2", Price = 7},
                new Book() {Title = "Title 3", Price = 17}
            };
        }
    }
}
