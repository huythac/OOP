﻿namespace ProjectOOP
{
    public class Food : Products
    {
        public Food(DateTime createAt, string locationFrom, string locationTo, string customer, int price, string note)
        {
            CreateAt = createAt;
            LocationFrom = locationFrom;
            LocationTo = locationTo;
            Customer = customer;
            Price = price;
            Note = note;
        }
    }
}
