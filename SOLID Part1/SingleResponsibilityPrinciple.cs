using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples
{
    class SingleResponsibilityPrinciple
    {
    }


    // BAD

    // the Add method below has 2 responsibilities.
    // Adding a customer to the database AND constructing a file logger.

    //class Customer
    //{

    //    void AddToDatabase(Database db) 
    //    {
    //        try
    //        {
    //            db.Add();
    //        }
    //        catch (Exception ex)
    //        {
    //            File.WriteAllText(@"C:\Error.txt", ex.ToString());   //this should be handled seperately 
    //        }
    //    }
    //}












    // GOOD

    // a seperate file logger class has been created to handle logging
    // this new logger is newed up and used in the customer class instead

    //class Customer
    //{
    //    private FileLogger logger = new FileLogger();

    //    void AddToDatabase(Database db)
    //    {
    //        try
    //        {
    //            db.Add();
    //        }
    //        catch (Exception ex)
    //        {
    //            logger.Log(ex.ToString());
    //        }
    //    }
    //}

    //class FileLogger
    //{
    //    public void Log(string error)
    //    {
    //        File.WriteAllText(@"C:\Error.txt", error);
    //    }
    //}

    // if we wanted to change or update the logger in some way, it only needs to be done in one place.

    // imagine changing all the File.WriteAllText(@"C:\Error.txt", ex.ToString()); throughout a codebase. Not fun.
}
