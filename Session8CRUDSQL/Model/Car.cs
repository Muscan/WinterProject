using System;
using System.Collections.Generic;

#nullable disable

namespace Session8CRUDSQL.Model
{
    public partial class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Engine { get; set; }
        public int SeriesYear { get; set; }
    }
}
