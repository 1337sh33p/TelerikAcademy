using System;


class HexadecimalToBinary
{
    static string[] hexaDecimal;
    static string[] result;
    static string hexaDec;

    static string HexToBinary(string[] hex)
    {
        result = new string [hex.Length];
        for (int i = 0; i < hex.Length; i++)
        {
            switch (hex[i])
            {
                case "0": result[i] = "0000"; break;
                case "1": result[i] = "0001"; break;
                case "2": result[i] = "0010"; break;
                case "3": result[i] = "0011"; break;
                case "4": result[i] = "0100"; break;
                case "5": result[i] = "0101"; break;
                case "6": result[i] = "0110"; break;
                case "7": result[i] = "0111"; break;
                case "8": result[i] = "1000"; break;
                case "9": result[i] = "1001"; break;
                case "A": result[i] = "1010"; break;
                case "B": result[i] = "1011"; break;
                case "C": result[i] = "1100"; break;
                case "D": result[i] = "1101"; break;
                case "E": result[i] = "1110"; break;
                case "F": result[i] = "1111"; break;
            }
           
            hexaDec += result[i];
            
        }
        return hexaDec;
    }

    static void Main()
    {
        string hexNumber = Console.ReadLine();
        hexaDecimal = new string[hexNumber.Length];

        for (int i = 0; i < hexNumber.Length; i++)
        {
            hexaDecimal[i] = hexNumber[i].ToString();
        }

        string hexaNum = HexToBinary(hexaDecimal);

        Console.WriteLine(hexaNum.Substring(hexaNum.IndexOf('1')));
    }
}
