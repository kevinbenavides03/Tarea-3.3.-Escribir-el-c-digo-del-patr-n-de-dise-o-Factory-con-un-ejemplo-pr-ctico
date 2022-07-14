using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class CreateChevrolet : Creator
    {
        public CreateChevrolet(string Nombre) : base(Nombre)
        {
            this.Nombre = Nombre;
        }
        public override IMarcas CreateMarcas(String Nombre)
        {
            Console.WriteLine(" - CreateChevrolet / CreateMarcas()");

            Chevrolet marca = new Chevrolet("Azul ");
            marca.Nombre = Nombre;

            return marca;
        }
    }
}