using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcijaKnjiga.Model.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Nationality Nationality { get; set; }
    }
}