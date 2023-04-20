using System;
using System.Collections.Generic;

public class Node
{
    public int val;
    public Node left;
    public Node right;

    public Node(int val)
    {
        this.val = val;
        this.left = null;
        this.right = null;
    }
}

public class BinaryTree
{
    public Node root;

    public BinaryTree()
    {
        this.root = null;
    }

    public void BreadthFirstSearch()
    {
        if (this.root == null)
        {
            return;
        }

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(this.root);

        while (queue.Count > 0)
        {
            Node curr = queue.Dequeue();
            Console.Write(curr.val + " ");

            if (curr.left != null)
            {
                queue.Enqueue(curr.left);
            }

            if (curr.right != null)
            {
                queue.Enqueue(curr.right);
            }
        }
    }

    public void BuildTree()
    {
        Console.Write("Enter the root node: ");
        int rootVal = int.Parse(Console.ReadLine());
        this.root = new Node(rootVal);

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(this.root);

        while (queue.Count > 0)
        {
            Node curr = queue.Dequeue();

            Console.Write($"Enter the left child of {curr.val} (or 'None'): ");
            string leftVal = Console.ReadLine();
            if (leftVal != "None")
            {
                int leftValInt = int.Parse(leftVal);
                if (leftValInt > curr.val)
                {
                    Console.WriteLine("Invalid input: left child cannot be greater than the parent.");
                    continue;
                }

                curr.left = new Node(leftValInt);
                queue.Enqueue(curr.left);
            }

            Console.Write($"Enter the right child of {curr.val} (or 'None'): ");
            string rightVal = Console.ReadLine();
            if (rightVal != "None")
            {
                int rightValInt = int.Parse(rightVal);
                if (rightValInt <= curr.val) // fixed condition
                {
                    Console.WriteLine("Invalid input: right child must be greater than the parent.");
                    continue;
                }

                curr.right = new Node(rightValInt);
                queue.Enqueue(curr.right);
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        BinaryTree tree = new BinaryTree();
        tree.BuildTree();
        Console.Write("Breadth-first search result: ");
        tree.BreadthFirstSearch();
    }
}
