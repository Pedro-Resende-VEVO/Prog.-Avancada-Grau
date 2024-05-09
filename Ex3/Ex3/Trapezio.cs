namespace Ex3;

public class Trapezio : Figura
{
    private double valorBaseMenor;

    private double valorBaseMaior;

    public Trapezio(double b, double c, double d) :base(b){
        valorBaseMaior = c;
        valorBaseMenor = d;
    }

    public double area(){
        valorArea = (valorBaseMaior + valorBaseMenor) / 2;
        return valorArea;
    }
}
