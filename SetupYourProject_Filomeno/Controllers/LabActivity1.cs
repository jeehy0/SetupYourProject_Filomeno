using Microsoft.AspNetCore.Mvc;
using SetupYourProject_Filomeno.Models;

namespace SetupYourProject_Filomeno.Controllers
{
    public class LabActivity1 : Controller
    {
        List<Student> StudentList = new List<Student>()
            {
                new Student()
                {
                    FirstName = "Cyril", LastName = "Filomeno", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.5, Email = "cyrilangelo.filomeno.cics@ust.edu.ph"
                },
                new Student()
                    {
                    FirstName = "Caster", LastName = "Lapuz", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-27"), GPA = 1.6, Email = "castertroi.lapuz.cics@ust.edu.ph"
                },
                new Student()
                {
                    FirstName = "Rico", LastName = "Nieto", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-28"), GPA = 1.8, Email = "rico.nieto.cics@ust.edu.ph"
                }
            };

        List<Instructor> InstructorList = new List<Instructor>()
            {
                new Instructor()
                {
                    Id = 1, FirstName = "Cyril", LastName = "Filomeno", IsTenured = true, Rank = Rank.Instructor, HiringDate = DateTime.Parse("2022-08-27")
                },
                new Models.Instructor()
                {
                    Id = 2, FirstName = "Caster", LastName = "Lapuz", IsTenured = false, Rank = Rank.AssistantProfessor, HiringDate = DateTime.Parse("2022-08-28")
                },
                new Models.Instructor()
                {
                    Id = 3, FirstName = "Rico", LastName = "Nieto", IsTenured = true, Rank = Rank.AssociateProfessor, HiringDate = DateTime.Parse("2022-08-29")
                }
            };

        public IActionResult Index()
        {
            return View(InstructorList);
        }
        public IActionResult Student()
        {
            return View(StudentList);
        }
        public IActionResult ShowDetails(int id) {
            Instructor? instructor = InstructorList.FirstOrDefault(Instructor => Instructor.Id == id);

            if (instructor != null) {
                return View(instructor);
            }
            return NotFound();
       }
    }
}
