namespace WebApplication4.DTOs;

public class StudentGetDto
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public IEnumerable<GroupDto> Groups { get; set; }
}

public class GroupDto
{
    public int GroupId { get; set; }
    public string Name { get; set; }
}