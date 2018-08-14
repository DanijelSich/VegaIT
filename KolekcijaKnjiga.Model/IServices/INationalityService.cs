﻿using KolekcijaKnjiga.Model.Entities;
using System.Collections.Generic;

namespace KolekcijaKnjiga.Model.IServices
{
    public interface INationalityService
    {
        List<Nationality> GetAllNationalities();
        Nationality GetNationalityById(int id);
        void CreateNationality(Nationality entity);
        void UpdateNationality(Nationality entity);
        void DeleteNationality(int id);
    }
}