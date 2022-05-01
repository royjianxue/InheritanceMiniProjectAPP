using System;

namespace InheritanceMiniProject
{
    public class VehicleModel : InventoryItemModel, IPurchasable, IRentable
    {
        public decimal DealerFee { get; set; }

        public void Purchase()
        {
            QuantityInstock -= 1;
            Console.WriteLine("This vehicle has been puchased.");
        }
        public void Rent()
        {
            QuantityInstock -= 1;
            Console.WriteLine("Yhis vehicle has been rented.");
        }

        public void ReturnRental()
        {
            QuantityInstock -= 1;
            Console.WriteLine("This vehicle has been returned.");
        }
    }



}
