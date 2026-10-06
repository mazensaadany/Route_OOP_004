namespace Route_OOP_004;
public class StandardShipment : Shipment
{
    #region constructors
    public StandardShipment(): base(string.Empty, string.Empty, 0m, 0m, default)
    {
    }

    public StandardShipment(string track, string desc, decimal w8, decimal fee, DeliveryAddress Dest) : base(track, desc, w8, fee, Dest)
    {
    }
    #endregion

    #region methods
    public override void PrintShipment()
    {
        Console.WriteLine("Standard Shipment Details:");
        base.PrintShipment();
    }
    #endregion
}

