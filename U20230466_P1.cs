using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nombre;
            int edad;
            string? direccion;
            int telefono;
            string? universidad;
            string? carrera;
            string? facultad;
            int ciclo;

            Console.WriteLine("*********Practica 1 - Programación Estructurada*********\n");

            Console.WriteLine("Ingrese su nombre completo: ");
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese su dirección: ");
            direccion = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese su número de teléfono: ");
            telefono = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese la Universidad donde estudia: ");
            universidad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese la carrera: ");
            carrera = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese la facultad: ");
            facultad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese su ciclo: ");
            ciclo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            //Imprimiendo datos

            Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("Su edad es: " + edad);
            Console.WriteLine("Su dirección es: " + direccion);
            Console.WriteLine("Su número de teléfono es: " + telefono);
            Console.WriteLine("Estudia en la universidad: " + universidad);
            Console.WriteLine("Su carrera es: " + carrera);
            Console.WriteLine("Facultad que pertenece: " + facultad);
            Console.WriteLine("Ciclo cursando: " + ciclo);





        }
    }
}