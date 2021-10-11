using System;
using System.Collections.Generic;
using System.Linq;

namespace SeminarioC_
{
    class Program
    {
        //Inciso b
        public static void PrintPeople (IEnumerable<Person> people)
        {
            foreach(var p in people)
                {
                    Console.WriteLine(p.Name);
                }

        }
        //Inciso c 
        static void PrintStudents(IEnumerable<Student> students, IComparer<Student> comparer) 
        {
            foreach (var student in students.OrderBy(x => x, comparer))
            Console.WriteLine(student.Name);
        } 
        //Inciso d
        static void PrintByConsole(Action<Action<Person>> person) 
        {
            person(x => Console.WriteLine(x.Name));
        }              
        static void Main(string[] args)
        {
            if(args[0] == "inciso-b")
            {//Inciso b
                List<Professor> temp=new List<Professor> ()
                    {
                        new Professor("Jose"),
                        new Professor("Luis"),
                        new Professor("Carlo")
                    };
                PrintPeople(temp);
                //Output:
                //Jose
                //Luis
                //Carlo
            }
            else
            {
                if (args[0] == "inciso-c")
                {
                    Student a = new Student("Alberto Pérez Garrido");
                    Student b = new Student("Alberto González Gárcía");
                    Student c = new Student("Abel Cruz Batista");
                    List<Student> list = new List<Student>(){a,b,c};
                    PrintStudents(list, new PersonComparerByName());
                    // Output:
                    //Abel Cruz Batista
                    //Alberto Pérez Garrido
                    //Roberto González Gárcía
                }
                else 
                {
                    if(args[0] == "inciso-d")
                    {
                        PrintByConsole(x=>x(new Student("Pedro")));
                        //Output:
                        //Pedro
                    }
                }

            }
            
        }
    }
}
