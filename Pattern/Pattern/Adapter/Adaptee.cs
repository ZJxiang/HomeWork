using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Adapter
{
    public class Adaptee
    {
        public void VoltageWeNeed()
        {
            Console.WriteLine("220V");        
        }
    }
}
