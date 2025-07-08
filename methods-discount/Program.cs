Console.WriteLine("Въведи цена:");
double price = double.Parse(Console.ReadLine());
Console.WriteLine("Въведи отстъпка %:");
double discount = double.Parse(Console.ReadLine());
Console.WriteLine($"Крайна цена:{GetDiscountPrice(price,discount):f2} ");
Console.WriteLine($"Спестяваш:{price - GetDiscountPrice(price, discount):f2}");
 double GetDiscountPrice(double price,double discount)
{
    double percent = discount / 100;
    return price-(price*percent);
}
