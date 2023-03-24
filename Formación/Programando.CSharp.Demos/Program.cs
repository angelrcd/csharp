using System;
using Universidad;

namespace Programando.CSharp.Demos
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            EjemplosConsole();            
        }

        static void EjemplosConsole()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            var tecla = Console.ReadKey();
            Console.WriteLine($"Pulso {tecla.KeyChar.ToString()}");

            Console.Write("Dime algo: ");
            string respuesta = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"Respueta: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{respuesta}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void DeclaracionVariables()
        {
            //variables de tipo referencía el valor predeterminado es NULL
            //variables de tipo valor el valor predeterminado es 0
            string texto;
            string texto1 = null;
            string otroTexto = "Hola Mundo !!!";

            int numero = 214;
            System.Int32 numero2 = 142;
            Int32 numero3 = 12;
            int otroNumero;
            decimal a, b, c;

            //el tipo int es distinto a int?
            int? numero4 = null;

            //Instaciamos el objeto alumno
            Alumno alumno1 = new Alumno();
            alumno1.nombre = "Borja";

            var alumno2 = new Alumno();
            alumno2.nombre = "Borja";

            Object alumno3 = new Alumno();
            ((Alumno)alumno3).nombre = "Borja";

            dynamic alumno4 = new Alumno();
            alumno4.nombre = "Borja";

            Console.WriteLine("Tipo de la variable 1: " + alumno1.GetType());
            Console.WriteLine("Nombre: {0}", alumno1.nombre);

            Console.WriteLine("Tipo de la variable 2: " + alumno2.GetType());
            Console.WriteLine("Nombre: {0}", alumno2.nombre);

            Console.WriteLine("Tipo de la variable 3: " + alumno3.GetType());
            Console.WriteLine("Nombre: {0}", ((Alumno)alumno3).nombre);

            Console.WriteLine("Tipo de la variable 4: " + alumno4.GetType());
            Console.WriteLine("Nombre: {0}", alumno4.nombre);
        }

        static void ConversionVariables()
        {
            // 0 - 255
            byte var1 = 200;
            int var2 = 90;
            string var3 = "45";

            // ToString() convierte a texto cualquir valor númerico
            // o muestra el nombre del objeto.
            var3 = var1.ToString();


            //Conversión con TRYPARSE
            bool resultado = byte.TryParse(var3, out var1);
            resultado = byte.TryParse(var3, out _);

            Console.Clear();
            Console.WriteLine("Resultado: {0}", resultado.ToString());
            Console.WriteLine("Var1: {0}", var1.ToString());
            //Console.Write("L1 \nL2" + Environment.NewLine + "L3");
            Console.ReadKey();


            var1 = Convert.ToByte(var3);

            // Conversión con PARSE
            var1 = byte.Parse(var3);

            //Conversión implicita
            var2 = var1;

            //Conversión explicita
            var1 = (byte)var2;

            //Conversión utilizando el Objeto CONVERT
            var1 = Convert.ToByte(var2);
        }
    }
}