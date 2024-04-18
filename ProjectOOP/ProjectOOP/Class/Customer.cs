namespace ProjectOOP.Class
{
    public class Customer : Person
    {
        public override string Name { get; set; }
        public override string Account { get; set; }
        public override string Password { get; set; }
        public override string ShowString()
        {
            return "oke oke";
        }
        public Customer(string name, string account, string password)
        {
            Name = name;
            Account = account;
            Password = password;
        }
    }
}
