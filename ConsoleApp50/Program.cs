using System;

namespace ConsoleApp50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of articles:");
            int num = Convert.ToInt32(Console.ReadLine());
            Store mag = new Store(num);
            mag.fill();
            mag.show();
        }
        class Article {
        private string itemName;
        private string shopName;
        private int cost;
            public void fill(string itemName, string shopName, int cost)
            {
                this.itemName = itemName;
                this.shopName = shopName;
                this.cost = cost;
            }
            public void show()
            {
                Console.WriteLine("Store: {0}\t Product: {1}\tprice: {2}\n", shopName, itemName, cost);
            }
        }
        class Store
        {
            private int Num;
            Article[] articles;
            public Store(int num) {
                this.articles = new Article[num];
                Num = num;
            }
            public void fill() {
                for (int i = 0; i < Num; i++)
                {
                    articles[i] = new Article();
                }
                for (int i = 0; i < Num; i++)
                {
                    Console.WriteLine("fill the {0} article (1.shop name => 2.item => 3.cost)", i);
                    articles[i].fill(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            public void show()
            {
                for (int i = 0; i < Num; i++)
                {
                    articles[i].show();
                }
            }
        }
    }
}
