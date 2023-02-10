
using UniversitySystem.enums;
namespace UniversitySystem
{
    public class Person
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string adress { get; set; }
        public string Email { get; set; }
        public string phone { get; set; }
        public Univeristy univeristy { get; set; }
        public Gender Gender { get; set; }
        public DateOnly DOB { get; set; }
    }
}