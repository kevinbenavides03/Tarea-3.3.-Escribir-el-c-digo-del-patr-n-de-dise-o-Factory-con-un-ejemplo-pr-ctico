using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class CreateKia: Creator
    {
        public CreateKia(string Nombre) : base(Nombre)
        {
            this.Nombre = Nombre;
        }
        public override IMarcas CreateMarcas(String Nombre)
        {
            Console.WriteLine(" - CreateKia / CreateMarcas()");
            Kia marca = new Kia("Kia ", 2022);
            marca.Nombre = Nombre;
            return marca;
        }
    }
}