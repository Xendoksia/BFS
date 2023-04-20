# BFS
breadth-first search in C# easy to understand
1-The Node class defines a binary tree node with a value (val) and left and right children (left and right).

2-The BinaryTree class defines a binary tree with a root node and two methods: BreadthFirstSearch and BuildTree.

3-The BreadthFirstSearch method performs a breadth-first search of the binary tree, starting at the root node. It uses a queue to keep track of the nodes to visit,
and it visits each node by dequeuing it from the queue, printing its value, and enqueueing its children (if any).

4-The BuildTree method prompts the user to enter the values for each node in the binary tree. It starts by creating the root node from the user's input. 
It then uses a queue to keep track of the nodes to add to the tree, starting with the root node. For each node in the queue, it prompts the user to enter the values for its left and right children
