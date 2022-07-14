using System;
using System.Collections.Generic;


namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Creator> lista = new List<Creator>();

            lista.Add(new CreateChevrolet("Chevrolet Blazer RS"));
            lista.Add(new CreateChevrolet("Chevrolet Camaro"));
            lista.Add(new CreateChevrolet("Chevrolet Captiva"));
            lista.Add(new CreateKia("Kia Rio 5"));
            lista.Add(new CreateKia("Kia Sedan"));
            lista.Add(new CreateKia("Kia Stringer "));

            foreach (Creator creator in lista)
            {
                creator.dimensionCarro();
            }
        }
    }

}