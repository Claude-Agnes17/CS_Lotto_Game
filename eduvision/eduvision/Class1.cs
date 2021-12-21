using System;
using System.Linq;

namespace eduvision
{
    class Class1
    {

        static void Main(string[] args)
        {
            Random rand = new Random();

            int input;

            Console.Write("게임수를 입력하세요 : ");
            input = int.Parse(Console.ReadLine());

            for(int g=0; g<input; g++)
            {
                int[] num = new int[7];

                for (int i = 0; i < num.Length; i++)
                {
                    int a = rand.Next(1, 46);
                    if (!num.Contains(a))
                        num[i] = a;
                    else
                        i--;
                }
                for (int j = 0; j < num.Length - 1; j++)
                {
                    for (int k = 1; k < num.Length - 1; k++)
                    {
                        if (num[k] < num[k - 1])
                        {
                            int temp = num[k];
                            num[k] = num[k - 1];
                            num[k - 1] = temp;
                        }
                    }
                }
                for (int m = 0; m < num.Length - 1; m++)
                {
                    Console.Write(num[m] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
