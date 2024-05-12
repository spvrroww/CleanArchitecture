using SchoolManagementApp.Domain.Entities;

namespace SchoolManagementApp.Domain.Abstractions;
public interface ISchoolRepository
{
    public Task Add(School school);
    public Task GetById(Guid Id);
}
