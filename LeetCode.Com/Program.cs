﻿using LeetCode.Com.Esay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com
{
    class Program
    {
        /// <summary>
        /// 测试类
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");

            #region No0001
            //No0001 no0001 = new No0001();
            //int[] a = {2, 7, 11, 15};
            //int[] b = no0001.TwoSum(a, 9);
            #endregion

            #region No0007
            //No0007 no0007 = new No0007();
            //Console.WriteLine(no0007.Reverse(123));
            //Console.WriteLine(no0007.Reverse(-123));
            //Console.WriteLine(no0007.Reverse(120));
            #endregion

            #region No0009
            No0009 no0009 = new No0009();
            Console.WriteLine(no0009.IsPalindrome(121));
            Console.WriteLine(no0009.IsPalindrome(-121));
            Console.WriteLine(no0009.IsPalindrome(10));
            #endregion

            Console.ReadKey();
        }
    }
}