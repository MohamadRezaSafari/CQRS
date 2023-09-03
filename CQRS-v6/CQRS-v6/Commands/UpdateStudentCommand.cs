using MediatR;

namespace CQRS_v6.Commands;

public class UpdateStudentCommand : IRequest<int>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public UpdateStudentCommand(int id, string name)
    {
        Id = id;
        Name = name;
    }
}