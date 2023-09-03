using CQRS_v6.Data;
using CQRS_v6.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_v6.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly ApplicationContext _dbContext;

    public StudentRepository(ApplicationContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<StudentDetails>> GetStudentListAsync()
    {
        return await _dbContext.Students.ToListAsync();
    }

    public async Task<StudentDetails> GetStudentByIdAsync(int id)
    {
        var result = await _dbContext.Students.FindAsync(id);
        return result;
    }

    public async Task<StudentDetails> AddStudentAsync(StudentDetails studentDetails)
    {
        var result = _dbContext.Students.Add(studentDetails);
        await _dbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<int> UpdateStudentAsync(StudentDetails studentDetails)
    {
        _dbContext.Students.Update(studentDetails);
        return await _dbContext.SaveChangesAsync();
    }

    public async Task<int> DeleteStudentAsync(int id)
    {
        var filteredData = _dbContext.Students.FirstOrDefault(x => x.Id == id);
        _dbContext.Students.Remove(filteredData);
        return await _dbContext.SaveChangesAsync();
    }
}