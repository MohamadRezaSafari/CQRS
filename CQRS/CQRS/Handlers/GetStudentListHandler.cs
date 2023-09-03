using CQRS.Models;
using CQRS.Queries;
using CQRS.Repositories;
using MediatR;

namespace CQRS.Handlers;

//public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<StudentDetails>>
//{
//    private readonly StudentRepository studentRepository;

//    public GetStudentListHandler(StudentRepository studentRepository)
//    {
//        this.studentRepository = studentRepository;
//    }

//    public async Task<List<StudentDetails>> Handle(GetStudentListQuery request, 
//        CancellationToken cancellationToken)
//    {
//        return await studentRepository.GetStudentListAsync();
//    }
//}