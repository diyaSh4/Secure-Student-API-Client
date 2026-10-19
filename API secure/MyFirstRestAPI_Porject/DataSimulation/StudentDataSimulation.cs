using StudentApi.Models;
using BCrypt.Net;

namespace StudentApi.DataSimulation
{
    public class StudentDataSimulation
    {
        public static readonly List<Student> StudentsList = new List<Student>
        {
           new Student
           {
               Id = 1,
               Name = "Diya Shoqeir",
               Age = 26,
               Grade = 88,
               Email = "diya.shoqeir@student.com",
               PasswordHash = BCrypt.Net.BCrypt.HashPassword("password1"),
               Role = "Student" 
           },
            new Student
            {
                Id = 2,
                Name = "Salah Osaly",
                Age = 26,
                Grade = 77,
                Email = "salah.osaly@student.com",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("password2"),
                Role = "Student"
            },
            new Student
            { 
                Id = 3,
                Name = "Anas Tamimi",
                Age = 23,
                Grade = 46,
                Email = "anas.tamimi@student.com",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("password3"),
                Role = "Student"
            },
            new Student 
            { 
                Id = 4,
                Name = "Omar Ory",
                Age = 20,
                Grade = 44,
                Email = "omar.ory@student.com",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("password4"),
                Role = "Admin" 
            }, 
            new Student 
            { 
                Id = 5,
                Name = "Bshar Amin",
                Age = 27,
                Grade = 90,
                Email = "bshar.amin@admin.com",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("admin123"),
                Role = "Admin"
            }
        };
    }
}
