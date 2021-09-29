using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework_5
{
    public static class Massage
    {

        private static string[] separators = { "!", "?", ",", ".", ":", ";", "(", ")", " ", ">", "<" };

        public static void CharWord(string str, int n)
        {
            string[] word = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Все слова, которые содержат не более {n} букв");
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].Length <= n)
                {
                    Console.WriteLine(word[i]);
                }
            }
        }


        public static void EndDeleteWord(string str, char e)
        {
            string[] word = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder str1 = new StringBuilder();
            Console.WriteLine($"Текст после форматирования:");
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i][word[i].Length - 1] != e)
                {
                    str1.Append($"{word[i]}\t");                    
                }
            }
            Console.WriteLine(str1);
        }

        public static void PoiskWord(string str)
        {
            string[] word = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int p = 0;
            for (int i = 0; i < word.Length; i++)
            {
                string str2 = word[i];
                string str5 = str2.ToLower();
                for (int b = 0; b < word.Length; b++)
                {
                    string str3 = word[b];
                    string str6 = str3.ToLower();
                    if (str5 == str6)
                    {
                        p++;
                    }
                }
                Console.WriteLine($"Слово [{word[i]}] встречается {p} раз.");
                p = 0;
            }
        }

        public static void MaxWord(string str)
        {
            string[] word = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Все слова, имеющие наибольшее количество букв:");
            int max = 0;
            int i = 0;
            for (i = 0; i < word.Length; i++)
            {
                if (word[i].Length >= max)
                {
                    max = word[i].Length;
                }
            }

            for (i = 0; i < word.Length; i++)
            {
                if (word[i].Length == max)
                {
                    Console.WriteLine(word[i]);
                }

            }
        }

        public static void MaxStringBuiler(string str)
        {

            string[] word = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Все слова, имеющие наибольшее количество букв:");
            int max = 0;
            int i = 0;
            for (i = 0; i < word.Length; i++)
            {
                if (word[i].Length >= max)
                {
                    max = word[i].Length;
                }
            }
            StringBuilder str1 = new StringBuilder();
            for (i = 0; i < word.Length; i++)
            {
                if (word[i].Length == max)
                {
                    str1.Append($"{word[i]}\t");
                }
            }
            Console.WriteLine(str1);

        }

    }
    class Program
    {

        static int Proverka1(char[] word) 
        {
            int p = 0;
            if (1 <= word.Length - 1 && word.Length - 1 <= 9) 
            {
                p = 1;
                return p;
            }
            else
            {
                Console.WriteLine("Пароль должен содержать  от 2 до 10 символов.");
                p = 0;
                return p;
            }

        }

        static int Proverka2(char[] word)
        {
            int m = 0;
            int i = 0;
            int p = 0;
            for (i = 0; i < word.Length; i++)
            {
                UnicodeCategory category1 = char.GetUnicodeCategory(word[i]);
                if (word[i] >= 'a' && word[i] <= 'z' || word[i] >= 'A' && word[i] <= 'Z' || category1 == UnicodeCategory.DecimalDigitNumber)
                {                                       
                    m++;                    
                }
            }
            if (m == i)
            {
                p = 1;
                return p;
            }
            else
            {
                Console.WriteLine("Пароль может содержать только латинские буквы и цифры.");
                p = 0;
                return p;
            }            
        }

        static int Proverka3(char[] word)
        {
            int m = 0;
            int i = 0;
            int p = 0;
            for (i = 0; i < word.Length; i++)
            {
                UnicodeCategory category1 = char.GetUnicodeCategory(word[0]);
                if (category1 != UnicodeCategory.DecimalDigitNumber)
                {
                    m++;
                }
            }
            if (m == i)
            {
                p = 1;
                return p;
            }
            else
            {
                Console.WriteLine("Пароль не может начинаться с цифры.");
                p = 0;
                return p;
            }

        }

        static void Task1() 
        {

            int mynumber1;
            Console.Clear();
            Console.Title = "Авторизация";
                       
            do
            {
                Console.Title = "Редактирование текста";
                PrintInCenter("Добро пожаловать в главное меню!");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("Чтобы выбрать номер задачи, Вам необходимо написать ее номер, чтобы вернуться в главнок меню нажмите 0.");
                Console.WriteLine("  ");
                Console.WriteLine("1 - стандартный способ");
                Console.WriteLine("2 - с помощью регулярных выражений;");                
                Console.WriteLine("-----------");
                Console.Write("Номер действия: ");

                if (int.TryParse(Console.ReadLine(), out mynumber1))
                {

                    switch (mynumber1)
                    {

                        case 1:
                            Task8();
                            break;
                        case 2:
                            Task7();
                            break;                        
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Вы ввели неправильный номер задания. Введите еще раз.");
                            Console.ReadLine();
                            break;

                    }

                }
                else
                {

                    Console.Write($"Вы ввели некорректное число.");
                    Console.ReadLine();
                    mynumber1++;

                }
                
            }
            while (mynumber1 != 0);

            Console.Clear();
            Console.Title = "Возвращение в главное меню.";
            Console.Write("Назад!");
            Console.ReadKey();

        }
        static void Task2()
        {
            int mynumber;
            Console.Clear();
            Console.Title = "Редактирование текста";
            Console.Write($"Введите текст: ");
            string str = Convert.ToString(Console.ReadLine());
            do
            {                
                Console.Title = "Редактирование текста";
                PrintInCenter("Добро пожаловать в главное меню!");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("Чтобы выбрать номер задачи, Вам необходимо написать ее номер, чтобы вернуться в главнок меню нажмите 0.");
                Console.WriteLine("  ");
                Console.WriteLine("1 - вывести только те слова сообщения, которые содержат не более n букв");
                Console.WriteLine("2 - удалить из сообщения все слова, которые заканчиваются на заданный символ;");
                Console.WriteLine("3 - найти самое длинное слово сообщения;");
                Console.WriteLine("4 - сформировать строку с помощью StringBuilder из самых длинных слов сообщения;");
                Console.WriteLine("5 - возвращает сколько раз каждое из слов массива входит в этот текст.");
                Console.WriteLine("-----------");
                Console.Write("Номер действия: ");

                if (int.TryParse(Console.ReadLine(), out mynumber))
                {

                    switch (mynumber)
                    {

                        case 1:
                            Task3(ref str);
                            break;
                        case 2:
                            Task4(ref str);
                            break;
                        case 3:
                            Task5(ref str);
                            break;
                        case 4:
                            Task6(ref str);
                            break;
                        case 5:
                            Task9(ref str);
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Вы ввели неправильный номер задания. Введите еще раз.");
                            Console.ReadLine();
                            break;

                    }

                }
                else
                {

                    Console.Write($"Вы ввели некорректное число.");
                    Console.ReadLine();
                    mynumber++;

                }

                Console.WriteLine(str);
            }
            while (mynumber != 0);

            Console.Clear();
            Console.Title = "Возвращение в главное меню.";
            Console.Write("Назад!");
            Console.ReadKey();

        }
        static void Task3(ref string str)
        {
                        
            Console.Title = "Редактирование текста";            
            Console.Write($"Сколько букв должно быть в слове? ");
            int n = Convert.ToInt32(Console.ReadLine());            
            Massage.CharWord(str, n);            
            Console.ReadKey();

        }
        static void Task4(ref string str)
        {

            Console.Clear();
            Console.Title = "Редактирование текста";            
            Console.Write($"На какую букву должны заканчиваться слова, которые будем удалять? ");
            char e = Convert.ToChar(Console.ReadLine());           
            Massage.EndDeleteWord(str, e);            
            Console.ReadKey();

        }
        static void Task5(ref string str)
        {

            Console.Clear();
            Console.Title = "Редактирование текста";            
            Massage.MaxWord(str);            
            Console.ReadKey();

        }
        static void Task6(ref string str)
        {
                       

            Console.Clear();
            Console.Title = "Редактирование текста";           
            Massage.MaxStringBuiler(str);
            Console.ReadKey();

        }

        static void Task9(ref string str)
        {


            Console.Clear();
            Console.Title = "Редактирование текста";
            Massage.PoiskWord(str);
            Console.ReadKey();

        }


        static void Task7()
        {


            Console.Clear();
            Console.Title = "Авторизация";
            Console.WriteLine("Login должен содержать  от 2 до 10 символов. Можно использовать буквы латинского алфавита или цифры, цифра не может быть первой.");
            int p1 = 0;
            Regex regex01 = new Regex("^[^0-9]{1}[a-zA-Z0-9]{1,9}$");
            do
            {
                Console.Write("Введите login: ");
                string login = Convert.ToString(Console.ReadLine());
                string login2;
                char[] word = login.ToCharArray();                
                //regex01.IsMatch(login);
                if (regex01.IsMatch(login))
                {
                    Console.Write("Повторите login: ");
                    login2 = Convert.ToString(Console.ReadLine());
                    if (login2 == login)
                    {
                        Console.WriteLine("Login одобрен.");
                        p1++;
                    }
                    else
                    {
                        Console.WriteLine("Login не совпадает.");
                    }
                }
                else
                {
                    Console.WriteLine("Login не подходит.");
                    Console.WriteLine("Login должен содержать  от 2 до 10 символов. Можно использовать буквы латинского алфавита или цифры, цифра не может быть первой.");
                }
            }
            while (p1 != 1);
            Console.ReadLine();


        }
        static void Task8()
        {
            Console.Clear();
            Console.Title = "Авторизация";
            Console.WriteLine("Login должен содержать  от 2 до 10 символов. Можно использовать буквы латинского алфавита или цифры, цифра не может быть первой.");
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            do
            {
                Console.Write("Введите login: ");
                string login = Convert.ToString(Console.ReadLine());
                string login2;
                char[] word = login.ToCharArray();
                p1 = Proverka1(word);
                if (p1 == 1)
                {
                    p2 = Proverka2(word);
                    if (p2 == 1)
                    {
                        p3 = Proverka3(word);
                        if (p3 == 1)
                        {
                            Console.Write("Повторите login: ");
                            login2 = Convert.ToString(Console.ReadLine());
                            if (login2 == login)
                            {
                                Console.WriteLine("Login одобрен.");
                                p4++;
                            }
                            else
                            {
                                Console.WriteLine("Login не совпадает.");
                            }
                        }
                    }
                }
            }
            while (p4 != 1);
            Console.ReadLine();
        }



        static void Main(string[] args)
        {
            
            int mynumber;

            do
            {
                Console.Clear();
                Console.Title = "Главное меню";
                Console.WriteLine("Марина Магера");           
                PrintInCenter("Добро пожаловать в главное меню!");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.WriteLine("Чтобы выбрать номер задачи, Вам необходимо написать ее номер, чтобы выйти из главного меню нажмите 0.");
                Console.WriteLine("  ");
                Console.WriteLine("Задание 1");
                Console.WriteLine("Задание 2");
                Console.WriteLine("-----------");
                Console.Write("Номер задания: ");

                if (int.TryParse(Console.ReadLine(), out mynumber))
                {

                    switch (mynumber)
                    {

                        case 1:
                            Task1();
                            break;
                        case 2:
                            Task2();
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Вы ввели неправильный номер задания. Введите еще раз.");
                            Console.ReadLine();
                            break;

                    }

                }
                else
                {

                    Console.Write($"Вы ввели некорректное число.");
                    Console.ReadLine();
                    mynumber++;

                }

                
            }
            while (mynumber != 0);

            Console.Clear();
            Console.Title = "Завершение работы программы";

            Console.Write("До новых встреч!");

            Console.ReadLine();

        }
        public static void PrintInCenter(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.WindowHeight / 2 - 1);
            Console.WriteLine(text);
        }
    }
}
