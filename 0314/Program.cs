using System;

namespace _0314
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //  {
            //      sum += i;
            //  }
            //  Console.WriteLine(sum);

            //練習1
            //for (int i = 0; i <= 5; i++)
            //{
            //    for (int j = 0; j <= 5; j++)
            //    {
            //        if (i > j)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.Read();

            //練習2
            //string input = Console.ReadLine();
            //int inputInt = int.Parse(input);
            //for (int i=0; i <= inputInt; i++)
            //{
            //    Console.WriteLine("N*"+i);
            //}

            //練習3
            //for(int i = 1; i <= 9; i++)
            //{
            //    for(int j=1; j<=9; j++)
            //    {
            //        Console.WriteLine(i + "*" + j + "=" +i*j);
            //    }
            //}
            string[] student = new string[5] { "Jack", "Mary", "Tom", "Grace", "Alice" };
            string[] suject = new string[3] { "電腦概論", "程式設計", "動畫設計" };
            int[] computer = { 80, 65, 100, 98, 83 };
            int[] program = { 75, 67, 93, 25, 82 };
            int[] animation = { 60, 62, 91, 50, 87 };
            int[] studentNo = { 1, 2, 3, 4, 5 };
            while (true)
            {
                Console.WriteLine("請輸入座號:");
                var input = Console.ReadLine();
                int intputstudentNo = int.Parse(input);
                int arrayIndex = Array.IndexOf(studentNo, intputstudentNo);
                if(arrayIndex>-1)
                {
                    Console.WriteLine("姓名" + student[arrayIndex]);
                    Console.WriteLine("電腦概論" + computer[arrayIndex]);
                    Console.WriteLine("程式設計" + program[arrayIndex]);
                    Console.WriteLine("動畫設計" + animation[arrayIndex]);

                }
                else
                {
                    Console.WriteLine("沒有這個座號");
                }
            }
        }
       

    }
}
