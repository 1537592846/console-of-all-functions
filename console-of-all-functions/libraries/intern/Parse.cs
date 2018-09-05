using System;

namespace console_of_all_functions.libraries.intern
{
    class Parse
    {
        public static object ParseValue(string type, string value)
        {
            switch (type.ToLower())
            {
                case "int32": return int.Parse(value);
                case "int64": return Int64.Parse(value);
                case "long": return long.Parse(value);
                case "datetime": return DateTime.Parse(value);
                case "double": return Double.Parse(value);
                case "string": return value;
                default: throw new ArgumentException("DataType is not supported");
            }
        }
    }
}
