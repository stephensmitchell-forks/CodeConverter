using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace EmptyVb
{
    internal class AClass
    {
        private Dictionary<int, int> dict = new Dictionary<int, int>();

        private void UseOutParameterInClass()
        {
            var x = default(object);
            int argvalue = Conversions.ToInteger(x);
            dict.TryGetValue(1, out argvalue);
        }

        private void UseEnumFromOtherFileInSolution(AnEnum m)
        {
            string nothing = Enumerable.Empty<string>().ToArray()[(int)AnEnum.AnEnumMember];
            switch (m)
            {
                case (AnEnum)(-1
               ):
                    {
                        return;
                    }

                case AnEnum.AnEnumMember:
                    {
                        return;
                    }
            }
        }
    }
}
