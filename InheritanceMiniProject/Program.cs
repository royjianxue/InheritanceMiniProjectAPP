using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<InventoryItemModel> inventory = new List<InventoryItemModel>();
            List<IRentable> rentables = new List<IRentable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Honda Accord"};
            var book = new BookModel {ProductName = "A Tale of Two Cities", NumberOfPages = 350 };
            var excavator = new Excavator { ProductName = "Bulldozer", QuantityInstock = 2};

            rentables.Add(vehicle);
            rentables.Add(excavator);
            purchasables.Add(book);
            purchasables.Add(vehicle);

            Console.Write("Do you want to rent or purchase: ");
            string rentalDecision = Console.ReadLine();

            if (rentalDecision.ToLower() == "rent")
            {
                foreach (var item in rentables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to rent this item(y/n): ");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() == "y")
                    {
                        item.Rent();
                    }
                    Console.Write("Do you want to return this item(y/n): ");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "y")
                    {
                        item.ReturnRental();
                    }
                }
            }

            else
            {
                foreach (var item in purchasables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.WriteLine("Do you want to purchase this product(y/n): ");
                    string wantToPurchase = Console.ReadLine();

                    if (wantToPurchase.ToLower() == "y")
                    {
                        item.Purchase();
                    }  
                }
            }

            Console.WriteLine("We are done.");
            Console.ReadLine();

        }
    }

}
