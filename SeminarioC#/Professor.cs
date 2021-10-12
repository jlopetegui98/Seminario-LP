namespace SeminarioC_
{
    public class Professor : Worker, ITeach
    {
        public Professor()
        { }
        public Professor(string name) : base(name)
        {
        }

        public virtual void GiveClass()
        {
            return;
        }
    }
}