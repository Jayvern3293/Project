﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ProjectManagement.Configurations.Entities
{
	public class RoleSeed : IEntityTypeConfiguration<IdentityRole>
	{
		public void Configure(EntityTypeBuilder<IdentityRole> builder)
		{
			builder.HasData(
			new IdentityRole
			{
				Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
				Name = "Administrator",
				NormalizedName = "ADMINISTRATOR"
			}
			);
		}
	}
}