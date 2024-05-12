using SchoolManagementApp.Domain.Abstractions;
using SchoolManagementApp.Domain.Entities;
using SchoolManagementApp.Persistence.DataAccess;

namespace SchoolManagementApp.Persistence.RepositoryImplementation;

public class SchoolRepository : ISchoolRepository
{
    private readonly ApplicationDbContext _db;

    public SchoolRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task Add(School school)
    {
        await _db.Schools.AddAsync(school);
    }

    public async Task GetById(Guid id)
    {
        await _db.Schools.FindAsync(id);
    }
}