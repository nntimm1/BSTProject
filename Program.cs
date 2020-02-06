using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BST tree = new BST();
            tree.Add(5);
            tree.Add(15);
            tree.Add(10);
            tree.Add(25);
            tree.Add(20);
            tree.Add(30);
            tree.Add(35);


            tree.Search(35); 
            tree.Search(16); 
            tree.Search(5);

        }
    }
}
