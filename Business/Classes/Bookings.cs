using Common.Interface;
using DatabaseSource.Interface;

namespace Business.Classes;

public class Bookings
{
    IDataBase _db;
    
    public Bookings(IDataBase data) => _db = data;

    public IEnumerable<IPerson> GetPerson()
    {
        return _db.GetPerson();
    }
    public IEnumerable<IVechicle> GetVechicle()
    {
        return _db.GetVechicle();
    }
    public IEnumerable<IHiring> GetHiring() 
    {
        return _db.GetBooking();
    }
}
