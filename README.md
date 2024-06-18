# Data Structures and Algorithms in C#

This repository contains implementations of various data structures and algorithms in C#. The implemented data structures include stack, queue, binary search tree (BST), linked list, and double linked list. The algorithms implemented here cover sequential search, binary search, merge sort, bubble sort, selection sort, and insertion sort.

## Data Structures

### Stack

The `Stack` data structure is implemented in two different ways: using arrays and using linked lists.

- **Array-based Stack (`Arr_Stack`):** This implementation uses an array to store elements and supports operations like `Push` (to add elements) and `Pop` (to remove elements).

- **Linked List-based Stack (`ArrayList_Stack`):** This implementation uses an ArrayList to store elements and supports similar operations to the array-based implementation.

### Queue

The `Queue` data structure is implemented using both arrays and ArrayList.

- **Array-based Queue (`Arr_Queue`):** This implementation uses an array to store elements and supports operations like `Enqueue` (to add elements) and `Dequeue` (to remove elements).

- **ArrayList-based Queue (`ArrayList_Queue`):** This implementation uses an ArrayList to store elements and supports similar operations to the array-based implementation.

### Binary Search Tree (BST)

The `BST` data structure represents a binary search tree, where each node has at most two child nodes and follows the property that the left child is less than the parent, and the right child is greater than the parent.

- **Binary Search Tree (`BinarySearchTree`):** This implementation provides operations for insertion, deletion, searching, and traversal of a binary search tree.

### Linked List

The `LinkedList` data structure represents a linear collection of elements where each element points to the next element in the sequence.

- **Singly Linked List (`SinglyLinkedList`):** This implementation supports operations like insertion, deletion, searching, and traversal in a singly linked list.

- **Doubly Linked List (`DoublyLinkedList`):** This implementation extends the singly linked list by providing each node with references to both the next and previous nodes.

## Algorithms

### Searching Algorithms

- **Sequential Search (`SequentialSearch`):** This algorithm sequentially searches for a target element in a list or array by iterating through each element until the target is found or the end of the list is reached.

- **Binary Search (`BinarySearch`):** This algorithm efficiently searches for a target element in a sorted list or array by repeatedly dividing the search interval in half.

### Sorting Algorithms

- **Merge Sort (`MergeSort`):** This algorithm sorts a list or array by recursively dividing it into smaller sublists, sorting those sublists, and then merging them back together.

- **Bubble Sort (`BubbleSort`):** This algorithm repeatedly steps through the list, compares adjacent elements, and swaps them if they are in the wrong order.

- **Selection Sort (`SelectionSort`):** This algorithm repeatedly finds the minimum element from the unsorted part of the list and moves it to the beginning.

- **Insertion Sort (`InsertionSort`):** This algorithm builds a sorted list by repeatedly taking elements from the unsorted part of the list and inserting them into their correct position in the sorted part.

## Usage

Each data structure and algorithm implementation is provided in its respective C# file. You can include the necessary files in your C# project and utilize the provided functionalities.

## License

This repository is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
