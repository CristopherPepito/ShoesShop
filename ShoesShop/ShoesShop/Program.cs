using System;
using System.Collections.Generic;

// Cristopher Pepito
// BSCpE 1-1
// Welcome to Adidas
namespace AdidasOrdringShop
{
    class Program
    {

        static void Main(string[] args)
        {
            // GREETING
            Console.WriteLine("\n--------Welcome to Adidas--------\n");

            // DECLARE
            int resultOfCategoryInput;
            string wantAgain;
            var categoryEnter = true;

            // DISPLAY THE CATEGORY
            while (categoryEnter)
            {
                displayCategory(); // Call for category
                resultOfCategoryInput = Convert.ToInt32(Console.ReadLine());

                // MENS SHOES
                if (resultOfCategoryInput == 1)
                {
                    menShoes(); // Call for display men shoes
                    conditionForMens(); // Call Switch case
                    wantAgain = Console.ReadLine();
                    if (wantAgain != "Y")
                        categoryEnter = false;
                    Console.WriteLine();
                    if (wantAgain == "N")
                    {
                        Console.WriteLine("Thank you to purchased we hope you will come back again");
                        break;
                    }
                }
                // WOMENS SHOES
                else if (resultOfCategoryInput == 2)
                {
                    womenShoes(); // Call for display women shoes
                    conditionForWomem(); // Call Switch case
                    wantAgain = Console.ReadLine();
                    if (wantAgain != "Y")
                        categoryEnter = false;
                    Console.WriteLine();
                    if (wantAgain == "N")
                    {
                        Console.WriteLine("Thank you to purchased we hope you will come back again");
                        break;
                    }
                }
                else if (resultOfCategoryInput == 3)
                {
                    kidsShoes();
                    conditionForKids();
                    wantAgain = Console.ReadLine();
                    if (wantAgain != "Y")
                        categoryEnter = false;
                    Console.WriteLine();
                    if (wantAgain == "N")
                    {
                        Console.WriteLine("Thank you to purchased we hope you will come back again");
                        break;
                    }
                }
                else
                {
                    error();
                }

            }

        }
        // Method With List
        static void displayCategory()
        {
            var category = new List<string>()
                {" CATEGORY ",
                "1. Men Shoes",
                "2. Women Shoes",
                "3. Kids Shoes",
                "\nEnter your want: "};
            
            foreach (string i in category)
            {
                Console.WriteLine(i);
            }
        }
        static void menShoes()
        {
            var menShoes = new List<string>()
            { "\n***********MENS ORIGINALS**********",
              "  Here the new top 5 Arrivals Shoes\n  ",
              "====================================",
              "1. Forum Low Cl           Php 5,500",
              "2. Forum Low Shoes        Php 5,000",
              "3. Super Star Shoes       Php 5,300",
              "4. Ultraboost Light       Php 11,000",
              "5. Supernova              Php 5,500 ",
              "====================================\n"};

            foreach (string i in menShoes)
            {
                Console.WriteLine(i);
            }
        }
        static void conditionForMens()
        {
            var quantity = 1;
            double total = 0;
            string userSize;
            string userAddress;

            // INPUTING FOR MENS SHOES
            Console.WriteLine("Enter you want order: ");
            int orderNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (orderNumber)
            {
                case 1:
                    Console.WriteLine("You choose is Forum Low Cl");
                    Console.WriteLine("The price is Php 5,500");
                    sizeMenAndWomenShoes(); // Call Size
                    Console.WriteLine("\nEnter your size you want:");
                    userSize = Console.ReadLine();
                    Console.WriteLine("What your address");
                    userAddress = Console.ReadLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total = quantity * 5500;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"SIZE: {userSize}");
                    Console.WriteLine($"Address: {userAddress}");
                    Console.WriteLine($"total: Php {total}");

                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no");
                    break;
                case 2:
                    Console.WriteLine("You choose is Forum Low Shoes");
                    Console.WriteLine("The price is Php 5,000");
                    sizeMenAndWomenShoes(); // Call Size
                    Console.WriteLine("\nEnter your size you want:");
                    userSize = Console.ReadLine();
                    Console.WriteLine("What your address");
                    userAddress = Console.ReadLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total = quantity * 5000;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"SIZE: {userSize}");
                    Console.WriteLine($"Address: {userAddress}");
                    Console.WriteLine($"total: Php {total}");

                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no");
                    break;
                case 3:
                    Console.WriteLine("You choose is Super Star Shoes");
                    Console.WriteLine("The price is Php 5,300");
                    sizeMenAndWomenShoes(); // Call Size
                    Console.WriteLine("\nEnter your size you want:");
                    userSize = Console.ReadLine();
                    Console.WriteLine("What your address");
                    userAddress = Console.ReadLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total = quantity * 5300;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"SIZE: {userSize}");
                    Console.WriteLine($"Address: {userAddress}");
                    Console.WriteLine($"total: Php {total}");

                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no");
                    break;
                case 4:
                    Console.WriteLine("You choose is Ultraboost Light");
                    Console.WriteLine("The price is Php 11,000");
                    sizeMenAndWomenShoes(); // Call Size
                    Console.WriteLine("\nEnter your size you want:");
                    userSize = Console.ReadLine();
                    Console.WriteLine("What your address");
                    userAddress = Console.ReadLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total = quantity * 11000;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"SIZE: {userSize}");
                    Console.WriteLine($"Address: {userAddress}");
                    Console.WriteLine($"total: Php {total}");

                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no");
                    break;
                case 5:
                    Console.WriteLine("You choose is Supernova");
                    Console.WriteLine("The price is Php 5,500");
                    sizeMenAndWomenShoes(); // Call Size
                    Console.WriteLine("\nEnter your size you want:");
                    userSize = Console.ReadLine();
                    Console.WriteLine("What your address");
                    userAddress = Console.ReadLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total = quantity * 5500;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"SIZE: {userSize}");
                    Console.WriteLine($"Address: {userAddress}");
                    Console.WriteLine($"total: Php {total}");

                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no");
                    break;
            }
        }
        private static void sizeMenAndWomenShoes()
        {
            var sizeMenAndWomenShoes = new List<string>()
            {          "HERE THE SIZE AVAILABLE",
                "A. 8.7 inch","B. 8.9 inch","C. 9.0 inch",
                "D. 9.2 inch","E. 9.4 inch","F. 9.5 inch",
                "G. 9.7 inch","H. 9.8 inch","I. 10.0 inch"
            };
            foreach (string i in sizeMenAndWomenShoes)
            {  Console.WriteLine(i); }
        }
        static void womenShoes()
        {
            var womenShoes = new List<string>()
            { "***********WOMENS ORIGINALS***********",
              "  Here the new top 5 Arrivals Shoes \n",
              "====================================",
              "1. Campus 00s             Php 5,000",
              "2. NMD S1                 Php 15,000",
              "3. Stan Smith             Php 5,300",
              "4. Agent Gil Restomod     Php 7,500",
              "5. 3MC                    Php 4,500",
              "====================================\n"};

            foreach (string i in womenShoes)
            {
                Console.WriteLine(i);
            }
        }
        static void conditionForWomem()
        {
            var quantity = 1;
            double total = 0;
            string userSize;
            string userAddress;

            // INPUTING FOR WOMENS SHOES
            Console.WriteLine("Enter you want order: ");
            int orderNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (orderNumber)
            {
                case 1:
                    Console.WriteLine("You choose is Campus 00s");
                    Console.WriteLine("The price is Php 5,000");
                    sizeMenAndWomenShoes();
                    Console.WriteLine("\nEnter your size you want:");
                    userSize = Console.ReadLine();
                    Console.WriteLine("What your address");
                    userAddress = Console.ReadLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total = quantity * 5000;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"SIZE: {userSize}");
                    Console.WriteLine($"Address: {userAddress}");
                    Console.WriteLine($"total: Php {total}");

                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no");
                    break;
                case 2:
                    Console.WriteLine("You choose is NMD S1");
                    Console.WriteLine("The price is Php 15,000");
                    sizeMenAndWomenShoes();
                    Console.WriteLine("\nEnter your size you want:");
                    userSize = Console.ReadLine();
                    Console.WriteLine("What your address");
                    userAddress = Console.ReadLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total = quantity * 15000;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"SIZE: {userSize}");
                    Console.WriteLine($"Address: {userAddress}");
                    Console.WriteLine($"total: Php {total}");

                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no");
                    break;
                case 3:
                    Console.WriteLine("You choose is Stan Smith");
                    Console.WriteLine("The price is Php 5,300");
                    sizeMenAndWomenShoes();
                    Console.WriteLine("\nEnter your size you want:");
                    userSize = Console.ReadLine();
                    Console.WriteLine("What your address");
                    userAddress = Console.ReadLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total = quantity * 5300;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"SIZE: {userSize}");
                    Console.WriteLine($"Address: {userAddress}");
                    Console.WriteLine($"total: Php {total}");

                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no");
                    break;
                case 4:
                    Console.WriteLine("You choose is Agent Gil Restomod");
                    Console.WriteLine("The price is Php 7,500");
                    sizeMenAndWomenShoes();
                    Console.WriteLine("\nEnter your size you want:");
                    userSize = Console.ReadLine();
                    Console.WriteLine("What your address");
                    userAddress = Console.ReadLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total = quantity * 7500;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"SIZE: {userSize}");
                    Console.WriteLine($"Address: {userAddress}");
                    Console.WriteLine($"total: Php {total}");

                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no");
                    break;
                case 5:
                    Console.WriteLine("You choose is 3MC");
                    Console.WriteLine("The price is Php 4,500");
                    sizeMenAndWomenShoes();
                    Console.WriteLine("\nEnter your size you want:");
                    userSize = Console.ReadLine();
                    Console.WriteLine("What your address");
                    userAddress = Console.ReadLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total = quantity * 4500;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"SIZE: {userSize}");
                    Console.WriteLine($"Address: {userAddress}");
                    Console.WriteLine($"total: Php {total}");

                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no");
                    break;
            }
        }
        static void kidsShoes ()
        {
            var kidsShoes = new List<string>()
            { "***********KIDS ORIGINALS***********",
              "  Here the new top 5 Arrivals Shoes \n",
              "===================================================",
              "1. Grand Court Lifestyle lace            Php 2,200",
              "2. Advantage Lifestyle Court Lace        Php 2,200",
              "3. Tensaur Run Shoes                     Php 2,000",
              "4. NMD 360                               Php 3,500",
              "5. RapidaSport Bounce Lace               Php 3,000",
              "===================================================\n"};
            
            foreach (string i in kidsShoes)
            {
                Console.WriteLine(i);
            }
        }
        static void conditionForKids()
        {
            var quantity = 1;
            double total = 0;
            string userSize;
            string userAddress;

            // INPUTING FOR WOMENS SHOES
            Console.WriteLine("Enter you want order: ");
            int orderNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (orderNumber)
            {
                case 1:
                    Console.WriteLine("You choose is Grand Court Lifestyle lace");
                    Console.WriteLine("The price is Php 2,200");
                    sizeKids(); // Call Size
                    Console.WriteLine("\nEnter your size you want:");
                    userSize = Console.ReadLine();
                    Console.WriteLine("What your address");
                    userAddress = Console.ReadLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total = quantity * 2200;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"SIZE: {userSize}");
                    Console.WriteLine($"Address: {userAddress}");
                    Console.WriteLine($"total: Php {total}");

                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no"); 
                    break;
                case 2:
                    Console.WriteLine("You choose is Advantage Lifestyle Court Lace");
                    Console.WriteLine("The price is Php 2,200");
                    sizeKids(); // Call Size
                    Console.WriteLine("\nEnter your size you want:");
                    userSize = Console.ReadLine();
                    Console.WriteLine("What your address");
                    userAddress = Console.ReadLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total = quantity * 2200;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"SIZE: {userSize}");
                    Console.WriteLine($"Address: {userAddress}");
                    Console.WriteLine($"total: Php {total}");

                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no");
                    break;
                case 3:
                    Console.WriteLine("You choose is Tensaur Run Shoes");
                    Console.WriteLine("The price is Php 2,000");
                    sizeKids(); // Call Size
                    Console.WriteLine("\nEnter your size you want:");
                    userSize = Console.ReadLine();
                    Console.WriteLine("What your address");
                    userAddress = Console.ReadLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total = quantity * 2000;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"SIZE: {userSize}");
                    Console.WriteLine($"Address: {userAddress}");
                    Console.WriteLine($"total: Php {total}");

                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no"); 
                    break;
                case 4:
                    Console.WriteLine("You choose is NMD 360");
                    Console.WriteLine("The price is Php 3,500");
                    sizeKids(); // Call Size
                    Console.WriteLine("\nEnter your size you want:");
                    userSize = Console.ReadLine();
                    Console.WriteLine("What your address");
                    userAddress = Console.ReadLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total = quantity * 3500;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"SIZE: {userSize}");
                    Console.WriteLine($"Address: {userAddress}");
                    Console.WriteLine($"total: Php {total}");

                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no");
                    break;
                case 5:
                    Console.WriteLine("You choose is RapidaSport Bounce Lace");
                    Console.WriteLine("The price is Php 3,000");
                    sizeKids(); // Call Size
                    Console.WriteLine("\nEnter your size you want:");
                    userSize = Console.ReadLine();
                    Console.WriteLine("What your address");
                    userAddress = Console.ReadLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total = quantity * 3000;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"SIZE: {userSize}");
                    Console.WriteLine($"Address: {userAddress}");
                    Console.WriteLine($"total: Php {total}");

                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no");
                    break;
            }
        }
        static void sizeKids()
        {
            var sizeKids = new List<string>()
            {          "HERE THE SIZE AVAILABLE",
                "A. 3.2 inch","B. 3.5 inch","C. 3.9 inch",
                "D. 4.2 inch","E. 4.5 inch","F. 4.9 inch",
                "G. 5.2 inch","H. 5.5 inch","I. 5.9 inch"
            };
            foreach (string i in sizeKids)
            { Console.WriteLine(i); }
        }
        static void error()
        {
            Console.WriteLine("\n        Invalid       ");
            Console.WriteLine("    Please try again  \n");
        }
 
    }
}