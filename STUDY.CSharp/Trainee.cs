namespace STUDY.CSharp;

public class Trainee: Person, IComparer<Trainee>, IPayable
{
    public string? Nid { get; set; }
    public int IntakeNumber { get; set; }
    public double Salary { get; private set; }

    public Trainee() { }

    public Trainee(string? nid, int intakeNumber, double salary)
    {
        Nid = nid;
        IntakeNumber = intakeNumber;
        Salary = salary;
    }
    public override string ToString()
    {
        return $"Nid: {Nid}, Intake Number: {IntakeNumber}";
    }
    
    public void ShowPayment()
    {
        Console.WriteLine($"Salary: {Salary}");
    }

    public int Compare(Trainee t1, Trainee t2)
    {
        return t1.Nid.CompareTo(t2.Nid); 
    }
    
    public void Print()
    {
            Console.WriteLine($"Nid: {Nid}, IntakeNumber: {IntakeNumber}, Salary: {Salary}");

    }
}