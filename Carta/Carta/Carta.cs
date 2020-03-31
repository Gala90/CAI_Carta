using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carta
{
    public class Carta
    {
        private string tipo;
        private string valor;
        private string palo;
        private List<String> juegosPosibles;

        
        public Carta (string tipo, string valor, string palo)
        {
            this.tipo = tipo;
            this.valor = valor;
            this.palo = palo;
            juegosPosibles = new List<string>();
        }

        public String Tipo
        {
            get
            {
                return this.tipo;
            }
            set { this.tipo = value; }
        }

        public String Valor
        {
            get
            {
                return this.valor;
            }
            set { this.valor = value; }
        }

        public String Palo
        {
            get
            {
                return this.palo;
            }
            set { this.palo = value; }
        }

        public void mostrarCarta()
        {
            List<string> valoresPosibles = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "11", "12", "10", "A", "J", "Q", "K" };
            if (!valoresPosibles.Contains(Valor))
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                Console.WriteLine("Tipo: " + Tipo + " Valor: " + Valor + " Palo: " + Palo);
            }
        }

        public void agregarJuego(string juego)
        {
            juegosPosibles.Add(juego);
        }

        public void mostrarJuegos()
        {   
            if (juegosPosibles == null)
            {
                throw new NullReferenceException("No puede ser null");
            }
                
            if (juegosPosibles.Count < 0)
            {
                Console.WriteLine("No hay juegos cargados posibles.");

            } else
            {
                foreach (string value in juegosPosibles)
                {
                    Console.WriteLine(value);
                }
            }
        }


        }

}

