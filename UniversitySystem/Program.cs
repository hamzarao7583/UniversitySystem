using UniversitySystem;
using UniversitySystem.enums;

namespace University
{
    public class Program
    {
        public static void initializeStudent()
        {
            Student Hamza = new Student()
            {
                ID = 1,
                name = "Hamza",
                Email = "hamzarao7583@gmail",
                adress = "Lahore",
                Gender = Gender.Male,
                phone = "03214967583",
                DOB = new DateOnly(2000, 01, 19),
                univeristy = Univeristy.UCP,
                studentID = 001,
                Batch = new DateOnly(2018, 03, 08),
                IsLegacy = true,
                EarnCreditcHours = 0,
                semester = new List<Semester>()
            };

            Hamza.Registersemester(semesterType.fall);

            Student Usama = new Student()
            {
                ID = 2,
                name = "Usama",
                Email = "usamarao53@gmail",
                adress = "Lahore",
                Gender = Gender.Male,
                phone = "03224836533",
                DOB = new DateOnly(1999, 07, 2),
                univeristy = Univeristy.Fast,
                studentID = 002,
                Batch = new DateOnly(2018, 01, 01),
                IsLegacy = true,
                EarnCreditcHours = 0,
                semester = new List<Semester>()
            };

            Usama.Registersemester(semesterType.fall);

            Faculty Mohsin = new Faculty
            {
                name = "Mohsin",
                Email = "Mohsin@gmail",
                phone = "03234986051",
                facultyID = 001,
                departments = Departments.ComupterScience,
                cabinNo = 10,
                facultyType = facultyType.permanent,
                facultyDesignation = facultyDesignation.Lecturer,

            };
            Faculty Abbas = new Faculty
            {
                name = "Abbas",
                Email = "abbas@gmail.com",
                phone = "03245659901",
                facultyID = 002,
                departments = Departments.Pharmacy,
                cabinNo = 15,
                facultyType = facultyType.permanent,
                facultyDesignation = facultyDesignation.Lecturer,

            };

            List<Student> Students = new List<Student>();

            Students.Add(Hamza);

            Students.Add(Usama);

            Mohsin.AddAssessment(Students, 1, assessmentType.assignment , "Practice Quiz 1", 20, 0 , 0);


            Assessment quiz1 = new Assessment(1, "Quiz 1", assessmentType.quiz, 10, 0, 15);

            Assessment quiz2 = new Assessment(2, "Quiz 2", assessmentType.quiz, 10, 0, 15);

            Assessment quiz3 = new Assessment(3, "Quiz 3", assessmentType.quiz, 10, 0, 15);

            Assessment assignment1 = new Assessment(4, "Assignment 1", assessmentType.assignment, 10, 0, 15);

            Assessment assignment2 = new Assessment(5, "Assignment 2", assessmentType.assignment, 10, 0, 15);

            Assessment assignment3 = new Assessment(6, "Assignment 3", assessmentType.assignment, 10, 0, 15);

            Assessment mid = new Assessment(7, "Mid", assessmentType.mid , 100, 0, 30);

            Assessment final = new Assessment(8, "Final", assessmentType.final, 100, 0, 40);





        }
        public static void Main(string[] args)
        {
            Program.initializeStudent();

        }
       
    }
}