using System;

namespace task1
{
    class Program
    {
        static int[] Task1(int A)
        {
            int B = A + 2;
            int C = (A + 3) / (A + 2);
            int D = (A + 4) / (A + 3);
            int E = (A + 5) / (A + 4);
            int[] values = {B, C, D, E};
            return values;
        }
        static bool Task21(double X, double Y)
        {
            if(X>=1 && Y>= -1){
                if(Math.Sqrt(Math.Pow(1 - X, 2) + Math.Pow(-1 - Y, 2))<=1)
                {
                    return true;
                }
            }
            return false;
        }
        static double Task22(double X, double Y, double W)
        {
            return Math.Min(Math.Min(W, X),Y)-Y*Y-W*W;
        }

        static int Task31(int A)
        {
            int k = 0;
            while (A != 0)
            {
                if ((A%10)%2==1)
                {
                    k++;
                }
                A = A / 10;
            }
            return k;
        }
        static void Task32()
        {
            double sum = 0;
            int k = 0;
            for(int i=0; Math.Abs(sum-Math.Atan(0.5))>=0.01; i++)
            {
                sum+=(Math.Pow(-1, i))/((2*i+1)*Math.Pow(2,2*i+1));
                k = i;
            }
            Console.WriteLine("10^-2 is " + Convert.ToString(k));
            sum = 0;
            k = 0;
            for (int i = 0; Math.Abs(sum - Math.Atan(0.5)) >= 0.0001; i++)
            {
                sum += (Math.Pow(-1, i)) / ((2 * i + 1) * Math.Pow(2, 2 * i + 1));
                k = i;
            }
            Console.WriteLine("10^-4 is " + Convert.ToString(k));
        }

        static void Main(string[] args)
        {
            int A;
            double X;
            double Y;
            double W;
            int[] values;
            Console.WriteLine("Available tasks: 1, 21, 22, 31, 32");
            Console.WriteLine("Choose your task:");
            string TaskNumber = Console.ReadLine();
            switch (TaskNumber)
            {
                case "1":
                    Console.WriteLine("Enter A value: ");
                    A = Convert.ToInt32(Console.ReadLine());
                    values = Task1(A);
                    Console.WriteLine("B value is " + Convert.ToString(values[0]));
                    Console.WriteLine("C value is " + Convert.ToString(values[1]));
                    Console.WriteLine("D value is " + Convert.ToString(values[2]));
                    Console.WriteLine("E value is " + Convert.ToString(values[3]));
                    break;
                case "21":
                    Console.WriteLine("Enter X value: ");
                    X = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Y value: ");
                    Y = Convert.ToDouble(Console.ReadLine());
                    if (Task21(X, Y))
                    {
                        Console.WriteLine("Your point is in the marked area");
                    }
                    else
                    {
                        Console.WriteLine("Your point is NOT in the marked area");
                    }
                    break;
                case "22":
                    Console.WriteLine("Enter X value: ");
                    X = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Y value: ");
                    Y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter W value: ");
                    W = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Expression equals " + Convert.ToString(Task22(X, Y, W)));
                    break;
                case "31":
                    Console.WriteLine("Enter A value: ");
                    A = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Quantity of odd numbers is " + Convert.ToString(Task31(A)));
                    break;
                case "32":
                    Task32();
                    break;
                default:
                    Console.WriteLine("Enter existing task number");
                    break;
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
