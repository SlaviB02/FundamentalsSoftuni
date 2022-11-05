using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp107
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+";
            string digitPattern = @"\d+";
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                string input = Console.ReadLine();
                Match barcode = Regex.Match(input, pattern);
                string code = barcode.Value;
                if(code!=string.Empty)
                {
                    string res = "";
                    MatchCollection digits = Regex.Matches(code, digitPattern);
                   foreach(Match final in digits)
                    {
                        res += final.Value;
                    }
                    if (res == "")
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {res}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
               
            }
            
            
               
              
                
            
            
        }
    }
}
