using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File类
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestPath();
            TestFile();
        }

        public static void TestFile()
        {
            string path = Path.GetFullPath(@"C:\Users\45294\Desktop\1.txt");
            //File.Create(path);
            //File.Delete(path);
            //File.Copy(path, Path.Combine(Path.GetDirectoryName(path), "2.txt"));
            File.WriteAllText(path, "这是第一次写入adadas", Encoding.UTF8);
        }

        public static void TestPath()
        {
            string str = @"D:\教程\基础\视频\亲情奉献全套精品.Net基础视频教程之9-面向对象继承\（第十一天）\video\9、Path类.avi";
            Console.WriteLine(Path.GetFileName(str)); // 获得文件的名称，包括文件的扩展名
            Console.WriteLine(Path.GetFileNameWithoutExtension(str)); // 获得文件的名称，不包括文件的扩展名
            Console.WriteLine(Path.GetExtension(str)); // 获得文件的扩展名
            Console.WriteLine(Path.GetDirectoryName(str)); // 获得文件所在的目录（递归）
            Console.WriteLine(Path.GetFullPath(str)); // 获得文件的全路径
            // 拼接文件路径
            Console.WriteLine(Path.Combine(@"D:\教程\基础\视频\亲情奉献全套精品.Net基础视频教程之9-面向对象继承\（第十一天）\video\", @"9、Path类.avi"));
            Console.ReadKey();
        }
    }
}
