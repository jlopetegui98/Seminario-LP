namespace SeminarioC_
{
    public class AssistantProfessor : Student, ITeach
    {
        public AssistantProfessor(){}
        public AssistantProfessor(string name):base(name)
        {
            
        }
        public virtual void GiveClass()
        {
            return;
        }
    }
}
