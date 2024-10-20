﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_2_woox_Travel.Entities
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int DayNight { get; set; }
        public string İmageUrl { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }


    }
}