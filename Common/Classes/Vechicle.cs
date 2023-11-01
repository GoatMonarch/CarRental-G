using Common.Enum;
using Common.Interface;

namespace Common.Classes;

public class Vechicle : IVechicle
{
    public string _RegNo { get; set; }
    public double _Odometer { get; set; }
    public EChassi _VechicleType { get; set; }
    public EMaker _Maker { get; set; }
    public int _Cost { get; set; }
    public int _DriveCost { get; set; }
    public int _Id { get; set; }
    public EHired _Hired { get; set; }

    //Cost is based on maker & chassi
    public int UseCost(EChassi chasi, EMaker maker) =>  ((int)chasi) + ((int)maker);
    public int DriveCost(int cost)
    {
       cost = cost / 100;
        if (cost < 0) cost = 1;
        return cost;
    }
}
