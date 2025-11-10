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
        private string userName;
        private string contactinfo;


        //public properties
        public int UserID
        {  
            get { return userId; }
            set {userId = value; } 
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string ContactInfo
        {
            get { return contactinfo; }
            set { contactinfo = value; }
        }
    }
}
