namespace STUDY.CSharp;

public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }

    public static string GetType(Person person)
    {
        return $"{person.GetType()}";
    }
}