using System;
using System.Text;

namespace Ex._1;

public class Calculator : IOperavel
{
    private double _val1;
    private double _val2;

    private double _result;

    public Calculator()
    {
        _val1 = 0;
        _val2 = 0;
        _result = 0;
    }

    public Calculator(double _val1, double _val2)
    {
        this._val1 = _val1;
        this._val2 = _val2;
    }

    private void init()
    {
        StringBuilder obj = new StringBuilder();
        obj.Append("Insira o primeiro valor");
        _val1 = Convert.ToDouble(Console.ReadLine());
        obj.Append("Insira o primeiro valor");
        _val2 = Convert.ToDouble(Console.ReadLine());
    }

    private void init2()
    {
        StringBuilder obj = new StringBuilder();
        obj.Append("Insira o valor");
        _val1 = Convert.ToDouble(Console.ReadLine());
    }

    public double add()
    {
        Calculator calculator = new Calculator();
        calculator.init();
        _result = _val1 + _val2;
        return _result;
    }

    public double subtract()
    {
        Calculator calculator = new Calculator();
        calculator.init();
        _result = _val1 + _val2;
        return _result;
    }

    public double multiply()
    {
        Calculator calculator = new Calculator();
        calculator.init();
        _result = _val1 + _val2;
        return _result;
    }

    public double divide()
    {


        Calculator calculator = new Calculator();
        calculator.init();
        divisionByZero();
        _result = _val1 + _val2;
        return _result;
    }

    private bool divisionByZero()
    {
        try
        {
            _result = _val1 / _val2;
        }
        catch
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }

        return true;
    }

    public bool isPrime()
    {
        Calculator calculator = new Calculator();
        calculator.init2();

        if (_val1 % 2 == 0)
        {
            return true;
        }

        return false;
    }
}
