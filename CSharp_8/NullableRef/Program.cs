using System;
using static System.Console;

namespace NullableRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.HomeAddress.Street);
        }
    }

    public class Person
    {
        public int Id { get; set; }
        // nullable ref will warn during compile time if HomeAddress is not initialized
        public Address HomeAddress { get; set; } = new Address();
    }

    public class Address
    {
        // nullable ref will warn during compile time if Street and City are not initialized
        public string Street { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
    }
}
 