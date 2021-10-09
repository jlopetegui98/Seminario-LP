using System;
using System.Collections.Generic;

namespace SeminarioC_
{
    public class Person
    {
        public string Name {get; private set;} 

        public Person(string name)
        {
            this.Name=name;
        }  
    }

    public class Student:Person, ITakeClass
    {
        public Student(string name):base(name)
        {
            
        }

        public void TakeClass()
        {
            return;
        }
    }

    public interface IGetSalary
    {
        void GetSalary();
    }
    public interface ITeaching
    {
        void GiveClass();
    }
    public interface ITakeClass
    {
        void TakeClass();
    }

    public class ProfessorAssistance : Student, ITeaching
    {
        public ProfessorAssistance(string name):base(name)
        {
            
        }
        public void GiveClass()
        {
            return;
        }
    }

    public class Worker : Person, IGetSalary
    {
        public Worker(string name):base(name)
        {
            
        }
        public void GetSalary()
        {
            return;
        }
    }

    public class Professor : Worker, ITeaching
    {
        public Professor(string name) : base(name)
        {
        }

        public void GiveClass()
        {
            return;
        }
    }

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
