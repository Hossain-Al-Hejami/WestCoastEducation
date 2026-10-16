using WestCoastEducation.Models;
using WestCoastEducation.Services;

namespace WestCoastEducation;

class Program
{
    static void Main()
    {
        CourseService courseService = new CourseService();
        PersonService personService = new PersonService();
        CourseJsonService courseJsonService = new CourseJsonService();

        bool running = true;
        while (running)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("     WestCoast Education");
            Console.WriteLine("===============================");

            Console.WriteLine("1. Lägg till kurs");
            Console.WriteLine("2. Visa alla kurser");
            Console.WriteLine("3. Lägg till student");
            Console.WriteLine("4. Visa alla studenter");
            Console.WriteLine("5. Lägg till lärare");
            Console.WriteLine("6. Visa alla lärare");
            Console.WriteLine("7. Lägg till utbildningsledare");
            Console.WriteLine("8. Visa alla utbildningsledare");
            Console.WriteLine("9. Lägg till administratör");
            Console.WriteLine("10. Visa alla administratörer");
            Console.WriteLine("11. Spara kurser till JSON");
            Console.WriteLine("12. Läs in kurser från JSON");
            Console.WriteLine("0. Avsluta programmet");
            Console.WriteLine("===============================");
            Console.WriteLine("Välj ett alternativ:");


            string Choise = Console.ReadLine() ?? "";

            switch (Choise)
            {
                case "1":
                    Console.WriteLine("Lägg till kurs:");
                    Console.WriteLine("-----------------");

                    Console.Write("Kursnummer: ");
                    string courseNumber = Console.ReadLine() ?? "";

                    Console.Write("Titel: ");
                    string Title = Console.ReadLine() ?? "";

                    Console.Write("Längd i dagar: ");
                    int.TryParse(Console.ReadLine(), out int durationDays);

                    Console.Write("Startdatum (yyyy-MM-dd): ");
                    DateTime.TryParse(Console.ReadLine(), out DateTime startDate);

                    Console.Write("Slutdatum (yyyy-MM-dd): ");
                    DateTime.TryParse(Console.ReadLine(), out DateTime endDate);

                    Console.WriteLine("Välj kurs typ:");
                    Console.WriteLine("1. Klassrum");
                    Console.WriteLine("2. Distans");

                    string typeChoice = Console.ReadLine() ?? "";

                    CourseType courseType;

                    if (typeChoice == "2")
                    {
                        courseType = CourseType.Distance;
                    }
                    else
                    {
                        courseType = CourseType.Classroom;
                    }

                    Course newCourse = new Course
                    {
                        CourseNumber = courseNumber,
                        Title = Title,
                        DurationDays = durationDays,
                        StartDate = startDate,
                        EndDate = endDate,
                        Type = courseType
                    };

                    courseService.AddCourse(newCourse);
                    break;

                case "2":
                    Console.WriteLine("Visa alla kurser:");
                    Console.WriteLine("-----------------");
                    courseService.ListCourses();
                    break;

                case "3":
                    Console.WriteLine("Lägg till student:");
                    Console.WriteLine("-----------------");

                    Student newStudent = new Student();

                    Console.Write("Förnamn: ");
                    newStudent.FirstName = Console.ReadLine() ?? "";

                    Console.Write("Efternamn: ");
                    newStudent.LastName = Console.ReadLine() ?? "";

                    Console.Write("Telefonnummer: ");
                    newStudent.Phone = Console.ReadLine() ?? "";

                    Console.Write("Personnummer: ");
                    newStudent.PersonalNumber = Console.ReadLine() ?? "";

                    Console.Write("Adress: ");
                    newStudent.Address.Street = Console.ReadLine() ?? "";

                    Console.Write("Postnummer: ");
                    newStudent.Address.PostalCode = Console.ReadLine() ?? "";

                    Console.Write("Ort: ");
                    newStudent.Address.City = Console.ReadLine() ?? "";

                    personService.AddStudent(newStudent);
                    break;

                case "4":
                    Console.WriteLine("Visa alla studenter:");
                    Console.WriteLine("-----------------");

                    personService.ListStudents();
                    break;

                case "5":
                    Console.WriteLine("Lägg till lärare:");
                    Console.WriteLine("-----------------");

                    Teacher newTeacher = new Teacher();

                    Console.Write("Förnamn: ");
                    newTeacher.FirstName = Console.ReadLine() ?? "";

                    Console.Write("Efternamn: ");
                    newTeacher.LastName = Console.ReadLine() ?? "";

                    Console.Write("Telefonnummer: ");
                    newTeacher.Phone = Console.ReadLine() ?? "";

                    Console.Write("Personnummer: ");
                    newTeacher.PersonalNumber = Console.ReadLine() ?? "";

                    Console.Write("Adress: ");
                    newTeacher.Address.Street = Console.ReadLine() ?? "";

                    Console.Write("Postnummer: ");
                    newTeacher.Address.PostalCode = Console.ReadLine() ?? "";

                    Console.Write("Ort: ");
                    newTeacher.Address.City = Console.ReadLine() ?? "";

                    Console.Write("Kunskapsområde: ");
                    newTeacher.KnowledgeArea = Console.ReadLine() ?? "";

                    personService.AddTeacher(newTeacher);
                    break;

                case "6":
                    Console.WriteLine("Visa alla lärare:");
                    Console.WriteLine("-----------------");
                    personService.ListTeachers();
                    break;

                case "7":
                    Console.WriteLine("Lägg till utbildningsledare:");
                    Console.WriteLine("-----------------");

                    EducationLeader newEducationLeader = new EducationLeader();

                    Console.Write("Förnamn: ");
                    newEducationLeader.FirstName = Console.ReadLine() ?? "";

                    Console.Write("Efternamn: ");
                    newEducationLeader.LastName = Console.ReadLine() ?? "";

                    Console.Write("Telefonnummer: ");
                    newEducationLeader.Phone = Console.ReadLine() ?? "";

                    Console.Write("Personnummer: ");
                    newEducationLeader.PersonalNumber = Console.ReadLine() ?? "";

                    Console.Write("Adress: ");
                    newEducationLeader.Address.Street = Console.ReadLine() ?? "";

                    Console.Write("Postnummer: ");
                    newEducationLeader.Address.PostalCode = Console.ReadLine() ?? "";

                    Console.Write("Ort: ");
                    newEducationLeader.Address.City = Console.ReadLine() ?? "";

                    Console.Write("Kunskapsområde: ");
                    newEducationLeader.KnowledgeArea = Console.ReadLine() ?? "";

                    Console.Write("Anställningsdatum (yyyy-MM-dd): ");
                    DateTime.TryParse(Console.ReadLine(), out DateTime employmentDate);
                    newEducationLeader.EmploymentDate = employmentDate;

                    personService.AddEducationLeader(newEducationLeader);
                    break;

                case "8":
                    Console.WriteLine("Visa alla utbildningsledare:");
                    Console.WriteLine("-----------------");
                    personService.ListEducationLeaders();
                    break;

                case "9":
                    Console.WriteLine("Lägg till administratör:");
                    Console.WriteLine("-----------------");

                    Administrator newAdministrator = new Administrator();

                    Console.Write("Förnamn: ");
                    newAdministrator.FirstName = Console.ReadLine() ?? "";

                    Console.Write("Efternamn: ");
                    newAdministrator.LastName = Console.ReadLine() ?? "";

                    Console.Write("Telefonnummer: ");
                    newAdministrator.Phone = Console.ReadLine() ?? "";

                    Console.Write("Personnummer: ");
                    newAdministrator.PersonalNumber = Console.ReadLine() ?? "";

                    Console.Write("Adress: ");
                    newAdministrator.Address.Street = Console.ReadLine() ?? "";

                    Console.Write("Postnummer: ");
                    newAdministrator.Address.PostalCode = Console.ReadLine() ?? "";

                    Console.Write("Ort: ");
                    newAdministrator.Address.City = Console.ReadLine() ?? "";

                    Console.Write("Kunskapsområde: ");
                    newAdministrator.KnowledgeArea = Console.ReadLine() ?? "";

                    Console.Write("Anställningsdatum (yyyy-MM-dd): ");
                    DateTime.TryParse(Console.ReadLine(), out DateTime adminEmploymentDate);
                    newAdministrator.EmploymentDate = adminEmploymentDate;

                    personService.AddAdministrator(newAdministrator);
                    break;

                case "10":
                    Console.WriteLine("Visa alla administratörer:");
                    Console.WriteLine("-----------------");
                    personService.ListAdministrators();
                    break;

                case "11":
                    Console.WriteLine("Spara kurser till JSON-fil:");
                    Console.WriteLine("-----------------");

                    List<Course> courseToSave = courseService.GetAllCourses();

                    courseJsonService.SaveCoursesToJson(courseToSave, "courses.json");

                    break;

                case "12":
                    Console.WriteLine("Läs kurser från JSON-fil:");
                    Console.WriteLine("-----------------");

                    List<Course> loadedCourses = courseJsonService.LoadCoursesFromJson("courses.json");

                    courseService.ReplaceCourses(loadedCourses);

                    Console.WriteLine("Kurser har lästs in från JSON-filen.");

                    courseService.ListCourses();

                    break;

                case "0":
                    Console.WriteLine("Avslutar programmet...");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }
}