using KolekcijaKnjiga.Model.Entities;
using System.Collections.Generic;

namespace KolekcijaKnjiga.Model.IServices
{
    public interface ILanguageService
    {
        List<Language> GetAllLanguages();
        Language GetLanguageById(int id);
        void CreateLanguage(Language entity);
        void UpdateLanguage(Language entity);
        void DeleteLanguage(int id);
    }
}
