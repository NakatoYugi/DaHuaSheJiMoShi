using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class UnitedNationSecurityCouncil : UniteNations
    {
        private USA _usa;
        private Iraq _iraq;

        public USA usa { set { _usa = value; } }
        public Iraq iraq { set { _iraq = value; } }
        public override void Declare(string message, Country colleague)
        {
            if (colleague == _usa)
            {
                _iraq.GetMessage(message);
            }

            if (colleague == _iraq)
            {
                _usa.GetMessage(message);
            }
        }
    }
}
