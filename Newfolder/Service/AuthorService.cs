using MIS.Context;
using MIS.Entity;

namespace MIS.Service
{
    public class AuthorService
    {
        private readonly DataContext _dataContext;

        public AuthorService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Author> GetAllAuthors()
        {
            return _dataContext.Authors.ToList();
        }

        public Author GetAuthorById(int id)
        {
            return _dataContext.Authors.FirstOrDefault(a => a.Id == id);
        }

        public void AddAuthor(Author author)
        {
            _dataContext.Authors.Add(author);
            _dataContext.SaveChanges();
        }

        public void UpdateAuthor(Author author)
        {
            _dataContext.Authors.Update(author);
            _dataContext.SaveChanges();
        }

        public void DeleteAuthor(int id)
        {
            var author = _dataContext.Authors.FirstOrDefault(a => a.Id == id);
            if (author != null)
            {
                _dataContext.Authors.Remove(author);
                _dataContext.SaveChanges();
            }
        }
        public List<Author> SearchAuthorsByName(string namePart)
        {
            return _dataContext.Authors
                .Where(a => a.Name.Contains(namePart))
                .ToList();
        }
    }
}
