using System.Windows;

namespace StackWebPage
{
    /// <summary>
    /// Interaction logic for WebsiteWindow.xaml
    /// </summary>
    public partial class WebsiteWindow : Window
    {
        public WebsiteWindow(string webUri)
        {
            InitializeComponent();
            InitializeWebView2(webUri);
        }


        private async void InitializeWebView2(string webUri)
        {
            //Microsoft (2023) demonstrates how to use WebView2.
            await webView2.EnsureCoreWebView2Async(null);
            webView2.CoreWebView2.Navigate(webUri);
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
//REFERENCE LIST:
//Microsoft. 2023. Get started with WebView2 in WinForms apps (Version 1.0)
//[Source code] https://learn.microsoft.com/en-us/microsoft-edge/webview2/get-started/winforms
//(Accessed 25 August 2024).
