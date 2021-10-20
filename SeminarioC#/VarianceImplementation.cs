namespace SeminarioC_ {
    public class ProfessorV<T> : ITeach<T> where T:Subject {
        public T Subject { get; set; }
        public string Name { get; set; }
        public ProfessorV (T sub, string name) {
            this.Subject = sub;
            this.Name = name;
        }
        public T GetSubject () {
            return this.Subject;
        }

    }

    interface ITeach<out T> where T : Subject {

        T GetSubject ();
    }
}