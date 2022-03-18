using System;
using System.IO;
using System.Web;
using System.Text.Json;

namespace Parser
{
    class Program
    {

        public Program ()
        {
            
        }

        static void Main(string[] args)
        {
            string path = @"E:\MAKS\StringParser\Parser\Parser\Doc\string.txt";
            
            // делим полученный массив символов из файла path на строки по символу ;
            string[] lines = Parser(path).ToString().Split(";");

            string urlline = lines[0];

            string url = HttpUtility.UrlDecode(urlline).Remove(0,26);

             //  url = url.Remove(0,26);
          
            

            //foreach (var s in stroki)
            //{
            //    string url = HttpUtility.UrlDecode(s);  // декодируем полученные строки
            //  //  string jsonString = JsonSerializer.Serialize(url); // сериализируем урл в json
            //}
            

            Console.WriteLine(url);
            //  Console.WriteLine(Parser(path).ToString());
            Console.ReadKey();

        }

        static string Parser (string path) 
        {
            string textfile = "";

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл отсутствует");
            }
            else 
            {
                string[] readText = File.ReadAllLines(path);
                foreach (string s in readText)
                {
                    textfile += s;
                }
            }
            return textfile;
        }
    }
}
