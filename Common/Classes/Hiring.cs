using Common.Enum;
using Common.Interface;

namespace Common.Classes;

public class Hiring : IHiring
{
	public IVechicle _Vechicle { get; set ; }
	public IPerson _Customer { get; set; }
	public DateTime _DateHired { get; set; }
	public DateTime? _DateReturned { get; set; }
	public double? _OdometerReturned { get; set; }
	public int? _TotalCost { get; set; }

	public Hiring (IVechicle vechicle, IPerson customer)
	{
		_Vechicle = vechicle;
		_Customer = customer;
		_DateHired = DateTime.Now;
	}

	public void ReturnVechicle(double OdoReturn)
	{
		this._DateReturned = DateTime.Now;
		this._OdometerReturned = OdoReturn;
		TimeSpan timedif = (TimeSpan)(_DateReturned - _DateHired);
		this._TotalCost = Convert.ToInt16(timedif.Days)*_Vechicle._Cost + Convert.ToInt16((_OdometerReturned - _Vechicle._Odometer) * _Vechicle._DriveCost);
		if (timedif.Days < 1) 
			_TotalCost = _TotalCost + _Vechicle._Cost;
		
		_Vechicle._Hired = EHired.Available;
	}

}
