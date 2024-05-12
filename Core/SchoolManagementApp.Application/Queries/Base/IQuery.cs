using MediatR;
using SchoolManagementApp.Domain.Shared;
namespace SchoolManagementApp.Application.Queries.Base;
public interface IQuery: IRequest<Result>
{
  
}
public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{

}