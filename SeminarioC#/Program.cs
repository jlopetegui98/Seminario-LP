using System;
using System.Collections.Generic;

namespace SeminarioC_
{
    class Program
    {
        public static void PrintPeople (IEnumerable<Person> people)
        {
            foreach(var p in people)
                {
                    Console.WriteLine(p.Name);
                }

        } 
        static void Main(string[] args)
        {
            Person [] temp=new Person [3]
                {
                    new Person("Jose"),
                    new Person("Luis"),
                    new Person("Carlo")
                };
            PrintPeople(temp);
        }
    }
}
