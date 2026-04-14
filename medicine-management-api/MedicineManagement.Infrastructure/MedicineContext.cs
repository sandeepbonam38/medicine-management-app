using MedicineManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MedicineManagement.Infrastructure
{
    public class MedicineContext : DbContext
    {
        public MedicineContext(DbContextOptions<MedicineContext> options)
            : base(options)
        {
        }

        public DbSet<Medicine> Medicines { get; set; }
    }
}