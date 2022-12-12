using System;
//Порушено ЛІСКОВ ПРИНЦИП і ПРИНЦИП ВІДКРИТОСТІ/ЗАКРИТОСТІ
interface IFigure
{
    int GetArea();
}
class Rectangle: IFigure
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int GetArea()
    {
        return Width * Height;
    }
}

//квадрат наслідується від прямокутника!!!
class Square :  IFigure
{
    public int GetArea()
    {
        return Width * Width;
    }
    public int Width
    {
        get { return Width; }
        set
        {
            Width = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 5;
            rect.Height = 10;

            Console.WriteLine(rect.GetArea());
            //Відповідь 100? Що не так???
            Console.ReadKey();
        }
    }
}
