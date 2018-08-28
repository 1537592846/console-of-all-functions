using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_of_all_functions.libraries.intern
{
    class Parse
    {
        public static object ParseValue(string type, string value)
        {
            switch (type.ToLower())
            {
                case "int32":
                case "int64": return int.Parse(value);
                case "datetime": return DateTime.Parse(value);
                case "double": return Double.Parse(value);
                default: throw new ArgumentException("DataType is not supported");
            }
        }
    }
}
