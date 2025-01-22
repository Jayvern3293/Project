using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain;

namespace Project.Configurations.Entities
{
	public class PetSeed : IEntityTypeConfiguration<Pet>
	{
		public void Configure(EntityTypeBuilder<Pet> builder)
		{
			builder.HasData(
			new Pet
			{
				PetId = 1,
				Name = "Kohaku",
				Age = 5,
				Species = "Dog",
				Colour = "White",
				Gender = "Unspecified",
				OrganizationId = 1
			},
			new Pet
			{
				PetId = 2,
				Name = "Bean",
				Age = 1,
				Species = "Monitor Lizard",
				Colour = "Brown",
				Gender = "Male"
				// this pet doesn't have an organization ID
			}
			);
		}

	}
}
