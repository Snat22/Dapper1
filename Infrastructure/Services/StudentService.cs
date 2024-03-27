using Dapper;
using Domain.Models;
using Infrastructure.DataContext;
namespace Infrastructure.Services;

public class StudentService : IStudentService
{
      private readonly DapperContext _context;

      public StudentService()
      {
        _context = new DapperContext();
      }
    public string AddStudent(Student student)
    {
        var sql = $"insert into student (firstname,lastname,age,university,email) values('{student.FirstName}','{student.LastName}',{student.Age},'{student.Unversity}','{student.Email}')";
        var inserted = _context.Connection().Execute(sql);
        if (inserted > 0) return "Successfully created new student";
         return "Error in creating new student";
    }


    public List<Student> GetStudents()
    {
        var sql = "Select * from Student";
        var selected = _context.Connection().Query<Student>(sql).ToList();
        return selected;
    }


    public Student GetStudentById(int id)
    {
        var sql = "Select * from Student where id=@id";
        var selected = _context.Connection().QueryFirstOrDefault<Student>(sql);
        return selected;
    }

        public string UpdateStudent(Student student)
    {
        var sql = $"update student set firstname = '{student.FirstName}', "+
            $"lastname = '{student.LastName}',',age = '{student.Age}',address='{student.Email}' "+
            $"where id = {student.id}";
            var updated = _context.Connection().Execute(sql);
               if (updated > 0) return "Successfully created new student";
        return "Error in creating new student";
    }

    public bool DeleteStudent(int id)
    {
        var sql = "Delete * from Student where id = {id}";
        var deleted = _context.Connection().Execute(sql);
        if (deleted > 0) return true;
         return false;
    }



}
