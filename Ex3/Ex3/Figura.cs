namespace Ex3;

public abstract class Figura
{
    protected double valorLado;

    protected double valorAltura;

    protected double valorArea;

    public Figura(){
        valorLado = 0;
        valorAltura = 0;
        valorArea = 0;
    }

    public Figura(double b){
        valorAltura = b;
        valorArea = 0;
    }

    public Figura(double a, double b){
        valorLado = a;
        valorAltura = b;
        valorArea = 0;
    }
}
