using CQRS.Commands;
using CQRS.Models;
using CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<StudentDetails>> GetStudentListAsync()
        {
            var students = await _mediator.Send(new GetStudentListQuery());

            return students;
        }

        [HttpGet("studentId")]
        public async Task<StudentDetails> GetStudentByIdAsync(int studentId)
        {
            var studentDetails = await _mediator.Send(new GetStudentByIdQuery() { Id = studentId });

            return studentDetails;
        }

        [HttpPost]
        public async Task<StudentDetails> AddStudentAsync(StudentDetails studentDetails)
        {
            var studentDetail = await _mediator.Send(new CreateStudentCommand(
                studentDetails.Name));

            return studentDetail;
        }

        [HttpPut]
        public async Task<int> UpdateStudentAsync(StudentDetails studentDetails)
        {
            var isStudentDetailUpdated = await _mediator.Send(new UpdateStudentCommand(
                studentDetails.Id,
                studentDetails.Name));

            return isStudentDetailUpdated;
        }

        [HttpDelete]
        public async Task<int> DeleteStudentAsync(int Id)
        {
            return await _mediator.Send(new DeleteStudentCommand() { Id = Id });
        }
    }
}
