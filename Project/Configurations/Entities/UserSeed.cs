using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain;

namespace Project.Configurations.Entities
{
	public class UserSeed : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasData(
			new User
			{
				UserId = 1,
				Name = "John Bork",
				Address = "123 Test Street",
				Email = "johnbork1@gmail.com"
			},
			new User 
			{
				UserId = 2,
				Name = "Big Papi",
				Address = "555 Haight Street",
				Email = "ortizpapi@gmail.com"
			}
			);
		}
	}
}
