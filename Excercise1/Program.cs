using System;

namespace T2009A_Pham_Duc_DUy_ThiAP_C
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Amar";
            person.Age = 40;
            int values = person.Age + 1;
            Console.WriteLine("Simple Properties Demo");
            Console.WriteLine($"Person details - Name = {person.Name}, Age = {person.Age}");
            Console.WriteLine($"Person details (After incrementing age) - Name = {person.Name}, Age = {values}");
        }
    }
}