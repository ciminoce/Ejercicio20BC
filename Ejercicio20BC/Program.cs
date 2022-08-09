using System;

namespace Ejercicio20BC
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese el primer lado del triángulo:");
                var lado1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo lado del triángulo:");
                var lado2 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el tercer lado del triángulo:");
                var lado3 = int.Parse(Console.ReadLine());

                if (VerificarTriangulo(lado1, lado2, lado3))
                {
                    var tipoTriangulo = ObtenerTipoTriangulo(lado1, lado2, lado3);
                    Console.WriteLine($"Es un {tipoTriangulo}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Alguno de los datos ingresados podrían estar erróneos");
                
            }

            Console.ReadLine();
        }

        private static string ObtenerTipoTriangulo(int lado1, int lado2, int lado3)
        {
            if (Math.Pow(lado1, 2) == Math.Pow(lado2, 2) + Math.Pow(lado3, 2))
            {
                return "Triángulo Rectángulo";
            }
            else if (Math.Pow(lado1, 2) > Math.Pow(lado2, 2) + Math.Pow(lado3, 2))
            {
                return "Triángulo Obtusángulo";
            }
            else
            {
                return "Triángulo Acutángulo";
            }

        }

        private static bool VerificarTriangulo(int lado1, int lado2, int lado3)
        {
            return lado1 + lado2 > lado3 &&
                   lado1 + lado3 > lado2 &&
                   lado2 + lado3 > lado1;
        }
    }
}
