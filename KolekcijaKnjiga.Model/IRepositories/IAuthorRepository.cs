using System;
using System.Collections.Generic;
using KolekcijaKnjiga.Model.Entities;
using System.Text;
using System.Threading.Tasks;

namespace KolekcijaKnjiga.Model.IRepositories
{
    public interface IAuthorRepository
    {
        List<Author> GetAll();
        Author GetById(int id);
        void Create(Author entity);
        void Update(Author entity);
        void Delete(int id);
    }
}