using Dapper;
using Domain.Models;
using Infrastructure.DataContext;
namespace Infrastructure.Services;

public class TeacherService : ITeacherService
{
          private readonly DapperContext _context;

        public TeacherService()
        {
            _context = new DapperContext();
        }
    public string AddTeacher(Teacher Teacher)
    {
        var sql = $"Insert into Teacher(firstname,lastname,experience) values('{Teacher.FirstName}','{Teacher.LastName}',{Teacher.Experience})";
        var inserted = _context.Connection().Execute(sql);
            if (inserted > 0) return "Successfully created new student";
         return "Error in creating new student";
    }

    public Teacher GetTeacherById(int id)
    {
        var sql = "Select * from Teacher where id =@id";
        var selected = _context.Connection().QueryFirstOrDefault<Teacher>(sql);
        return selected;
    }

    public List<Teacher> GetTeachers()
    {
        var sql = "select * from Teacher";
        var selected = _context.Connection().Query<Teacher>(sql).ToList();
        return selected;
    }

    public string UpdateTeacher(Teacher Teacher)
    {
        var sql = $"Update Teacher set firstname = '{Teacher.FirstName}', "+
            $"lastname = '{Teacher.LastName}','experience = {Teacher.Experience} "+
            $"where id = {Teacher.id}";
            var updated = _context.Connection().Execute(sql);
             if (updated > 0) return "Successfully created new student";
        return "Error in creating new student";
    }

    public bool DeleteStudent(int id)
    {
        var sql = "Delete * from Teacher where id=@id";
        var deleted = _context.Connection().Execute(sql);
         if (deleted > 0) return true;
         return false;
    }

}
