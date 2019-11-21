using System;

namespace TestClassifiedAd
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassifiedAd ad = new ClassifiedAd("Used Cars", 2);
            Console.WriteLine("Category: {1}{0}Word Count: {2}{0}Price: {3}", Environment.NewLine, ad.Category, ad.WordCount, ad.Price);
        }
    }
    class ClassifiedAd
    {
        public string Category { get; set; }
        public int WordCount { get; set; }
        public double Price { get => WordCount * 0.9D; }
        public ClassifiedAd(string category, int word)
        {
            Category = category;
            WordCount = word;
        }
        public ClassifiedAd() : this("X", 0) { }
    }
}
