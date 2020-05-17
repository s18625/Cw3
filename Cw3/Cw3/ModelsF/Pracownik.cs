using System;
using System.Collections.Generic;

namespace Cw3.ModelsF
{
    public partial class Pracownik
    {
        public int IdPracownik { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int? IdMiasto { get; set; }
    }
}
