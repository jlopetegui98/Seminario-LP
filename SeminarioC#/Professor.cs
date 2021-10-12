namespace SeminarioC_
{
    public class Professor : Worker, ITeach
    {
        public Professor()
        { }
        public Professor(string name) : base(name)
        {

        }

        public override void GetSalary(){
            System.Console.WriteLine("El profesor cobra 5000 cup");
        }
        public virtual void GiveClass()
        {
            return;
        }
    }
}