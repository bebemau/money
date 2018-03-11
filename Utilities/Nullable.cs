using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class Nullable
    {
        public static int? ToNullableInt(this string input)
        {
            int i;
            if (int.TryParse(input, out i)) return i;
            return null;
        }

        public static double? ToNullableDouble(this string input)
        {
            double i;
            if (double.TryParse(input, out i)) return i;
            return null;
        }

        public static DateTime? ToNullableDateTime(this string input)
        {
            DateTime i;
            if (DateTime.TryParse(input, out i)) return i;
            return null;
        }
    }
}
