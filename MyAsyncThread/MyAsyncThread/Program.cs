using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace MyAsyncThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskList = new List<Task>();
            int totalCount = 0;
            var initList = new List<int>();
            Console.WriteLine($"Main threadId:{Thread.CurrentThread.ManagedThreadId}-{DateTime.Now}");
            for (int i = 0; i < 10; i++)
            {
                int newI = i;
                taskList.Add(new TaskFactory().StartNew(() =>
                {
                    Console.WriteLine($"Task{newI}:{Thread.CurrentThread.ManagedThreadId}-{DateTime.Now}");
                    totalCount += 1;
                    initList.Add(newI);
                }));
            }

            Task.WaitAll(taskList.ToArray());
            Console.WriteLine("*****Complete********");
            Console.WriteLine(totalCount);
            Console.WriteLine(initList.Count);
            Console.WriteLine("Hello World!");
        }
    }
}
