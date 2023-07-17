using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test1
{
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
    internal class Magazine
    {
        public string Name
        {
            get => _name;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(nameof(value));
                }
                _name = value;
            }
        }

        public Article Frequency
        {
            get => _frequency;
            set => _frequency = value;
        }

        public DateOnly ReleaseDate
        {
            get => _releaseDate;
            set => _releaseDate = value;
        }

        public int Circulation
        {
            get => _circulation;
            set
            {
                if (value >= 0)
                    _circulation = value;
            }
        }

        public List<Article> Articles
        {
            get => _articles;
            set => _articles = value;
        }

        public double AverageRate
        {
            get
            {
                double result = 0;
                foreach (var article in Articles)
                {
                    result += article.Rate;
                }

                return result / Articles.Count;
            }
        }

        private string? _name;
        private Article _frequency;
        private DateOnly _releaseDate;
        private int _circulation;
        private List<Article> _articles;

        public Magazine(string name, Article frequency, DateOnly releaseDate, int circulation, params Article[] articles)
        {
            Name = name;
            Frequency = frequency;
            ReleaseDate = releaseDate;
            Circulation = circulation;
            Articles = articles.ToList<Article>();
        }

        public Magazine()
        {
            Name = "Unknown";
            Frequency = Article.Weekly;
            ReleaseDate = new DateOnly(1970, 01, 01);
            Circulation = 0;
            Articles = new List<Article>();
        }

        public void AddArticles(params Article[] articles)
        {
            foreach (var article in articles)
            {
                Articles.Add(article);
            }
        }

        public string ToFullString()
        {
            string result = string.Join(", ", _name, _frequency, _releaseDate, _circulation);
            foreach (var article in Articles)
            {
                result += "\n" + article.ToFullString();
            }
            return result;
        }

        public string ToShortString()
        {
            return string.Join(", ", _name, _frequency, _releaseDate, _circulation, AverageRate);
        }
    }
#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
}
