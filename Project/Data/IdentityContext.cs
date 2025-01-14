using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Data;

namespace Project.Data
{
    public class IdentityContext(DbContextOptions<IdentityContext> options) : IdentityDbContext<ProjectUser>(options)
    {
    }
}
