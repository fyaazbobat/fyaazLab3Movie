using System;
using System.Collections.Generic;

#nullable disable

namespace fyaazGouthamLab3.Models
{
    public partial class MovieViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string UrlImage { get; set; }
    }
}
