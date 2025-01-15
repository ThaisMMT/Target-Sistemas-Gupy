using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string caminhoArquivo = "faturamento.json";

        if (File.Exists(caminhoArquivo))
        {
            string json = File.ReadAllText(caminhoArquivo);
           
            List<Faturamento> faturamentoMensal = JsonSerializer.Deserialize<List<Faturamento>>(json);

            var diasComFaturamento = faturamentoMensal.Where(f => f.Valor > 0).ToList();

            if (diasComFaturamento.Count > 0)
            {
                double menorValor = diasComFaturamento.Min(f => f.Valor);
                double maiorValor = diasComFaturamento.Max(f => f.Valor);
                double media = diasComFaturamento.Average(f => f.Valor);
                int diasAcimaDaMedia = diasComFaturamento.Count(f => f.Valor > media);

                Console.WriteLine($"Menor valor de faturamento: {menorValor:F2}");
                Console.WriteLine($"Maior valor de faturamento: {maiorValor:F2}");
                Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
            }
            else
            {
                Console.WriteLine("Não há dias com faturamento positivo para processar.");
            }
        }
        else
        {
            Console.WriteLine("Arquivo de faturamento não encontrado.");
        }
    }

    class Faturamento
    {
        public int Dia { get; set; }
        public double Valor { get; set; }
    }
}