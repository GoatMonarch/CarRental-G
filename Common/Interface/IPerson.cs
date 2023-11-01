using System.Reflection.Metadata.Ecma335;

namespace Common.Interface;

public interface IPerson : IData
{
    int _SSN { get; set; }
    string _FName { get; set; }
    string _LName { get; set; }

    public string Identifier();
}
