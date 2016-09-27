using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace DotaParser
{
    internal class Program
    {
        public class Networking
        {
            public static string GetRequest(string url)
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "text/html; charset=utf-8;en-us";
                request.UserAgent = @"Mozilla/5.0 Chrome/32.0.1667.0";
                var response = (HttpWebResponse)request.GetResponse();
                var sr = new StreamReader(response.GetResponseStream());
                var stream = sr.ReadToEnd();
                return stream;
            }
        }

        public class Dotabuff
        {
            public static string GetMMR(string id)
            {
                string solommr = null;
                string partymmr = null;
                var stream = Networking.GetRequest(string.Format("http://www.dotabuff.com/players/{0}", id));
                solommr =
                    Regex.Match(stream, "<dt>Last Match</dt></dl><dl><dd>(.*?)?</dd><dt>Solo MMR</dt>",
                        RegexOptions.Singleline).Groups[1].Value;
                var r = new Regex("<dt>Last Match</dt></dl><dl><dd>(.*?)?</dd><dt>Solo MMR</dt>");
                if (!r.IsMatch(stream))
                {
                    partymmr = Regex.Match(stream,
                        "<dt>Last Match</dt></dl><dl><dd>(.*?)?</dd><dt>Party MMR</dt></dl><dl><dd><span class=\"game-record\">",
                        RegexOptions.Singleline).Groups[1].Value;
                }
                else
                    partymmr =
                        Regex.Match(stream,
                            "<dt>Solo MMR</dt></dl><dl><dd>(.*?)?</dd><dt>Party MMR</dt></dl><dl><dd><span class=\"game-record\">",
                            RegexOptions.Singleline).Groups[1].Value;
                return string.Format("Соло ММР = {0}\nГрупповой ММР = {1}\n",
                    String.IsNullOrEmpty(solommr) ? "undefined" : solommr,
                    String.IsNullOrEmpty(partymmr) ? "undefined" : partymmr);
            }
            public static string GetName(string id)
            {
                var stream = Networking.GetRequest(string.Format("http://www.dotabuff.com/players/{0}", id));
                var name =
                    Regex.Match(stream, "<div class=\"header-content-title\"><h1>(.*?)?<small>",
                        RegexOptions.Singleline).Groups[1].Value;
                return string.Format("Имя игрока = {0}", name);
            }
            public static string GetKills(string id)
            {

                var stream = Networking.GetRequest(string.Format("http://www.dotabuff.com/players/{0}/heroes?metric=impact", id));
                var regex = new Regex("<td data-value=\"[\\s\\S]+?\">[\\s\\S]+?<div");
                var matches = regex.Matches(stream);
                var output = matches.Cast<Match>().Aggregate("", (current, t) => current + t);
                var info = Regex.Matches(output, ">(.*?)?<", RegexOptions.Compiled);
                var output2 = info.Cast<object>().Aggregate("", (current, t) => current + (t + "%"));
                output2 = output2.Replace(">", "").Replace("<", "").Replace(".", "").Replace(",", "");
                var ma = output2.Split(new[] { '%' }, StringSplitOptions.RemoveEmptyEntries);
                var mas = ma.Select(int.Parse).ToArray();
                var source = mas.ToList();
                var result = source.Where((t, i) => i % 4 != 0).Where((t, i) => i % 3 == 0).ToList();
                return string.Format("Всего убийств = {0}", result.ToArray().Sum());
            }
        }

        private static void Main()
        {
            while (true)
            {
                Console.Write("Введите id: ");
                var id = Console.ReadLine();
                Console.Clear();
                if (String.IsNullOrEmpty(id)) continue;
                Console.WriteLine("ID игрока = "+ id);
                Console.WriteLine(Dotabuff.GetName(id));
                Console.WriteLine(Dotabuff.GetKills(id));
                Console.WriteLine(Dotabuff.GetMMR(id));
            }
        }
    }
}
