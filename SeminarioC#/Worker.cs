namespace SeminarioC_
{
    public class Worker : Person, IGetSalary
    {
        public Worker(){ }
        public Worker(string name):base(name)
        {
            
        }
        public virtual void GetSalary()
        {
            System.Console.WriteLine("El trabajador cobra 3000 cup");
        }
    }
}