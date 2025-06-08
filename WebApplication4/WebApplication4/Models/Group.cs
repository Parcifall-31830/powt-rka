using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models;

public class Group
{
    [Key]
    public int IdGroup { get; set; }

    [MaxLength(50)] public string Name { get; set; } = null!;

    public virtual ICollection<StudentGroup> StudentGroups { get; set; } = null!;
}