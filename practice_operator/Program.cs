using System;
using System.Text;
using System.Linq;

namespace practice_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //参照型の比較はEqualsメソッドで行う

            var sb = new StringBuilder("あいう");
            var b = sb;
            sb.Append("えお");
            Console.WriteLine(sb);
            Console.WriteLine(b);
            //同じメモリを参照している
            Console.WriteLine(sb==b);

            //参照しているメモリアドレスが異なる
            var sb2 = new StringBuilder("あいう");
            Console.WriteLine(sb2);
            Console.WriteLine(sb == sb2);
            Console.WriteLine(sb.Equals(b));

            //配列
            var data1 = new[] { "い","ろ","は"};
            var data2 = new[] { "い","ろ","は"};
            Console.WriteLine(data1[0]==data2[0]);
            Console.WriteLine(data1[0].Equals(data2[0]));
            //配列ごと比較するときはSequenceEqualメソッドを使用
            Console.WriteLine(data1.SequenceEqual(data2));

            //条件演算子
            var　score = 70;
            Console.WriteLine(score<=80?"不合格":"合格");
            Console.WriteLine(score<=80||score>=60? "合格" : "不合格");

            //null合体演算子
            string first_name = null;
            var last_name = "春樹";
            Console.WriteLine(first_name??last_name);
            Console.WriteLine(first_name==null?last_name:first_name);

            //nameof演算子
            string str = null;
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
        }
    }
}
