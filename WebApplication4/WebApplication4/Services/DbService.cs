using Microsoft.EntityFrameworkCore;
using WebApplication4.Data;
using WebApplication4.DTOs;
using WebApplication4.Models;

namespace WebApplication4.Services;
public interface IDbService{
public Task<ICollection<StudentGetDto>> GetStudents();
}
public class DbService(AppDbContext data ):IDbService
{
    public async Task<ICollection<StudentGetDto>> GetStudents()
    {
        return await data.Students.Select(st => new StudentGetDto
        {
            StudentId = st.IdStudent,
            FirstName = st.FirstName,
            LastName = st.LastName,
            Age = st.Age,
            Groups = st.StudentGroups.Select(sg => new GroupDto
            {
                GroupId = sg.IdGroup,
                Name = sg.Group.Name
            }).ToList()
        }).ToListAsync();
    }
}