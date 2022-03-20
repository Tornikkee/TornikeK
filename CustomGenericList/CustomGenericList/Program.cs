using System;

namespace CustomGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integers: ");

            CustomList<int> myCustomList = new CustomList<int>();
            myCustomList.AddItem(17);
            myCustomList.AddItem(18);
            myCustomList.AddItem(201);
            myCustomList.AddItem(500);
            myCustomList.AddItem(99);
            myCustomList.AddItem(207);
            myCustomList.AddToBeginning(5);
            
            myCustomList.Print();

            myCustomList.RemoveItem(201);
            Console.WriteLine("After removing integer: ");
            myCustomList.Print();

            Console.WriteLine("Persons: ");

            CustomList<Person> persons = new CustomList<Person>();
            persons.AddItem(new Person { Name = "Tornike", Age = 21, City = "Tbilisi" });
            persons.AddItem(new Person { Name = "Juan", Age = 29, City = "Madrid" });
            persons.AddItem(new Person { Name = "Malxazi", Age = 15, City = "Tbilisi" });
            persons.AddItem(new Person { Name = "Lamzira", Age = 60, City = "Chokhatauri" });
            persons.AddItem(new Person { Name = "Lea", Age = 31, City = "Paris" });
            persons.AddItem(new Person { Name = "Sophie", Age = 12, City = "London" });
            persons.AddItem(new Person { Name = "Kate", Age = 24, City = "Bournemouth" });
            persons.AddToBeginning(new Person { Name = "Novak", Age = 34, City = "Belgrade" });

            

            Person p = new Person { Age = 65, Name = "Shota", City = "Rustavi" };
            persons.AddItem(p);
            foreach (var item in persons)
            {
                Console.WriteLine($"{item.Name}, {item.Age}, {item.City}");
            }

            persons.RemoveItem(p);
            foreach (var item in persons)
            {
                Console.WriteLine($"{item.Name}, {item.Age}, {item.City}");
            }

        }
    }
}
