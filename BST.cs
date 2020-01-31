using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BST
    {
        // ------------------------------- Member Valiable ------------------------------------
       
        public Node root;


        //  ------------------------------ Constructor -----------------------------------------
        public BST()
        {
            
        }
        // -------------------------------- Member method --------------------------------------

        public void Add(int data)
        {
            Node current;

            if (root == null)
            { 
                root = new Node(data); 
            }

            current = root;

            while (data >= current.data) 
            {
                if (current.rightChild == null)
                {
                    current.rightChild = new Node(data);
                }
                else
                {
                    current = current.rightChild;
                }
            }  // rightChild

            while (data <= current.data)
            {
                if (current.leftChild == null)
                {
                    current.leftChild = new Node(data);
                }
                else
                {
                    current = current.leftChild;
                }
            }  // leftChild
        }
        public void Search(int data)
        {
            Node current;
            current = root; 

            if (root == null)
            {
                Console.WriteLine("No match found.");
            }
            else if (root == current)
            {
                Console.WriteLine("Match Found");
            }

            while (data >= current.data)
            {
                if (current.rightChild == null)
                {
                    Console.WriteLine("No match found.");
                }
                else if(data == current.data)
                {
                    Console.WriteLine("Match Found");
                }
                else
                {
                    current = current.rightChild;
                }
            }  // rightChild

            while (data <= current.data)
            {
                if (current.leftChild == null)
                {
                    Console.WriteLine("No match found.");
                }
                else if (data == current.data)
                {
                    Console.WriteLine("Match Found");
                }
                else
                {
                    current = current.leftChild;
                }
            }  // leftChild
        }
    }
}
