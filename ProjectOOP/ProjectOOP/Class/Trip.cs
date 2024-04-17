namespace ProjectOOP.Class
{
    public class Trip : Products
    {
        public Trip(DateTime createAt, string locationFrom, string locationTo, string type, string productName, int price, string note)
        {
            CreateAt = createAt;
            LocationFrom = locationFrom;
            LocationTo = locationTo;
            Type = type;
            ProductName = productName;
            Price = price;
            Note = note;
        }
    }
}
