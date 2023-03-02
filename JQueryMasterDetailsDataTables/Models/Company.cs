using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JQueryDataTables.Models
{
    public class Company
    {
        static int nextID = 0;

        public Company()
        {
            ID = nextID++;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
    }
}



