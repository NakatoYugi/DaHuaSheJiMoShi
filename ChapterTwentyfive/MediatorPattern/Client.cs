using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Client
    {
        static void Main(string[] args)
        {
            UnitedNationSecurityCouncil UNSC = new UnitedNationSecurityCouncil(); //中介者

            USA usa = new USA(UNSC);
            Iraq iraq = new Iraq(UNSC);

            UNSC.usa = usa;
            UNSC.iraq = iraq;

            usa.Declare("不准研制核武器，否则要发动战争");
            iraq.Declare("我们没有核武器，也不怕侵略");

            Console.Read();
        }
    }
}
