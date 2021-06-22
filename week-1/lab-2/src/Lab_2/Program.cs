using System;

namespace Lab_2
{
    class Program
    {
        // Class Members => Fields, properties, methods
        static void Main(string[] args)
        {
            Boolean continuar = true;
            while(continuar)
            {

                Book libro = new Book();
                Console.WriteLine($"{libro.Title} - {libro.NumberOfPages}");

                Carro Toyota = new Carro();
                Toyota.Modelo = "Rav4";
                Toyota.Color = "Blanco";
                Toyota.Year = 2019;

                Toyota.acelerar();

                Saludo("Marye");

                Console.WriteLine("Desea reiniciar el programa? presione s -> si n -> no");
                string option = Console.ReadLine();
                switch(option)
                {
                    case "s":
                        Console.Clear();
                        break;
                    case "n":
                        continuar = false;
                        break;
                }
            }


        }

        public class Book
        {
            public string Title = "goodbye, things";
            public int NumberOfPages = 253;
        }

        public class Carro
        {
            public string Modelo;
            public string Color;
            public int Year;

            public void acelerar()
            {
                Console.WriteLine("El auto va a toda velocidad");
            }

        }

        static void Saludo(String nombre)
        {
            Console.WriteLine($"Hola {nombre}");
        }
    }
}
