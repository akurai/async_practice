using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using myLib;

namespace async_practice
{
    class Program
    {
        private static int taskLength = 10000;
        static async Task Main(string[] args)
        {
            Console.WriteLine("********Antal Kurai's practice program to learn how asyncronous programming works********\n\n");
            await myLib.AsyncronousProgram.Start(taskLength);

        }
    }
}
