using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objects
            Person yo = new Person("Maryelin", "Ramirez", 18);
            IHuman human = yo;
            
            Console.WriteLine(yo.Nombre);

            // Enum
            Console.WriteLine(Weekdays.Monday);

            // Nullable types
            int? optionalInt = default;
            optionalInt = 5;
            #nullable enable
            string? optionalText = default;
            #nullable disable
            optionalText = "Hi";

            Console.WriteLine($"{optionalInt} - {optionalText}");
        }

        // Classes
        public class Person : IHuman
        {
            public string Nombre { get; }
            public string Apellido { get; }
            public int Edad { get; }

            public Person(string nombre, string apellido, int edad) => (Nombre, Apellido, Edad) = (nombre, apellido, edad);

            public void Live()
            {
                Console.WriteLine("Im living my life");
            }
        }

        // Base classes
        public class Adult : Person
        {
            public Boolean isAdult { get; set; }
            public Adult(string nombre, string apellido, int edad) : base(nombre, apellido, edad)
            {
                if (edad > 18)
                {
                    isAdult = true;
                }
                else
                {
                    isAdult = false;
                }
            }
        }

        // Generic class type
        public class Pair<TFirst, TSecond>
        {
            public TFirst First { get; set; }
            public TSecond Second { get; set; }
            public Pair(TFirst first, TSecond second) => (First, Second) = (first, second);
        }

        // Interfaces
        interface IHuman
        {
            void Live();
        }

        // Enums
        public enum Weekdays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }




    }
}
