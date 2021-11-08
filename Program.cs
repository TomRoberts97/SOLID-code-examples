using SOLID_code_examples.OCP.Failing;
using SOLID_code_examples.OCP.Passing;
using SOLID_code_examples.SRP;
using SOLID_code_examples.SRP.Passing;
using System;

namespace SOLID_code_examples
{
    class Program
    {
        //SRP FAIL
        //static void Main(string[] args)
        //{
        //    var customer = new Customer("Tom", "Wales", 24);

        //    customer.RegisterCustomer();

        //    Console.ReadKey();
        //}

        //OCP FAIL
        //static void Main(string[] args)
        //{
        //    var user = new BeeliveryUser("tom", "Driver");

        //    user.SignIn();

        //    Console.ReadKey();
        //}



        //OCP Pass
        //static void Main(string[] args)
        //{
        //    var user1 = new Kustomer();
        //    var user2 = new Driver();
        //    var user3 = new Admin();



        //    user1.SignIn();

        //    Console.ReadKey();
        //}

























        // SRP PASSING

        //static void Main(string[] args)
        //{
        //    var customer = new Customer("Tom", "Wales", 24);

        //    customer.RegisterCustomer();


        //    // What if we wanted customers emails recorded and an email sent to them once registration is complete?

        //    // This would mean Customer class has TWO reasons to change!

        //    var customerNew = new CustomerNew("Jack", "England", 55, "Jack@gmail.com", "password");
        //    var emailService = new EmailService();
        //    var customerService = new CustomerService(emailService);

        //    customerService.RegisterCustomer(customerNew);


        //    Console.ReadKey();
        //}



        // OCP PASSING
    }
}
