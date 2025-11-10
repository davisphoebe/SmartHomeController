using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeController
{
    public class User
    {
        //private fields
        private int userId;
        private string username;
        private string contactinfo;
        private string password;
        private bool isLoggedIn;



        //public properties
        public int UserID
        {  
            get { return userId; }
            set {userId = value; } 
        }

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public string ContactInfo
        {
            get { return contactinfo; }
            set { contactinfo = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }



        //constructor
        public User(int userID, string username, string contactinfo, string password)
        {
            this.userId = userID;
            this.username = username;
            this.password = password;
            this.isLoggedIn = false;
        }



        //methods
        public bool Login(string userName, string password) 
        {
            if (UserName == userName && Password == password)
            {
                IsLoggedIn = true;
                Console.WriteLine("Login Successful");
            }
            else 
            {
                IsLoggedIn = false;
                Console.WriteLine($"Login Failed. Username {userName} or password is incorrect");
            }
            return IsLoggedIn;
        }

        public void Logout()
        {
            if (IsLoggedIn)
            { 
                IsLoggedIn =false;
                Console.WriteLine("User is logged out successfully");
            }
            else
            {
                Console.WriteLine("User is not logged in");
            }
        }


        public void ControlDevice(int deviceID, string deviceName, string deviceAction)
        {
            if (IsLoggedIn)
            {
                Console.WriteLine($"Performing action {deviceAction} on {deviceName}");
            }
            else
            {
                Console.WriteLine("Please log in to control the device");
            }
        }

    }
}
