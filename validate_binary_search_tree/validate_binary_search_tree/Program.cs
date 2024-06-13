using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validate_binary_search_tree
{
    internal class Program
    {
        public class TreeNode
        {
 *          public int val;
 *          public TreeNode left;
 *          public TreeNode right;
 *          public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        static void Main(string[] args)
        {
        }

        public bool IsValidBST(TreeNode root)
        {
            return validateTree(root, Int64.MinValue, Int64.MaxValue);
        }

        public bool validateTree(TreeNode root, Int64 minimum, Int64 maximum)
        {
            if (root == null) { return true; }

            if (!(root.val > minimum &&
                root.val < maximum))
            {
                return false;
            }

            return validateTree(root.left, minimum, root.val) &&
                validateTree(root.right, root.val, maximum);
        }
    }
}
