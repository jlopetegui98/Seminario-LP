namespace SeminarioC_
{
    public class AssistantProfessor : Student, ITeach
    {
        public AssistantProfessor(string name):base(name)
        {
            
        }
        public void GiveClass()
        {
            return;
        }
    }
}