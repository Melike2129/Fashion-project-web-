using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace faskion.Data
{
    public class faskionContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public faskionContext() : base("name=faskionContext")
        {
            Database.SetInitializer<faskionContext>(new DropCreateDatabaseIfModelChanges<faskionContext>());
        }

        public System.Data.Entity.DbSet<faskion.Models.Gift> Gifts { get; set; }

        public System.Data.Entity.DbSet<faskion.Models.Capsule> Capsules { get; set; }

        public System.Data.Entity.DbSet<faskion.Models.NewIn> NewIns { get; set; }

        public System.Data.Entity.DbSet<faskion.Models.Admin> Admins { get; set; }
        public System.Data.Entity.DbSet<faskion.Models.User> Users { get; set; }
    }
}
