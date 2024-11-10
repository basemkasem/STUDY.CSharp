namespace STUDY.CSharp;

public class PhoneBook
{

    private Dictionary<string, int> _phoneBook;

    public PhoneBook()
    {
        _phoneBook = new();
    }
    
    public int this[string name]
    {
        get => _phoneBook.ContainsKey(name) ? _phoneBook[name] : throw new KeyNotFoundException();
        set
        {
            if (_phoneBook.ContainsKey(name))
                _phoneBook[name]= value;
            else 
                throw new KeyNotFoundException();
        }
    }

    public string this[int number]
    {
        get
        {
            return _phoneBook.FirstOrDefault(x => x.Value == number).Key;
        }
        set
        {
            var myKey = _phoneBook.FirstOrDefault(x => x.Value == number).Key;
            if (!_phoneBook.ContainsKey(myKey))
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                var myValue = _phoneBook[myKey];
                _phoneBook.Remove(myKey);
                _phoneBook.Add(value, myValue);
            }
        }
    }

    public void Add(string name, int number)
    {
        _phoneBook.Add(name, number);
    }
    public void Display()
    {
        for (int i = 0; i < _phoneBook.Count; i++)
        {
            Console.WriteLine(_phoneBook.ElementAt(i));
        }
    }
}