using System;

namespace Solicitar_Apellido_Nombre
{
    class Program
    {
        static void Main (string[] args)
        {
            static string pedirnombre()
            {
                Console.WriteLine("Digite su nombre: \n");
                return Console.ReadLine();
            }

            static string pedirapellido()
            {
                Console.WriteLine("Digite su apellido: \n");
                return Console.ReadLine();
            }

            string nombre   = pedirnombre();
            string apellido = pedirapellido();

            Console.WriteLine("\n Hola " + nombre + " " + apellido+ " ");
            Console.ReadLine(); 
        }
    }
}