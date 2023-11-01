using Common.Enum;

namespace Common.Interface;

public interface IVechicle : IData
{
    string _RegNo { get; set; }
    double _Odometer { get; set; }
    EChassi _VechicleType { get; set; }
    EMaker _Maker { get; set; }
    int _Cost { get; set; }
    int _DriveCost { get; set; }
    EHired _Hired { get; set; }

    public int UseCost(EChassi chasi, EMaker maker);
    
    

}
