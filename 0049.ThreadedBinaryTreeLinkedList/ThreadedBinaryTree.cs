using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0049.ThreadedBinaryTreeLinkedList
{
    internal class ThreadedBinaryTree
    {
        private Node root;
        public ThreadedBinaryTree()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        private Node InOrderPredecessor(Node p)
        {
            if(p.leftThread == true)
                return p.left;
            else
            {
                p = p.left;
                while (p.rightThread == false)
                    p = p.right;
                return p;
            }

        }

        private Node InOrderSuccessor(Node p)
        {
            if (p.rightThread == true)
                return p.right;
            else
            {
                p = p.right;
                while (p.leftThread == false)
                    p = p.left;
                return p;
            }
        }

        public void InOrder()
        {
            if(root == null)
            {
                Console.WriteLine("The tree is empty");
                return;
            }    
            
            Node p = root;
            while (p.leftThread == false)
                p = p.left;
            while (p != null)
            {
                Console.Write(p.info + "  ");
                if(p.rightThread == true)
                    p = p.right;
                else
                {
                    p = p.right;
                    while (p.leftThread == false)
                        p = p.left;
                }
            }
            Console.WriteLine();
        }

        public void Insert(int x)
        {
            Node p = root;
            Node parent = null;

            //Find the node closest to the Node to be inserted and mark it as parent
            while (p != null)
            {
                parent = p;
                if(x < p.info)
                {
                    if (p.leftThread == false)
                        p = p.left;
                    else
                        break;
                }
                else if(x > p.info)
                {
                    if (p.rightThread == false)
                        p = p.right;
                    else
                        break;
                }
                else
                {
                    Console.WriteLine("Node with value " + x + " is already present in the list");
                    return;
                }
            }

            Node temp = new Node(x);
            if (parent == null)
                root = temp;
            else if(x < parent.info)
            {
                //Insert node to left of parent if value is less than parent 
                temp.left = parent.left;
                temp.right = parent;
                parent.left = temp;
                parent.leftThread = false;
            }
            else
            {
                //Insert node to the right of parent if value is greater than parent
                temp.right = parent.right;
                temp.left = parent;
                parent.right = temp;
                parent.rightThread = false;
            }
        }

        public void Delete(int x)
        {
            Node p = root;
            Node parent = null;
            
            //Traverse tree to find the node to be deleted
            while (p != null)
            {
                if (x == p.info)
                    break;
                parent = p;
                if (x < p.info)
                {
                    if (p.leftThread == false)
                        p = p.left;
                    else
                        break;
                }                  
                else
                {
                    if (p.rightThread == false)
                        p = p.right;
                    else
                        break;
                }
            }

            //If traversal does not yeild a match throw not found message
            if(p == null || p.info != x)
            {
                Console.WriteLine(x + " is not found");
                return;    
            }

            //If node to be deleted if found
            //Case 1: If node to be deleted is not a leaf node and has 2 children
            if (p.leftThread == false && p.rightThread == false)
            {
                //Find inorder successor and its parent
                //Set initial values for parent of successor and successor
                Node pSuccessor = p;
                Node successor = p.right;

                while (successor.leftThread == false)
                {
                    //Find the left most node in the right subtree reset successor and its parent
                    pSuccessor = successor;
                    successor = successor.left;
                }

                //copy successor info to the node to be deleted
                p.info = successor.info;
                //reset p to be the successor
                p = successor;
                //reset parent to parent of successor
                parent = pSuccessor;
            }
            //Case 2: If node to be deleted is a leaf node and has no children
            if(p.leftThread == true && p.rightThread == true) 
            {
                //If tree has only one node then parent is null
                if (parent == null)
                    root = null;
                else if(p == parent.left)
                {
                    //If node to be deleted is the left node of its parent
                    //Copy delete node's left to parent
                    //Delete this left node by setting parent's left thread to true 
                    parent.left = p.left;
                    parent.leftThread = true;
                }
                else if(p == parent.right)
                {
                    //If node to be deleted is the right node of its parent
                    //Copy delete node's right to parent
                    //Delete right node by setting parent's right thread to true
                    parent.right = p.right;
                    parent.rightThread = true;
                }
            }
            //Case 3: If node to be deleted is not a lead node and has 1 child
            Node ch;
            //identify the child node and set its value
            //If node to be deleted has left child
            if(p.leftThread == false)
                ch = p.left;
            else //Node to be deleted has right child
                ch = p.right;

            //If node to be deleted is root node
            if (parent == null)
                root = ch;
            else if(p == parent.left) //Node to be deleted is left node of its parent
                parent.left = ch; //Delete node by setting parent left to child of delete node
            else
                parent.right = ch; //Delete node by setting parent right to child of delete node

            //Find INorder predecessor and successor for the delete node
            Node pred = InOrderPredecessor(p);
            Node succ = InOrderSuccessor(p);

            //If delete Node has a left child, then its right is a thread
            //Reset P's Predecessor's right to its successor
            if (p.leftThread == false)
                pred.right = succ;
            else //If delete node has right child, then its left is a thread  
                succ.left = pred; //reset P's successor's left to predecessor
        }
    }
}
