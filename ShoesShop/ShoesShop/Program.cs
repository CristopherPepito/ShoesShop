using System;


// Cristopher Pepito
// BSCpE 1-1
// Welcome to Adidas

namespace AdidasOrdringShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greeting
            Console.WriteLine();
            Console.WriteLine("--------Welcome to Adidas--------");
            Console.WriteLine();

            // Declare
            int quantity = 1;
            double total = 0;
            string wantAgain;
            string yourAddress;
            bool userInput = true;

            // Display the all Arrivals top 5 Shoes
            while (userInput)
            {
                Console.WriteLine("  Here the new top 5 Arrivals Shoes  ");
                Console.WriteLine();
                Console.WriteLine("====================================");
                Console.WriteLine("1. Forum Low Cl           Php 5,500" );
                Console.WriteLine("2. Forum Low Shoes        Php 5,000" );
                Console.WriteLine("3. Super Star Shoes       Php 5,300" );
                Console.WriteLine("4. Ultraboost Light       Php 11,000");
                Console.WriteLine("5. Supernova              Php 5,500 ");
                Console.WriteLine("====================================");
                Console.WriteLine();
             // Inputing 
                Console.WriteLine("Enter you want order: ");
                int orderNumber = Convert.ToInt32( Console.ReadLine() );
                Console.WriteLine();

                // Condition 
                if ( orderNumber == 1 ) 
                {
                    Console.WriteLine("You choose is Forum Low Cl");
                    Console.WriteLine("The price is Php 5,500");
                    Console.WriteLine();
                    Console.WriteLine("What your address");
                    yourAddress = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32( Console.ReadLine() );
                    total = quantity * 5500;

                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Address: " + yourAddress);
                    Console.WriteLine("total: Php " + total);
                    
                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no");
                    wantAgain = Console.ReadLine(); 

                    if (wantAgain != "Y")
                        userInput = false;
                        Console.WriteLine();
                    if (wantAgain == "N")
                    {
                        Console.WriteLine("Thank you to purchased we hope you will come back again");
                    }


                }
                else if (orderNumber == 2 ) 
                {
                    Console.WriteLine("You choose is Forum Low Shoes");
                    Console.WriteLine("The prics Php 5,000");
                    Console.WriteLine();
                    Console.WriteLine("What your address");
                    yourAddress = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total = quantity * 5000;

                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Address: " + yourAddress);
                    Console.WriteLine("total: Php " + total);

                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no");
                    wantAgain = Console.ReadLine();

                    if (wantAgain != "Y")
                        userInput = false;
                    Console.WriteLine();
                    if (wantAgain == "N")
                    {
                        Console.WriteLine("Thank you to purchased we hope you will come back again");
                    }
                }
                else if ( orderNumber == 3 ) 
                {
                    Console.WriteLine("You choose is Super Star Shoes");
                    Console.WriteLine("The price is Php 5,300");
                    Console.WriteLine();
                    Console.WriteLine("What your address");
                    yourAddress = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total = quantity * 5300;

                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Address: " + yourAddress);
                    Console.WriteLine("total: Php " + total);

                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no");
                    wantAgain = Console.ReadLine();

                    if (wantAgain != "Y")
                        userInput = false;
                    Console.WriteLine();
                    if (wantAgain == "N")
                    {
                        Console.WriteLine("Thank you to purchased we hope you will come back again");
                    }
                } 
                else if (orderNumber == 4 ) 
                {
                    Console.WriteLine("You choose is Ultraboost Light");
                    Console.WriteLine("The price is Php 11,000");
                    Console.WriteLine();
                    Console.WriteLine("What your address");
                    yourAddress = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total = quantity * 11000;

                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Address: " + yourAddress);
                    Console.WriteLine("total: Php " + total);

                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no");
                    wantAgain = Console.ReadLine();

                    if (wantAgain != "Y")
                        userInput = false;
                    Console.WriteLine();
                    if (wantAgain == "N")
                    {
                        Console.WriteLine("Thank you to purchased we hope you will come back again");
                    }
                }
                else if (orderNumber == 5) 
                {
                    Console.WriteLine("You choose is Supernova");
                    Console.WriteLine("The price is Php 5,500");
                    Console.WriteLine();
                    Console.WriteLine("What your address");
                    yourAddress = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    total = quantity * 5500;

                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Address: " + yourAddress);
                    Console.WriteLine("total: Php " + total);

                    Console.WriteLine();
                    Console.WriteLine("Do you want to buy again?");
                    Console.WriteLine("Please press Y if yes or N if no");
                    wantAgain = Console.ReadLine();

                    if (wantAgain != "Y")
                        userInput = false;
                    Console.WriteLine();
                    if (wantAgain == "N")
                    {
                        Console.WriteLine("Thank you to purchased we hope you will come back again");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("        Invalid       ");
                    Console.WriteLine("    Please try again  ");
                    Console.WriteLine();
                }

            }
        }
        
    }
}