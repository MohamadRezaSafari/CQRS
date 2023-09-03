using CQRS_v6.Models;

namespace CQRS_v6.Repositories;

public interface IStudentRepository
{
    public Task<List<StudentDetails>> GetStudentListAsync();
    public Task<StudentDetails> GetStudentByIdAsync(int Id);
    public Task<StudentDetails> AddStudentAsync(StudentDetails studentDetails);
    public Task<int> UpdateStudentAsync(StudentDetails studentDetails);
    public Task<int> DeleteStudentAsync(int Id);
}