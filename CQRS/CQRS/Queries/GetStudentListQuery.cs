using CQRS.Data;
using CQRS.Models;
using CQRS.Repositories;
using MediatR;

namespace CQRS.Queries;

//public class GetStudentListQuery : IRequest<List<StudentDetails>>
//{
    
//}

public class GetStudentListQuery : IRequest<List<StudentDetails>>
{
    public class GetStudentListQueryHandler : IRequestHandler<GetStudentListQuery, List<StudentDetails>>
    {
        private readonly StudentRepository _context;

        public GetStudentListQueryHandler(StudentRepository context)
        {
            _context = context;
        }
        public async Task<List<StudentDetails>> Handle(GetStudentListQuery query, CancellationToken cancellationToken)
        {
            var productList = await _context.GetStudentListAsync();
            if (productList == null)
            {
                return null;
            }
            return productList;
        }
    }
}