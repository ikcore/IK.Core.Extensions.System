using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace IK.Core.Extensions.System
{
    public static class StringExtensions
    {
        public static string Truncate(this string value, int maxLen)
        {
            return value.Length > maxLen ? value.Substring(0, maxLen) : value;
        }
        public static string ConvertWhitespacesToSingleSpaces(this string value)
        {
            return Regex.Replace(value, @"\s+", " ");
        }
        public static string ConvertWhitespacesToString(this string value, string chars)
        {
            return Regex.Replace(value, @"\s+", chars);
        }
        public static byte[] ToASCIIBytes(this string value)
        {
            return Encoding.ASCII.GetBytes(value);
        }
        public static byte[] ToASCIIHashBytes(this string value)
        {
            return SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(value));
        }
        public static byte[] ToUTF8Bytes(this string value)
        {
            return Encoding.UTF8.GetBytes(value);
        }
        public static byte[] ToUTF8HashBytes(this string value)
        {
            return SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(value));
        }
    }
}
