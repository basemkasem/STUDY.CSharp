namespace STUDY.CSharp;

public class Trainee: Person
{
    public string? Nid { get; set; }
    public int IntakeNumber { get; set; }

    public override string ToString()
    {
        return $"Nid: {Nid}, Intake Number: {IntakeNumber}";
    }
}