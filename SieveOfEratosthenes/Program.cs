using System;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Number: ");
            long InputNum = Convert.ToInt64(Console.ReadLine());

            /*
             * Default boolean Array value is false, so true is used to flag composite.
             */
            bool[] isComposite = new bool[InputNum + 1];
            

            //even Num
            for(int i=4;i<=InputNum;i=i+2)
            {
                isComposite[i] = true;
            }

            //odd num
            int boundary = 3;
            while (boundary <= Math.Sqrt(InputNum))
            {
                int odd = boundary;
                int proc = odd * 2;
                while (proc <= InputNum)
                {
                    isComposite[proc] = true;
                    proc += odd;
                }

                for(boundary+=2;boundary<=Math.Sqrt(InputNum);boundary=boundary+2)
                {
                    if(isComposite[boundary]==false)
                    {
                        break;
                    }
                    else { }
                }
            }

            //output
            int dividual = 2;
            string title = "Prime Numbers List\n";
            const int alignNum = 8;
            int LineCount = 10;

            int titleAlign= (alignNum * LineCount - title.Length+1) / 2;
            //Alignment Number must be a constant value, so output blank instead of assign specific alignment value in {,}
            for (int i = 0; i < titleAlign; i++)
                Console.Write(" ");
            Console.WriteLine($"{title}");

            Console.Write($"{dividual,alignNum} ");
            int changeLine = 1;
            for(int i=3;i<=InputNum;i=i+2)
            {
                if (isComposite[i] == false)
                {
                    Console.Write($"{i,alignNum} ");
                    changeLine++;
                    if (changeLine % LineCount == 0)
                        Console.WriteLine();
                    else { }
                }
                else { }
            }

        }
    }
}
