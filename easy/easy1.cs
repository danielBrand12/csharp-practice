// Example
// a = 7
// b = 3
// Return 10.
// Function Description
// Complete the solveMeFirst function in the editor below.
// solveMeFirst has the following parameters:
//     int a: the first value
//     int b: the second value

// Returns
// - int: the sum of a and b

using System;
using System.Collections.Generic;
using System.IO;

namespace easy.easy1{
    class SolutionEasy1 {

        static int solveMeFirst(int a, int b) { 
        if (a < 1 || a > 1000 || b < 1 || b > 1000){
            throw new Exception("Out of range");
        }
        return a + b;
        }

        public static void solve() {
            Console.WriteLine("Insert first number:");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert second number:");
            int val2 = Convert.ToInt32(Console.ReadLine());
            try {
                int sum = solveMeFirst(val1,val2);
                Console.WriteLine(sum);
            }
            catch(Exception ex) {
                Console.WriteLine(ex.ToString());
            }         
        }
    } 
}     
