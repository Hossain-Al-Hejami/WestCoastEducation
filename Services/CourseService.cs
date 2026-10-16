using WestCoastEducation.Models;

namespace WestCoastEducation.Services;

public class CourseService
{
    private List<Course> courses = new List<Course>();

    public void AddCourse(Course course)
    {
        foreach (Course existingCourse in courses)
        {
            if (existingCourse.CourseNumber == course.CourseNumber)
            {
                Console.WriteLine($"Kursen med kursnummer {course.CourseNumber} finns redan.");
                return;
            }
        }
        courses.Add(course);
        Console.WriteLine($"Kursen {course.Title} har lagts till.");
    }

    public void ListCourses()
    {
        if (courses.Count == 0)
        {
            Console.WriteLine("Inga kurser finns registrerade.");
            return;
        }
        Console.WriteLine("Lista över kurser:");
        foreach (Course course in courses)
        {
            Console.WriteLine(course);
        }
    }

    public Course? GetCourseByNumber(string courseNumber)
    {
        foreach (Course course in courses)
        {
            if (course.CourseNumber == courseNumber)
            {
                return course;
            }
        }
        return null;
    }

    public void RemoveCourse(string courseNumber)
    {
        Course? courseToRemove = GetCourseByNumber(courseNumber);
        if (courseToRemove != null)
        {
            courses.Remove(courseToRemove);
            Console.WriteLine($"Kursen med kursnummer {courseNumber} har tagits bort.");
        }
        else
        {
            Console.WriteLine($"Kursen med kursnummer {courseNumber} hittades inte.");
        }
    }

    public List<Course> GetAllCourses()
    {
        return courses;
    }

    public void ReplaceCourses(List<Course> loadedCourses)
    {
        courses = loadedCourses;
    }
}