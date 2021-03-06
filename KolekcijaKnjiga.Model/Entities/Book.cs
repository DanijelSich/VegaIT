﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcijaKnjiga.Model.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Description { get; set; }

        public Genre Genre { get; set; }
        public Language Language { get; set; }
        public List<Author> Authors { get; set; }
    }
}