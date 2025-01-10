using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Domain;

namespace Project.Data
{
    public class ProjectContext : DbContext
    {
        public ProjectContext (DbContextOptions<ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Project.Domain.AdoptionHistory> AdoptionHistory { get; set; } = default!;
        public DbSet<Project.Domain.Appointment> Appointment { get; set; } = default!;
        public DbSet<Project.Domain.Donation> Donation { get; set; } = default!;
        public DbSet<Project.Domain.FAQ> FAQ { get; set; } = default!;
        public DbSet<Project.Domain.Inquiry> Inquiry { get; set; } = default!;
        public DbSet<Project.Domain.Organization> Organization { get; set; } = default!;
        public DbSet<Project.Domain.Pet> Pet { get; set; } = default!;
        public DbSet<Project.Domain.User> User { get; set; } = default!;
    }
}
