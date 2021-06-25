using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Earn._1Creator;
using Tools.Earn._2Product;
using Tools.Earn._3ConcreteProduct;

namespace Tools.Earn._4ConcreteCreator
{
    public class ForeingEarnFactory : EarnFactory
    {
        private decimal _percentage;
        private decimal _extra;

        public ForeingEarnFactory(decimal percentage, decimal extra)
        {
            _percentage = percentage;
            _extra = extra;
        }

        public override IEarn GetEarn()
        {
            return new ForeingEarn(_percentage, _extra);
        }
    }
}
