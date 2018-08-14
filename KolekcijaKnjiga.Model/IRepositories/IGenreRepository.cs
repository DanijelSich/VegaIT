using System;
using System.Collections.Generic;
using KolekcijaKnjiga.Model.Entities;
using System.Text;
using System.Threading.Tasks;

namespace KolekcijaKnjiga.Model.IRepositories
{
    public interface IGenreRepository
    {
        List<Genre> GetAll();
        Genre GetById(int id);
        void Create(Genre entity);
        void Update(Genre entity);
        void Delete(int id);
    }
}