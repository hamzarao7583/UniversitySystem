
using UniversitySystem;
using UniversitySystem.enums;

namespace University
{
    public class Course

    {
        public int SemId { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CreditHour { get; set; }
        public CourseType CourseType { get; set; }
        public Departments Departments { get; set; }
        public int Instructor { get; set; }

        public Grade Grade { get; set; }
        private static List<Course> Courses = new List<Course>();
        public List<Assessment> Assessments = new List<Assessment>();
        public static List<Course> GetAllAvailableCourses()

        {
            if (Courses.Count == 0)
            {
                InitializeCourse();
            }
            return Courses;
        }
        public static List<Course> GetElectiveCourses()
        {
            return Course.GetAllAvailableCourses().Where(Course => Course.CourseType == CourseType.Elective).ToList();
        }
        public static List<Course> GetSemesterCourse(int Semesterid)
        {
            return Course.GetAllAvailableCourses().Where(Course => Course.SemId == Semesterid).ToList();
        }
        public static List<Course> GetDepartmentCourses(Departments department)
        {
            return Course.GetAllAvailableCourses().Where(Course => Course.Departments == department).ToList();
        }
        private static void InitializeCourse()
        {
            Course PF = new Course
            {

                CourseId = 001,
                SemId = 1,
                CourseName = "Programming Fundamentals",
                CourseType = CourseType.core,
                CreditHour = 3,
                Grade = Grade.Unassigned,
                Departments = UniversitySystem.enums.Departments.ComupterScience,

            };

            Course DS = new Course
            {
                CourseId = 002,
                SemId = 2,
                CourseName = "Data Structures",
                CourseType = CourseType.core,
                CreditHour = 4,
                Grade = Grade.Unassigned,
                Departments = Departments.ComupterScience,

            };

            Course English = new Course
            {
                CourseId = 003,
                SemId = 1,
                CourseName = "English",
                CourseType = CourseType.core,
                CreditHour = 3,
                Grade = Grade.Unassigned,
                Departments = Departments.law,

            };

            Course OS = new Course
            {
                CourseId = 004,
                SemId = 1,
                CourseName = "Operating Systems",
                CourseType = CourseType.core,
                CreditHour = 3,
                Grade = Grade.Unassigned,
                Departments = Departments.ComupterScience,

            };

            Course ITC = new Course
            {
                CourseId = 005,
                SemId = 1,
                CourseName = "Introduction to Computing",
                CourseType = CourseType.core,
                CreditHour = 3,
                Grade = Grade.Unassigned,
                Departments = Departments.ComupterScience,

            };

            Course Accounting = new Course
            {
                CourseId = 006,
                SemId = 2,
                CourseName = "Islamiat",
                CourseType = UniversitySystem.enums.CourseType.core,
                CreditHour = 3,
                Grade = Grade.Unassigned,
                Departments = Departments.Management,

            };

            Course Databases = new Course
            {
                CourseId = 007,
                SemId = 3,
                CourseName = "Databases",
                CourseType = CourseType.core,
                CreditHour = 4,
                Grade = Grade.Unassigned,
                Departments = Departments.ComupterScience,

            };

            Course OB = new Course
            {
                CourseId = 008,
                SemId = 0,
                CourseName = "Organizational Behavior",
                CourseType = CourseType.Elective,
                CreditHour = 3,
                Grade = Grade.Unassigned,
                Departments = Departments.Media,

            };

            Course ITL = new Course
            {
                CourseId = 009,
                SemId = 0,
                CourseName = "Intro to Law",
                CourseType = CourseType.Elective,
                CreditHour = 3,
                Grade = Grade.Unassigned,
                Departments = Departments.law,

            };

            Course HCI = new Course
            {
                CourseId = 010,
                SemId = 1,
                CourseName = "HCI",
                CourseType = CourseType.core,
                CreditHour = 3,
                Grade = Grade.Unassigned,
                Departments = Departments.ComupterScience,

            };

            Courses.Add(PF);
            Courses.Add(DS);
            Courses.Add(English);
            Courses.Add(ITL);
            Courses.Add(OB);
            Courses.Add(Databases);
            Courses.Add(ITC);
            Courses.Add(Accounting);
            Courses.Add(OS);
            Courses.Add(HCI);


        }
        public static void AddCourse(Course course)
        {
            if (
                Courses.Count == 0)
            {
                InitializeCourse();

            }
        }
        public static void Remove(int id)
        {
            var Rem = Courses.Find(x => x.CourseId == id);
            Courses.Remove(Rem);
        }



    }
}