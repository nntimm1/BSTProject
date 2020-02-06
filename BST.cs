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
                return;
            }

            current = root;

            while (current != null) 
            {
                if (data >= current.data)
                {
                    if (current.rightChild == null)
                    {
                        current.rightChild = new Node(data);
                        return;
                    }
                    else
                    {
                        current = current.rightChild;
                    }
                }
                else if (data <= current.data)
                {
                    if (current.leftChild == null)
                    {
                        current.leftChild = new Node(data);
                        return;
                    }
                    else
                    {
                        current = current.leftChild;
                    }
                }
            }  
        }
        public void Search(int data)
        {
            Node current;
            current = root;
            while (current != null)
            {

                if (data == current.data)
                {
                    Console.WriteLine("Match Found.");
                    return;
                }
                else if (data < current.data)
                {
                    current = current.leftChild;
                    if (current == null)
                    {
                        Console.WriteLine("No Match Found.");
                    }
                }
                else if (data > current.data)
                {
                    current = current.rightChild;
                    if (current == null)
                    {
                        Console.WriteLine("No Match Found.");
                    }
                }
                else if (data != current.data)
                {
                    Console.WriteLine("No Match Found.");
                    return;
                }
            } 
        }

    }
}
