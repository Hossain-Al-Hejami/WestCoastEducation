using WestCoastEducation.Interfaces;

namespace WestCoastEducation.Models;

public class Course : IDisplayable
{
    public string CourseNumber { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public int DurationDays { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public CourseType Type { get; set; }

    public string GetDetails()
    {
        return $"{CourseNumber} - {Title} - {Type}";
    }
    public override string ToString()
    {
        return $"{CourseNumber} - {Title}, Typ: {Type}, Längd: {DurationDays} dagar, {StartDate:yyyy-MM-dd} - {EndDate:yyyy-MM-dd}";
    }
}