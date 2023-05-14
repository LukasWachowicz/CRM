using System;

namespace Crm
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program do zarządzania klientami");
            Console.WriteLine("Co chciałbyś zrobić?");
            Console.WriteLine("1. Dodanie nowego klienta");
            Console.WriteLine("2. Usunięcie klientaz bazy");
            Console.WriteLine("3. Edycja istniejącego klienta");
            // Console.WriteLine("4. Wyszukanie klienta"); Funkcja czasowo nie dostępna :)

            string choice = Console.ReadLine();
        }
    }
}
