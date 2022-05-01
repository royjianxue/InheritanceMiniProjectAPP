using System;

namespace InheritanceMiniProject
{
    public class Excavator : InventoryItemModel, IRentable
    {
        public void Dig()
        {
            Console.WriteLine("I am digging!");
        }

        public void Rent()
        {
            QuantityInstock -= 1;
            Console.WriteLine("This excavator has been rented.");
        }

        public void ReturnRental()
        {
            QuantityInstock += 1;
            Console.WriteLine("The excavator has been returned.");
        }
    }



}
