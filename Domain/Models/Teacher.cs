namespace Domain.Models;

public class Teacher
{
    public int id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Experience { get; set; }   
    public Student Students { get; set; }
}
