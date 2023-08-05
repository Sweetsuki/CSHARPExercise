using System;
namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入成绩：");
            string score = Console.ReadLine();
            if (int.Parse(score) >= 0 && int.Parse(score) <= 59)
            {
                Console.WriteLine("你的成绩：不及格");
            }
            else if (int.Parse(score) >= 60 && int.Parse(score) <= 69)
            {
                Console.WriteLine("你的成绩：及格");
            }
            else if (int.Parse(score) >= 70 && int.Parse(score) <= 79)
            {
                Console.WriteLine("你的成绩：中等");
            }
            else if (int.Parse(score) >= 80 && int.Parse(score) <= 89)
            {
                Console.WriteLine("你的成绩：良好");
            }
            else if (int.Parse(score) >= 90 && int.Parse(score) <= 100)
            {
                Console.WriteLine("你的成绩：优秀");
            }
            else
            {
                Console.WriteLine("您输入的数字不符合要求");
            }
            //int inputScore;
            //string outputScore;
            //Console.WriteLine("请输入百分制分数：");
            //inputScore = Convert.ToInt32(Console.ReadLine());
            //int temp = inputScore / 10;
            //switch (temp)
            //{
            //    case 10:
            //        outputScore = "优秀";
            //        break;
            //    case 9:
            //        outputScore = "优秀";
            //        break;
            //    case 8:
            //        outputScore = "良好";
            //        break;
            //    case 7:
            //        outputScore = "中等";
            //        break;
            //    case 6:
            //        outputScore = "及格";
            //        break;
            //    default:
            //        outputScore = "不及格";
            //        break;
            //}
            //Console.WriteLine("百分制下{0}分经转换，为五分制下的{1}", inputScore, outputScore);
        }
    }
}