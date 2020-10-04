using System;
using System.Collections.Generic;

namespace FilmesWebApi.Domains
{
    public partial class Filmes
    {
        public int IdFilme { get; set; }
        public string Titulo { get; set; }
        public int? IdGenero { get; set; }

        public Generos IdGeneroNavigation { get; set; }
    }
}
