namespace ProjectOOP
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public float Evaluate { get; set; }

        public abstract string ShowString();
        public Person() { }
    }
}
