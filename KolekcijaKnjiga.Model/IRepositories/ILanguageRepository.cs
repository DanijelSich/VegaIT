using System;
using System.Collections.Generic;
using KolekcijaKnjiga.Model.Entities;
using System.Text;
using System.Threading.Tasks;

namespace KolekcijaKnjiga.Model.IRepositories
{
    public interface ILanguageRepository
    {
        List<Language> GetAll();
        Language GetById(int id);
        void Create(Language entity);
        void Update(Language entity);
        void Delete(int id);
    }
}