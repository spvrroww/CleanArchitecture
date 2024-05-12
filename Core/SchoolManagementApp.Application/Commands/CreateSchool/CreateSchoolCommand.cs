using SchoolManagementApp.Application.Commands.Base;
using SchoolManagementApp.Domain.Entities;
namespace SchoolManagementApp.Application.Commands.CreateSchool;
public record CreateSchoolCommand(School School): ICommand
{
  
}
