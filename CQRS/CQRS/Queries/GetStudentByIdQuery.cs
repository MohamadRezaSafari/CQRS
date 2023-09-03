using CQRS.Models;
using MediatR;

namespace CQRS.Queries;

public class GetStudentByIdQuery : IRequest<StudentDetails>
{
    public int Id { get; set; }
}