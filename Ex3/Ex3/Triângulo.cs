namespace Ex3;

public class Triangulo : Figura
{
    public Triangulo(double a, double b) : base(a,  b){}
    public double area(){
        valorArea = valorAltura * valorLado / 2;
        return valorArea;
    }
}
