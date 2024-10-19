namespace STUDY.CSharp;

public class PhoneBook
{
    
    public Dictionary<int, string> phoneBook = new();
    
    public string this[int number]
    {
        get
        {
            return phoneBook.ContainsKey(number) ? phoneBook[number] : "Not Found";
        }
        set
        {
            phoneBook[number]= value;
        }
    }

    public int this[string name]
    {
        get
        {
            return  phoneBook.FirstOrDefault(x => x.Value == name).Key;
        }
        set
        {
            
            var myKey = phoneBook.FirstOrDefault(x => x.Value == name).Key;
            if (!phoneBook.ContainsKey(myKey))
            {
                phoneBook.Add(value,name);
            }
            else
            {
                var myValue = phoneBook?[myKey];
                phoneBook.Remove(myKey);
                phoneBook.Add(myKey, myValue);
            }
        }
    }

    public void Display()
    {
        for (int i = 0; i < phoneBook.Count; i++)
        {
            Console.WriteLine(phoneBook.ElementAt(i));
        }
    }
}