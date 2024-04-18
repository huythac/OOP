namespace ProjectOOP.Class
{
    public abstract class Person
    {
        public abstract string Name { get; set; }
        public abstract string Account { get; set; }
        public abstract string Password { get; set; }

        public abstract string ShowString();
    }
}
