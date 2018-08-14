using System;
using System.Collections.Generic;
using KolekcijaKnjiga.Model.Entities;
using System.Text;
using System.Threading.Tasks;

namespace KolekcijaKnjiga.Model.IRepositories
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book GetById(int id);
        void Create(Book entity);
        void Update(Book entity);
        void Delete(int id);
        List<string> GetAllISBNs();
    }
}