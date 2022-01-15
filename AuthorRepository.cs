using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repositories
{
    public class AuthorRepository : IbookStoreRepositorie <Author>
    {
        IList <Author> authors;

        public AuthorRepository()
        {
            authors = new List<Author>()
            {
                new Author
                {
                    Id = 1,
                    FullName = "Mark Selby"
                },

                new Author
                {
                    Id = 2,
                    FullName = "Neil Robertson"
                },

                new Author
                {
                    Id = 3,
                    FullName = "The Man"
                }
            };
        }

        public void Add(Author entity)
        {
            authors.Add(entity);
        }

        public void Delete(int Id)
        {
            var author = Find(Id);

            authors.Remove(author);
        }

        public Author Find(int Id)
        {
            var author = Find(Id);

            return author;
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void Update(int Id, Author newAuthor)
        {
            var author = authors.SingleOrDefault(a => a.Id == Id);

            author.Id = newAuthor.Id;
            author.FullName = newAuthor.FullName;
        }
    }
}
