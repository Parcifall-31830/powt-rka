using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models;


[Table("Student")]
public class Student
{
    [Key]
    public int IdStudent { get; set; }

    [MaxLength(50)] 
    public string FirstName { get; set; } = null!;
    
    [MaxLength(50)]
    public string LastName { get; set; } = null!;
    
    public int Age { get; set; }
    
    
    public virtual ICollection<StudentGroup> StudentGroups { get; set; } = null!;
    
}