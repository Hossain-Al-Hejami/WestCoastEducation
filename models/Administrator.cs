namespace WestCoastEducation.Models;

public class Administrator : EducationLeader
{
    public override string ToString()
    {
        return $"{FirstName} {LastName}, Administratör, Anställd: {EmploymentDate:yyyy-MM-dd}, Adress: {Address}";
    }
}