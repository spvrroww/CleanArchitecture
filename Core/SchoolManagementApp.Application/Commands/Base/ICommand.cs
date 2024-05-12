using MediatR;
using SchoolManagementApp.Domain.Shared;
namespace SchoolManagementApp.Application.Commands.Base;
public interface ICommand: IRequest<Result>
{
  
}
public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{

}