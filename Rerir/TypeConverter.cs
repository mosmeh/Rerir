using System;
using System.ComponentModel;

namespace Rerir
{
    class PercentageTypeConverter: TypeConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(String))
            {
                return Math.Floor((double)value * 100) + "%";
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
