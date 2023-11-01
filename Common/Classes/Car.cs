using Common.Enum;

namespace Common.Classes;

public class Car : Vechicle
{
    public Car(string regNo, double odoM,EChassi chassi , EMaker maker, EHired hired)
    {
        _RegNo = regNo;
        _Odometer = odoM;
        _VechicleType = chassi;
        _Maker = maker;
        _Cost = UseCost(chassi, maker);
        _Id = 0;
        _Hired = hired;
        _DriveCost = DriveCost(_Cost);
        _Hired = hired;
    }

}
