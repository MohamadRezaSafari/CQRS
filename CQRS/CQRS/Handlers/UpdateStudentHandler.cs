using CQRS.Commands;
using CQRS.Repositories;
using MediatR;

namespace CQRS.Handlers;

public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, int>
{
    private readonly StudentRepository _studentRepository;

    public UpdateStudentHandler(StudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<int> Handle(UpdateStudentCommand command,
        CancellationToken cancellationToken)
    {
        var student = await _studentRepository.GetStudentByIdAsync(command.Id);
        if (student is null)
            return default;

        student.Name = command.Name;

        return await _studentRepository.UpdateStudentAsync(student);
    }
}