using CQRS_v6.Commands;
using CQRS_v6.Models;
using CQRS_v6.Repositories;
using MediatR;

namespace CQRS_v6.Handlers;

public class CreateStudentHandler : IRequestHandler<CreateStudentCommand, StudentDetails>
{
    private readonly IStudentRepository _studentRepository;

    public CreateStudentHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<StudentDetails> Handle(CreateStudentCommand command, 
        CancellationToken cancellationToken)
    {
        var student = new StudentDetails()
        {
            Name = command.Name
        };

        return await _studentRepository.AddStudentAsync(student);
    }
}