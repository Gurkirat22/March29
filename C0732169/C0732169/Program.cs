﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C0732169
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("downloading a file");
            Download();
            Console.ReadLine();
        }

        static void Download()
        {
<<<<<<< HEAD
            Thread.Sleep(3000);
            Console.WriteLine("Download complete...");
        }
=======
        Thread.Sleep(7000);
>>>>>>> 47f8a5d902d6c55f3157ddbd3474df455032f3ec
    }
}