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
    public class LocalEarnFactory : EarnFactory
    {
        private decimal _percentage;

        public LocalEarnFactory(decimal percentage)
        {
            _percentage = percentage;
        }

        public override IEarn GetEarn()
        {
            return new LocalEarn(_percentage);
        }
    }
}
