namespace StackWebPage
{
    public class Website
    {
        public string WebName { get; set; }
        public string WebDescription { get; set; }
        public string WebUri { get; set; }

        public Website(string webName, string webDescription, string webUri)
        {
            WebName = webName;
            WebDescription = webDescription;
            WebUri = webUri;
        }

        override public string ToString()
        {
            return $"{WebName}\n{WebDescription}";
        }
    }
}
