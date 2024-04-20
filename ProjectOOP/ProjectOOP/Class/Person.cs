namespace ProjectOOP.Class
{
    public abstract class Person
    {
        public abstract string FullName { get; set; }
        public abstract string PhoneNumber { get; set; }
        public abstract string Password { get; set; }

        public abstract List<string> SelectedServices { get; set; }

    }
}
