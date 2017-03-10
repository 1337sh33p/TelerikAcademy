using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PeshoCode
{
    class Startup
    {
        static void Main()
        {
            var keyWord = Console.ReadLine();
            var numberOfLines = int.Parse(Console.ReadLine());
            BigInteger result = 0;
            var start = 0;
            var partOfText = "";
            var text = new StringBuilder();
            var textFinal = "";

            for (int i = 0; i < numberOfLines; i++)
            {
                var line = Console.ReadLine();
                text.AppendLine(line);
            }
                textFinal = text.ToString();

            var positionOfKeyword = textFinal.IndexOf(keyWord);

            var dot = textFinal.IndexOf('.', positionOfKeyword);
            var qMark = textFinal.IndexOf('?', positionOfKeyword);

            if ((dot > qMark && qMark!= -1) || dot == -1)
            {
                start = positionOfKeyword + keyWord.Length + 1;
                partOfText = textFinal.Substring(start, qMark - start);
            }
            else if ((qMark > dot && dot != -1) || qMark == -1)
            {
                var indexOfPrevDot = textFinal.LastIndexOf('.', positionOfKeyword);
                var indexOfPrevQMark = textFinal.LastIndexOf('?', positionOfKeyword);

                if ((indexOfPrevDot> indexOfPrevQMark && indexOfPrevQMark != -1) || indexOfPrevDot == -1)
                {
                    start = indexOfPrevQMark + 1;
                    partOfText = textFinal.Substring(start, positionOfKeyword);
                }
                else if ((indexOfPrevQMark > indexOfPrevDot || indexOfPrevDot != -1)|| indexOfPrevQMark == -1)
                {
                    start = indexOfPrevDot + 1;
                    partOfText = textFinal.Substring(start, positionOfKeyword-start-1);
                }
            }

            string[] separators = { " ", "\r", "\n" }; 
            string[] words = partOfText.Split(separators,StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
                for (int j = 0; j < words[i].Length; j++)
                {
                    result+=words[i][j];
                }
            }
            Console.WriteLine(result);
        }
    }
}
