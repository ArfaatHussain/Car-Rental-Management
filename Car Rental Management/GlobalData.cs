using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Car_Rental_Management
{
    class GlobalData
    {
       public static string connectionString = "server=localhost;uid=root;pwd=mysql@0000;database=car_rental_management";
        public static string customerName;
        public static int customerId;
        public static string customerEmail;
        public static string adminUsername = "admin";
        public static string adminPassword = "admin";
        public static string customerPassword;
        public static string customerAddress;
        public static string customerPhone;

    }
}
