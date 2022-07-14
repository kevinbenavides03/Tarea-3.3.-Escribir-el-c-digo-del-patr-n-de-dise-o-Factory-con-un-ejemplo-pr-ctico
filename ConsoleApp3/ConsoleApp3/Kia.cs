using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Kia : IMarcas
    {
        public String Nombre { get; set; }
        public String Marca { get; set; }
        public int Año { get; set; }

        public Kia(String Marca, int Año)
        {
            this.Marca = Marca;
            this.Año = Año;
        }

        public void pPintar()
        {
            Console.WriteLine(" - Estoy en Tipo de carros Kia / pPintar()");
            Console.WriteLine(" -- Nombre del carro: " + this.Nombre);
            Console.WriteLine(" --- Año: " + this.Año);
            Console.WriteLine(" ** Marca: " + this.Marca);
        }
    }
}