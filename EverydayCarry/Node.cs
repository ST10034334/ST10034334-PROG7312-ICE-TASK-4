namespace EverydayCarry
{
    //Node class represents a generic node that stores an object of type T.
    //Microsoft (2024) demonstrates the LinkedListNode<T> Class.
    public class Node<T>
    {

        //Property to get or set the data of type T.
        public T Data { get; set; }

        //Property to get or set the reference to the next node.
        public Node<T> Next { get; set; }

        //Constructor used to initialize the data and set Next to null.
        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
}
//REFERENCE LIST:
//Microsoft. 2024. LinkedListNode<T> Class (Version 1.0)
//[Source code] https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-8.0
//(Accessed 25 July 2024).