namespace Ex3;

public class Quadrilatero : Figura
{
    public Quadrilatero(double a, double b) : base (a,b){ }
    
    public double area(){
        valorArea = valorAltura * valorLado;
        return valorArea;
    }
}
