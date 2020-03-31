using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carta
{
    class Program
    {
        static void Main(string[] args)
        {
            Carta miCarta1 = new Carta("Española", "8", "Oro");

            Carta miCarta2 = new Carta("Española", "18", "Oro");

            miCarta1.mostrarCarta();
         
            try
            {
                miCarta2.mostrarCarta();
            }
            catch (ArgumentOutOfRangeException )
            {
                Console.WriteLine("El valor " + miCarta2.Valor + " no es posible");

            }

            try
            {
                miCarta1.mostrarJuegos();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No puede ser null el listado");   //Esto funciona si no inicializo la lista en Carta.cs

            }


            string juego;
            Console.WriteLine("Que juego quiere agregar? ");
            juego = Console.ReadLine();
            miCarta1.agregarJuego(juego);
            miCarta1.mostrarJuegos();




            Console.ReadKey();
        }
    }
}
