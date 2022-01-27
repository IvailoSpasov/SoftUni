using System;
using System.Threading.Channels;

namespace _02._Articles
{
    class Article
    {
        private string title_;
        private string content_;
        private string author_;

        public Article(string title, string content, string author)
        {
            Author = author;
            Content = content;
            Title = title;
        }

        public string Title
        {
            get => title_;
            set => title_ = value;
        }
        public string Content
        {
            get => content_;
            set => content_ = value;
        }

        public string Author
        {
            get=>author_;
            set=>author_=value;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

        public void Edit(string content)
        {
            Content = content;
        }
        public void ChangeAuthor(string author)
        {
            Author = author;
        }
        public void Rename(string title)
        {
            Title = title;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Article article = new Article(input[0], input[1], input[2]);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(": ");
                switch (cmd[0])
                {
                    case "Edit":
                        article.Edit(cmd[1]);
                        break;
                    case "Rename":
                        article.Rename(cmd[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(cmd[1]);
                        break;
                }

            }

            Console.WriteLine(article);
        }
    }
}
