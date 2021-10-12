namespace SeminarioC_
{
    public class Person
    {
        public string Name {get; private set;} 

        //constructor por defecto
        public Person(){ }
        public Person(string name)
        {
            this.Name=name;
        }  
    }
}