using Activity1Part3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloWorldService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        public List<UserModel> users { get; set; }

        public UserService()
        {
            users = new List<UserModel>();
            for (int i = 0; i < 10; i++)
            {
                var user = new UserModel();
                user.Username = "USERNAME" + i.ToString();
                user.Password = "PASSWORD" + i.ToString();
                users.Add(user);
            }
        }

        public DTO GetAllUsers()
        {
            var user = new DTO();
            user.ErrorCode = 0;
            user.ErrorMsg = "OK";
            user.Data = users;
            return user;
        }

        public string GetData(string data)
        {
            return "The data passed in is --> " + data;
        }

        public HelloObject GetModelObject(string id)
        {
            HelloObject hello = new HelloObject();
            if(int.Parse(id) >= 10)
            {
                hello.happy = true;
                hello.message = "Howdy Friend";
                return hello;
            }
            else
            {
                hello.happy = false;
                hello.message = "Howdy Enemy";
                return hello;
            }
        }

        public DTO GetUser(string id)
        {
            var user = new DTO();
            var l = users.Count();//getting user list count
            var i = int.Parse(id);

            if (i < l)
            {
                user.ErrorCode = 0;
                user.ErrorMsg = "OK";
                user.Data.Add(users[i]);
            }
            else
            {
                user.ErrorCode = -1;
                user.ErrorMsg = "User Does Not Exist";
            }
            return user;
        }

        public string SayHello()
        {
            return "Good-bye, and hello, as always";
        }
    }
}
