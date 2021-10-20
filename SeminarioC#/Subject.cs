namespace SeminarioC_ {

    public class Subject {
        public string Name { get; set; }

        public Subject (string name) {
            this.Name = name;
        }
    }

    public class Math : Subject {
        public Math (string name) : base (name) { }
    }
    public class Calculus : Math {
        public Calculus (string name) : base (name) { }
    }
    public class History : Subject {
        public History (string name) : base (name) { }
    }
    public class Spanish : Subject {
        public Spanish (string name) : base (name) { }
    }

}