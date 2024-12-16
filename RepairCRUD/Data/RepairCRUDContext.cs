using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepairCRUD.models;

namespace RepairCRUD.Data
{
    public class RepairCRUDContext : DbContext
    {
        public RepairCRUDContext (DbContextOptions<RepairCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<RepairCRUD.models.Staff> Staff { get; set; } = default!;
        public DbSet<RepairCRUD.models.Client> Client { get; set; } = default!;
        public DbSet<RepairCRUD.models.Service> Service { get; set; } = default!;
        public DbSet<RepairCRUD.models.Request> Request { get; set; } = default!;
    }
}
