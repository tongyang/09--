using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList集合
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            // 添加单个元素
            list.Add(true);
            list.Add(1);
            list.Add("张三");
            // 添加集合元素
            list.AddRange(new int[] { 1, 3, 4, 55 });
            list.Add('男');
            list.AddRange(list);
            // 清空元素
            //list.Clear();

            // 删除元素
            list.Remove(1); // 删除第一个匹配项
            list.RemoveAt(0);
            list.RemoveRange(0, 2);

            // 反转
            list.Reverse();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }

        public void MaoPao()
        {
            int[] nums = { 3, 4, 6, 7, 1, 54, 122, 45 };
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }
    }
}
