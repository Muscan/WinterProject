using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8.Data.Persistance
{
    using Session8.Data.DPO;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Runtime.Remoting.Contexts;

    public partial class CarRentalEntities : DbContext
    {
        public CarRentalEntities()
            : base("name=CarRentalEntities")
        {
            Database.SetInitializer<CarRentalEntities>(null);
        }

        public virtual DbSet<CarDPO> Cars { get; set; }
    }
}
