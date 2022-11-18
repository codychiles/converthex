using System;
using System.Text;

namespace converthex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertHex("fortnite");
        }
        static void ConvertHex(string minecraft)
        {

            byte[] fortnite = Encoding.Default.GetBytes("sample");
            var hexString = BitConverter.ToString(fortnite).ToLower();
            hexString = hexString.Replace("-", " ");

            Console.WriteLine("Hex value: " + hexString);
        }
    }
}
