using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio.POO.Ejercicio1
{
    public class PrismaRectangularRecto
    {
        //a.Tiene como atributos el largo, la altura y el ancho que son de tipo entero y privados; y solo se
        //podrán leer sus valores.
        private int _largo;
        private int _ancho;
        private int _altura;

        public int GetLargo() => _largo;
        public int GetAncho() => _ancho;
        public int GetAltura() => _altura;
        
        //b.La clase tiene 2 constructores: en uno de ellos es donde se pasan los
        //valores de sus atributos, si los datos no son válidos, arrojar una
        //excepción de tipo ArgumentException, cuando no se pasan valores
        //se asuma 1 para cada atributo
        public PrismaRectangularRecto(int largo, int ancho, int altura)
        {
            if (largo <= 0 || ancho <= 0 || altura <= 0)
            {
                throw new ArgumentNullException("DATOS INVÁLIDOS");
            }
            _largo = largo;
            _ancho = ancho;
            _altura = altura;
        }
        public PrismaRectangularRecto() : this(1, 1, 1) { }
        
        //c.La clase tendrá los siguientes métodos privados:

        //i.Area Base: que devolverá el área de la base del prisma, que
        //se calcula con la siguiente fórmula: donde A es el valor del
        //largo, y B es el valor del ancho.
        private int AreaBase()
        {
            return GetLargo() * GetAncho();
        }
        //ii.Area Altura: que devolverá el area de una de las caras, que
        //se calcula con la siguiente fórmula , donde h es la altura y B
        //el ancho.
        private int AreaAltura()
        {
            return GetAltura() * GetAltura();
        }
        //iii.Area Ancho: que devolverá el area de la otra cara, que se calcula con la siguiente
        //fórmula:, donde h es la altura y A el largo.
        private int AreaAncho()
        {
            return GetAltura() * GetLargo();
        }

        //d.La clase debe poder informar su área, su volumen y el valor de la diagonal.

        //i.Área=2*(Ab+Ah+Aa) donde Ab es el área base, Ah es el área de la altura y Aa es el área del ancho.
        public double GetArea()
        {
            return 2 * AreaBase() + AreaAltura() + AreaAncho();
        }
        //ii.Volumen=A*B*h, donde A es el largo, B es el ancho y h la altura.
        public double GetVolumen()
        {
            return GetLargo() * GetAncho() * GetAltura();
        }

        //iii.Diagonal, donde A es el largo, B es el ancho y h la altura.
        public double GetDiagonal()
        {
            return Math.Sqrt(Math.Pow(GetLargo(), 2) + Math.Pow(GetAncho(),2) + Math.Pow(GetAltura(),2));
        }

        //e.La clase debe tener un método para informar todos sus datos, cada dato en una línea diferente.
        public string MostarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"PRISMA RECTANGULAR RECTO");
            sb.AppendLine($"Altura:....... {GetAltura()}");
            sb.AppendLine($"Ancho:.........{GetAncho()}");
            sb.AppendLine($"Area:..........{GetArea()}");
            sb.AppendLine($"Diagonal:......{GetDiagonal()}");
            sb.AppendLine($"Largo:.........{GetLargo()}");
            sb.AppendLine($"Volumen:.......{GetVolumen()}");
            return sb.ToString();
        }

        //f.Utilizar la clase en un proyecto de consola.

    }
}
