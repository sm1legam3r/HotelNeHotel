﻿using HotelNeHotel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelNeHotel.Data
{
    static public class UsersData
    {
        private static List<User> UserList = new List<User>();
        public static List<User> GetUsers()
        {
            if (UserList.Count == 0)
            {
                UserList.Add(new User()
                {
                    Id = 0,
                    FirstName = "Pasha",
                    Surname = "Popov",
                    Login = "admin",
                    Password = "1234",
                    Status = UserStatus.Active,
                    LastDateLogin = DateTime.Now,
                    Role = UserRole.Admin
                });

                UserList.Add(new User()
                {
                    Id = 1,
                    FirstName = "User1",
                    Surname = "User1",
                    Login = "1",
                    Password = "1",
                    Status = UserStatus.Active,
                    LastDateLogin = new DateTime(2025, 3, 2),
                    Role = UserRole.Client
                });

                UserList.Add(new User()
                {
                    Id = 2,
                    FirstName = "User2",
                    Surname = "User2",
                    Login = "2",
                    Password = "2",
                    LastDateLogin = null,
                    Status = UserStatus.Active,
                    Role = UserRole.Admin
                });
            }
            return UserList;
        }
    }
}
