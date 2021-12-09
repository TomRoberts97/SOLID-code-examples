
using System;
using System.Collections.Generic;
using SOLID_code_examples.DIP;
using SOLID_code_examples.DIP.Failing;
//using SOLID_code_examples.ISP.Failing;

namespace SOLID_code_examples
{
    class Program
    {
        //DIP MAIN
        static void Main(string[] args)
        {
            var cus = Factory.CreateCustomer("1", "Tom", "tom@gmail.com");

            var order = Factory.CreateOrder("123abc", cus, new List<string> { }, 0, false);


            order.AddProduct("beer", 5.50m);

            order.CompleteOrder();

        }



        //ISP MAIN
        //static void Main(string[] args)
        //{
        //    var cus = new Customer("1000", "Tom", "tom@gmail.com");
        //    cus.SignIn();

        //    Console.WriteLine(cus.DriverID); // customer calling DriverID


        //    var driver = new Driver("1001", "Bob", "driverBob@gmail.com", "222");
        //    driver.AcceptOrder();

        //    Console.WriteLine(driver.AdminPermissions); // driver calling AdminPermissions

        //    var admin = new Admin("1", "admin@gmail.com");
        //    admin.DeleteAccount();


        //    Console.ReadKey();
        //}
    }
}
