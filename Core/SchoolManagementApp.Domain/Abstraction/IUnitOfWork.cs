using SchoolManagementApp.Domain.Entities;

namespace SchoolManagementApp.Domain.Abstractions;
public interface IUnitOfWork
{
    public ISchoolRepository SchoolRepository { get; }
    public Task<bool> SaveChangesAsync();
}
