using SchoolManagementApp.Domain.Entities;
using SchoolManagementApp.Domain.Exceptions.Base;

namespace SchoolManagementApp.Domain.Exceptions.SchoolExceptions;

public class SchoolNotFoundException : BaseNotFoundException<School>
{
    public SchoolNotFoundException(Guid id) : base(id)
    {
        
    }
}
