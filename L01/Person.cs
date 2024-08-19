namespace L01
{
    internal class Person
    {
        public Person(string fornavn)
        {
            this.fornavn = fornavn;
        }

        private string fornavn
        {
            get
            {
                return Fornavn;
            }
            set
            {
                Fornavn = value;
            }
        }
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
    }
    
}

