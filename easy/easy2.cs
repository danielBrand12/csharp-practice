using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Net.Http.Headers;
using System.Xml.Schema;
using System.Runtime.InteropServices;

class ResultEasy2
{

    /*
     * Complete the 'bonAppetit' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY bill
     *  2. INTEGER k
     *  3. INTEGER b
     * https://www.hackerrank.com/challenges/bon-appetit/problem?isFullScreen=true
     */

    public static void bonAppetit(List<int> bill, int k, int b)
    {
        int index = 0;
        int total = 0;
        foreach(int product in bill) {
            if (index != k) {
                total += product;
            }
            index += 1;
        }
        if (total != 0) {
            int total_pay = total / 2;
            if (total_pay == b) {
                Console.WriteLine("Bon Appetit");
            }
            else {
                Console.WriteLine(b - total_pay);
            }
        }
        else {
            Console.WriteLine("Process Failed");
        }

    }

}

namespace easy.easy2 {
    class SolutionEasy2
    {
        public static void solve()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            // items ordered
            int n = Convert.ToInt32(firstMultipleInput[0]);
            if (2 > n || n > 10e5) {
                throw new Exception("Not a valid number of items");
            }

            int k = Convert.ToInt32(firstMultipleInput[1]);
            if ( 0 > k || k >= n) {
                throw new Exception("Not a valid index");
            }
            
            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            ResultEasy2.bonAppetit(bill, k, b);
        }
    }
}