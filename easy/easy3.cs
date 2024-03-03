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

class ResultEasy3
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     * https://www.hackerrank.com/challenges/sock-merchant/problem?isFullScreen=true
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        Dictionary<int, int> numberOfSocks =
            new Dictionary<int, int>();
        
        for (int sockIndex = 0; sockIndex < n; sockIndex++) {
            if (numberOfSocks.ContainsKey(ar[sockIndex])) {
                numberOfSocks[ar[sockIndex]] += 1;
            } else {
                numberOfSocks.Add(ar[sockIndex], 1);
            }
        }

        int numberOfPairs = 0;
        foreach(var item in numberOfSocks) {
            if (item.Value > 1) {
                if (item.Value % 2 == 0) {
                    numberOfPairs += item.Value / 2;
                } else {
                    numberOfPairs += (item.Value - 1) / 2;
                }
            }
            
        }
        return numberOfPairs;
    }

}

namespace easy.easy3{
    class SolutionEasy3 {
        public static void solve()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = ResultEasy3.sockMerchant(n, ar);

            Console.WriteLine(result);

        }
}
}
