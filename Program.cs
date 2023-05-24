using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello World!!");

        for (int i = 0; i < sb.Length; i++)
            Console.Write(sb[i]);
    }
}