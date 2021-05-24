using System;
using System.Threading;

namespace ConsoleApp1
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public User(string Login, string Name, bool IsPremium)
        {
            this.Login = Login;
            this.Name = Name;
            this.IsPremium = IsPremium;
        }
    }

    class Program
    {
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

        static void ShowAdsLogic(User[] user)
        {
            foreach (var premium in user)
            {
                if (premium.IsPremium == false)
                {
                    Console.WriteLine($"Hello {premium.Name}");
                    ShowAds();
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            User[] user = {
                new User("user1", "User1", false),
                new User("user2", "User2", true),
                new User("user3", "User3", false),
                new User("user4", "User4", false),
                new User("user5", "User5", true) };

            ShowAdsLogic(user);
        }
    }
}
