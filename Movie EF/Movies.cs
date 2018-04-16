using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_EF
{
    // PK ID int
    // Title nvarchar 
    // YearReleased nvarchar
    // Genre nvarchar
    // Tagline nvarchar
    // Rating decimal

    public class Movies
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string YearReleased { get; set; }
        public string Genre { get; set; }
        public string Tagline { get; set; }
        public decimal Rating { get; set; }

    }
}
