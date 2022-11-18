using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.ICalculateStrategies;

namespace Calculator.TreeStructures
{
    public class ArithmeticTree
    {
        public Calculator Calculator;
        public Stack<ICalculateStrategy> OperandStack;
        public Stack<TreeNode> NodeStack;
        public int LeftParenthesesCounter;
        public TreeNode Root;
        string PreOrderString;
        string InOrderString;
        string PostOrderString;

        public ArithmeticTree(Calculator calculator)
        {
            this.Calculator = calculator;
            OperandStack = new Stack<ICalculateStrategy>();
            NodeStack = new Stack<TreeNode>();
            LeftParenthesesCounter = 0;
            Root = null;
            PreOrderString = "";
            InOrderString = "";
            PostOrderString = "";
        }

        public void Cadence()
        {
            Console.WriteLine("======");
            foreach (ICalculateStrategy calculateStrategy in OperandStack)
            {
                Console.WriteLine(calculateStrategy);
            }
            Console.WriteLine("======");
            foreach (TreeNode treeNode in NodeStack)
            {
                Console.WriteLine(treeNode.OutputString);
            }
            Console.WriteLine("======");
        }

        public void AddLeftPar()
        {
            Cadence();
            OperandStack.Push(new LeftParenthesisStrategy());
            LeftParenthesesCounter += 1;
            Cadence();
        }

        public void AddRightPar()
        {
            Cadence();
            while (OperandStack.Count != 0)
            {
                if(OperandStack.Peek().ShowOperator() != "(")
                {
                    Console.WriteLine(OperandStack.Peek().ShowOperator());
                    Console.WriteLine(NodeStack.Count());
                    ICalculateStrategy Op = OperandStack.Pop();
                    TreeNode n1 = NodeStack.Pop();
                    TreeNode n2 = NodeStack.Pop();

                    TreeNode CombinedNode = new TreeNode(Op.CalculateResult(n2.Value, n1.Value));
                    CombinedNode.OutputString = Op.ShowOperator();
                    CombinedNode.LeftChild = n2;
                    CombinedNode.RightChild = n1;

                    NodeStack.Push(CombinedNode);
                }
                else
                {
                    break;
                }
            }
            // pop left parenthesis
            OperandStack.Pop();
            LeftParenthesesCounter -= 1;
            Cadence();
            Console.WriteLine("==Result in Parenthesis==");
            Console.WriteLine(NodeStack.Peek().Value.ToString());
            Console.WriteLine("==End Result in Parenthesis==");
        }

        public void AddNumber(decimal num)
        {
            Cadence();
            TreeNode NewNode = new TreeNode(num);
            NewNode.OutputString = num.ToString();
            NodeStack.Push(NewNode);
            Cadence();
        }

        public void AddAddition()
        {
            Cadence();
            /// calculate first then push
            while (OperandStack.Count != 0)
            {
                if (OperandStack.Peek().ShowPriority() >= new AdditionStrategy().ShowPriority())
                {
                    ICalculateStrategy Op = OperandStack.Pop();
                    TreeNode n1 = NodeStack.Pop();
                    TreeNode n2 = NodeStack.Pop();

                    TreeNode CombinedNode = new TreeNode(Op.CalculateResult(n2.Value, n1.Value));
                    CombinedNode.OutputString = Op.ShowOperator();
                    CombinedNode.LeftChild = n2;
                    CombinedNode.RightChild = n1;

                    NodeStack.Push(CombinedNode);
                }
                else
                {
                    break;
                }
            }
            OperandStack.Push(new AdditionStrategy());
            Cadence();
        }

        public void AddSubstraction()
        {
            Cadence();
            while (OperandStack.Count != 0)
            {
                if (OperandStack.Peek().ShowPriority() >= new SubstractionStrategy().ShowPriority())
                {
                    ICalculateStrategy Op = OperandStack.Pop();
                    TreeNode n1 = NodeStack.Pop();
                    TreeNode n2 = NodeStack.Pop();

                    TreeNode CombinedNode = new TreeNode(Op.CalculateResult(n2.Value, n1.Value));
                    CombinedNode.OutputString = Op.ShowOperator();
                    CombinedNode.LeftChild = n2;
                    CombinedNode.RightChild = n1;

                    NodeStack.Push(CombinedNode);
                }
                else
                {
                    break;
                }
            }
            OperandStack.Push(new SubstractionStrategy());
            Cadence();
        }

        public void AddMultiplication()
        {
            Cadence();
            while (OperandStack.Count != 0)
            {
                Console.WriteLine("hi");
                if (OperandStack.Peek().ShowPriority() >= new MultiplicationStrategy().ShowPriority())
                {
                    ICalculateStrategy Op = OperandStack.Pop();
                    TreeNode n1 = NodeStack.Pop();
                    TreeNode n2 = NodeStack.Pop();

                    TreeNode CombinedNode = new TreeNode(Op.CalculateResult(n2.Value, n1.Value));
                    CombinedNode.OutputString = Op.ShowOperator();
                    CombinedNode.LeftChild = n2;
                    CombinedNode.RightChild = n1;

                    NodeStack.Push(CombinedNode);
                }
                else
                {
                    break;
                }
            }
            // highest priority
            OperandStack.Push(new MultiplicationStrategy());
            Cadence();
        }

        public void AddDivision()
        {
            Cadence();
            while (OperandStack.Count != 0)
            {
                if (OperandStack.Peek().ShowPriority() >= new DivisionStrategy().ShowPriority())
                {
                    ICalculateStrategy Op = OperandStack.Pop();
                    TreeNode n1 = NodeStack.Pop();
                    TreeNode n2 = NodeStack.Pop();

                    TreeNode CombinedNode = new TreeNode(Op.CalculateResult(n2.Value, n1.Value));
                    CombinedNode.OutputString = Op.ShowOperator();
                    CombinedNode.LeftChild = n2;
                    CombinedNode.RightChild = n1;

                    NodeStack.Push(CombinedNode);
                }
                else
                {
                    break;
                }
            }
            // highest priority
            OperandStack.Push(new DivisionStrategy());
            Cadence();
        }

        public decimal AddEquals()
        {
            Cadence();
            Console.WriteLine("LeftParenthesisCounter = " + LeftParenthesesCounter.ToString());
            /// remember to add right parentheses if needed
            /// should move to other place
            int tmpCounter = LeftParenthesesCounter;
            for (int i = 0; i < tmpCounter; i++)
            {
                Console.WriteLine("Adding Par");
                AddRightPar();
            }

            while(OperandStack.Count != 0)
            {
                ICalculateStrategy Op = OperandStack.Pop();
                TreeNode n1 = NodeStack.Pop();
                TreeNode n2 = NodeStack.Pop();

                TreeNode CombinedNode = new TreeNode(Op.CalculateResult(n2.Value, n1.Value));
                CombinedNode.OutputString = Op.ShowOperator();
                CombinedNode.LeftChild = n2;
                CombinedNode.RightChild = n1;

                NodeStack.Push(CombinedNode);
            }
            Root = NodeStack.Peek();
            Cadence();

            this.Calculator.PreOrderString = PreOrder(this.Root);
            this.Calculator.InOrderString = InOrder(this.Root);
            this.Calculator.PostOrderString = PostOrder(this.Root);

            return NodeStack.Peek().Value;
        }

        public string PreOrder(TreeNode treeNode)
        {
            string ResString = "";
            ResString = treeNode.OutputString;
            if(treeNode.LeftChild != null)
            {
                ResString = ResString + " " + PreOrder(treeNode.LeftChild);
            }
            if(treeNode.RightChild != null)
            {
                ResString = ResString + " " + PreOrder(treeNode.RightChild);
            }
            return ResString;
        }

        public string InOrder(TreeNode treeNode)
        {
            string ResString = "";
            if (treeNode.LeftChild != null)
            {
                ResString = ResString + " " + InOrder(treeNode.LeftChild);
            }
            ResString = ResString + " " + treeNode.OutputString;
            if (treeNode.RightChild != null)
            {
                ResString = ResString + " " + InOrder(treeNode.RightChild);
            }
            return ResString;
        }

        public string PostOrder(TreeNode treeNode)
        {
            string ResString = "";
            if (treeNode.LeftChild != null)
            {
                ResString = ResString + " " + PostOrder(treeNode.LeftChild);
            }
            if (treeNode.RightChild != null)
            {
                ResString = ResString + " " + PostOrder(treeNode.RightChild);
            }
            ResString = ResString + " " + treeNode.OutputString;
            return ResString;
        }
    }
}
