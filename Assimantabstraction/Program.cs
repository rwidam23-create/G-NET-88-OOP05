using Assimantabstraction.Interfaces;

namespace Assimantabstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            #region(a)
            //Abstraction:hide the complex internal implementation details of something
            //and expose only the essential features relevant to the user
            #endregion
            #region(b)
            //reduces complexity and makes code easier to understand and use
            //It doesn't allow the high-level tier to interact with the low-level tier.
            #endregion

            #endregion

            #region Question02
            #region(a)
            //interface:static Method/No fields/public only/implementation multiable interface/No constructor/Extention
            //Abstract:concret Method/Have fielda/Any access modifier/inhertience/have constructor
            #endregion
            #region(b)
            //when you have unrelated classes that need to guarantee a certain capability or behavior
            #endregion
            #region(c)
            //No/because it One parent only
            //yes
            #endregion

            #endregion


            #region part02
            //Console.WriteLine("=====================================");
            //Console.WriteLine("Delivery Center");
            //Console.WriteLine("======================================");

            //Console.WriteLine("Standard Shipment");
            //Console.WriteLine();
            //DeliveryAddress add = new DeliveryAddress("Cairo", "Elharam", 10);
            //StandardShipment st=new StandardShipment("SH001","Laptop",3,80,add);
            //st.PrintShipment();
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("Express Shipment");
            //Console.WriteLine();
            //ExpressShipment ex = new ExpressShipment("SH002", "phone", 2, 60, add,30);
            //ex.PrintShipment();
            //Console.WriteLine("-------------------------------------------");
            //InternationalShipment inter = new InternationalShipment("SH003", "Television", 8, 120, add, "Germany", 100);
            //inter.PrintShipment();
            //Console.WriteLine("==========================================");
            //Console.WriteLine("Tracking Status");
            //Console.WriteLine();
            //ITrackable[] track ={
            //    new StandardShipment("SH001","Laptop",3,80,add),
            //    new ExpressShipment("SH002", "phone", 2, 60, add,30),
            //    new InternationalShipment("SH003", "Television", 8, 120, add, "Germany", 100)
            //};
            //foreach(ITrackable tr in track)
            //{
            //    Console.WriteLine(tr.GetTrackingStatus());
            //}
            //Console.WriteLine("==============================================");
            //Console.WriteLine("Insurance");
            //Console.WriteLine();
            //IInsurable[] insur =
            //{
            //     new StandardShipment("SH001","Laptop",3,80,add),
            //    new ExpressShipment("SH002", "phone", 2, 60, add,30),
            //    new InternationalShipment("SH003", "Television", 8, 120, add, "Germany", 100)
            //};
            //foreach (IInsurable ins in insur)
            //{
            //    Console.WriteLine(ins.CalculateInsurance());
            //}

            //Console.WriteLine("=====================================");
            //Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
            //Console.WriteLine("======================================");
                
            #endregion
        }
    }
}
