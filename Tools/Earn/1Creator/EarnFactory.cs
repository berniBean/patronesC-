using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Earn._2Product;

namespace Tools.Earn._1Creator
{
    public abstract class EarnFactory
    {
        public abstract IEarn GetEarn();
    }
}
