using CQRS_v6.Models;
using MediatR;

namespace CQRS_v6.Queries;

public class GetStudentByIdQuery : IRequest<StudentDetails>
{
    public int Id { get; set; }
}