using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Adapter
{
    public class Adaptera:Target
    {
        //public static string read()
        //{
        //    string InitialVoltage = Console.ReadLine().Trim() ;
        //    return InitialVoltage;
        //}
        private Adaptee adaptee;
        public void GetAdaptee(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        public void VoltageChange()
        {
            adaptee.VoltageWeNeed();
        }
    }
}
