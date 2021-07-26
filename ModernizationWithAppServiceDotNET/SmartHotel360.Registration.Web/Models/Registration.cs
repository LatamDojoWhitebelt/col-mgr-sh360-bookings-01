﻿namespace SmartHotel.Registration.Models
{
    using System;

    public class Registration
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public DateTime Date { get; set; }

        public string CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string Passport { get; set; }

        public string Address { get; set; }

        public int Amount { get; set; }

        public int Total { get; set; }
    }
}