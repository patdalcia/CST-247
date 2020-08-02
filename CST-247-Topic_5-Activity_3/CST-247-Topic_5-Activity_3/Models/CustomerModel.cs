using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CST_247_Topic_5_Activity_3.Models
{
    public class CustomerModel
    {
        public int id { get; set; }
        public String name { get; set; }
        public int age { get; set; }

        public CustomerModel(int i, String n, int a)
        {
            this.id = i;
            this.name = n;
            this.age = a;
        }

        public CustomerModel() { }
    }
}