using System;
using System.Collections.Generic;
using System.Text;

namespace IK.Core.Extensions.System
{
    public static class IntExtensions
    {
        public static bool IsNullOrEmpty(this short? value)
        {
            return (value == null || !value.HasValue);
        }
        public static bool IsNullOrEmpty(this Int32? value)
        {
            return (value == null || !value.HasValue);
        }
        public static bool IsNullOrEmpty(this Int64? value)
        {
            return (value == null || !value.HasValue);
        }
    }

    public static class FloatExtensions
    {
        public static bool IsNullOrEmpty(this float? value)
        {
            return (value == null || !value.HasValue);
        }
        public static bool IsNullOrEmpty(this double? value)
        {
            return (value == null || !value.HasValue);
        }
    }

    public static class DecimalExtensions
    {
        public static bool IsNullOrEmpty(this decimal? value)
        {
            return (value == null || !value.HasValue);
        }
    }
}
