﻿namespace ProjectOOP.Class
{
    public class Food : Products
    {
        public Food(DateTime createAt, string locationFrom, string locationTo,string type, string productName, int price, string note)
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