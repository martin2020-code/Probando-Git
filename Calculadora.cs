using System;

namespace Probando_Git
{
    public class Calculadora
    {
        float Add (int x, int y) => x + y;
        float Substract (int x, int y) => x - y;
        float Multiply (int x, int y) => x * y;
        float Divide (int x, int y) => x / y;
        double Power (double x, double y) => Math.Pow (x, y); 
        double Square (double x) => Math.Pow(x, 0.5);
    }
}