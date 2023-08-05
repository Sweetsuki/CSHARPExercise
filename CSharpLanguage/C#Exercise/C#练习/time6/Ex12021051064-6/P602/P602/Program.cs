//马磊
//using System;
//namespace p602
//{
//    class Student
//    {
//        private string stuNo, stuName;
//        private int[] score;
//        public Student()
//        {
//            stuNo = "71";
//            stuName = "马";
//            score = new int[5];
//        }
//        public int this[int index]
//        {
//            get { return this[index]; }
//            set { this[index] = value; }
//        }
//        public Student(string stuNo, string stuName)
//        {
//            this.stuNo = stuNo;
//            this.stuName = stuName;
//            this.score = new int[5] { 0, 0, 0, 0, 0 };
//        }
//        public void Display()
//        {
//            Console.WriteLine("学号:{0}", stuNo);
//            Console.WriteLine("姓名:{0}", stuName);
//            Console.WriteLine("成绩:{0}/成绩:{1}/成绩:{2}/成绩:{3}/成绩:{4}", score[0], score[1], score[2], score[3], score[4]);
//        }
//        public void SetScore(params int[] score)
//        {
//              for (int i = 0; i < score.Length; i++)
//                this.score[i] = score[i]; 
//        }
//        public void GetMaxAndMin(out int max, out int min)
//        {
//            max = 0;
//            min = 100;
//            for (int i = 0; i < score.Length; i++)
//            {
//                if (score[i] > max)
//                    max = score[i];
//                if (score[i] < min)
//                    min = score[i];
//            }
//        }
//        public float GetAvg(out int count)
//        {
//            count = 0;
//            int sum = 0;
//            for (int i = 0; i < score.Length; i++)
//            {
//                sum += score[i];
//                if (score[i] < 60)
//                    count++;
//            }
//            float avg = sum / 5;
//            return avg;
//        }

//    }
//    class progarm
//    {
//        static void Main(string[] args)
//        {
//            int Min = 0;
//            int Max = 0;
//            int Count = 0;
//            Student s1 = new Student();
//            s1.SetScore(96,85,45,85,65);
//            s1.Display();
//            s1.GetMaxAndMin(out Max, out Min);
//            Count = Convert.ToInt16(s1.GetAvg(out Count));
//            Console.WriteLine("平均分为{0},不及格门数为:{1}", s1.GetAvg(out Count), Count);
//            Console.ReadKey();
//        }
//    }

//}
//孙钰程1
//using System;
//namespace HelloWorldApplication
//{
//    class Student
//    {
//        private string stuNo, stuName;
//        private int[] score;
//        public Student()
//        {
//            stuNo = "";
//            stuName = "";
//            score = new int[5];
//        }
//        public Student(string stuNo, string stuName)
//        {
//            this.stuNo = stuNo;
//            this.stuName = stuName;
//            this.score = new int[5] { 0, 0, 0, 0, 0 };
//        }
//        public void Display()
//        {
//            Console.Write("学生的学号是：{0}", stuNo);
//            Console.ReadLine();
//            Console.Write("学生的名字是：{0}", stuName);
//            Console.ReadLine();
//            Console.Write("学生的成绩分别为：");
//            for (int i = 0; i < score.Length; i++)
//            {
//                score[i] = int.Parse(Console.ReadLine());
//                SetScore(score[i]);
//            }
//        }
//        public void SetScore(params int[] score)
//        {

//        }

//        public void getmaxandmin(ref int max, ref int min)
//        {
//            max = 0;
//            min = 100;
//            for (int i = 0; i < score.Length - 1; i++)
//            {
//                if (score[i] <= score[i + 1])
//                {
//                    max = score[i + 1];
//                }
//            }
//            for (int j = 0; j < score.Length - 1; j++)
//            {
//                if (score[j] >= score[j + 1])
//                {
//                    min = score[j + 1];
//                }
//            }
//            Console.WriteLine("最高分：{0},最低分:{1}", max, min);
//        }
//        public float getavg(out int count)
//        {
//            count = 0;
//            for (int i = 0; i < score.Length; i++)
//            {
//                if (score[i] < 60)
//                    count++;
//            }
//            float sum = 0;
//            float avg = 0;
//            for (int j = 0; j < score.Length; j++)
//            {
//                sum += score[j];
//            }
//            avg = sum / score.Length;
//            return avg;
//        }


//    }
//    class HelloWorld
//    {
//        static void Main(string[] args)
//        {
//            int Max = 0, Min = 0, count = 0;
//            Student s1 = new Student();
//            s1.Display();
//            s1.getmaxandmin(ref Max, ref Min);
//            s1.getavg(out count);
//            Console.WriteLine("不及格门数{0},平均分数为:{1}", count, s1.getavg(out count));
//        }
//    }
//}
//余天齐
//using System;

//namespace P602
//{
//    class Student
//    {
//        private string stuNo, stuName;
//        private int[] score;
//        public Student()
//        {
//            stuNo = "";
//            stuName = "";
//            score = new int[5];
//        }
//        public Student(string stuNo, string stuName)
//        {
//            this.stuNo = stuNo;
//            this.stuName = stuName;
//            this.score = new int[5] { 0, 0, 0, 0, 0 };
//        }
//        public void Display()
//        {
//            Console.WriteLine("学号：" + stuNo);
//            Console.WriteLine("姓名：" + stuName);
//            Console.Write("成绩：");

//            for (int i = 0; i < score.Length; i++)
//            {
//                Console.Write(this[i] + " ");
//            }
//            Console.WriteLine();
//            int count;
//            float avg = GetAvg(out count);
//            Console.WriteLine("平均分：" + avg);
//            Console.WriteLine("不及格门数：" + count);
//            int max, min;
//            GetMaxAndMin(out max, out min);
//            Console.WriteLine("最高分：" + max);
//            Console.WriteLine("最低分：" + min);

//        }
//        public void SetScore(params int[] score)
//        {
//            for (int i = 0; i < score.Length; i++)
//            {
//                this[i] = score[i];
//            }
//        }
//        public void GetMaxAndMin(out int max, out int min)
//        {
//            max = score[0];
//            min = score[0];
//            for (int i = 1; i < score.Length; i++)
//            {
//                if (score[i] > max)
//                    max = score[i];
//                if (score[i] < min)
//                    min = score[i];
//            }
//        }

//        public float GetAvg(out int count)
//        {
//            count = 0;
//            int sum = 0;
//            for (int i = 0; i < score.Length; i++)
//            {
//                sum += score[i];
//                if (score[i] < 60)
//                    count++;
//            }
//            float avg = sum / 5;
//            return avg;
//        }
//        public int this[int index]
//        {
//            get { return score[index]; }
//            set { score[index] = value; }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("请输入学生学号：");
//            string no = Console.ReadLine();
//            Console.WriteLine("请输入学生姓名：");
//            string name = Console.ReadLine();
//            Console.WriteLine("请输入学生成绩：");
//            string s = Console.ReadLine();

//            string[] str = s.Split(" ");
//            int[] score = new int[str.Length];
//            for (int i = 0; i < str.Length; i++)
//                score[i] = int.Parse(str[i]);

//            Student stu = new Student(no, name);
//            stu.SetScore(score);
//            stu.Display();
//        }
//    }
//}
//孙钰程2
//using System;
//namespace HelloWorldApplication
//{
//    class Student
//    {
//        private string stuNo, stuName;
//        private int[] score;
//        public Student()
//        {
//            stuNo = "";
//            stuName = "";
//            score = new int[5];
//        }
//        public Student(string stuNo, string stuName)
//        {
//            this.stuNo = stuNo;
//            this.stuName = stuName;
//            this.score = new int[5] { 0, 0, 0, 0, 0 };
//        }
//        public void Display()
//        {
//            Console.Write("学生的学号是：");
//            Console.ReadLine();
//            Console.Write("学生的名字是：");
//            Console.ReadLine();
//            Console.Write("学生的成绩分别为：");

//        }
//        public void SetScore(params int[] score)
//        {
//            for (int i = 0; i < score.Length; i++)
//            {
//                this.score[i] = score[i];
//            }
//        }
//        public void GetMaxAndMin(out int max, out int min)
//        {
//            max = 0; min = 100;
//            for (int i = 0; i < score.Length - 1; i++)
//            {
//                if (score[i] <= score[i + 1])
//                {
//                    max = score[i + 1];
//                }
//            }
//            for (int j = 0; j < score.Length - 1; j++)
//            {
//                if (score[j] >= score[j + 1])
//                {
//                    min = score[j + 1];
//                }
//            }
//        }
//        public float getavg(out int count)
//        {
//            count = 0;
//            for (int i = 0; i < score.Length; i++)
//            {
//                if (score[i] < 60)
//                    count++;
//            }
//            float sum = 0;
//            float avg = 0;
//            for (int j = 0; j < score.Length; j++)
//            {
//                sum += score[j];
//            }
//            avg = sum / score.Length;
//            return avg;
//        }
//    }
//    class HelloWorld
//    {
//        static void Main(string[] args)
//        {
//            int max = 0, min = 100, count = 0;
//            Student s1 = new Student();
//            s1.Display();
//            int[] Score = new int[5];
//            for (int i = 0; i < Score.Length; i++)
//                Score[i] = int.Parse(Console.ReadLine());
//            s1.SetScore(Score[0], Score[1], Score[2], Score[3], Score[4]);
//            s1.GetMaxAndMin(out max, out min);
//            s1.getavg(out count);
//            Console.WriteLine("不及格门数{0},平均分数为:{1}", count, s1.getavg(out count));
//        }
//    }
//}
//using System;
//namespace P602
//{
//    class Student
//    {
//        private string stuNo, stuName;
//        private int[] score;
//        public int[] Score
//        {
//            get { return score; }
//            set { score = value; }
//        }
//        public Student()
//        {
//            stuNo = "64";
//            stuName = "Jason";
//            score = new int[5];
//        }
//        public Student(string stuNo, string stuName)
//        {
//            this.stuNo = stuNo;
//            this.stuName = stuName;
//            this.score = new int[5] { 0, 0, 0, 0, 0 };
//        }
//        public int this[int index]
//        {
//            get { return score[index]; }
//            set { score[index] = value; }
//        }
//        public void Display()
//        {
//            Console.Write("学号：{0} ", stuNo);
//            Console.WriteLine("姓名：{0}", stuName);
//            Console.Write("五门科目分数分别为：");
//            for (int i = 0; i < score.Length; i++)
//            {
//                Console.Write(this.score[i]);
//                Console.Write(' ');
//            }
//            GetMaxAndMin(out int max, out int min);
//            Console.Write("平均分：{0}", GetAvg(out int count));
//            //显示学生所有信息
//        }
//        public void SetScore(params int[] score)
//        {
//            for (int i = 0; i < score.Length; i++)
//                this.score[i] = score[i];
//            //为所有成绩赋值
//        }
//        public void GetMaxAndMin(out int max, out int min)
//        {
//            max = 0; min = 100;
//            for (int i = 0; i < score.Length; i++)
//            {
//                if (score[i] > max) max = score[i];
//                if (score[i] < min) min = score[i];
//            }
//            Console.WriteLine("最高分：{0}，最低分：{1}", max, min);
//            //查找最高及最低分数
//        }
//        public float GetAvg(out int count)
//        {
//            float avg = 0;
//            int sum = 0;
//            count = 0;
//            for (int i = 0; i < score.Length; i++)
//            {
//                if (score[i] < 60) count++;
//                sum += score[i];
//            }
//            avg = sum / score.Length;
//            Console.Write("不及格门数：{0} ", count);
//            return avg;
//            //返回该生的平均分数，并统计不及格门数
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int count = 0;
//            Student s1 = new Student();
//            Console.Write("请输入五门课程的成绩：");
//            string value = Console.ReadLine();
//            string[] val = value.Split(' ');
//            int[] score = new int[val.Length];
//            for (int i = 0; i < val.Length; i++)
//                score[i] = int.Parse(val[i]);
//            s1.SetScore(score);
//            s1.Display();
//            Console.ReadKey();
//        }
//    }
//}
do
{
    Random r = new Random();
    int rnumber = r.Next(64, 126);
    Console.WriteLine("恭喜你，{0}可以开讲了。", rnumber);
}
while (Console.ReadKey().KeyChar != 'Q');
Console.ReadKey();
