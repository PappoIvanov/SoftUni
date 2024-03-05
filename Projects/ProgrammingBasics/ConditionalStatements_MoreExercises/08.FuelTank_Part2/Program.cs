//  Бензин – 2.22 лева за един литър, 
//  Дизел – 2.33 лева за един литър
//  Газ – 0.93 лева за литър

string typeOfFule = Console.ReadLine();
double volumeOfFuel = double.Parse(Console.ReadLine());
string clubCart = Console.ReadLine();

double gasolinePrice = 2.22;
double dieselPrice = 2.33;
double gasPrice = 0.93;
double price = 0;
double gasolinePriceWithVolume = 2.22 * volumeOfFuel;
double dieselPriceWithVolume = 2.33 * volumeOfFuel;
double gasPriceWithVolume = 0.93 * volumeOfFuel;

switch (clubCart)
{
    case "Yes": 
        if (typeOfFule == "Gasoline")
        {
            price = (gasolinePrice - 0.18) * volumeOfFuel;
            if (volumeOfFuel >= 20 && volumeOfFuel <= 25)
            {
                price *= 0.92;
            }
            else if (volumeOfFuel > 25)
            {
                price *= 0.90;
            }
        }
        else if (typeOfFule == "Diesel")
            {
                price = (dieselPrice - 0.12) * volumeOfFuel;
                if (volumeOfFuel >= 20 && volumeOfFuel <= 25)
                {
                    price *= 0.92;
                }
                else if (volumeOfFuel > 25)
                {
                    price *= 0.90;
                }
            }
        else if (typeOfFule == "Gas")
            {
                price = (gasPrice - 0.08) * volumeOfFuel;
                if (volumeOfFuel >= 20 && volumeOfFuel <= 25)
                {
                    price *= 0.92;
                }
                else if (volumeOfFuel > 25)
                {
                    price *= 0.90;
                }
            }
        break;
    case "No": 
        switch (typeOfFule)
        {
            case "Gasoline":
                if (volumeOfFuel < 20)
                {
                    price = gasolinePriceWithVolume;
                }
                else if (volumeOfFuel >= 20 && volumeOfFuel <= 25)
                {
                    price = gasolinePriceWithVolume * 0.92;
                }
                else if (volumeOfFuel > 25)
                {
                    price = gasolinePriceWithVolume * 0.9;
                }
                break;
            case "Diesel":
                if (volumeOfFuel < 20)
                {
                    price = dieselPriceWithVolume;
                }
                else if (volumeOfFuel >= 20 && volumeOfFuel <= 25)
                {
                    price = dieselPriceWithVolume * 0.92;
                }
                else if (volumeOfFuel > 25)
                {
                    price = dieselPriceWithVolume * 0.9;
                }
                break;
            case "Gas":
                if (volumeOfFuel < 20)
                {
                    price = gasPriceWithVolume;
                }
                else if (volumeOfFuel >= 20 && volumeOfFuel <= 25)
                {
                    price = gasPriceWithVolume * 0.92;
                }
                else if (volumeOfFuel > 25)
                {
                    price = gasPriceWithVolume * 0.9;
                }
                break;
        }
        break;
}

Console.WriteLine($"{price:f2} lv.");