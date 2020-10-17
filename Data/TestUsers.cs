using System;
using System.Collections.Generic;
using System.Linq;
using DNP_Assignment_1.Models;

namespace DNP_Assignment_1.Data
{
    public class TestUsers : IUserService
    {
        private List<User> users;

        public TestUsers()
        {
            users = new[]
            {
                new User
                {
                    UserName = "Chris",
                    Password = "1234",
                    Role = "Admin",
                },
                new User
                {
                    UserName = "Test",
                    Password = "1234",
                    Role = "User",
                },
                new User
                {
                    UserName = "Test2",
                    Password = "1234",
                    Role = "Guest",
                }
            }.ToList();
        }

        public User ValidateUser(string Username, string Password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(Username));

            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(Password))
            {
                throw new Exception("Password incorrect, try again");
            }

            return first;
        }
    }
}