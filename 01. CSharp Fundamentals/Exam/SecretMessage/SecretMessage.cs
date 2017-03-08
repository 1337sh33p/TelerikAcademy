using System;

namespace SecretMessage
{
    class SecretMessage
    {
        static void Main()
        {
            string message = "";
            int start = 0;
            int end = 0;

            for (int i = 1; ; i++)
            {
                string S = Console.ReadLine();
                bool success = int.TryParse(S, out start);
                if (success == false)
                {
                    break;
                }
                end = int.Parse(Console.ReadLine());
                string text = Console.ReadLine();
                char[] secret = text.ToCharArray();
                if (start >= 0 && end >= 0)
                {
                    for (int chars = start; chars <= end;)
                    {
                        if (i % 2 == 0)
                        {
                            message += secret[chars];
                            chars += 4;
                        }
                        else
                        {
                            message += secret[chars];
                            chars += 3;
                        }
                    }
                }
                else if (start < 0 && end <0)
                {
                    start = secret.Length + start;
                    end = secret.Length + end;
                    for (int chars = start; chars <= end;)
                    {
                        if (i % 2 == 0)
                        {
                            message += secret[chars];
                            chars += 4;
                        }
                        else
                        {
                            message += secret[chars];
                            chars += 3;
                        }
                    }
                }
                else if (start < 0)
                {
                    start = secret.Length + start;
                    for (int chars = start; chars <= end;)
                    {
                        if (i % 2 == 0)
                        {
                            message += secret[chars];
                            chars += 4;
                        }
                        else
                        {
                            message += secret[chars];
                            chars += 3;
                        }
                    }
                }
                else if (end < 0)
                {
                    end = secret.Length + end;
                    for (int chars = start; chars <= end;)
                    {
                        if (i % 2 == 0)
                        {
                            message += secret[chars];
                            chars += 4;
                        }
                        else
                        {
                            message += secret[chars];
                            chars += 3;
                        }
                    }
                }
            }   
                    Console.WriteLine(message);
        }
    }
}
