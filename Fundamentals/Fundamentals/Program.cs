using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solo positivos
            byte n1 = 255;

            //Admite Negativos
            sbyte n2 = 126;

            //Admite Negativos
            int n3;

            //Solo Positivos
            uint n4;



            //4 bytes
            float n5=2f;
            // 8 bytes
            double n6 = 1d;
            //16 bytes
            decimal n7=1m;

            //char
            char character = 'A';

            //string
            string name = "hola";

            long n8;

            DateTime date = DateTime.Now;

            bool siOno= false;

            int numero=new int();
            
            //? make nullable
            int? nTest = null;

            //Solo funciona en local
            var test = "Hola";

            var persona = new { nombre = "Hola", apellido = "MiApellido" };

            Console.WriteLine(persona.nombre);
        }
    }
}
