using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.EF.DTOs;
using EmployeeInformation.EF.DTOs.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.EF
{
    public class EmployeesDbContext : DbContext
    {
        public EmployeesDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EmployeeDTO> Employees { get; set; }
        public DbSet<Vacation2018DTO> Vacations2018 { get; set; }
        public DbSet<Vacation2019DTO> Vacations2019 { get; set; }
        public DbSet<Vacation2020DTO> Vacations2020 { get; set; }
        public DbSet<Vacation2021DTO> Vacations2021 { get; set; }
        public DbSet<Vacation2022DTO> Vacations2022 { get; set; }
        public DbSet<Vacation2023DTO> Vacations2023 { get; set; }


        public DbSet<DepartmentDTO> Departments { get; set; }
        public DbSet<SectorDTO> Sectors { get; set; }
        public DbSet<EducationDTO> Educations { get; set; }
        public DbSet<MilitaryServiceDTO> MilitaryServices { get; set; }
        public DbSet<MaritialDTO> Maritials { get; set; }


        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            var datas = ChangeTracker
                 .Entries<BaseDTO>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.Now,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.Now,
                    _ => DateTime.Now
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Vacation2018DTO>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Vacation2019DTO>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Vacation2020DTO>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Vacation2021DTO>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Vacation2022DTO>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Vacation2023DTO>()
                .HasKey(c => c.Id);



            modelBuilder.Entity<EmployeeDTO>()
                .HasOne(c => c.Vacation2018DTO)
                .WithOne(c => c.EmployeeDTO)
                .HasForeignKey<Vacation2018DTO>(c => c.Id);

            modelBuilder.Entity<EmployeeDTO>()
                .HasOne(c => c.Vacation2019DTO)
                .WithOne(c => c.EmployeeDTO)
                .HasForeignKey<Vacation2019DTO>(c => c.Id);

            modelBuilder.Entity<EmployeeDTO>()
                .HasOne(c => c.Vacation2020DTO)
                .WithOne(c => c.EmployeeDTO)
                .HasForeignKey<Vacation2020DTO>(c => c.Id);

            modelBuilder.Entity<EmployeeDTO>()
                .HasOne(c => c.Vacation2021DTO)
                .WithOne(c => c.EmployeeDTO)
                .HasForeignKey<Vacation2021DTO>(c => c.Id);

            modelBuilder.Entity<EmployeeDTO>()
                .HasOne(c => c.Vacation2022DTO)
                .WithOne(c => c.EmployeeDTO)
                .HasForeignKey<Vacation2022DTO>(c => c.Id);

            modelBuilder.Entity<EmployeeDTO>()
                .HasOne(c => c.Vacation2023DTO)
                .WithOne(c => c.EmployeeDTO)
                .HasForeignKey<Vacation2023DTO>(c => c.Id);
        }
    }
}
