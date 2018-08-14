using KolekcijaKnjiga.Model.Entities;
using System.Collections.Generic;

namespace KolekcijaKnjiga.Model.IServices
{
    public interface IAuthorService
    {
        List<Author> GetAllAuthors();
        Author GetAuthorById(int id);
        void CreateAuthor(Author entity);
        void UpdateAuthor(Author entity);
        void DeleteAuthor(int id);
    }
}
