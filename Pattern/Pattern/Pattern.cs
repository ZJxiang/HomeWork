using Pattern.Adapter;
using Pattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    public class Pattern
    {
        static void Main(string[] args)
        {
            SchoolMaster schoolmaster = new SchoolMaster();
            Teacher T1 = new Teacher("陈老师", schoolmaster);
            Teacher T2 = new Teacher("李老师", schoolmaster);
            Student S1 = new Student("小赵",schoolmaster);
            schoolmaster.Criticized();

            Adaptee adaptee = new Adaptee();
            Adaptera adapters = new Adaptera();
            adapters.GetAdaptee(adaptee);
            adapters.VoltageChange();

            Console.ReadKey();
        }
    }
}
