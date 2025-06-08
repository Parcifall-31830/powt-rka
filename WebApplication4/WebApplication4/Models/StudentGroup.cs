using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models;
[Table("StudentGroup")]
[PrimaryKey("IdGroup","IdStudent")]
public class StudentGroup
{
    public int IdGroup { get; set; }
    public int IdStudent { get; set; }
    
    [ForeignKey("IdStudent")]
    public virtual Student Student { get; set; } = null!;
    [ForeignKey("IdGroup")]
    public virtual Group Group { get; set; } = null!;
    
}