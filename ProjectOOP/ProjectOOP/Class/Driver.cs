namespace ProjectOOP.Class
{
    public class Driver : Person
    {
        public override string Name { get; set; }
        public override string Account { get; set; }
        public override string Password { get; set; }
        public override string ShowString()
        {
            return "";
        }
        public Driver(string name, string account, string password)
        {
            Name = name;
            Account = account;
            Password = password;
        }
    }
}
