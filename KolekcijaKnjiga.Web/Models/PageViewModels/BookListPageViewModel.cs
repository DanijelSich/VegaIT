using KolekcijaKnjiga.Web.Models.ViewModels;
using System.Collections.Generic;

namespace KolekcijaKnjiga.Web.Models.PageViewModels
{
    public class BookListPageViewModel
    {
        public List<BookViewModel> BookViewModels { get; set; }

        public List<GenreViewModel> GenreList { get; set; }
        public List<LanguageViewModel> LanguageList { get; set; }
        public List<AuthorViewModel> AuthorList { get; set; }

        public BookSearchViewModel BookSearchViewModel { get; set; }
    }
}