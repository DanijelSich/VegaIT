using KolekcijaKnjiga.Model.IServices;
using KolekcijaKnjiga.Model.Entities;
using KolekcijaKnjiga.Model.IRepositories;
using System.Collections.Generic;

namespace KolekcijaKnjiga.Service.Services
{
    public class GenreService : IGenreService
    {
        private IGenreRepository _genreRepository;

        public GenreService(IGenreRepository repository)
        {
            _genreRepository = repository;
        }

        public void CreateGenre(Genre entity)
        {
            _genreRepository.Create(entity);
        }

        public void DeleteGenre(int id)
        {
            _genreRepository.Delete(id);
        }

        public List<Genre> GetAllGenres()
        {
            return _genreRepository.GetAll();
        }

        public Genre GetGenreById(int id)
        {
            return _genreRepository.GetById(id);
        }

        public void UpdateGenre(Genre entity)
        {
            _genreRepository.Update(entity);
        }
    }
}
