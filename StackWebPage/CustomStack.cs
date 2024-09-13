namespace StackWebPage
{
    //GeeksForGeeks (2019) demonstrates the Stack class.
    public class CustomStack<T>
    {
        private T[] itemArray;
        private int top;
        private int size;

        //Constructor initializes the itemArray and other variables with appropriate values.
        public CustomStack(int s)
        {
            itemArray = new T[s];
            size = s;
            top = -1;
        }

        //Push() method adds the item to the top of the stack.
        //First checks if array is full, and if not, adds the item to top of stack and returns the
        //appropriate boolean value.
        public bool Push(T item)
        {
            if (top == size - 1)
            {
                return false;
            }
            else
            {
                itemArray[++top] = item;
                return true;
            }
        }

        //Peek() method returns the top item without removing it according to LIFO approach:
        //First checks that the stack array is not empty, and if so, returns the item at the top of the stack,
        //else returns the default.
        public T Peek()
        {
            if (top >= 0)
            {
                return itemArray[top];
            }
            else
            {
                return default;
            }
        }

        //Pop() method removes the top item from the stack.
        //First checks that the stack array is not empty, and if so, returns the item at the top of the stack,
        //then decrements the top, else returns the default.
        public T Pop()
        {
            if (top >= 0)
            {
                return itemArray[top--];
            }
            else
            {
                return default;
            }
        }

        //Print() method returns the current stack as an array.
        public T[] Print()
        {
            T[] currentItems = new T[top + 1];
            for (int i = 0; i <= top; i++)
            {
                currentItems[i] = itemArray[top - i];
            }
            return currentItems;
        }

        //Checks if the stack is empty.
        public bool IsEmpty()
        {
            return top == -1;
        }
    }
}
//REFERENCE LIST:
//GeeksForGeeks. 2019. C# | Stack Class (Version 2.0)
//[Source code] https://www.geeksforgeeks.org/c-sharp-stack-class/
//(Accessed 25 August 2024).