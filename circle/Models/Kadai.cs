﻿using System;
namespace circle.Models
{
    public class Kadai
    {
        public Kadai()
        {
        }
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
