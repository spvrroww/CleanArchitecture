using MediatR;
using SchoolManagementApp.Domain.Shared;
namespace SchoolManagementApp.Application.Queries.Base;
public interface IQueryHandler<TQuery>: IRequestHandler<TQuery,Result> where TQuery : IQuery
{
  
}
public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>> where TQuery : IQuery<TResponse>
{

}