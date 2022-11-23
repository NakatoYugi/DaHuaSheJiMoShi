using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    //联合国机构
    public abstract class UniteNations
    {
        public abstract void Declare(string message, Country colleague);
    }
}
