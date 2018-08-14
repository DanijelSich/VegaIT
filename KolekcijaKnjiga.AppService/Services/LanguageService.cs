using KolekcijaKnjiga.Model.IServices;
using KolekcijaKnjiga.Model.Entities;
using KolekcijaKnjiga.Model.IRepositories;
using System.Collections.Generic;
using System;

namespace KolekcijaKnjiga.Service.Services
{
    public class LanguageService : ILanguageService
    {
        private ILanguageRepository _languageRepository;

        public LanguageService(ILanguageRepository repository)
        {
            _languageRepository = repository;
        }

        public void CreateLanguage(Language entity)
        {
            _languageRepository.Create(entity);
        }

        public void DeleteLanguage(int id)
        {
            _languageRepository.Delete(id);
        }

        public List<Language> GetAllLanguages()
        {
            return _languageRepository.GetAll();
        }

        public Language GetLanguageById(int id)
        {
            return _languageRepository.GetById(id);
        }

        public void UpdateLanguage(Language entity)
        {
            _languageRepository.Update(entity);
        }
    }
}
