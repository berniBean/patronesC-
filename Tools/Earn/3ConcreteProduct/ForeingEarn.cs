﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Earn._2Product;

namespace Tools.Earn._3ConcreteProduct
{
    public class ForeingEarn : IEarn
    {
        private decimal _percentage;
        private decimal _extra;

        public ForeingEarn(decimal percentage, decimal extra)
        {
            _percentage = percentage;
            _extra = extra;
        }

        public decimal Earn(decimal amount)
        {
            return (amount * _percentage) + _extra;
        }
    }
}
