using System.Collections;

namespace EverydayCarry
{
    //CustomLinkedList class is a generic collection used to store objects of type T.
    //Microsoft (2024) demonstrates the LinkedList<T> Class.
    public class CustomLinkedList<T> : IEnumerable<T>
    {
        //Private fields of the class.
        private Node<T> head;
        private Node<T> tail;
        private int count;

        //Constructor used to initialize private fields.
        public CustomLinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        //Count() method returns the current count of the list.
        public int Count { get { return count; } }

        //The AddLast() method adds an item to the end of the list.
        //First, it creates a new node with the given data and checks if the head is null.
        //If it is, the new node becomes both the head and tail of the list, and the count is increased.
        //If not, the current tail points to the new node (using Next property), which then becomes the new tail,
        //and the count is updated.
        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                count++;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
                count++;
            }
        }

        //Find() method returns the first node whose data matches the value.
        //It starts at the head and iterates through the list, updating the current node to the next one.
        //If the data and value matches, the current node is returned.
        //If no node matches the value and the end of the list is reached (current becomes null), the method returns null,
        //indicating no matching node was found.
        public Node<T> Find(T value)
        {
            Node<T> current = head;

            while (current != null)
            {
                if (current.Data.Equals(value))
                {
                    return current;
                }
                current = current.Next;
            };

            return null;

        }

        //Clear() method sets the pointer to head to null, and therefore the rest of the list can't be viewed.
        public void Clear()
        {
            head = null;
        }

        //GetEnumerator() method enables the use of the FOREACH loop with the CustomLinkedList.
        //It starts at the head node and iterates through the list, yielding each node's data one by one.
        //Dutta (2021) demonstrates how to implement the IEnumerable interface.
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        //Remove() method removes the first occurrence of the specified value from the linked list.
        //It initializes 'current' to the head and 'previous' to null to keep track of the nodes.
        //Head Case: If the value matches the data in the head node, the head is updated to the next node (head.Next).
        //Other Case: The method iterates through the list, updating 'current' and 'previous',  until it finds the node with the specified value
        //or reaches the end of the list. If the node is found, 'previous.Next' is updated to skip over the node to be removed  by pointing it to 'current.Next',
        //effectively removing the node from the list.
        public void Remove(T value)
        {
            Node<T> current = head;
            Node<T> previous = null;

            if (head.Data.Equals(value))
            {
                head = head.Next;
                return;
            }

            while (current != null && !(current.Data.Equals(value)))
            {
                previous = current;
                current = current.Next;
            }

            if (current.Next != null)
            {
                previous.Next = current.Next;
            }

        }

        //IEnumerable.GetEnumerator() returns the generic GetEnumerator() method to support iteration using the FOREACH loop
        //for both generic and non-generic collections.
        //Dutta (2021) demonstrates how to implement the IEnumerable interface.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
//REFERENCE LIST:
//Dutta, D. 2021. How to implement IEnumerable interface. Medium, 30 September 2021 (Version 1.0)
//[Source code] https://divinesense.medium.com/how-to-implement-ienumerable-interface-696c17811d8a
//(Accessed 25 July 2024).
//Microsoft. 2024. Func<T,TResult> Delegate (Version 1.0)
//[Source code] https://learn.microsoft.com/en-us/dotnet/api/system.func-2?view=net-8.0&redirectedfrom=MSDN
//(Accessed 25 July 2024).
//Microsoft. 2024. LinkedList<T> Class (Version 1.0)
//[Source code] https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-8.0
//(Accessed 25 July 2024).
