using OOP_Task5;

internal class Program
{
    private static void Main(string[] args)
    {
        Phones electronics = new IPhone();
        Phones electronics1 = new Samsung();
        Phones electronics2 = new Xiaomi();

        IPhone iphone = (IPhone)electronics;
        iphone.ProductModel = "Iphone 6s";
        iphone.ProductCountry = "USA";
        iphone.ProductCost = 1500;
        iphone.ProductYear = 2015;
        iphone.IsNew = true;
        iphone.ScreenSize = 5.5;
        iphone.Ram = 4;
        iphone.OperationSystem = "IOS";
        iphone.Hdd = 512;
        iphone.GetElectronics();

        Samsung samsung = (Samsung)electronics1;
        samsung.ProductModel = "Galaxy S9";
        samsung.ProductCountry = "South Korea";
        samsung.ProductCost = 1200;
        samsung.ProductYear = 2017;
        samsung.IsNew = true;
        samsung.ScreenSize = 6.5;
        samsung.Ram = 8;
        samsung.OperationSystem = "Android";
        samsung.Hdd = 256;
        samsung.GetElectronics();

        Xiaomi xiaomi = (Xiaomi)electronics2;
        xiaomi.ProductModel = "Xiaomi 13";
        xiaomi.ProductCountry = "China";
        xiaomi.ProductCost = 1800;
        xiaomi.ProductYear = 2022;
        xiaomi.IsNew = true;
        xiaomi.ScreenSize = 6.7;
        xiaomi.Ram = 12;
        xiaomi.OperationSystem = "Android";
        xiaomi.Hdd = 256;
        xiaomi.GetElectronics();
        Console.ReadLine();
    }

}