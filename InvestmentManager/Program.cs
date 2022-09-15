using Model;
using System.Collections;

Console.WriteLine("Investment Manager 3000");
Console.WriteLine();

// TODO: Instantiate House and Boat objects 
House _house = new()
{
    Description = "Et fint hus",
    Address = "Et eller andet sted",
    Condition = "Fint som sagt",
    SquareMeterPrice = 10000,
    SquareMeters = 150
};
Boat _boat = new()
{
    Condition = "Fine",
    Description = "A sailboat",
    Length = 12,
    MeterPrice = 12000,
    RegYear = 1994
};

// TODO: Add the objects to an ArrayList
//ArrayList _list = new ArrayList();
// After the interface is created, the list will look like this:
List<IInvestment> _list = new();
_list.Add(_boat);
_list.Add(_house);


// TODO: Iterate through the objects and run either Boat or House methods
// HINT: You can use the "is" operator and Type Casting
int price = 0;
string? invSummary = null;

foreach (var item in _list)
{
    //if (item is Boat)
    //{
    //    invSummary = ((Boat)item).InvestSummary();
    //    price = ((Boat)item).CalculatePrice();
    //}
    //if (item is House)
    //{
    //    invSummary = ((House)item).InvestSummary();
    //    price = ((House)item).PriceCalculate();
    //}

    // Instead of typecasting objects you should now just access the methods
    // through the interface

    invSummary = item.InvestSummary();
    price = item.PriceCalculate();

    Console.WriteLine("{0} - price: {1}", invSummary, price);
}




