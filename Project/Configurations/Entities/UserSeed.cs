using Project.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Project.Configurations.Entities
{
	public class UserSeed : IEntityTypeConfiguration<ProjectUser>
	{
		public void Configure(EntityTypeBuilder<ProjectUser> builder)
		{
			var hasher = new PasswordHasher<ProjectUser>();
			builder.HasData(
			new ProjectUser
			{
				Id = "1781efa7-66dc-47f0-860f-e506d04102e4",
				Email = "staff@localhost.com",
				NormalizedEmail = "STAFF@LOCALHOST.COM",
				FirstName = "Fready",
				LastName = "Sedys",
				UserName = "staff@localhost.com",
				NormalizedUserName = "STAFF@LOCALHOST.COM",
				PasswordHash = hasher.HashPassword(null, "P@ssword1"),
				EmailConfirmed = true // Set to true, otherwise you won't be able to login
			},
			new ProjectUser
			{
				Id = "2781efa7-66dc-47f0-860f-e506d04102e4",
				Email = "customer@localhost.com",
				NormalizedEmail = "CUSTOMER@LOCALHOST.COM",
				FirstName = "John",
				LastName = "Bork",
				UserName = "customer@localhost.com",
				NormalizedUserName = "CUSTOMER@LOCALHOST.COM",
				PasswordHash = hasher.HashPassword(null, "P@ssword2"),
				EmailConfirmed = true
			}
			);
		}
	}
}