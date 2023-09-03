using CQRS_v6.Models;
using CQRS_v6.Queries;
using CQRS_v6.Repositories;
using MediatR;

namespace CQRS_v6.Handlers;

public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, StudentDetails>
{
    private readonly IStudentRepository _studentRepository;

    public GetStudentByIdHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<StudentDetails> Handle(GetStudentByIdQuery request,
        CancellationToken cancellationToken)
    {
        return await _studentRepository.GetStudentByIdAsync(request.Id);
    }
}