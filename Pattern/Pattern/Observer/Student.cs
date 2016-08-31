using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Observer
{
    public class Student:Observer
    {
        private string Name;
        public Student(string Name,Subject someone)
        {
            this.Name = Name;
            someone.AimAt(this);
        }
        public void Criticized()
        {
            Console.WriteLine("{0} is Criticized by SchoolMaster!",this.Name);
        }
    }
}
