using Common.Enum;
using Common.Interface;

namespace Common.Classes;

public class Motorcycle : Vechicle
{
    

    //Dif from Car: Chassi is known
    public Motorcycle(string regNo, double odoM, EMaker maker, EHired hired)
    {
        _RegNo = regNo;
        _Odometer = odoM;
        _VechicleType = EChassi.Motorcycle;
        _Maker = maker;
        _Cost = UseCost(EChassi.Motorcycle, maker);
        _Id = 0;
        _Hired = hired;
    }
}
