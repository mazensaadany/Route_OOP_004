namespace Route_OOP_004;
public class ExpressShipment:Shipment
{

    private decimal extraFee;

    #region constructors
    public ExpressShipment(): base(string.Empty, string.Empty, 0m, 0m, default)
    {
    }

    public ExpressShipment(string track, string desc, decimal w8, decimal fee, DeliveryAddress Dest,decimal exFee) : base(track, desc,w8,fee,Dest)
    {
        ExtraFee = exFee;
    }
    #endregion

    #region properties
    public decimal ExtraFee 
    {
        get
        {
            ExtraFee = extraFee;
            return ExtraFee;
        }

        set
        {
            if(value >= 0) 
                ExtraFee = value;
        }
    }

    public override decimal EstimatedCost
    {
        get { return DeliveryFee + (Weight * 5)+ExtraFee; }

    }
    #endregion

    #region methods
    public override void PrintShipment()
    {
        Console.WriteLine("Express Shipment Details:");
        base.PrintShipment();
        Console.WriteLine($"Extra Fee: {ExtraFee:C}");
    }
    #endregion
}