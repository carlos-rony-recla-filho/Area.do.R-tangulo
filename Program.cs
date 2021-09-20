using System;

namespace AreadoR_tangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Decimal  Juros, montante, tempo, taxaJuros, Capital;

            Console.WriteLine("Bem vindo a calculadora de Juros Simples!");

            Console.Write("Capital [c] (R$)......:");
            Capital = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Taxa de Juros [i] (%)..:");
            taxaJuros = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Tempo [t] (meses).....: ");
            tempo = Convert.ToDecimal(Console.ReadLine());

            Juros = Capital * (taxaJuros / 100) * tempo;
            montante = Capital + Juros;

            Console.WriteLine($"\nJuros (R$).......: {Juros.ToString("C")}");
            Console.WriteLine($"Montantes (R$).....: {montante.ToString("C")}");
        }
    }
}
