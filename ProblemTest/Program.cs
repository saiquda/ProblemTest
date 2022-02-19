using System;
using System.Collections.Generic;

namespace Probl
{
    class Program
    {
        public static List<int> FindNumsNoPair(int[] nums)
        {
            Dictionary<int, uint> cnt = new Dictionary<int, uint>();
            foreach (int elem in nums)
            {
                if (!cnt.ContainsKey(elem))
                    cnt.Add(elem, 1);
                else
                    cnt[elem]++;
            }
            List<int> res = new List<int>();
            foreach (var elem in cnt)
            {
                if (elem.Value == 1)
                    res.Add(elem.Key);
            }
            return res;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < nums.Length; i++)
                nums[i] = rnd.Next(0, 9);
            for (int i = 0; i < nums.Length; i++)
                Console.Write(nums[i] + " ");
            List<int> res = FindNumsNoPair(nums);
            res.ForEach(i => Console.WriteLine(i));
        }
    }
}
