using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Linq;

namespace Session8.Data.DPO
{
    [Table("Car")]
    public partial class CarDPO
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Engine { get; set; }
        public int SeriesYear { get; set; }
    }
}
