using System.Collections.Generic;

namespace SeminarioC_
{
    public class PersonComparerByName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}