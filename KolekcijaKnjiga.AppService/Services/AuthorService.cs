using KolekcijaKnjiga.Model.IServices;
using KolekcijaKnjiga.Model.Entities;
using KolekcijaKnjiga.Model.IRepositories;
using System.Collections.Generic;

namespace KolekcijaKnjiga.Service.Services
{
    public class AuthorService : IAuthorService
    {
        private IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository repository)
        {
            _authorRepository = repository;
        }

        public void CreateAuthor(Author entity)
        {
            _authorRepository.Create(entity);
        }

        public void DeleteAuthor(int id)
        {
            _authorRepository.Delete(id);
        }

        public List<Author> GetAllAuthors()
        {
            return _authorRepository.GetAll();
        }

        public Author GetAuthorById(int id)
        {
            return _authorRepository.GetById(id);
        }

        public void UpdateAuthor(Author entity)
        {
            _authorRepository.Update(entity);
        }
    }
}
