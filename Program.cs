using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    class Program
    {
        static void Main(string[] args)
        {
            string aString = " ";
            string bString = " ";

            Console.WriteLine("Calculemos la suma y division de dos números\n\nDa el primer número");
            aString = Console.ReadLine();
            a = Convert.ToInt16(aString);

            Console.WriteLine("Da el segundo número");
            bString = Console.ReadLine();
            b = Convert.ToInt16(bString);

            Operaciones Op = new Operaciones();
            Op.GetSuma(Op.a, Op.b);
            Op.GetDivicion(Op.a, Op.b);

            Console.WriteLine("La suma es: {0}\nLa divicion es: {1}", Op.suma,Op.divicion);
            Console.ReadKey();
        }
    }
}
