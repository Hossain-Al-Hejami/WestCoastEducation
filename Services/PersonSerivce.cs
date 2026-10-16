using WestCoastEducation.Models;

namespace WestCoastEducation.Services;

public class PersonService
{
    private List<Student> students = new List<Student>();
    private List<Teacher> teachers = new List<Teacher>();
    private List<EducationLeader> educationLeaders = new List<EducationLeader>();
    private List<Administrator> administrators = new List<Administrator>();

    public void AddStudent(Student student)
    {
        if (students.Contains(student))
        {
            Console.WriteLine("Studenten finns redan registrerad.");
            return;
        }
        students.Add(student);
        Console.WriteLine($"Studenten {student.GetFullName()} har lagts till.");
    }

    public void AddTeacher(Teacher teacher)
    {
        if (teachers.Contains(teacher))
        {
            Console.WriteLine("Läraren finns redan registrerad.");
            return;
        }
        teachers.Add(teacher);
        Console.WriteLine($"Läraren {teacher.GetFullName()} har lagts till.");
    }

    public void AddEducationLeader(EducationLeader educationLeader)
    {
        if (educationLeaders.Contains(educationLeader))
        {
            Console.WriteLine("Utbildningsledaren finns redan registrerad.");
            return;
        }
        educationLeaders.Add(educationLeader);
        Console.WriteLine($"Utbildningsledaren {educationLeader.GetFullName()} har lagts till.");
    }

    public void AddAdministrator(Administrator administrator)
    {
        if (administrators.Contains(administrator))
        {
            Console.WriteLine("Administratören finns redan registrerad.");
            return;
        }
        administrators.Add(administrator);
        Console.WriteLine($"Administratören {administrator.GetFullName()} har lagts till.");
    }

    public void ListStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("Inga studenter finns registrerade.");
            return;
        }
        Console.WriteLine("Lista över studenter:");
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
    }

    public void ListTeachers()
    {
        if (teachers.Count == 0)
        {
            Console.WriteLine("Inga lärare finns registrerade.");
            return;
        }
        Console.WriteLine("Lista över lärare:");
        foreach (Teacher teacher in teachers)
        {
            Console.WriteLine(teacher);
        }
    }

    public void ListEducationLeaders()
    {
        if (educationLeaders.Count == 0)
        {
            Console.WriteLine("Inga utbildningsledare finns registrerade.");
            return;
        }
        Console.WriteLine("Lista över utbildningsledare:");
        foreach (EducationLeader educationLeader in educationLeaders)
        {
            Console.WriteLine(educationLeader);
        }
    }

    public void ListAdministrators()
    {
        if (administrators.Count == 0)
        {
            Console.WriteLine("Inga administratörer finns registrerade.");
            return;
        }
        Console.WriteLine("Lista över administratörer:");
        foreach (Administrator administrator in administrators)
        {
            Console.WriteLine(administrator);
        }
    }
}