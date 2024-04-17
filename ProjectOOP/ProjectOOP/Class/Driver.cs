namespace ProjectOOP.Class
{
    public class Driver : Person
    {
        public override string ShowString()
        {
            return "";
        }
        public Driver(string name, string account, string password, float evaluate)
        {
            Name = name;
            Account = account;
            Password = password;
            Evaluate = evaluate;
        }
    }
}
