namespace WestCoastEducation.Models;

public class Teacher : Person
{
    public string KnowledgeArea { get; set; } = string.Empty;
    public List<Course> Courses { get; set; } = new List<Course>();

    public override string ToString()
    {
        return $"{FirstName} {LastName}, Kunskapsområde: {KnowledgeArea}, Adress: {Address}";
    }

    public void AddCourse(Course course)
    {
        if (Courses.Contains(course))
        {
            Console.WriteLine("Läraren är redan registrerad på kursen.");
        }
        else
        {
            Courses.Add(course);
            Console.WriteLine($"Läraren {GetFullName()} har lagts till kursen {course.Title}.");
        }
    }
}