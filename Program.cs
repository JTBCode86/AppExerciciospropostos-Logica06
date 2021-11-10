using System;
using System.Globalization;

namespace AppExerciciospropostos_Logica06
{
    /// <summary>
    /// Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e  mostre:
    ///  
    /// -> A área do triângulo retângulo que tem A por base e C por altura. 
    ///  -> A área do círculo de raio C. (pi = 3.14159) 
    ///  -> A área do trapézio que tem A e B por bases e C por altura.
    ///  -> A área do quadrado que tem lado B.
    ///  -> A área do retângulo que tem lados A e B.
    /// 
    /// </summary>
   
    class Program
    {
        public static double calculoRetangulo(double A, double B)
        {
            double areaRetangulo = (A * B);
            return areaRetangulo;
        }

        public static double calculoQuadrado(double B) 
        {
            double areaQuadrado = Math.Pow(B, 2);
            return areaQuadrado;
        }

        public static double calculoTrapezio(double A, double B,double C)
        {
            double areaTrapezio = (A + B) * C / 2;
            return areaTrapezio;

        }

        public static double calculoTrianguloRetangulo(double A,double C) 
        {
            double areaTriangulo = (A * C) / 2;
            return areaTriangulo;
        }
        
        public static double calculoAreaCirculo(double raio) 
        {
            double pi = 3.14159;
            double areaCirculo = pi * Math.Pow(raio, 2);
            return areaCirculo;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os valores de A, B e C: ");

            float A = float.Parse(Console.ReadLine());
            float B = float.Parse(Console.ReadLine());
            float C = float.Parse(Console.ReadLine());

            double trianguloRetangulo = calculoTrianguloRetangulo(A, C);
            double circulo =   calculoAreaCirculo(C);
            double trapezio =  calculoTrapezio(A, B, C);
            double quadrado =  calculoQuadrado(B);
            double retangulo = calculoRetangulo(A,B);

            Console.WriteLine("\n");

            Console.Clear();
            Console.WriteLine("Resultados: ");
            Console.WriteLine("TRIANGULO: {0}", trianguloRetangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: {0}", circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: {0}", trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: {0}", quadrado.ToString("F3"));
            Console.WriteLine("QUADRADO: {0}", retangulo.ToString("F3"));

            Console.ReadLine();
        }
    }
}
