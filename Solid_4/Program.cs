using System;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/

interface IItem
{
    void SetPrice(double price);
}
 
interface IDicountedItem
{
    void ApplyDiscount(String discount);
}
interface IPromocodedItem
{
    void ApplyPromocode(String promocode);
}
interface IColoredItem
{
    void SetColor(byte color);
}
interface ISizedItem
{
    void SetSize(byte size);
}
class book: IItem, IDicountedItem
{
    double Price { get; set; }
    string Discount { get; set; }
    
    void IItem.SetPrice(double price)
    {
        Price = price;
    }

    void IDicountedItem.ApplyDiscount(string discount)
    {
        Discount = discount;
    }
}
class Wear: IItem, IDicountedItem, IColoredItem, ISizedItem
{
    byte Color { get; set; }
    byte Size { get; set; }
    string Discount { get; set; }
    double Price { get; set; }

    public void ApplyDiscount(string discount)
    {
        Discount = discount;
    }

    public void SetColor(byte color)
    {
        Color = color;
    }

    public void SetPrice(double price)
    {
        Price = price;
    }

    public void SetSize(byte size)
    {
        Size = size;
    }
}
class Program
{
    static void Main(string[] args)
    {
       
        Console.ReadKey();
    }
}