using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_code_examples
{
    class LiskovSubstitutionPrinciple
    {
    }

    // BAD
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Apple apple = new Orange();
    //        Debug.WriteLine(apple.GetColor());
    //    }
    //}
    //public class Apple
    //{
    //    public virtual string GetColor()
    //    {
    //        return "Red";
    //    }
    //}
    //public class Orange : Apple
    //{
    //    public override string GetColor()
    //    {
    //        return "Orange";
    //    }
    //}







    //GOOD
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Fruit fruit = new Orange();
    //        Debug.WriteLine(fruit.GetColor());
    //        fruit = new Apple();
    //        Debug.WriteLine(fruit.GetColor());
    //    }
    //}
    //public abstract class Fruit
    //{
    //    public abstract string GetColor();
    //}
    //public class Apple : Fruit
    //{
    //    public override string GetColor()
    //    {
    //        return "Red";
    //    }
    //}
    //public class Orange : Fruit
    //{
    //    public override string GetColor()
    //    {
    //        return "Orange";
    //    }
    //}
}
