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

class ResultMedium2
{

    /*
     * Complete the 'timeInWords' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER h
     *  2. INTEGER m
     */

    public static Dictionary<string, string> numbers =
            new Dictionary<string, string>{
                ["00"] = "cero",
                ["01"] = "one",
                ["02"] = "two",
                ["03"] = "three",
                ["04"] = "four",
                ["05"] = "five",
                ["06"] = "six",
                ["07"] = "seven",
                ["08"] = "eight",
                ["09"] = "nine",
                ["0"] = "cero",
                ["1"] = "one",
                ["2"] = "two",
                ["3"] = "three",
                ["4"] = "four",
                ["5"] = "five",
                ["6"] = "six",
                ["7"] = "seven",
                ["8"] = "eight",
                ["9"] = "nine",
                ["10"] = "ten",
                ["11"] = "eleven",
                ["12"] = "twelve",
                ["13"] = "thirteen",
                ["14"] = "fourteen",
                ["15"] = "quarter",
                ["16"] = "sixteen",
                ["17"] = "seventeen",
                ["18"] = "eighteen",
                ["19"] = "nineteen",
                ["20"] = "twenty",
                ["21"] = "twenty one",
                ["22"] = "twenty two",
                ["23"] = "twenty three",
                ["24"] = "twenty four",
                ["25"] = "twenty five",
                ["26"] = "twenty six",
                ["27"] = "twenty seven",
                ["28"] = "twenty eight",
                ["29"] = "twenty nine",
                ["30"] = "thirty"
            };



    public static string timeInWords(string h, string m)
    {
        int intHours = Convert.ToInt32(h);
        int intMinutes = Convert.ToInt32(m);

        if (intMinutes == 0) {
            return ResultMedium2.numbers[h] + " o' clock";
        } 
        else if (intMinutes == 1) {
            return ResultMedium2.numbers[m] + " minute past " + ResultMedium2.numbers[h];
        } else if (intMinutes == 15) {
            return ResultMedium2.numbers[m] + " to " + ResultMedium2.numbers[h];
        }
        else if (intMinutes < 30) {
            return ResultMedium2.numbers[m] + " minutes past " + ResultMedium2.numbers[h];
        } else if (intMinutes > 30) {
            string reverseValue = Convert.ToString(60-intMinutes);
            string nextHour = Convert.ToString(intHours + 1);
            if (reverseValue == "1") {
                return ResultMedium2.numbers[reverseValue] + " minute to " + ResultMedium2.numbers[nextHour];
            } else if (reverseValue == "15") {
                return ResultMedium2.numbers[reverseValue] + " to " + ResultMedium2.numbers[nextHour];
            }
            return ResultMedium2.numbers[reverseValue] + " minutes to " + ResultMedium2.numbers[nextHour];
        } else if (intMinutes == 30) {
            return "half past " + ResultMedium2.numbers[h];
        }else {
            return "Not a valid value";
        }
    }

}

namespace medium.medium2 {
    class SolutionMedium2
    {
        public static void solve()
        {

            string h = Console.ReadLine().Trim();

            string m = Console.ReadLine().Trim();

            string result = ResultMedium2.timeInWords(h, m);

            Console.WriteLine(result);
        }
    }
}