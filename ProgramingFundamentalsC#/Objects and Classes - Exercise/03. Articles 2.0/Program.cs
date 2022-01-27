using System;
using System.Collections.Generic;
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
            get => author_;
            set => author_ = value;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                Article article = new Article(input[0], input[1], input[2]);
                articles.Add(article);
            }

            string cmd = Console.ReadLine();
            if (cmd == "title")
            {
                articles.Sort((x, y) => x.Title.CompareTo(y.Title));
            }
            else if (cmd == "content")
            {
                articles.Sort((x, y) => x.Content.CompareTo(y.Content));
            }
            else if (cmd == "author")
            {
                articles.Sort((x, y) => x.Author.CompareTo(y.Author));
            }

            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }
}
