using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;
        public CashRebate(string monyRebate)
        {
            this.moneyRebate = double.Parse(monyRebate);
        }

        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}
