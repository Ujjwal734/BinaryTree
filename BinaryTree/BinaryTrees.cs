using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTrees
    {
        private Node _root;
        public BinaryTrees()
        {
            _root = null;
        }
        public void Add(int data)
        { 
            if (_root == null)
            {
                _root = new Node(data);
                return;
            } 
            Add(_root, new Node(data));
        }
        public void Add(Node root, Node newNode)
        {
            if (root == null)
                root = newNode;

            if (newNode.Data < root.Data)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    Add(root.Left, newNode);

            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    Add(root.Right, newNode);
            }
        }
        public void Display(Node root)
        {
            if (root == null) return;

            Display(root.Left);
            System.Console.Write(root.Data + " ");
            Display(root.Right);
        }
        public void Display()
        {
            Display(_root);
        }
        
    }
}
