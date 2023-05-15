using System;

namespace TPFinal_Lorenzo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar una lista de números que
           // corta cuando se ingresa un cero. A partir de dichos datos informar:

           // a. El mayor de los números pares.
           // b. La cantidad de números impares.
           // c. El menor de los números primos.

           // Nota: evaluar el uso de una función que analice si un número dado es primo o no 
           // y que devuelva true o false según corresponda.
            
            int n, mayorPares = 0, conImpares = 0, menorPrimos = 0, conPares = 0, conPrimos = 0;

            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                if (n % 2 == 0)
                    conPares++;

                if (n % 2 == 0 && conPares == 1)
                    mayorPares = n;

                if (n % 2 == 0 && n > mayorPares)
                    mayorPares = n;

                if (n % 2 != 0)
                    conImpares++;            

                if (primo(n))
                    conPrimos++;

                if (primo(n) && conPrimos == 1)
                    menorPrimos = n;

                if (primo(n) && n < menorPrimos)
                    menorPrimos = n;        

                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El mayor de los números pares es: " + mayorPares);
            Console.WriteLine("La cantidad de números impares es: " + conImpares);
            Console.WriteLine("El menor de los números primos es: " + menorPrimos);
        }

        static bool primo(int n)
        {
            int conDivisible = 0;

            for (int x = 1; x <= n; x++)
            {
                if (n % x == 0)
                    conDivisible++;
            } 

            if (conDivisible == 2)
                return true;
            else 
                return false;  
        }
    }
}
