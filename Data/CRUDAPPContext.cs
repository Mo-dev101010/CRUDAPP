using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDAPP.Model;

namespace CRUDAPP.Data
{
    public class CRUDAPPContext : DbContext
    {
        public CRUDAPPContext (DbContextOptions<CRUDAPPContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDAPP.Model.Customer> Customer { get; set; } = default!;
    }
}
