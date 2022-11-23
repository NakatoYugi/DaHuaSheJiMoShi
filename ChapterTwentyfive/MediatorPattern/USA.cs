﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class USA : Country
    {
        public USA(UniteNations mediator) : base(mediator)
        {
        }

        public void Declare(string message) { mediator.Declare(message, this); }

        public void GetMessage(string message) { Console.WriteLine("美国获得对方信息：" + message); }
    }
}
