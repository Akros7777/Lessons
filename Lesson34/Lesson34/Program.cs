using System;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace Lesson34
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://mycsharp.ru");
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string html = reader.ReadToEnd();
            MatchCollection matches = Regex.Matches(html, "<h2>.*?</h2>", RegexOptions.Singleline);
            foreach (Match element in matches)
            {

                string header = Regex.Replace(element.Value, "<.*?>", "");
                Console.WriteLine(header);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
