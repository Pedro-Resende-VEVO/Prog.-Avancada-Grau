namespace Ex._1;

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        // Testando operações matemáticas
        Console.WriteLine("Soma: " + calculator.add());
        Console.WriteLine("Subtração: " + calculator.subtract());
        Console.WriteLine("Multiplicação: " + calculator.multiply());
        Console.WriteLine("Divisão: " + calculator.divide());

        // Testando número primo
        Console.WriteLine("É primo? " + calculator.isPrime());

    }
}