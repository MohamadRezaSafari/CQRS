using CQRS.Models;
using CQRS.Queries;
using CQRS.Repositories;
using MediatR;

namespace CQRS.Handlers;

public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, StudentDetails>
{
    private readonly StudentRepository _studentRepository;

    public GetStudentByIdHandler(StudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<StudentDetails> Handle(GetStudentByIdQuery request,
        CancellationToken cancellationToken)
    {
        return await _studentRepository.GetStudentByIdAsync(request.Id);
    }
}