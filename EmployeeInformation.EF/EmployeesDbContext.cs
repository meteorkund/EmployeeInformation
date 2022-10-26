using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.EF.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.EF
{
    public class EmployeesDbContext :DbContext
    {
        public EmployeesDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EmployeeDTO> Employees { get; set; }
        public DbSet<Vacation2018DTO> Vacations { get; set; }


        //public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    //ChangeTracker : Entityler üzerinden yapılan değişiklerin ya da yeni eklenen verinin yakalanmasını sağlayan propertydir. Update operasyonlarında Track edilen verileri yakalayıp elde etmemizi sağlar.

        //    var datas = ChangeTracker
        //         .Entries<BaseDTO>();

        //    foreach (var data in datas)
        //    {
        //        _ = data.State switch
        //        {
        //            EntityState.Added => data.Entity.CreatedDate = DateTime.Now,
        //            EntityState.Modified => data.Entity.UpdatedDate = DateTime.Now,
        //            _ => DateTime.Now
        //        };
        //    }

        //    return await base.SaveChangesAsync(cancellationToken);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vacation2018DTO>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<EmployeeDTO>()
                .HasOne(c => c.Vacation2018DTO)
                .WithOne(c => c.EmployeeDTO)
                .HasForeignKey<Vacation2018DTO>(c => c.Id);
        }
    }
}
