using SchoolManagementApp.Application.Commands.Base;
using SchoolManagementApp.Domain.Abstractions;
using SchoolManagementApp.Domain.Entities;
using SchoolManagementApp.Domain.Shared;
namespace SchoolManagementApp.Application.Commands.CreateSchool;
public class CreateSchoolCommandHandler : ICommandHandler<CreateSchoolCommand>
{
    private readonly IUnitOfWork _unitOfWork;
    public CreateSchoolCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(CreateSchoolCommand request, CancellationToken cancellationToken)
    {
        try
        {
            await _unitOfWork.SchoolRepository.Add(request.School);

            return new SuccessResult();      
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}