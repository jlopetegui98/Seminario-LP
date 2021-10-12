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
            return;
        }
    }
}