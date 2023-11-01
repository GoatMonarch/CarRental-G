namespace Common.Interface;

public interface IHiring
{
	 IVechicle _Vechicle { get; set; }
	 IPerson _Customer { get; set; }
	 DateTime _DateHired { get; set; }
	 DateTime? _DateReturned { get; set; }
	double? _OdometerReturned { get; set; }
	int? _TotalCost { get; set; }

	public void ReturnVechicle(double OdoReturn);
}
