using System;
namespace Tumakov
{
    class Laba
    {
        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
        }
        static void Task1()
        {
            Console.WriteLine("8.1");
            try {
                Bank acc1 = new Bank(5000, BankAccountType.savings);
                Console.WriteLine($"Баланс 1 счёта до перевода: {acc1.Balance}");
                Bank acc2 = new Bank(1000, BankAccountType.current);
                Console.WriteLine($"Баланс 2 счёта до перевода: {acc2.Balance}");
                acc1.Transfer(acc2, 3000);
                Console.WriteLine($"Теперь баланс 1 счёта = {acc1.Balance}, баланс 2 счёта = {acc2.Balance}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный ввод");
            }
        }
        static void Task2()
        {
            Console.WriteLine("8.2");
            try 
            {
                Console.WriteLine("Введите строку, которую хотите перевернуть:");
                string str = Console.ReadLine();
                Reversing reversing = new Reversing();
                Console.WriteLine($"Перевёрнутая строка: {reversing.ReversingString(str)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный ввод");
            }
        }
        static void Task3()
        {
            try
            {
                Console.WriteLine("8.3");
                Console.WriteLine("Введите путь к файлу:");
                string path = @$"{Console.ReadLine()}";//Файл к заданию 8.3.txt
                Files file = new Files();
                Console.WriteLine(file.FileProcessing(path));
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите корректный путь к файлу");
            }
        }
        static void Task4()
        {
            Console.WriteLine("8.4");
            IFormatable iformat = new IFormatable();
            object number = 111;
            object dateTime = DateTime.Now;
            Console.WriteLine(iformat.IFormat(number));
            Console.WriteLine(iformat.IFormat(dateTime));
        }
        static void Task5()
        {
            try
            {
                Console.WriteLine("dz8.1");
                Console.WriteLine("Введите путь к файлу:");
                string path = Console.ReadLine();//Емайлы.txt
                Email email = new Email();
                Console.WriteLine(email.GetEmail(path));
                Console.WriteLine("Введите строку со ссылкой:");
                string s = Console.ReadLine();//Петров Петр Петрович # petr@mail.ru
                Console.WriteLine(email.SearchEmail(s));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Введите корректный путь к файлу");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Введите корректную строку");
            }
        }
        static void Task6()
        {
            Console.WriteLine("dz8.2");
            List<Song> songs = new List<Song>
            {
                new Song { Name = "Konstrukt", Author = "Oxxxymiron" },
                new Song { Name = "По пятам", Author = "Эндшпиль" },
                new Song { Name = "I Got Love", Author = "Miyagi & Эндшпиль, Рем Дигга" },
                new Song { Name = "Guts", Author = "KLAN NOGI" }
            };
            for (int i = 1; i < songs.Count; i++)
            {
                songs[i].Prev = songs[i - 1];
            }
            foreach (Song song in songs)
            {
                song.Title();
            }
            if (songs[0].Equals(songs[1]))
            {
                Console.WriteLine("Первая и вторая песни совпадают");
            }
            else
            {
                Console.WriteLine("Первая и вторая песни не совпадают");
            }
        }
    }
}