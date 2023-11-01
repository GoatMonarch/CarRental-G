using Common.Interface;

namespace DatabaseSource.Interface;

public interface IDataBase
{
    IEnumerable<IPerson> GetPerson();
    IEnumerable<IVechicle> GetVechicle();
    IEnumerable<IHiring> GetBooking();
}
