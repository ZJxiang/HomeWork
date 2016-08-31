using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Observer
{
    public interface Subject
    {
        void AimAt(Observer Person);
    }
}
