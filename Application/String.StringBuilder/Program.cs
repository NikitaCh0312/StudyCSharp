namespace String.StringBuilder
{
    using System;
    using System.Text;

    public class Text
    {
        public int x;
    }

    class Program
    {
        static void Main(string[] args)
        {
            StringBuilderVsString();
            StringVsClassCompare();
            Console.ReadKey();
        }

        public static void StringBuilderVsString()
        {
            string str = System.String.Empty;
            for (int i = 0; i < 1000; i++)
            {
                str += "any text";
            }

            StringBuilder builder = new StringBuilder();
            Console.WriteLine(builder.ToString());
            Console.WriteLine($"Capacity: {builder.Capacity}");
            Console.WriteLine($"Length: {builder.Length}");

            builder.Append("12345678910111213141516");
            Console.WriteLine(builder.ToString());
            Console.WriteLine($"Capacity: {builder.Capacity}");
            Console.WriteLine($"Length: {builder.Length}");

            for (int i = 0; i < 1000; i++)
            {
                builder.Append("any text");
            }

            Console.WriteLine(builder.ToString());
            Console.WriteLine($"Capacity: {builder.Capacity}");
            Console.WriteLine($"Length: {builder.Length}");
        }

        public static void StringVsClassCompare()
        {
            /*******************************/
            /*string*/
            /*******************************/
            string text1 = "text1";
            string text2;

            text2 = text1;
            bool isSameInstanse = Object.ReferenceEquals(text1, text2);
            Console.WriteLine(isSameInstanse);
            Console.WriteLine(text1);
            Console.WriteLine(text2);

            text2 = "qwerty";
            Console.WriteLine(text1);
            Console.WriteLine(text2);

            isSameInstanse = ReferenceEquals(text1, text2);
            Console.WriteLine(isSameInstanse);

            /*******************************/
            /*Class*/
            /*******************************/
            Text t1 = new Text();
            t1.x = 10;
            Text t2 = t1;

            isSameInstanse = ReferenceEquals(t1, t2);
            Console.WriteLine(isSameInstanse);
            Console.WriteLine(t1.x);

            t2.x = 1;
            Console.WriteLine(t1.x);
            Console.WriteLine(t1.x);

            isSameInstanse = ReferenceEquals(t1, t2);
            Console.WriteLine(isSameInstanse);
        }
    }
}
