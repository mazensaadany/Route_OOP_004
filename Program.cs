namespace Route_OOP_004;
internal class Program
{
    static void Main(string[] args)
    {
        #region theorical ans 1
        //Abstraction: a concept of hiding the complex implementation
        //details and showing only the essential features of an object
        //In C#, abstraction can be achieved using abstract classes and interfaces
        //******************************************//

        // bc it makes big projects more simple and easier to manage
        #endregion

        #region theorical ans 2
        //abstract class: a class that cannot be instantiated and is meant to be inherited by other classes.
        //It can contain abstract methods (without implementation) and concrete methods (with implementation).
        //-----------------------------------------------//
        //interface: a contract that defines a set of methods and properties that a class must implement.

        //************************************************//

        // choose interface when you want to define a contract that multiple classes can implement.

        //************************************************//

        // NO, in C# class cannot inherit from multiple classes,
        // but it can implement multiple interfaces.
        #endregion
        //////////////////////////////////////////////
        // Practical part //

        #region ans a:e
        StandardShipment STshipment = new StandardShipment();
        ExpressShipment EXshipment = new ExpressShipment();
        InternationalShipment INshipment = new InternationalShipment();

        DeliveryCenter center = new DeliveryCenter();
        center.AddShipment(EXshipment);
        center.AddShipment(INshipment);
        center.AddShipment(STshipment);

        center.PrintAllShipments();
        #endregion

        #region f,g
        center.PrintTrackingStatus();
        center.PrintInsurance();
        #endregion

        #region h

        #endregion
    }
}

