using Common.Interface;

namespace Common.Classes;

    public class Customer : IPerson
{
    public int _Id { get; set; }
    public int _SSN { get; set; }
    public string _FName { get; set; }
    public string _LName { get; set; }
    
    public Customer(int id, int ssn, string fname, string lname) 
    {
        _Id = id;
        _SSN = ssn;
        _FName = fname;
        _LName = lname;
    }
    //Constructor for app level
    public Customer(int ssn, string fname, string lname) 
    {
        _SSN= ssn;
        _FName = fname;
        _LName = lname;
    }

    public string Identifier()
    {
        string Identity = _FName + " " + _LName + " " + _Id;
        return Identity;
    }

}
