namespace Domain.Models;

public class University
{
    public int Id { get; set; }
    public string name { get; set; }
    public string subject { get; set; }
    public decimal contract { get; set; }
    public Teacher Teachers { get; set; }
    public Student Students { get; set; }
}
