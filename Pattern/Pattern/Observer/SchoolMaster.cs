using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Observer
{
    public class SchoolMaster:Subject
    {
        private ArrayList observers;
        private string Name;
        public SchoolMaster()
        {
            this.observers = new ArrayList();
        }
        public void AimAt(Observer someone)
        {
            this.observers.Add(someone);
        }
        public void Criticized()
        {
            Console.WriteLine("SchoolMaster is angry!");
            foreach (Observer someone in this.observers)
            {
                someone.Criticized();
            }
        }
    }
}
