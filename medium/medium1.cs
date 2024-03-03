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
using System.Reflection.PortableExecutable;

class ResultMedium1
{

    /*
     * Complete the 'extraLongFactorials' function below.
     *
     * The function accepts INTEGER n as parameter.
     * https://www.hackerrank.com/challenges/extra-long-factorials/problem?isFullScreen=true
     */

    public static double extraLongFactorials(double n)
    {
        if (n == 1) {
            return n;
        }

        return n*extraLongFactorials(n - 1);

    }


}

namespace medium.medium1 {
    class SolutionMedium1
    {
        public static void solve()
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine(ResultMedium1.extraLongFactorials(n));
        }
    }
}