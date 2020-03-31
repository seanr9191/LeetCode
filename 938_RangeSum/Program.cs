using System;

namespace _938_RangeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            var rootNode = new TreeNode(10);
            var l1 = new TreeNode(5);
            var r1 = new TreeNode(15);
            var l2 = new TreeNode(3);
            var l3 = new TreeNode(7);
            var r2 = new TreeNode(18);
            l1.left = l2;
            l1.right = l3;
            r1.right = r2;
            rootNode.left = l1;
            rootNode.right = r1;


            Console.WriteLine(p.RangeSumBST(rootNode, 7, 15));
        }

        public int RangeSumBST(TreeNode root, int L, int R)
        {
            if (root == null)
            {
                return 0;
            }
            if (root.val >= L && root.val <= R)
            {
                return root.val + RangeSumBST(root.left, L, R) + RangeSumBST(root.right, L, R);
            } else
            {
                return RangeSumBST(root.left, L, R) + RangeSumBST(root.right, L, R);
            }
        }

    }

}
