using System;

namespace raioDeUmTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float raio, area;
            Console.WriteLine("Informe o raio do circulo");
            raio = float.Parse(Console.ReadLine());
            area = (float)(3.14 * (raio * raio));
            Console.WriteLine("A área do circulo é: {0}", area);
        }
    }
}
