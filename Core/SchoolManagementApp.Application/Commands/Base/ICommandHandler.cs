using MediatR;
using SchoolManagementApp.Domain.Shared;
namespace SchoolManagementApp.Application.Commands.Base;
public interface ICommandHandler<TCommand>: IRequestHandler<TCommand, Result> where TCommand : ICommand
{
  
}

public interface ICommandHandler<TCommand, TResponse>: IRequestHandler<TCommand, Result<TResponse>> where TCommand : ICommand<TResponse> 
{
  
}
