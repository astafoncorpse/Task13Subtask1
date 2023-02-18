using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;


namespace Task13Subtas1

{
    class Program
    {
        public static LinkedList<string> LinkedList = new LinkedList<string>();
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\SuperUser\\Downloads\\Text1.txt");
            CreateListT(text);

            CreateLinkList(text);
        }
        static void CreateListT(string text)
        {

            Console.WriteLine("\nCreateListT начал работу");
            var text1 = new List<string>();

            text1.Add("Проверка скорсти List<T>");

            foreach (var Add in text1)
                Console.WriteLine(text + ": " + Add);
            Console.WriteLine();



            var timer = new Stopwatch();
            timer.Start();

            char[] delimiters = new char[] { ' ', '\r', '\n' };

            var wordslist = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();

            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);

            Console.WriteLine("CreateListT завершил работу");
            Thread.Sleep(5000);


        }
        static void CreateLinkList(string text)
        {

            Console.WriteLine("\nCreateLinkList начал работу");

            var text1 = new LinkedList<string>();
            LinkedList.AddFirst(text);
            var t = LinkedList.AddFirst("Проверка скорости LinkList");
            


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Выведем список ещё раз после вставки");
            Console.WriteLine();


            GoOnwards(); //   Прямой проход списка
            GoBackwards(text); // Обратный проход списка

            static void GoOnwards()
            {
                LinkedListNode<string> node;

                Console.WriteLine("Элементы коллекции в прямом направлении: ");
                for (node = LinkedList.First; node != null; node = node.Next)
                    Console.Write(node.Value + " ");
            }

            static void GoBackwards(string text)
            {
                LinkedListNode<string> node;

                Console.WriteLine("\n\nЭлементы коллекции в обратном направлении: ");
                for (node = LinkedList.Last; node != null; node = node.Previous)
                    Console.Write(node.Value + " ");





                var timer = new Stopwatch();
                timer.Start();

                char[] delimiters = new char[] { ' ', '\r', '\n' };

                var linkedList = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();

                timer.Stop();
                Console.WriteLine(timer.ElapsedMilliseconds);

                Console.WriteLine("CreateLinkList завершил работу");
                Console.ReadKey();
            }
        }
    }
}