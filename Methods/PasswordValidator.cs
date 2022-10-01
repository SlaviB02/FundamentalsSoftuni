using System;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if(NumberOfCharacters(input)!=string.Empty)
            {
                Console.WriteLine(NumberOfCharacters(input));
            }
            if (LettersAndDigits(input) != string.Empty)
            {
                Console.WriteLine(LettersAndDigits(input));
            }
            if (MoreThanTwoDigits(input) != string.Empty)
            {
                Console.WriteLine(MoreThanTwoDigits(input));
            }
            if(NumberOfCharacters(input)==string.Empty && LettersAndDigits(input)==string.Empty && MoreThanTwoDigits(input)==string.Empty)
            {
                Console.WriteLine("Password is valid");
            }
        }
     static string NumberOfCharacters(string input)
        {
            string result = "";
            if(input.Length<6 || input.Length>10)
            {
                result = "Password must be between 6 and 10 characters";
            }
            return result;
        }
        static string LettersAndDigits(string input)
        {
            string result = "";
            for(int i=0;i<input.Length;i++)
            {
                char symbol = input[i];
                if((char.IsLetterOrDigit(symbol))!=true)
                {
                    result ="Password must consist only of letters and digits";
                    return result;
                }
                
            }
            return result;
        }
        static string MoreThanTwoDigits(string input)
        {
            int digitsCounter = 0;
            string result = "";
           for(int i=0;i<input.Length;i++)
            {
                char symbol = input[i];
                if(symbol>='0' && symbol<='9')
                {
                    digitsCounter++;
                }
            }
           if(digitsCounter<2)
            {
                result = "Password must have at least 2 digits";
            }
            return result;
        }
    }
}
