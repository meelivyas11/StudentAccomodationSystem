using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentAccommodationSystem.Models
{
    public class RoomModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
        public decimal SasPrice { get; set;}
        public RoomModel(string title, string description, string address, decimal price, string image)
        {
            Title = title;
            Description = description;
            Address = address;
            Price = price;
            SasPrice = (price * 55) / 100;
            Image = image;
        }

        public RoomModel() { }
    }
}