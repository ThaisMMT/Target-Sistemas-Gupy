using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
        int numero = int.Parse(Console.ReadLine());
        
        if (PertenceAFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool PertenceAFibonacci(int num)
    {
        int a = 0, b = 1, fib = 0;
        
        while (fib < num)
        {
            fib = a + b;
            a = b;
            b = fib;
        }
        
        return (fib == num || num == 0);
    }
}