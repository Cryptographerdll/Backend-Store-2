using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repositories
{
    public class BookRepository : IbookStoreRepositorie <Book>
    {
        List <Book> Books;

        public BookRepository()
        {
            Books = new List<Book>()
            {
                new Book
                {
                    Id = 1,
                    Title = "C# in Depth",
                    Description = "How to Master C# in Good way for Beginners "
                },

                new Book
                {
                    Id = 2,
                    Title = "Eloquent Javascript",
                    Description = "How to Master Js Libraries for Beginners "
                },

                new Book
                {
                    Id = 3,
                    Title = "Ruby on Rails",
                    Description = "Get started with Ruby Language "
                }
            };
        }

        public void Add(Book entity)
        {
            Books.Add(entity);
        }

        public void Delete(int Id)
        {
            var Book = Find(Id);

            Books.Remove(Book);
        }

        public Book Find(int Id)
        {
            var book = Find(Id);

            return book;
        }

        public IList<Book> List()
        {
            return Books;
        }

        public void Update(int Id, Book newBook)
        {
            var Book = Books.SingleOrDefault (b => b.Id == Id);

            Book.Title = newBook.Title;
            Book.Description = newBook.Description;
            Book.Author = newBook.Author;
        }
    }
}
