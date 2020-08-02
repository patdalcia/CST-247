using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Topic_5_Activity_3.Models
{
    public class CustomerModel
    {
        public int id { get; set; }
        public String name { get; set; }
        public int age { get; set; }

        public CustomerModel(int Id, String Name, int Age)
        {
            this.id = Id;
            this.name = Name;
            this.age = Age;
        }
    }
}