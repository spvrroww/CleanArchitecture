using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolManagementApp.Domain.Entities;

namespace SchoolManagementApp.Persistence.DataAccess;

public class ApplicationDbContext : IdentityDbContext<AppUser, Approle, Guid>
{
    public DbSet<School> Schools { get; set; }
}