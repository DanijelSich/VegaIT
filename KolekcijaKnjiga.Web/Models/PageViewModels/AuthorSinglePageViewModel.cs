using KolekcijaKnjiga.Web.Models.ViewModels;
using System.Collections.Generic;

namespace KolekcijaKnjiga.Web.Models.PageViewModels
{
    public class AuthorSinglePageViewModel
    {
        public AuthorViewModel AuthorViewModel { get; set; }
        public List<NationalityViewModel> NationalityList { get; set; }
    }
}