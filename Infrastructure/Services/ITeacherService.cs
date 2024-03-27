using Domain.Models;

namespace Infrastructure.Services;

public interface ITeacherService
{
    List<Teacher> GetTeachers();

    Teacher GetTeacherById(int id);

    string AddTeacher(Teacher Teacher);

    string UpdateTeacher(Teacher Teacher);

    bool DeleteStudent(int id);
}
