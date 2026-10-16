namespace WestCoastEducation.Models;


public class Person
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string PersonalNumber { get; set; } = string.Empty;
    public Address Address { get; set; } = new Address();

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}
