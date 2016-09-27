using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CourseSh
{
    public class Mathematic<T> 
    {
        public List<T> Items = new List<T>();
        public string Joiner(T[] first, T[] second, List<T> items)
        {
            items.Clear();
            string str = null;
            items.AddRange(first);
            items.AddRange(second);
            Console.Write("\nМножество А: ");
            foreach (var f in first) Console.Write(f + " ");
            Console.Write("\nМножество B: ");
            foreach (var f in second) Console.Write(f + " ");
            Console.Write("\nОбъединение множеств: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var t in items)
            {
                Console.Write(t + " ");
                str += t + ", ";
            }
            Console.ForegroundColor = ConsoleColor.White;
            return string.Format(@"Joiner(A,B) = {{{0}}}", str);
        }

        public string Crossing(T[] first, T[] second, List<T> items)
        {
            items.Clear();
            string str = null;
            items.AddRange(first.Intersect(second));
            Console.Write("\nМножество А: ");
            foreach (var f in first) Console.Write(f + " ");
            Console.Write("\nМножество B: ");
            foreach (var f in second) Console.Write(f + " ");
            Console.Write("\nПересечение множеств: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var t in items){
                Console.Write(t + " ");
                str += t + ", ";
            }
            Console.ForegroundColor = ConsoleColor.White;
            return string.Format(@"Crossing(A,B) = {{{0}}}", str);
        }

        public string Excepting(T[] first, T[] second, List<T> items)
        {
            string str = null;
            items.Clear();
            items.AddRange(first.Except(second));
            Console.Write("\nМножество А: ");
            foreach (var f in first) Console.Write(f + " ");
            Console.Write("\nМножество B: ");
            foreach (var f in second) Console.Write(f + " ");
            Console.Write("\nВычитание множеств: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var t in items) { 
                Console.Write(t + " ");
                str += t + ", ";
            }
            Console.ForegroundColor = ConsoleColor.White;
            return string.Format(@"Excepting(A,B) = {{{0}}}", str);
        }

        public string XOR(int[] first, int[] second)
        {
            var C = new int[first.Length];
            string str = null;
            for (var i = 0; i < first.Length; i++)
            {
                C[i] = first[i] | second[i];
                str += C[i] + ", ";
            }
            Console.Write("\nМножество А: ");
            foreach (var f in first) Console.Write(f + " ");
            Console.Write("\nМножество B: ");
            foreach (var f in second) Console.Write(f + " ");
            Console.Write("\nДизъюнктивного сложения: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var t in C)
            {
                Console.Write(t + " ");
            }
            Console.ForegroundColor = ConsoleColor.White;
            return string.Format(@"XOR(A,B) = {{{0}}}", str);
        }
    }

    public class Program
    {
        private static void WriteToLog(string abs)
        {
            var appendText = string.Format("{0} : {2} {1}\n", DateTime.Now, abs == null ? "Ошибка" : null, abs);
            File.AppendAllText("Session.log", appendText, Encoding.UTF8);
        }
        private static void Main(string[] args)
        {
            int[] A = {}, B = {};
            try
            {
                try
                {
                    var mtchA = Regex.Match(File.ReadAllText(args[0] + ".txt"), @"{.*?(\w.*)\s*}",
                        RegexOptions.Singleline).Groups[1].Value.Split(new[] {','},
                            StringSplitOptions.RemoveEmptyEntries);
                    var mtchB = Regex.Match(File.ReadAllText(args[1] + ".txt"), @"{.*?(\w.*)\s*}",
                        RegexOptions.Singleline).Groups[1].Value.Split(new[] {','},
                            StringSplitOptions.RemoveEmptyEntries);
                    A = mtchA.Select(int.Parse).ToArray();
                    B = mtchB.Select(int.Parse).ToArray();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода! Символы запрещены!\n\n");
                    Console.ReadKey();
                }
                Console.ForegroundColor = ConsoleColor.White;
                var list = new Mathematic<int>();

                while (true)
                {
                    Console.WriteLine(
                                      "\n1. Объединение множеств\n" +
                                      "2. Пересечение множеств\n" +
                                      "3. Вычитание множеств\n" +
                                      "4. Дизъюнктивного сложения\n" +
                                      "5. Ввести данные вручную\n" +
                                      "6. Выход\n");
                    var key = Console.ReadLine();

                    switch (key)
                    {
                        case "1":
                            WriteToLog(list.Joiner(A, B, list.Items));
                            break;
                        case "2":
                            WriteToLog(list.Crossing(A, B, list.Items));
                            break;
                        case "3":
                            WriteToLog(list.Excepting(A, B, list.Items));
                            break;
                        case "4":
                            WriteToLog(list.XOR(A, B));
                            break;
                        case "5":
                        {
                            Console.WriteLine("Введите множество A в формате A={a1,....,ai}: ");
                            string am;
                            using (var sw = new StreamWriter(args[0] + ".txt"))
                            {
                                am = Console.ReadLine();
                                sw.WriteLine(am);
                            }
                            Console.WriteLine("Введите множество A в формате B={b1,....,bi}: ");
                            string bm;
                            using (var sw = new StreamWriter(args[1] + ".txt"))
                            {
                                bm = Console.ReadLine();
                                sw.WriteLine(bm);
                            }
                            try
                            {
                                var matchA = Regex.Match(am, @"{.*?(\w.*)\s*}",
                                    RegexOptions.Singleline).Groups[1].Value.Split(new[]{','},
                                    StringSplitOptions.RemoveEmptyEntries);
                                var matchB =
                                    Regex.Match(bm, @"{.*?(\w.*)\s*}",
                                    RegexOptions.Singleline).Groups[1].Value.Split(new[]{','},
                                    StringSplitOptions.RemoveEmptyEntries);
                                A = matchA.Select(int.Parse).ToArray();
                                B = matchB.Select(int.Parse).ToArray();
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Ошибка ввода! Символы запрещены!\n\n");
                                Console.ReadKey();
                            }

                            Console.WriteLine("Данные успешно перезаписаны!");
                            break;
                        }
                        case "6":
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.Write("Открывайте программу с командной строки в формате run.exe arg1 arg 2\n\n");
                Console.ReadKey();
            }
        }
    }
}
