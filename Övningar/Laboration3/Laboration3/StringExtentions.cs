using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extentions
{
    static class StringExtentions
    {
        public static float MakeItFloat(this string Foo)
        {
            float Bar;
            bool IsNumber = float.TryParse(Foo, out Bar);

            if (IsNumber)
            {
                return Bar;
            }
            else
                return 0.0000f;



        }
    }
}
