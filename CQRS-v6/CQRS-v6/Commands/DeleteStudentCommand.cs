using MediatR;

namespace CQRS_v6.Commands;

public class DeleteStudentCommand : IRequest<int>
{
    public int Id { get; set; }
}