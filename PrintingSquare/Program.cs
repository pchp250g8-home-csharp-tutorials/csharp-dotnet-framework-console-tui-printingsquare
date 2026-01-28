using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrintingSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var strLine = "Hello,World!!! Printing Square!!!";
            Console.Clear();
            Console.CursorVisible = false;
            for (int i = 0; i < strLine.Length; i++)
            {
                Console.SetCursorPosition(10 + i, 10);
                Console.Write(strLine[i] + "\u2588");
                Thread.Sleep(500);
            }
            Console.SetCursorPosition(10, 10);
            Console.Write(strLine + " ");
            Console.ReadKey();
        }
    }
}
