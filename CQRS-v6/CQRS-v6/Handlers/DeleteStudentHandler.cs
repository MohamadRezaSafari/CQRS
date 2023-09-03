using CQRS_v6.Commands;
using CQRS_v6.Repositories;
using MediatR;

namespace CQRS_v6.Handlers;

public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, int>
{
    private readonly IStudentRepository _studentRepository;

    public DeleteStudentHandler(IStudentRepository studentRepository)
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