using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tojaproject.Models
{
    public class KontaktForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Telefonnr { get; set; }
        public char Kommentar {get; set;}
    }
}
