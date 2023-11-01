using Common.Classes;
using Common.Enum;
using Common.Interface;
using DatabaseSource.Interface;


namespace DatabaseSource.Classes;

public class Database : IDataBase
{
    readonly  List<IVechicle> _Vechicles = new List<IVechicle>();
    readonly  List<IPerson> _Persons = new List<IPerson>();
    readonly List<IHiring> _IHiring = new List<IHiring>();

    public Database() => SeedData();

    private void SeedData()
    {
        //Enum and json are kind of wonky to work with.
        //After hours of work I'd rather do this the hard way than working up a system to read a string, and correlate a number to an enum.
		//Otherwise the json files would have worked immediately.

		Car c1 = new("B52", 0.5, EChassi.Van, EMaker.Nissan, EHired.Available);
		_Vechicles.Add(c1);
		Car c2 = new("B78", 100.9, EChassi.Van, EMaker.Volvo, EHired.Available);
		_Vechicles.Add(c2);
		Car c3 = new("A90", 400.5, EChassi.SUV, EMaker.Saab, EHired.Hired);
		_Vechicles.Add(c3);
		Car c4 = new("CH2", 300.5, EChassi.Sedan, EMaker.BMW, EHired.Available);
		_Vechicles.Add(c4);
		Car c5 = new("B22", 800, EChassi.Sedan, EMaker.BMW, EHired.Hired);
		_Vechicles.Add(c5);
		Motorcycle c6 = new("H52", 600, EMaker.Saab, EHired.Available);
		_Vechicles.Add(c6);
		Motorcycle c7 = new("C24", 400, EMaker.Toyota, EHired.Available);
		_Vechicles.Add(c7);

		Customer p1 = new(123456, "Barak", "Obama");
		_Persons.Add(p1);
		Customer p2 = new(456123, "John", "Kennedy");
		_Persons.Add(p2);
		Customer p3 = new(142536, "James", "Garfield");
		_Persons.Add(p3);
		Customer p4 = new(142536, "Donald", "Trump");
		_Persons.Add(p4);
		Customer p5 = new(870456, "Abraham", "Linkon");
		_Persons.Add(p5);

		Hiring h1 = new(c3, p1);
		_IHiring.Add(h1);
		Hiring h2 = new(c5, p2);
		_IHiring.Add(h2);

		//Rather than hard coding h2 as returned, we simulate it on start up. 
		var lastHiring = _IHiring.Last();
		lastHiring.ReturnVechicle(lastHiring._Vechicle._Odometer + 1000);

		///TODO: Run a for each to grant IDs to lists.


	}
    

    public IEnumerable<IPerson> GetPerson() => _Persons;
    public IEnumerable<IVechicle> GetVechicle() => _Vechicles;
    public IEnumerable<IHiring> GetBooking() => _IHiring;

    

}
