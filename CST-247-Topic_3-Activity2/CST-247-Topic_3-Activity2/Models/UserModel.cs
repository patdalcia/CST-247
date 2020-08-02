using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CST_247_Topic_3_Activity2.Models
{
    public class UserModel
    {
        public String Name { get; set; }
        public String EmailAddress { get; set; }
        public String PhoneNumber { get; set; }

        public UserModel(String name, String email, String phone)
        {
            this.Name = name;
            this.EmailAddress = email;
            this.PhoneNumber = phone;
        }
    }
}