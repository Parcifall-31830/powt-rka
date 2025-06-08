using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Data;

public class AppDbContext: DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<StudentGroup> StudentGroups { get; set; }
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var student = new Student
        {
            IdStudent=1,
            FirstName="John",
            LastName="Doe",
            Age=18
        };
        var student2 = new Student
        {
            IdStudent = 2,
            FirstName = "Anna",
            LastName = "Doe",
            Age = 18
        };

        var group1 = new Group()
        {
            IdGroup = 1,
            Name = "Grupa Informatyczna"
        };
        var group2 = new Group()
        {
            IdGroup = 2,
            Name = "Grupa Prawnicza"
        };

        var studentGroup1 = new StudentGroup()
        {
            IdGroup = 1,
            IdStudent = 1
        };
        var studentGroup2 = new StudentGroup()
        {
            IdGroup = 2,
            IdStudent = 1
        };
        var studentGroup3 = new StudentGroup()
        {
            IdGroup = 2,
            IdStudent = 2
        };
        
        modelBuilder.Entity<Group>().HasData([group1,group2]);
        modelBuilder.Entity<Student>().HasData([student,student2]);
        modelBuilder.Entity<StudentGroup>().HasData([studentGroup1,studentGroup2,studentGroup3]);
    }
}