using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe uma string para inverter: ");
        string entrada = Console.ReadLine();

        string invertida = InverterString(entrada);
        Console.WriteLine($"String invertida: {invertida}");
    }

    static string InverterString(string str)
    {
        char[] caracteres = new char[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            caracteres[i] = str[str.Length - 1 - i];
        }

        return new string(caracteres);
    }
}