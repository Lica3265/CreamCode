namespace Add_Two_Numbers
{
    public class Solution
    {
        public static void Main()
        {
            var sol = new Solution();
            ListNode l1 = new ListNode(2, new ListNode(4));
            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            System.Console.WriteLine(sol.AddTwoNumbers(l1, l2));
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode result = new ListNode(0);
            ListNode current = result;

            while (l1 != null || l2 != null || carry > 0)
            {
                if (l1 != null)
                {
                    carry = carry + l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    carry = carry + l2.val;
                    l2 = l2.next;
                }
                current.next = new ListNode(carry % 10);
                carry = carry / 10;
                current = current.next;
            }
            return result.next;
        }
    }


}
