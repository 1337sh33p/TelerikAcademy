using System;

class ParseURL
{
    static void Main()
    {
        var input = Console.ReadLine();
        var protocol = input.Substring(0,input.IndexOf(':'));
        input = input.Remove(0, protocol.Length + 3);
        var server = input.Substring(0, (input.IndexOf('/')));
        input = input.Remove(0, server.Length);
        var resource = input;

        Console.WriteLine("[protocol] = {0}",protocol);
        Console.WriteLine("[server] = {0}",server);
        Console.WriteLine("[resource] = {0}",resource);
    }
}