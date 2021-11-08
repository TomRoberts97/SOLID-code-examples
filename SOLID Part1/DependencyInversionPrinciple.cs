using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples
{
    class DependencyInversionPrinciple
    {
    }
}

    //BAD 

    //class FileLogger
    //{
    //    void Handle(string error)
    //    {
    //        File.WriteAllText(@"C:\Error.txt", error);
    //    }
    //}

    //internal class Customer
    //{
    //    FileLogger logger = new FileLogger(); // this makes the Customer class dependent on FileLogger

    //    public void Add(Database db)
    //    {
    //        try
    //        {
    //            db.Add();
    //        }
    //        catch (Exception error)
    //        {
    //            logger.Handle(error.ToString());
    //        }
    //    }
    //}







    //GOOD 

    // ties in with the single responsibility principle

    // What if we wanted to log a different way ?


//    interface ILogger  // General ILogger interface, all our new loggers will implement this interface 
//    {
//        void Handle(string error);
//    }

//    class EmailLogger : ILogger
//    {
//        void Handle(string error)
//        {
//            File.WriteAllText(@"C:\Error.txt", error);
//        }
//    }

//    class Customer
//    {
//        ILogger logger;
//        Customer(ILogger logger) // ILogger is injected into Customer, this means any kind of Logger that implements ILogger can be passed into Customer
//        {
//            this.logger = logger;
//        }

//        void Add(Database db)
//        {
//            try
//            {
//                db.Add();
//            }
//            catch (Exception error)
//            {
//                logger.Handle(error.ToString());
//            }
//        }
//    }

//    void UseDependencyInjectionForLogger()
//    {
//        var customer = new Customer(new EmailLogger()); // This shows the new email logger being injected into Customer
//        customer.Add(new Database());
//    }
//}
