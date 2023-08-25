using System;

class URI
{

    static void Main(string[] args)
    {

        /**
         * Escreva a sua solução aqui
         * Code your solution here
         * Escriba su solución aquí
         */
        double pi = 3.14159;
        double r = double.Parse(Console.ReadLine());
        double area = pi * Math.Pow(r, 2);

        Console.WriteLine("A=" + area.ToString("F4"));

    }

}