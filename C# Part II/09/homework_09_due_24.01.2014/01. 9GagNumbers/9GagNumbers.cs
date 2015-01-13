using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._9GagNumbers
{
    class Program
    {
        // this string comprises a total of 64 unique digits for conversion purposes
        public const string allDigits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz#$";

        static public ulong SimplePow(ulong num, ulong pow)
        {
            ulong result = 1;

            for (ulong i = 0; i < pow; i++)
            {
                result *= num;
            }

            return result;
        }

        static public ulong ConvertSToDec(string sourceNum, ulong numeralSys)
        {
            ulong result = 0;
            ulong pow = 0;

            for (int i = sourceNum.Length - 1; i >= 0; i--)
            {
                result += (ulong)allDigits.IndexOf(sourceNum[i]) * SimplePow(numeralSys, pow);
                pow++;
            }

            return result;
        }

        static public string DecodeDigit(string source)
        {
            switch (source)
            {
                case "-!": return "0"; break;
                case "**": return "1"; break;
                case "!!!": return "2"; break;
                case "&&": return "3"; break;
                case "&-": return "4"; break;
                case "!-": return "5"; break;
                case "*!!!": return "6"; break;
                case "&*!": return "7"; break;
                case "!!**!-": return "8"; break;
                default: return "no"; break;
            }
        }

        static public string Decode(string sourceStr)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder source = new StringBuilder(sourceStr);


            while (source.Length > 0)
            {
                int index = 0;

                StringBuilder currentDigit = new StringBuilder(source[index].ToString());

                string resDigit = DecodeDigit(currentDigit.ToString());

                while (resDigit == "no")
                {
                    if (index + 1 < source.Length)
                    {
                        index++;
                        currentDigit.Append(source[index]);
                        resDigit = DecodeDigit(currentDigit.ToString());
                    }                    
                }

                result.Append(resDigit);

                if (resDigit == "0" || resDigit == "1" || resDigit == "3" || resDigit == "4" || resDigit == "5")
                {
                    source.Remove(0, 2);
                }
                else if (resDigit == "2" || resDigit == "7")
                {
                    source.Remove(0, 3);
                }
                else if (resDigit == "8")
                {
                    source.Remove(0, 6);
                }
                else
                {
                    source.Remove(0, 4);
                }
            }

            return result.ToString();
        }

        static void Main()
        {
            string sourceNum = Console.ReadLine();
            string resultNum = Decode(sourceNum);
            
            // 871265340

            // !!**!-&*!**!!!*!!!!-&&&--!

            //Console.WriteLine(resultNum);

            Console.WriteLine(ConvertSToDec(resultNum, 9));

        }
    }
}