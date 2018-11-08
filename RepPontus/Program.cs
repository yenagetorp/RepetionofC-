using System;
using System.Linq;

namespace RepPontus
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Person[] people = new Person[]    //Array of Person.
            var people = new Person[]
            {
                new Person("Bo", new DateTime(2000, 1, 1)),
                new Person("Li", new DateTime(2003, 2, 5)),
                new Person("Anna", new DateTime(2005, 5, 6)),
                new Person("Mats", DateTime.Now)
            };

            //people[0].Age++;
            //var lastAge = people[people.Length - 1].Age;
            //Console.WriteLine(lastAge);

            var longNames = people
                .Where(p => p.Name.Length > 2)   //Where alltid filtreara.
                .Select(p =>p.Name);             // Select alltid forma om.

            foreach (var name in longNames)
            {
                Console.WriteLine(name);
            }

            //* Anonym types *//
            //skapa en instans av annym typ.
            var a = new
            {
                CompanyName = "Acme",
                Emploees = 100
            };
            Console.WriteLine(a.CompanyName);

            //* Titta en gång till!!! *//
            int nr = 1;
            var numberOfPeople = people
                .Select(p => new
                {
                    Nr = nr++,                     //use select to choose to print out nr   !!!
                    //use select to choose to print out name and date of birth.  !!!
                    PersonName = p.Name,           
                    //DateOfBirth = p.DateOfBirth
                    p.DateOfBirth
                });
            foreach (var item in numberOfPeople)
            {
                Console.WriteLine($"{item.Nr}: {item.PersonName} {item.DateOfBirth.ToShortDateString()}");
            }

           

        }
    }
}
