namespace Route_OOP_004;
internal class DeliveryReport
{
    #region methods
    public void PrintShipment(ITrackable shipment)
    {
        Console.WriteLine($"Tracking Status: {shipment.GetTrackingStatus()}");
        Console.WriteLine("================================");
    }

    public void PrintInsurance(IInsurable shipment)
    {
        Console.WriteLine(shipment.CalculateInsurance());
    }
    #endregion
}
