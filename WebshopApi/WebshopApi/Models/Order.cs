﻿namespace WebshopApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UId { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
    }
}
