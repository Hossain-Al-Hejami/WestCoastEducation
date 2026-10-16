using WestCoastEducation.Interfaces;

namespace WestCoastEducation.Models;

public class Student : Person, IDisplayable
{
    public string GetDetails()
    {
        return $"Student: {GetFullName()} | {Address}";
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, Adress: {Address}";
    }

    public List<Course> Courses { get; set; } = new List<Course>();

    public void AddCourse(Course course)
    {
        if (Courses.Contains(course))
        {
            Console.WriteLine("Studenten är redan registrerad på kursen.");
        }
        else
        {
            Courses.Add(course);
            Console.WriteLine($"Studenten {GetFullName()} har lagts till kursen {course.Title}.");
        }
    }
}