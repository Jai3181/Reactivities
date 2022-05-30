using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Activity
    {
        public Guid Id { get; set; }       // "Id" is a special property name, as entity framework recognises it to be unique hence considering it to be the primary key for the table 
        public String Title { get; set; }
        public DateTime Date { get; set; }
        public String Description { get; set; }
        public String Category { get; set; }
        public String City { get; set; }
        public String Venue { get; set; }
    }
}

// whenever we call activity, we call an object with properties (ID, Title ..... Venue)
// It creates a table named Activity in the database with columns as (ID, Title ..... Venue)..... This is called Entity Framework