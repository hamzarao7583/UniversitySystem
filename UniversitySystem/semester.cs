using University;
using UniversitySystem.enums; 
namespace UniversitySystem
{
    public class Semester
    {
        public int SemesterID { get; set; }
        public int CreditHours { get; set; }
        public List<Course> Course { get; set; }
        public semesterType semesterType { get; set; }
        public int CGPA { get; set; }

        public decimal CalculateSCGPA()
        {
            var SGPA = Course.Average(X => (decimal)X.Grade);
            return SGPA;
        }

    }

}