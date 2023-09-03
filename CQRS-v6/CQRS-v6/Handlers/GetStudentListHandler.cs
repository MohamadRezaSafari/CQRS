using CQRS_v6.Models;
using CQRS_v6.Queries;
using CQRS_v6.Repositories;
using MediatR;

namespace CQRS_v6.Handlers;

public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<StudentDetails>>
{
    private readonly IStudentRepository studentRepository;

    public GetStudentListHandler(IStudentRepository studentRepository)
    {
        this.studentRepository = studentRepository;
    }

    public async Task<List<StudentDetails>> Handle(GetStudentListQuery request, 
        CancellationToken cancellationToken)
    {
        return await studentRepository.GetStudentListAsync();
    }
}