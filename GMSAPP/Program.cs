using GMSBL;

class Program
{
    static void Main()
    {
        Dictionary<int, double> coffeePrices = new Dictionary<int, double> { { 1, 10.0 }, { 2, 0.5 } };
        GourmetCoffeeShop coffeeShop = new GourmetCoffeeShop(101, "Coffee Delight", coffeePrices);
        coffeeShop.PayPerPiece(5);
        Console.WriteLine($"Total Bill for Coffee: {coffeeShop.TotalBillValue}");
        Console.WriteLine($"Tax on Total Bill: {coffeeShop.TaxOnTotalBill()}");

        Dictionary<int, double> organicPrices = new Dictionary<int, double> { { 1, 15.0 }, { 2, 0.8 } };
        GourmetOrganicShop organicShop = new GourmetOrganicShop(102, "Organic Heaven", organicPrices);
        organicShop.PayPerWeight(10);
        Console.WriteLine($"Total Bill for Organic Items: {organicShop.TotalBillValue}");
        Console.WriteLine($"Tax on Total Bill: {organicShop.TaxOnTotalBill()}");
    }
}
