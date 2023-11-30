namespace Part2
{
    public class Book
    {
        private string title;
        private string author;
        private string publisher;

        public Book(string title, string author, string publisher)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
        }
        public string Title
        {
            get
            {
                return title;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
        }
        public string Publisher
        {
            get
            {
                return publisher;
            }
        }
        public override string ToString()
        {
            return $"Название: {title}, автор: {author}, издатель: {publisher}";
        }
    }
}
