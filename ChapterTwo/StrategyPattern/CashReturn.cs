﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;
        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }
        public override double acceptCash(double money)
        {
            return money >= moneyCondition ? money - Math.Floor(money / moneyCondition) * moneyReturn : money;
        }
    }
}
