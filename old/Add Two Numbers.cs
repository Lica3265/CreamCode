public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
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