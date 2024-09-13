using System.Windows;

namespace StackWebPage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Website website1;
        private Website website2;
        private Website website3;
        private BrowserHistory<Website> webStack;
        public MainWindow()
        {
            InitializeComponent();
            viewWebsites();
        }

        //viewWebsites() initializes the websites and the stack.
        private void viewWebsites()
        {
            website1 = new Website("AltexSoft - C# Pros and Cons", "Discusses the advantages and disadvantages of using C#, providing insights for developers considering the language for their projects.", "https://www.altexsoft.com/blog/c-sharp-pros-and-cons/");
            website2 = new Website("GeeksforGeeks - Introduction to C#", "Offers an introductory guide to C#, covering the basics of the language, including its features and applications.", "https://www.geeksforgeeks.org/introduction-to-c-sharp/");
            website3 = new Website("W3Schools - Introduction to Data Structures", "Provides a beginner-friendly introduction to data structures, explaining key concepts and their importance in programming.", "https://www.w3schools.com/dsa/dsa_intro.php");

            btnWeb1.Content = $"{website1}";
            btnWeb2.Content = $"{website2}";
            btnWeb3.Content = $"{website3}";

            webStack = new BrowserHistory<Website>(3);


        }

        //btnWeb1_Click() method pushes the web page onto the stack by calling the Push() method and 
        //opens web page 1.
        private void btnWeb1_Click(object sender, RoutedEventArgs e)
        {

            webStack.Push(website1);
            WebsiteWindow websiteWindow = new WebsiteWindow(website1.WebUri);
            websiteWindow.Show();
        }

        //btnWeb2_Click() method pushes the web page onto the stack by calling the Push() method and 
        //opens web page 2.
        private void btnWeb2_Click(object sender, RoutedEventArgs e)
        {
            webStack.Push(website2);
            WebsiteWindow websiteWindow = new WebsiteWindow(website2.WebUri);
            websiteWindow.Show();

        }

        //btnWeb3_Click() method pushes the web page onto the stack by calling the Push() method and 
        //opens web page 3.
        private void btnWeb3_Click(object sender, RoutedEventArgs e)
        {
            webStack.Push(website3);
            WebsiteWindow websiteWindow = new WebsiteWindow(website3.WebUri);
            websiteWindow.Show();
        }


        //btnViewHistory_Click() method shows the history of web pages visited by showing the web name of the
        //pages in order of LIFO returned by the PrintHistory() method.
        private void btnViewHistory_Click(object sender, RoutedEventArgs e)
        {
            lstbxHistory.Items.Clear();
            int count = 0;
            Website[] stackItems = webStack.PrintHistory();

            while (count < stackItems.Length)
            {
                lstbxHistory.Items.Add($"{stackItems[count].WebName}");
                count++;
            }
        }

        //btnPreviousPage_Click() method opens the last page visited or shows an error messagebox depending on
        //the result of the GoBack() method.
        private void btnPreviousPage_Click(object sender, RoutedEventArgs e)
        {
            var result = webStack.GoBack();

            if (result.visited == true)
            {
                WebsiteWindow websiteWindow = new WebsiteWindow(result.item.WebUri);
                websiteWindow.Show();
            }
            else
            {
                MessageBox.Show("No Web Page Visited Yet!");
            }

        }
    }
}