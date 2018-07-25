using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        public static void Basics(int[] x)
        {
            // for(var i = 0; i<256; i++){
            //     Console.WriteLine(i);
            // }
            // for(var i = 0; i<256; i++)
            // {
            //     if(i%2==1){
            //         Console.WriteLine(i);
            //     }
            // }
            // int sum = 0;
            // for(var i =0; i< 256; i++){
            //     sum += i;
            //     Console.WriteLine("New Number: " + i + " Sum: " + sum);
            // }
            // int[] x = {1,3,5,7,9,13};
            // for(var i = 0; i < x.Length; i++){
            //     Console.WriteLine(x[i]);
            // }
            // int max = 0;
            // for(var i =0; i <x.Length; i++){
            //     max += x[i];
            // }
            // Console.WriteLine(max);
            int sum = 0;
            int avg = 0;
            for(var i =0; i<x.Length; i++){
                sum += x[i];
            }
            avg = sum/x.Length;
            Console.WriteLine(avg);
        }
        static void Main(string[] args)
        {
            int[] x = {1,2,23,4,5};
            Basics(x);
        }
    }
}
