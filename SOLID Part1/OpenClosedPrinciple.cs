using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples
{
    class OpenClosedPrinciple
    {
    }


    // BAD

    // the Add method has different implementation for customers of different types.
    // One for new customers and one for Existing customers.
    // meaning if we wanted to add more customer types, the existing code would need to be modified.

    //class Customer
    //{
    //    int Type;

    //    void AddToDatabase(Database db)
    //    {
    //        if (Type == 0)
    //        {
    //            db.Add();
    //        }
    //        else
    //        {
    //            db.AddExistingCustomer();
    //        }
    //    }
    //}











    //GOOD

    // Its now been broken up into a parent customer class and two child customer classes.
    // now if more types of customer need to be added we can do this without modifying any existing code.


    //class Customer
    //{
    //    void AddToDatabase(Database db)
    //    {
    //        db.Add();
    //    }
    //}

    //class ExistingCustomer : Customer
    //{
    //    override void AddToDatabase(Database db)
    //    {
    //        db.AddExistingCustomer();
    //    }
    //}

    //class AnotherCustomer : Customer
    //{
    //    override void AddToDatabase(Database db)
    //    {
    //        db.AddAnotherCustomer();
    //    }
    //}

    //class AnotherCustomer2 : Customer
    //{
    //    override void AddToDatabase(Database db)
    //    {
    //        db.AddAnother2Customer();
    //    }
    //}
}
