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
            // GREETING
            Console.WriteLine();
            Console.WriteLine("--------Welcome to Adidas--------");
            Console.WriteLine();

            // DECLARE
            var quantity = 1;
            double total = 0;
            string wantAgain;
            string userAddress;
            int resultOfCategoryInput;
            var categoryEnter = true;

            // DISPLAY THE CATEGORY
            while (categoryEnter)
            {
                Console.WriteLine(" CATEGORY ");
                Console.WriteLine("1. Men Shoes");
                Console.WriteLine("2. Women Shoes");
                Console.WriteLine("3. Kids Shoes");
                Console.WriteLine();
                Console.WriteLine("Enter your want:");
                resultOfCategoryInput = Convert.ToInt32(Console.ReadLine());
                // MENS SHOES
                if (resultOfCategoryInput == 1)
                {
                    Console.WriteLine("***********MENS ORIGINALS**********");
                    Console.WriteLine("  Here the new top 5 Arrivals Shoes ");
                    Console.WriteLine();
                    Console.WriteLine("====================================");
                    Console.WriteLine("1. Forum Low Cl           Php 5,500");
                    Console.WriteLine("2. Forum Low Shoes        Php 5,000");
                    Console.WriteLine("3. Super Star Shoes       Php 5,300");
                    Console.WriteLine("4. Ultraboost Light       Php 11,000");
                    Console.WriteLine("5. Supernova              Php 5,500 ");
                    Console.WriteLine("====================================");
                    Console.WriteLine();
                    // INPUTING FOR MENS SHOES
                    Console.WriteLine("Enter you want order: ");
                    int orderNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (orderNumber)
                    {
                        case 1:
                            Console.WriteLine("You choose is Forum Low Cl");
                            Console.WriteLine("The price is Php 5,500");
                            Console.WriteLine();
                            Console.WriteLine("What your address");
                            userAddress = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter the quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 5500;

                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine($"Address: {userAddress}");
                            Console.WriteLine($"total: Php {total}");

                            Console.WriteLine();
                            Console.WriteLine("Do you want to buy again?");
                            Console.WriteLine("Please press Y if yes or N if no");
                            wantAgain = Console.ReadLine();

                            if (wantAgain != "Y")
                                categoryEnter = false;
                            Console.WriteLine();
                            if (wantAgain == "N")
                            {
                                Console.WriteLine("Thank you to purchased we hope you will come back again");
                                break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("You choose is Forum Low Shoes");
                            Console.WriteLine("The price is Php 5,000");
                            Console.WriteLine();
                            Console.WriteLine("What your address");
                            userAddress = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter the quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 5000;

                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine($"Address: {userAddress}");
                            Console.WriteLine($"total: Php {total}");

                            Console.WriteLine();
                            Console.WriteLine("Do you want to buy again?");
                            Console.WriteLine("Please press Y if yes or N if no");
                            wantAgain = Console.ReadLine();

                            if (wantAgain != "Y")
                                categoryEnter = false;
                            Console.WriteLine();
                            if (wantAgain == "N")
                            {
                                Console.WriteLine("Thank you to purchased we hope you will come back again");
                                break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("You choose is Super Star Shoes");
                            Console.WriteLine("The price is Php 5,300");
                            Console.WriteLine();
                            Console.WriteLine("What your address");
                            userAddress = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter the quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 5300;

                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine($"Address: {userAddress}");
                            Console.WriteLine($"total: Php {total}");

                            Console.WriteLine();
                            Console.WriteLine("Do you want to buy again?");
                            Console.WriteLine("Please press Y if yes or N if no");
                            wantAgain = Console.ReadLine();

                            if (wantAgain != "Y")
                                categoryEnter = false;
                            Console.WriteLine();
                            if (wantAgain == "N")
                            {
                                Console.WriteLine("Thank you to purchased we hope you will come back again");
                                break;
                            }
                            break;
                        case 4:
                            Console.WriteLine("You choose is Ultraboost Light");
                            Console.WriteLine("The price is Php 11,000");
                            Console.WriteLine();
                            Console.WriteLine("What your address");
                            userAddress = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter the quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 11000;

                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine($"Address: {userAddress}");
                            Console.WriteLine($"total: Php {total}");

                            Console.WriteLine();
                            Console.WriteLine("Do you want to buy again?");
                            Console.WriteLine("Please press Y if yes or N if no");
                            wantAgain = Console.ReadLine();

                            if (wantAgain != "Y")
                                categoryEnter = false;
                            Console.WriteLine();
                            if (wantAgain == "N")
                            {
                                Console.WriteLine("Thank you to purchased we hope you will come back again");
                                break;
                            }
                            break;
                        case 5:
                            Console.WriteLine("You choose is Supernova");
                            Console.WriteLine("The price is Php 5,500");
                            Console.WriteLine();
                            Console.WriteLine("What your address");
                            userAddress = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter the quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 5500;

                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine($"Address: {userAddress}");
                            Console.WriteLine($"total: Php {total}");

                            Console.WriteLine();
                            Console.WriteLine("Do you want to buy again?");
                            Console.WriteLine("Please press Y if yes or N if no");
                            wantAgain = Console.ReadLine();

                            if (wantAgain != "Y")
                                categoryEnter = false;
                            Console.WriteLine();
                            if (wantAgain == "N")
                            {
                                Console.WriteLine("Thank you to purchased we hope you will come back again");
                                break;
                            }
                            break;
                    }
                }
                // WOMENS SHOES
                else if (resultOfCategoryInput == 2)
                {
                    Console.WriteLine("***********WOMENS ORIGINALS***********");
                    Console.WriteLine("  Here the new top 5 Arrivals Shoes   ");
                    Console.WriteLine();
                    Console.WriteLine("====================================");
                    Console.WriteLine("1. Campus 00s             Php 5,000");
                    Console.WriteLine("2. NMD S1                 Php 15,000");
                    Console.WriteLine("3. Stan Smith             Php 5,300");
                    Console.WriteLine("4. Agent Gil Restomod     Php 7,500");
                    Console.WriteLine("5. 3MC                    Php 4,500");
                    Console.WriteLine("====================================");
                    Console.WriteLine();
                    // INPUTING FOR WOMENS SHOES
                    Console.WriteLine("Enter you want order: ");
                    int orderNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (orderNumber)
                    {
                        case 1:
                            Console.WriteLine("You choose is Campus 00s");
                            Console.WriteLine("The price is Php 5,000");
                            Console.WriteLine();
                            Console.WriteLine("What your address");
                            userAddress = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter the quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 5000;

                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine($"Address: {userAddress}");
                            Console.WriteLine($"total: Php {total}");

                            Console.WriteLine();
                            Console.WriteLine("Do you want to buy again?");
                            Console.WriteLine("Please press Y if yes or N if no");
                            wantAgain = Console.ReadLine();

                            if (wantAgain != "Y")
                                categoryEnter = false;
                            Console.WriteLine();
                            if (wantAgain == "N")
                            {
                                Console.WriteLine("Thank you to purchased we hope you will come back again");
                                break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("You choose is NMD S1");
                            Console.WriteLine("The price is Php 15,000");
                            Console.WriteLine();
                            Console.WriteLine("What your address");
                            userAddress = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter the quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 15000;

                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine($"Address: {userAddress}");
                            Console.WriteLine($"total: Php {total}");

                            Console.WriteLine();
                            Console.WriteLine("Do you want to buy again?");
                            Console.WriteLine("Please press Y if yes or N if no");
                            wantAgain = Console.ReadLine();

                            if (wantAgain != "Y")
                                categoryEnter = false;
                            Console.WriteLine();
                            if (wantAgain == "N")
                            {
                                Console.WriteLine("Thank you to purchased we hope you will come back again");
                                break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("You choose is Stan Smith");
                            Console.WriteLine("The price is Php 5,300");
                            Console.WriteLine();
                            Console.WriteLine("What your address");
                            userAddress = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter the quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 5300;

                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine($"Address: {userAddress}");
                            Console.WriteLine($"total: Php {total}");

                            Console.WriteLine();
                            Console.WriteLine("Do you want to buy again?");
                            Console.WriteLine("Please press Y if yes or N if no");
                            wantAgain = Console.ReadLine();

                            if (wantAgain != "Y")
                                categoryEnter = false;
                            Console.WriteLine();
                            if (wantAgain == "N")
                            {
                                Console.WriteLine("Thank you to purchased we hope you will come back again");
                                break;
                            }
                            break;
                        case 4:
                            Console.WriteLine("You choose is Agent Gil Restomod");
                            Console.WriteLine("The price is Php 7,500");
                            Console.WriteLine();
                            Console.WriteLine("What your address");
                            userAddress = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter the quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 7500;

                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine($"Address: {userAddress}");
                            Console.WriteLine($"total: Php {total}");

                            Console.WriteLine();
                            Console.WriteLine("Do you want to buy again?");
                            Console.WriteLine("Please press Y if yes or N if no");
                            wantAgain = Console.ReadLine();

                            if (wantAgain != "Y")
                                categoryEnter = false;
                            Console.WriteLine();
                            if (wantAgain == "N")
                            {
                                Console.WriteLine("Thank you to purchased we hope you will come back again");
                                break;
                            }
                            break;
                        case 5:
                            Console.WriteLine("You choose is 3MC");
                            Console.WriteLine("The price is Php 4,500");
                            Console.WriteLine();
                            Console.WriteLine("What your address");
                            userAddress = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter the quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 4500;

                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine($"Address: {userAddress}");
                            Console.WriteLine($"total: Php {total}");

                            Console.WriteLine();
                            Console.WriteLine("Do you want to buy again?");
                            Console.WriteLine("Please press Y if yes or N if no");
                            wantAgain = Console.ReadLine();

                            if (wantAgain != "Y")
                                categoryEnter = false;
                            Console.WriteLine();
                            if (wantAgain == "N")
                            {
                                Console.WriteLine("Thank you to purchased we hope you will come back again");
                                break;
                            }
                            break;
                    }

                }
                else if (resultOfCategoryInput == 3)
                {
                    Console.WriteLine("***********KIDS ORIGINALS***********");
                    Console.WriteLine("  \nHere the new top 5 Arrivals Shoes ");

                    Console.WriteLine("===================================================");
                    Console.WriteLine("1. Grand Court Lifestyle lace            Php 2,200");
                    Console.WriteLine("2. Advantage Lifestyle Court Lace        Php 2,200");
                    Console.WriteLine("3. Tensaur Run Shoes                     Php 2,000");
                    Console.WriteLine("4. NMD 360                               Php 3,500");
                    Console.WriteLine("5. RapidaSport Bounce Lace               Php 3,000");
                    Console.WriteLine("===================================================");
                    Console.WriteLine();
                    // INPUTING FOR WOMENS SHOES
                    Console.WriteLine("Enter you want order: ");
                    int orderNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (orderNumber)
                    {
                        case 1:
                            Console.WriteLine("You choose is Grand Court Lifestyle lace");
                            Console.WriteLine("The price is Php 2,200");
                            Console.WriteLine();
                            Console.WriteLine("What your address");
                            userAddress = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter the quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 2200;

                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine($"Address: {userAddress}");
                            Console.WriteLine($"total: Php {total}");

                            Console.WriteLine();
                            Console.WriteLine("Do you want to buy again?");
                            Console.WriteLine("Please press Y if yes or N if no");
                            wantAgain = Console.ReadLine();

                            if (wantAgain != "Y")
                                categoryEnter = false;
                            Console.WriteLine();
                            if (wantAgain == "N")
                            {
                                Console.WriteLine("Thank you to purchased we hope you will come back again");
                                break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("You choose is Advantage Lifestyle Court Lace");
                            Console.WriteLine("The price is Php 2,200");
                            Console.WriteLine();
                            Console.WriteLine("What your address");
                            userAddress = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter the quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 2200;

                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine($"Address: {userAddress}");
                            Console.WriteLine($"total: Php {total}");

                            Console.WriteLine();
                            Console.WriteLine("Do you want to buy again?");
                            Console.WriteLine("Please press Y if yes or N if no");
                            wantAgain = Console.ReadLine();

                            if (wantAgain != "Y")
                                categoryEnter = false;
                            Console.WriteLine();
                            if (wantAgain == "N")
                            {
                                Console.WriteLine("Thank you to purchased we hope you will come back again");
                                break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("You choose is Tensaur Run Shoes");
                            Console.WriteLine("The price is Php 2,000");
                            Console.WriteLine();
                            Console.WriteLine("What your address");
                            userAddress = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter the quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 2000;

                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine($"Address: {userAddress}");
                            Console.WriteLine($"total: Php {total}");

                            Console.WriteLine();
                            Console.WriteLine("Do you want to buy again?");
                            Console.WriteLine("Please press Y if yes or N if no");
                            wantAgain = Console.ReadLine();

                            if (wantAgain != "Y")
                                categoryEnter = false;
                            Console.WriteLine();
                            if (wantAgain == "N")
                            {
                                Console.WriteLine("Thank you to purchased we hope you will come back again");
                                break;
                            }
                            break;
                        case 4:
                            Console.WriteLine("You choose is NMD 360");
                            Console.WriteLine("The price is Php 3,500");
                            Console.WriteLine();
                            Console.WriteLine("What your address");
                            userAddress = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter the quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 3500;

                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine($"Address: {userAddress}");
                            Console.WriteLine($"total: Php {total}");

                            Console.WriteLine();
                            Console.WriteLine("Do you want to buy again?");
                            Console.WriteLine("Please press Y if yes or N if no");
                            wantAgain = Console.ReadLine();

                            if (wantAgain != "Y")
                                categoryEnter = false;
                            Console.WriteLine();
                            if (wantAgain == "N")
                            {
                                Console.WriteLine("Thank you to purchased we hope you will come back again");
                                break;
                            }
                            break;
                        case 5:
                            Console.WriteLine("You choose is RapidaSport Bounce Lace");
                            Console.WriteLine("The price is Php 3,000");
                            Console.WriteLine();
                            Console.WriteLine("What your address");
                            userAddress = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter the quantity");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            total = quantity * 3000;

                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine($"Address: {userAddress}");
                            Console.WriteLine($"total: Php {total}");

                            Console.WriteLine();
                            Console.WriteLine("Do you want to buy again?");
                            Console.WriteLine("Please press Y if yes or N if no");
                            wantAgain = Console.ReadLine();

                            if (wantAgain != "Y")
                                categoryEnter = false;
                            Console.WriteLine();
                            if (wantAgain == "N")
                            {
                                Console.WriteLine("Thank you to purchased we hope you will come back again");
                                break;
                            }
                            break;
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