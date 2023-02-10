using UniversitySystem;
using UniversitySystem.enums;

namespace University
{
    public class Student : Person
    {
        public int University { get; set; }
        public int studentID { get; set; }
        public string department { get; set; }
        public DateOnly Batch { get; set; }
        public string waringCount { get; set; }
        public bool IsLegacy { get; set; }
        public float CGPA { get; set; }
        public int EarnCreditcHours { get; set; }
        public List<Semester> semester { get; set; }


        public int DegreeYear()
        {
            return DateTime.Now.Year - Batch.Year;
        }

        public void Registersemester(semesterType semestertype)
        {
            var current_sem_courses = Course.GetSemesterCourse(this.semester.Count + 1);
            Semester semester = new Semester
            {
                SemesterID = this.semester.Count + 1,
                Course = current_sem_courses,
                semesterType = semestertype,
                CreditHours = current_sem_courses.Sum(x => x.CreditHour)
            };
          
        }
        public Semester getcurrentSemester()
        {
            return semester.Last();
        }

    }

}