using System;

namespace CalculoVolumeEsfera
{
    public class Program
    {
        static void Main(string[] args)
        {
            double volume, raio;
            Program program = new Program();

            Console.WriteLine("Digite o valor do Raio:");
            raio = Convert.ToDouble(Console.ReadLine());

            volume = program.Calculo(raio);
            Console.WriteLine("O volume da esfera é {0}: ", volume);
        }
        public double Calculo(double raio)
        {
            return  4 * 3.14 * Math.Pow (raio, 3) / 3;
        }
    }
}
