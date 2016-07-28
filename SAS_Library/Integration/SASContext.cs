using SAS_Library.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jorge_Cotillo_Day4_ClassLibrary.Integration
{
    public class SASContext : DbContext
    {
        public SASContext() : base("name = SASContext")
        {
            this.Database.Log = i => System.Diagnostics.Debug.WriteLine(i);
        }

        public DbSet<UserEntity> UserTable { get; set; }
        public DbSet<RoomEntity> RoomTable { get; set; }
    }
}
