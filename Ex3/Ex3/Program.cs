namespace Ex3;

public class Program
{
    static void Main(string[] args)
    {
        Quadrilatero objFigura1 = new Quadrilatero(2, 2);
        Triangulo objFigura2 = new Triangulo(2,2);
        Trapezio objFigura3 = new Trapezio(2,2,2);

        Console.WriteLine(objFigura1.area());
        Console.WriteLine(objFigura2.area());
        Console.WriteLine(objFigura3.area());
    }
}