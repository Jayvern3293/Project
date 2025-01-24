using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Domain;

namespace Project.Configurations.Entities
{
    public class OrganizationSeed : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.HasData(
            new Organization
            {
                OrganizationId = 1,
                Name = "HYV Animal Shelter",
                Address = "977 Grove Street"
            }
            );
        }

    }
}
