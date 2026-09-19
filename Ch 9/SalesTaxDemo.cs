using System;
using static System.Console;
using System.Globalization;
class SalesTaxDemo
{
    public static void Main()
    {
        Sale[] itemsArray = new Sale[10];


        for (int i = 0; i < itemsArray.Length; ++i)
        {
            Write("Enter inventory number #" + (i + 1) + " >> ");
            itemsArray[i] = new Sale();
            itemsArray[i].InventoryNumber = ReadLine();
            Write("Enter amount of sale >> ");
            itemsArray[i].Amount = Convert.ToDouble(ReadLine());
            
        }

        for (int i = 0; i < itemsArray.Length; ++i)
        {
            WriteLine("Sale # " + (i + 1) + " Amount: " + itemsArray[i].InventoryNumber + " Sale " + 
                itemsArray[i].Amount.ToString("C", CultureInfo.GetCultureInfo("en-US")));
            WriteLine("     Tax is " + (itemsArray[i].Tax.ToString("C", CultureInfo.GetCultureInfo("en-US"))));
        }

    }

    class Sale
    {
        private double tax;
        private double amount;
        private string inventoryNumber;

        public string InventoryNumber { get; set; }
        public double Amount { get; set; }

        public double Tax
        {
            get
            {
                if (Amount <= 100)
                    tax = 0.08;
                else
                    tax = 0.06;

                return tax * Amount;
            }

        }

    }
}