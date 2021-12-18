using System;

namespace Probando_Git
{
    public class Calculadora
    {
        float Add (float x, float y) => x + y;
        float Substract (float x, float y) => x - y;
        float Multiply (float x, float y) => x * y;
        float Divide (float x, float y) => x / y;
        double Power (double x, double y) => Math.Pow (x, y); 
        double Square (double x) => Math.Pow(x, 0.5);
    }
}