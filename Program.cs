using System;

namespace Ejercicio1DeLutien_
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia;
            double velocidad;
            double tiempo;
            double kilometros;
            Console.Write("INGRESE EL TIEMPO (representado en segundos) RECORRIDO POR EL MOVIL: ");
            tiempo = double.Parse (Console.ReadLine());

            Console.Write("INGRESE LA VELOCIDAD A LA CUAL ESTUVO DESPLAZANDOCE EL MOVIL: ");
            velocidad = double.Parse (Console.ReadLine());

            distancia = (velocidad * tiempo);
            Console.WriteLine($"los metros recorridos por el automovil son: {distancia}  M/s");

            kilometros = (distancia * 0.001);
            Console.WriteLine($"los kilometros recorridos por el movil son: {kilometros}  ");
        
        }
    }
}
