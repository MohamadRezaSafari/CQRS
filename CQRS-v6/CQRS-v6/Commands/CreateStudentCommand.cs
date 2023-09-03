using CQRS_v6.Models;
using MediatR;

namespace CQRS_v6.Commands;

public class CreateStudentCommand : IRequest<StudentDetails>
{
    public string Name { get; set; }

    public CreateStudentCommand(string name)
    {
        Name = name;
    }
}