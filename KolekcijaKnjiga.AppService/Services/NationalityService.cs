using KolekcijaKnjiga.Model.IServices;
using KolekcijaKnjiga.Model.Entities;
using KolekcijaKnjiga.Model.IRepositories;
using System.Collections.Generic;

namespace KolekcijaKnjiga.Service.Services
{
    public class NationalityService : INationalityService
    {
        private INationalityRepository _nationalityRepository;

        public NationalityService(INationalityRepository repository)
        {
            _nationalityRepository = repository;
        }

        public void CreateNationality(Nationality entity)
        {
            _nationalityRepository.Create(entity);
        }

        public void DeleteNationality(int id)
        {
            _nationalityRepository.Delete(id);
        }

        public List<Nationality> GetAllNationalities()
        {
            return _nationalityRepository.GetAll();
        }

        public Nationality GetNationalityById(int id)
        {
            return _nationalityRepository.GetById(id);
        }

        public void UpdateNationality(Nationality entity)
        {
            _nationalityRepository.Update(entity);
        }
    }
}
