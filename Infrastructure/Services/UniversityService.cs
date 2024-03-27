using Dapper;
using Domain.Models;
using Infrastructure.DataContext;
namespace Infrastructure.Services;

public class UniversityService : IUniversityService
{

        private readonly DapperContext _context;

        public UniversityService ()
        {
            _context = new DapperContext();
        }
    public string AddUniversity(University University)
    {
        var sql = $"Insert into university(name,subject,contract,Students,Teachers) values('{University.name}','{University.subject}',{University.contract},{University.Students},{University.Teachers})";
        var inserted = _context.Connection().Execute(sql);
         if (inserted > 0) return "Successfully created new student";
         return "Error in creating new student";
    }

    public bool DeleteStudent(int id)
    {
        var sql = "Delete * from UNiversity where id = @id";
        var deleted = _context.Connection().Execute(sql);
          if (deleted > 0) return true;
         return false;
    }

    public University GetUniversityById(int id)
    {
        var sql = "Select * from university where id=@id";
        var selected = _context.Connection().QueryFirstOrDefault<University>(sql);
        return selected;

    }

    public List<University> GetUniversitys()
    {
        var sql = "Select * from university";
        var selected = _context.Connection().Query<University>(sql).ToList();
        return selected;
    }

    public string UpdateUniversity(University University)
    {
     var sql = $"Update Teacher set name = '{University.name}', "+
            $"subject = '{University.subject}','contract = {University.contract} "+
            $"where id = {University.Id}";
            var updated = _context.Connection().Execute(sql);
             if (updated > 0) return "Successfully created new student";
        return "Error in creating new student";    }

}
