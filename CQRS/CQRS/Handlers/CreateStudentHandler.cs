using CQRS.Commands;
using CQRS.Models;
using CQRS.Repositories;
using MediatR;

namespace CQRS.Handlers;

public class CreateStudentHandler : IRequestHandler<CreateStudentCommand, StudentDetails>
{
    private readonly StudentRepository _studentRepository;

    public CreateStudentHandler(StudentRepository studentRepository)
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