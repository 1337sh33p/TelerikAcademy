using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FunctionalNumeralSystem
{
    class Program
    {
        static string ConvertToDecimal(string num)
        {
            string[] strangeSystem = { "ocaml", "haskell", "scala", "f#", "lisp", "rust", "ml", "clojure", "erlang", "standardml", "racket", "elm", "mercury", "commonlisp", "scheme", "curry" };
            StringBuilder wtf = new StringBuilder();
            wtf.Append(num);
            wtf.Replace("haskell", "B");
            wtf.Replace("f#", "D");
            wtf.Replace("commonlisp", "N");
            wtf.Replace("lisp", "E");
            wtf.Replace("rust", "F");
            wtf.Replace("clojure", "H");
            wtf.Replace("racket", "K");
            wtf.Replace("mercury", "M");
            wtf.Replace("curry", "P");
            wtf.Replace("ocaml", "A");
            wtf.Replace("scala", "C");
            wtf.Replace("erlang", "I");
            wtf.Replace("standardml", "J");
            wtf.Replace("elm", "L");
            wtf.Replace("scheme", "O");
            wtf.Replace("ml", "G");

            var theNumber = wtf.ToString();

            return theNumber;
        }

        static BigInteger BaseTransform(int NumBase, string number)
        {
            BigInteger result = 0;
            foreach (var digit in number)
            {
                result = result * NumBase + (digit - 'A');
            }
            return result;
        }

        static void Main()
        {
            //input
            string[] separator = { ", " };
            var theNumbers = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();

            // logic
           var number1 = ConvertToDecimal(theNumbers[0]);
           var number2 = ConvertToDecimal(theNumbers[1]);
           var number3 = ConvertToDecimal(theNumbers[2]);

            var num1InDeci = BaseTransform(16, number1);
            var num2InDeci = BaseTransform(16, number2);
            var num3InDeci = BaseTransform(16, number3);

            //output = product of three numbers
            BigInteger finalResult = num1InDeci * num2InDeci * num3InDeci;
            Console.WriteLine(finalResult);
        }
    }
}
