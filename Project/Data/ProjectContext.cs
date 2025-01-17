using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Configurations.Entities;
using Project.Data;
using ProjectManagement.Configurations.Entities;

namespace Project.Data
{
    public class ProjectContext(DbContextOptions<ProjectContext> options) : IdentityDbContext<ProjectUser>(options)
    {
		public DbSet<Project.Domain.AdoptionHistory> AdoptionHistory { get; set; } = default!;
		public DbSet<Project.Domain.Appointment> Appointment { get; set; } = default!;
		public DbSet<Project.Domain.Donation> Donation { get; set; } = default!;
		public DbSet<Project.Domain.FAQ> FAQ { get; set; } = default!;
		public DbSet<Project.Domain.Inquiry> Inquiry { get; set; } = default!;
		public DbSet<Project.Domain.Organization> Organization { get; set; } = default!;
		public DbSet<Project.Domain.Pet> Pet { get; set; } = default!;
		public DbSet<Project.Domain.User> User { get; set; } = default!;


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new PetSeed());
			modelBuilder.ApplyConfiguration(new RoleSeed());
			modelBuilder.ApplyConfiguration(new UserSeed());
			modelBuilder.ApplyConfiguration(new UserRoleSeed());
		}
	}
}
