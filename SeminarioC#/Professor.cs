namespace SeminarioC_
{
    public class Professor : Worker, ITeach
    {
        public Professor(string name) : base(name)
        {
        }

        public void GiveClass()
        {
            return;
        }
    }
}