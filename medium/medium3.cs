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
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Concurrent;

class ResultMedium3
{

    /*
     * Complete the 'encryption' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     * https://www.hackerrank.com/challenges/encryption/problem?isFullScreen=true
     */

    public static string encryption(string s)
    {
        string cleanedString = s.Replace(" ", "");
        int stringLength = cleanedString.Length;

        double lengthSquareRoot = Math.Sqrt(stringLength);

        int floor = Convert.ToInt32(Math.Floor(lengthSquareRoot));
        int ceiling = Convert.ToInt32(Math.Ceiling(lengthSquareRoot));

        if (floor*ceiling < stringLength) {
            floor = ceiling;
        }

        char[][] encoded = new char[floor][];

        int partition = ceiling; // this corresponds to the columns
        int partitionLength = 0;
        for (int row = 0; row < floor; row++) {
            if ((row+1)*partition > stringLength){
                partitionLength = ceiling - ((row+1)*partition - stringLength);
            }
            else {
                partitionLength = partition;
            }
            string partitionedString = cleanedString.Substring(row*partition, partitionLength);
            char[] column  = new char[ceiling];
            int colIndex = 0;
            foreach (char letter in partitionedString) {
                column[colIndex] = letter;
                colIndex++;
            }
            encoded[row] = column;
        }

        string finalString = "";
        for (int columns = 0; columns < ceiling; columns ++) {
            for (int rows = 0; rows < floor; rows++) {
                char letter = encoded[rows][columns];
                if (letter == '\0') {
                    letter = ' ';
                }
                finalString = finalString + letter;
            }
            finalString = finalString + " ";
        }

        return finalString;
    }

}

namespace medium.medium3
{
    class SolutionMedium3
    {
        public static void solve()
        {
            string s = Console.ReadLine();

            string result = ResultMedium3.encryption(s);

            Console.WriteLine(result);
        }
    }   
}