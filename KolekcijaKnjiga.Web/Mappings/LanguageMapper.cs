using KolekcijaKnjiga.Model.Entities;
using KolekcijaKnjiga.Web.Models.ViewModels;
using System;
using System.Collections.Generic;

namespace KolekcijaKnjiga.Web.Mappings
{
    public static class LanguageMapper
    {
        public static LanguageViewModel ConvertToViewModel(this Language model)
        {
            LanguageViewModel viewModel = new LanguageViewModel();
            viewModel.LanguageId = model.Id;
            viewModel.Language = model.Name;

            return viewModel;
        }

        public static List<LanguageViewModel> ConvertToViewModelList(this List<Language> models)
        {
            List<LanguageViewModel> viewModels = new List<LanguageViewModel>();
            foreach (Language m in models)
            {
                viewModels.Add(m.ConvertToViewModel());
            }

            return viewModels;
        }

        public static Language ConvertToModel(this LanguageViewModel viewModel)
        {
            Language model = new Language();
            if (viewModel.LanguageId != null)
                model.Id = Convert.ToInt32(viewModel.LanguageId);
            model.Name = viewModel.Language;

            return model;
        }
    }
}