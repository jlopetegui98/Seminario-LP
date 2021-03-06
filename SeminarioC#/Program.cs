using System;
using System.Collections.Generic;
using System.Linq;

namespace SeminarioC_ {
    class Program {
        //Inciso b
        public static void PrintPeople (IEnumerable<Person> people) {
            foreach (var p in people) {
                Console.WriteLine (p.Name);
            }
        }
        //Inciso c 
        static void PrintStudents (IEnumerable<Student> students, IComparer<Student> comparer) {
            foreach (var student in students.OrderBy (x => x, comparer))
                Console.WriteLine (student.Name);
        }
        //Inciso d
        static void PrintByConsole (Action<Action<Person>> person) {
            person (x => Console.WriteLine (x.Name));
        }
        //Inciso e
        static void PrintStudentsOnly (IEnumerable<object> people) {
            foreach (var student in people.Where (x => x.GetType () == typeof (Student)))
                Console.WriteLine (((Person) student).Name);
        }
        static void Main (string[] args) {
            if (args[0] == "covariance") {
                ITeach<SeminarioC_.Calculus> a = new SeminarioC_.ProfessorV<SeminarioC_.Calculus> (new SeminarioC_.Calculus("Calculus"), "Ana");
                ITeach<SeminarioC_.Math> b = a;

            } else if (args[0] == "polimorfismo") {
                Worker[] workers = new Worker[2] {
                new Worker ("Jose"),
                new Professor ("Luis"),
                };
                for (int i = 0; i < workers.Length; i++)
                    workers[i].GetSalary ();
                //Output    
                //El trabajador cobra 3000 cup
                //El profesor cobra 5000 cup                
            } else if (args[0] == "inciso-b") {
                //Inciso b
                List<Professor> temp = new List<Professor> () {
                new Professor ("Jose"),
                new Professor ("Luis"),
                new Professor ("Carlo")
                };
                PrintPeople (temp);
                //Output:
                //Jose
                //Luis
                //Carlo
            } else if (args[0] == "inciso-c") {
                Student a = new Student ("Alberto Pérez Garrido");
                Student b = new Student ("Alberto González Gárcía");
                Student c = new Student ("Abel Cruz Batista");
                List<Student> list = new List<Student> () { a, b, c };
                PrintStudents (list, new PersonComparerByName ());
                // Output:
                //Abel Cruz Batista
                //Alberto Pérez Garrido
                //Roberto González Gárcía
            } else if (args[0] == "inciso-d") {
                PrintByConsole (x => x (new Student ("Pedro")));
                //Output:
                //Pedro
            } else if (args[0] == "inciso-e") {
                List<Person> list = new List<Person> () {
                new Professor ("Jose"),
                new Student ("Luis"),
                new AssistantProfessor ("Carlos")
                };
                PrintStudentsOnly (list);
            }
        }
    }
}