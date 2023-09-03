using CQRS.Commands;
using CQRS.Repositories;
using MediatR;

namespace CQRS.Handlers;

public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, int>
{
    private readonly StudentRepository _studentRepository;

    public DeleteStudentHandler(StudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<int> Handle(DeleteStudentCommand command,
        CancellationToken cancellationToken)
    {
        var student = _studentRepository.GetStudentByIdAsync(command.Id);

        if (student is null) return default;

        return await _studentRepository.DeleteStudentAsync(command.Id);
    }
}