using System.Text.Json;
using System.Text.Json.Serialization;
using WestCoastEducation.Models;

namespace WestCoastEducation.Services;

public class CourseJsonService
{
    public void SaveCoursesToJson(List<Course> courses, string filePath)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter() }
        };

        string jsonString = JsonSerializer.Serialize(courses, options);
        File.WriteAllText(filePath, jsonString);
        Console.WriteLine($"Kurser har sparats till filen: {filePath}");
    }

    public List<Course> LoadCoursesFromJson(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"Filen {filePath} hittades inte.");
            return new List<Course>();
        }

        var options = new JsonSerializerOptions
        {
            Converters = { new JsonStringEnumConverter() }
        };
        
        string jsonString = File.ReadAllText(filePath);
        List<Course> courses = JsonSerializer.Deserialize<List<Course>>(jsonString, options) ?? new List<Course>();
        Console.WriteLine($"Kurser har lästs in från filen: {filePath}");
        return courses;
    }
}