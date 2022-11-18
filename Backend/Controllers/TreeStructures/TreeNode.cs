using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.TreeStructures
{
    public class TreeNode
    {
        public decimal Value;
        public string OutputString;
        public TreeNode LeftChild;
        public TreeNode RightChild;

        public TreeNode(decimal value)
        {
            this.Value = value;
            LeftChild = null;
            RightChild = null;
        }
    }
}
