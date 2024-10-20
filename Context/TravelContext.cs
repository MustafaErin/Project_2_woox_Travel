using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Project_2_woox_Travel.Entities;

namespace Project_2_woox_Travel.Context
{
    public class TravelContext:DbContext
    {
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }    
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet <Admin> Admins { get; set; }

    }
}