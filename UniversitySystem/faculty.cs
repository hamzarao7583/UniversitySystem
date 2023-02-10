using University;
using UniversitySystem;
using UniversitySystem.enums;

namespace UniversitySystem
{
    public class Faculty : Person
    {
        public int facultyID { get; set; }
        public Departments departments{ get; set; }
        public facultyType facultyType { get; set; }
        public int courseID { get; set; }
        public int cabinNo { get; set; }
        public facultyDesignation facultyDesignation { get; set; }



        public void AssignCourses(int courseID)
        {
            Course.GetAllAvailableCourses().Find(x => x.CourseId == courseID).Instructor = this.facultyID;
        }


        public void AddAssessment(List<Student> students, int assesmentID, assessmentType assesmentType, string assesmentName, double totalMarks, double obtainedMarks, double weightage)
        {
            Assessment newAssessment = new Assessment(assesmentID, assesmentName, assesmentType, totalMarks, 0, weightage);
            students[0].getcurrentSemester().Course[0].Assessments.Add(newAssessment);
            students[1].getcurrentSemester().Course[0].Assessments.Add(newAssessment);
            students[2].getcurrentSemester().Course[0].Assessments.Add(newAssessment);
        }
    }
}