using Domain.Models;

namespace Infrastructure.Services;

public interface IUniversityService
{
    List<University> GetUniversitys();

    University GetUniversityById(int id);

    string AddUniversity(University University);

    string UpdateUniversity(University University);

    bool DeleteStudent(int id);
}
