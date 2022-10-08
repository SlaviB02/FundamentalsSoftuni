using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string word = string.Empty;
            for (int i = 0; i < N; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int tempNumber = number;
                int count = 0;
                int mainDigit = 0;
                int offset = 0;
                int letterIndex = 0;
                while (tempNumber > 0)
                {
                    mainDigit = tempNumber % 10;
                    tempNumber /= 10;
                    count++;
                }
                offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }
                letterIndex = (offset + count - 1);
                letterIndex += 97;
                if(mainDigit==0)
                {
                    word += " ";
                    continue;
                }
                word += (char)letterIndex;
            }
            Console.WriteLine(word);
        }
    }
}
  