using CQRS_v6.Commands;
using CQRS_v6.Repositories;
using MediatR;

namespace CQRS_v6.Handlers;

public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, int>
{
    private readonly IStudentRepository _studentRepository;

    public UpdateStudentHandler(IStudentRepository studentRepository)
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