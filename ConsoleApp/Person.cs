namespace L01;
    internal class Person
    {
        public Person(string fornavn)
        {
            this.fornavn = fornavn;
        }

        private string fornavn;
        public string Fornavn
        {
            get
            {
                return fornavn;
            }
            set
            {
                fornavn = value;
            }
        }

        public override string ToString()
        {
            return "Name is: " + this.fornavn;
        }
    }


