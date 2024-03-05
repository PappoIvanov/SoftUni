//using System;

//namespace _04.TouristShop
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            decimal budget = decimal.Parse(Console.ReadLine());
//            string product = Console.ReadLine();
//            int productsCounter = 0;
//            decimal sumOfProducts = 0;
//            //bool productTooExpensive = false;

//            while (product != "Stop")
//            {
//                decimal priceOfProduct = decimal.Parse(Console.ReadLine());

//                if (priceOfProduct > budget)
//                {
//                    Console.WriteLine("You don't have enough money!");
//                    Console.WriteLine($"You need {priceOfProduct - budget:f2} leva!");
//                    return;
//                }
//                productsCounter++;
//                if (productsCounter % 3 == 0)
//                {
//                    priceOfProduct *= 0.50m;
//                }
//                budget -= priceOfProduct;
//                sumOfProducts += priceOfProduct;


//              product = Console.ReadLine();
//            }

//            Console.WriteLine($"You bought {productsCounter} products for {sumOfProducts:f2} leva.");
//        }
//    }
//}


using System;

namespace _04.TouristShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int productsCounter = 0;
            double sumOfProducts = 0;
            bool productTooExpensive = false;
            bool productIsStop = false;
            double priceOfProduct = 0;

            while (true)
            {
                string product = Console.ReadLine();
                if (product == "Stop") { productIsStop = true; break; }

                priceOfProduct = double.Parse(Console.ReadLine());

                if (priceOfProduct > budget)
                {
                    productTooExpensive = true;
                    break;
                }
                productsCounter++;
                if (productsCounter % 3 == 0)
                {
                    priceOfProduct *= 0.50;
                }
                budget -= priceOfProduct;
                sumOfProducts += priceOfProduct;
            }

            if (productIsStop)
            {
                Console.WriteLine($"You bought {productsCounter} products for {sumOfProducts:f2} leva.");
            }
            else if (productTooExpensive)
            {
                Console.WriteLine("You don't have enough money!");
                Console.WriteLine($"You need {priceOfProduct - budget:f2} leva!");
            }
        }
    }
}