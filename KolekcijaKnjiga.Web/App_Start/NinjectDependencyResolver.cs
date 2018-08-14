using KolekcijaKnjiga.Model.IRepositories;
using KolekcijaKnjiga.Model.IServices;
using KolekcijaKnjiga.Repository.Repositories;
using KolekcijaKnjiga.Service.Services;
using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace KolekcijaKnjiga.Web.App_Start
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel _kernel;

        public NinjectDependencyResolver()
        {
            _kernel = new StandardKernel();
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            _kernel.Bind<IBookRepository>().To<BookRepository>();
            _kernel.Bind<IBookService>().To<BookService>();

            _kernel.Bind<IAuthorRepository>().To<AuthorRepository>();
            _kernel.Bind<IAuthorService>().To<AuthorService>();

            _kernel.Bind<IGenreRepository>().To<GenreRepository>();
            _kernel.Bind<IGenreService>().To<GenreService>();

            _kernel.Bind<ILanguageRepository>().To<LanguageRepository>();
            _kernel.Bind<ILanguageService>().To<LanguageService>();

            _kernel.Bind<INationalityRepository>().To<NationalityRepository>();
            _kernel.Bind<INationalityService>().To<NationalityService>();
        }
    }
}