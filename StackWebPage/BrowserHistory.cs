namespace StackWebPage
{
    public class BrowserHistory<T>
    {
        private CustomStack<T> history;
        private CustomStack<T> previous;

        public BrowserHistory(int size)
        {
            previous = new CustomStack<T>(size);
            history = new CustomStack<T>(size);

        }

        //Pushes all websites visited to both previous and history stacks.
        public void Push(T item)
        {
            previous.Push(item);
            history.Push(item);
        }


        //Returns to the previously visited website.
        public (T item, bool visited) GoBack()
        {
            if (previous.IsEmpty())
            {
                return (default, false);

            }
            else
            {
                return (previous.Peek(), true);
            }
        }

        //Shows all history of websites visited.
        public T[] PrintHistory()
        {
            return history.Print();
        }
    }
}
