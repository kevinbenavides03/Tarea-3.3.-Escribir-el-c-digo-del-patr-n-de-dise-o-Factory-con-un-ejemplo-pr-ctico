using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Chevrolet : IMarcas
    {
        public String Nombre { get; set; }
        public String Color { get; set; }
        public Chevrolet(String Color)
        {
            this.Color = Color;
        }

        public void pPintar()
        {
            Console.WriteLine(" - Estoy en Tipos de carros  Chevrolet / pPintar()");
            Console.WriteLine(" -- Nombre del carro: " + this.Nombre);
            Console.WriteLine(" --- Color del Carro: " + this.Color);
        }
    }
}