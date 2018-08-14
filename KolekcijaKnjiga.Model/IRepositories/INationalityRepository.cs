using System;
using System.Collections.Generic;
using KolekcijaKnjiga.Model.Entities;
using System.Text;
using System.Threading.Tasks;

namespace KolekcijaKnjiga.Model.IRepositories
{
    public interface INationalityRepository
    {
        List<Nationality> GetAll();
        Nationality GetById(int id);
        void Create(Nationality entity);
        void Update(Nationality entity);
        void Delete(int id);
    }
}
