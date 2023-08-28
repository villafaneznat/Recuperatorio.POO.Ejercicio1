using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio.POO.Ejercicio1.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrismaRectangularRecto prisma = new PrismaRectangularRecto();
            Console.WriteLine(prisma.MostarDatos());

            PrismaRectangularRecto prisma2 = new PrismaRectangularRecto();
            Console.WriteLine(prisma2.MostarDatos());

        }
    }
}
