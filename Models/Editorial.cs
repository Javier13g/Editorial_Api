using System;
using System.Collections.Generic;

namespace Editorial_Api.Models
{
    public partial class Editorial
    {
        public int CodEditorial { get; set; }
        public string NombreEditorial { get; set; } = null!;
        public decimal LatitudUbicacion { get; set; }
        public decimal LongitudUbicacion { get; set; }
    }
}
