namespace SeminarioC_
{
    public class Student:Person, ITakeClass
    {
        public Student(){}
        public Student(string name):base(name)
        {
            
        }

        public void TakeClass()
        {
            return;
        }
    }
}