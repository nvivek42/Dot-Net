using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousApp
{
    public  static class MathEngine
    {
        public static int addition(this Account acct, int a, int b)
        {
            return a+b;
        }
    }
}
