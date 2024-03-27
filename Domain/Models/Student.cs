namespace Domain.Models;

public class Student
{
    public int id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public University Unversity { get; set; }
    public string Email { get; set; }

}
