using System;

namespace ConsoleApp1.ExercícioCincoListaDois
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int X, Y, Z = 0; //A, B, C = 0; 
            do
            {
                Console.Write("Digite o valor A: ");
                X = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o valor B: ");
                Y = Convert.ToInt32(Console.ReadLine());
                if (X == Y)  // Faça um algoritmo que leia dois valores inteiros X e Y
                    Z = X + Y;
                else         //se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B.
                    Z = X * Y;
                Console.WriteLine("\nO valor C é: " + Z);
            } while (true);
            
        }
    }
}
