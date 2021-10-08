using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;

public class Person
{
    public string Name {get; private set;} 

    public Person(string name)
        {
            this.Name=name;
        }  
}

public interface IWorker
    {
        void Salary();
    }
public interface IProfesor :IWorker
    {
        void GiveClass();
    }
public interface IStudent
    {
        void TakeClass();
    }

public interface IHStudent:IStudent, IWorker
    {

    }    

class Program
{
    static void Main()
        {
            Person [] temp=new Person [3]
                {
                    new Person("Jose"),
                    new Person("Luis"),
                    new Person("Carlo")
                };
            PrintPeople(temp);
        }

    public static void PrintPeople (IEnumerable<Person> people)
        {
            foreach(var p in people)
                {
                    Console.WriteLine(p.Name);
                }

        } 
}
