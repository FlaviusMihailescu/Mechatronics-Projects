﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLoginApp.Models
{
    public class User
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User()
        {

        }
        public User(string Username,string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public bool CheckInformation()
        {
            try
            {
                if (!this.Username.Equals("") && !this.Password.Equals(""))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
