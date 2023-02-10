using UniversitySystem.enums; 
namespace UniversitySystem;

public class Assessment
{
    public Assessment(int assesmentID, string assesmentName, assessmentType assesmentType, double totalMarks1, int v, double weightage1)
    {
    }

    public int ASSESSMENT_ID { get; set; }
    public string AssessmentName { get; set; }
    public assessmentType assessmentType { get; set; }
    public decimal totalMarks { get; set; }
    public decimal marksObtained { get; set; }
    public int weightage { get; set; }
​
    public decimal GetAbsoluteMarks()
    {
        decimal marks = (this.marksObtained / this.totalMarks) * weightage;
        return marks;
    }
​
​
}
​
​