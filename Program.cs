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

class Solution
{

    // Complete the repeatedString function below.
    //
    //There is a string, , of lowercase English letters that is repeated infinitely many times.
    // Given an integer, , find and print the number of letter a's in the first  letters of the infinite string.
    //
    //
    //Example
    //
    // s = 'abcac'
    // n = 10
    //
    //The substring we consider is abcacabcac, the first 10 characters of the infinite string. There are 4 occurrences of 'a' in the substring.
    //
    //
    //Function Description
    //
    //Complete the repeatedString function in the editor below.
    //
    //repeatedString has the following parameter(s):
    //
    //s: a string to repeat
    //n: the number of characters to consider
    //Returns
    //
    //
    //int: the frequency of a in the substring
    
    static long repeatedString(string s, long n)
    {
        // Count of 'a' in substring 's'
        long a_count = 0;

        // Length of remainder and count of 'a' in the remainder
        long r_count = 0;
        long r_length = (n % s.Length);

        // Iterate over the string
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'a')
            {
                // Count the 'a' in the string
                a_count++;

                // Count the 'a' in the tailing partial string
                if (i < r_length)
                {
                    r_count++;
                }
            }
        }
        return a_count * (n / s.Length) + r_count;
    }

    static void Main(string[] args)
    {
        // String length == 100, 'a' == 3, n == 549382313570
        //                                                         v        v           v
        //         "epsxyyflvrrrxzvnoenvpegvuonodjoxfwdmcvwctmekpsnamchznsoxaklzjgrqruyzavshfbmuhdwwmpbkwcuomqhiyvuztwvq"
        //              ^    ^    ^    ^    ^    ^    ^    ^    ^    ^    ^    ^    ^    ^    ^    ^    ^    ^    ^    ^

        string s = "epsxyyflvrrrxzvnoenvpegvuonodjoxfwdmcvwctmekpsnamchznsoxaklzjgrqruyzavshfbmuhdwwmpbkwcuomqhiyvuztwvq";
        long n = 549382313570;
        //string s = "a";
        //long n = 1000000000000;
        //string s = "aba";
        //long n = 10;

        long result = repeatedString(s, n);

        Console.WriteLine(result);
    }
}
