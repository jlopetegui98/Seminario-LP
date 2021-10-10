namespace SeminarioC_
{
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
}