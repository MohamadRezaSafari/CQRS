using MediatR;

namespace CQRS.Commands;

public class DeleteStudentCommand : IRequest<int>
{
    public int Id { get; set; }
}