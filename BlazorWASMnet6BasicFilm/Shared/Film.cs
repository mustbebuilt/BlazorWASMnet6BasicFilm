using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWASMnet6BasicFilm.Shared
{
    public class Film

    {

        public int FilmID { get; set; }

        public string FilmTitle { get; set; }

        public string FilmCertificate { get; set; }

        public string FilmDescription { get; set; }

        public string FilmImage { get; set; }

        public decimal FilmPrice { get; set; }

        public int stars { get; set; }

        public DateTime ReleaseDate { get; set; }

    }
}

