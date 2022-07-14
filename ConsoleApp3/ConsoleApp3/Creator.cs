using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class Creator
    {
        public String Nombre { get; set; }
        public Creator(String Nombre)
        {
            this.Nombre = Nombre;
        }

        public void dimensionCarro()
        {
            Console.WriteLine("Se ejecuta: dimensionCarro()");
            IMarcas marcas = CreateMarcas(Nombre);
            marcas.pPintar();
        }

        public abstract IMarcas CreateMarcas(String Nombre);
    }
}