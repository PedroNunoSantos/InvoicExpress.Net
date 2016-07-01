using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace InvoicExpress.Net
{
    public static class XmlConverterHelpers
    {
        const string DateFormat = @"dd\/MM\/yyyy";
        const string FloatFormat = "N2";
        
        public static string ToXml<T>(this T data)
        {
            if (typeof(T) == typeof(float?))
            {
                var floatValue = data as float?;
                return floatValue.HasValue ? floatValue.Value.ToString(FloatFormat, CultureInfo.InvariantCulture) : null;
            }

            if (typeof(T) == typeof(DateTime?))
            {
                var dateValue = data as DateTime?;
                return dateValue.HasValue ? dateValue.Value.ToString(DateFormat, CultureInfo.InvariantCulture) : null;
            }

            if (typeof(T) == typeof(int?))
            {
                var intValue = data as int?;
                return intValue.HasValue ? intValue.Value.ToString(CultureInfo.InvariantCulture) : null;
            }

            throw new ArgumentOutOfRangeException();
        }
        
        public static T FromXml<T>(this string str)
        {
            Type baseType = typeof(T);
            baseType = Nullable.GetUnderlyingType(baseType) ?? baseType;

            if (baseType == typeof(float))
            {
                float floatValue;
                if (float.TryParse(str, out floatValue))
                    return (T)Convert.ChangeType(floatValue, baseType);
                return default(T);
            }
            if (baseType == typeof(DateTime))
            {
                DateTime dateVal;
                if (DateTime.TryParseExact(str, DateFormat, null, DateTimeStyles.AssumeLocal,
                        out dateVal))
                    return (T)Convert.ChangeType(dateVal, baseType);
                return default(T);

            }
            if (baseType == typeof(int))
            {
                int intValue;
                if (int.TryParse(str, out intValue))
                    return (T)Convert.ChangeType(intValue, baseType);
                return default(T);
            }

            throw new ArgumentOutOfRangeException();
        }
	
    }
}