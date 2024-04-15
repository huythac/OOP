namespace ProjectOOP
{
    public class Customer : Person
    {
        public override string ShowString()
        {
            return "oke oke";
        }
        public Customer(string name, string account, string password, float evaluate)
        {
            Name = name;
            Account = account;
            Password = password;
            Evaluate = evaluate;
        }
    }
}
