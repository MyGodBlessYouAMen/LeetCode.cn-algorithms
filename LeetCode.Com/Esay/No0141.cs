﻿using LeetCode.Com.Com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Esay
{
    /// <summary>
    /// Linked List Cycle
    /// </summary>
    public class No0141
    {
        public bool HasCycle(ListNode head)
        {
            //设置两个指针，一快一慢，快的每次走两步，慢的每次走一步，如果快的和慢的相遇，则说明有环。
            ListNode fast = head;
            ListNode slow = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
