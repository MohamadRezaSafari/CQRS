using CQRS.Models;
using MediatR;

namespace CQRS.Commands;

public class CreateStudentCommand : IRequest<StudentDetails>
{
    public string Name { get; set; }

    public CreateStudentCommand(string name)
    {
        Name = name;
    }
}