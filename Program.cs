using System;

namespace finalnum3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] number = new int[] { };
            string input2;
           
            double[] inputnum = new double[] { };
            int i = 0;
            string[] input = new string[] { };
            do
            {
                input[i] = Console.ReadLine();
                i++;
            } while (input[i] != "End");
            for (int p = 0; p < i; p++)
            {
                inputnum[p] = double.Parse(input[i]);
            }

            input2 = Console.ReadLine();
            switch (input2)
            {
                case "FindMax":
                    FindMax(inputnum);
                    break;

                case "FindMin":
                    FindMin(inputnum);
                    break;

                case "FindMean":
                    FindMean(inputnum);
                    break;

                default:
                    Console.WriteLine("Invalid mode");
                    break;
            }

        }
        static void FindMax(double[] inputnum)
        {
            double max = inputnum[0];
            int i = 0;
            for (i = 0; i < inputnum.GetLength(0); i++)
            {
                if (max < inputnum[i])
                    max = inputnum[i];
            }
            Console.WriteLine(max);
        }

        static void FindMin(double[] inputnum)
        {
            double min = inputnum[0];
            int i = 0;
            for (i = 0; i < inputnum.GetLength(0); i++)
            {
                if (min > inputnum[i])
                    min = inputnum[i];
            }
            Console.WriteLine(min);
        }

        static void FindMean(double[] inputnum)
        {
            int i;
            double answer = 0;
            for (i = 0; i < inputnum.GetLength(0); i++)
            {
                answer = answer + inputnum[i];
            }
            Console.WriteLine(answer/inputnum.GetLength(0));

        }
    }
}

