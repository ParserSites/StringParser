using System;
using System.IO;
using System.Web;
using System.Text.Json;
using Parser.Models;
using Newtonsoft.Json;

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

            Model_Price ttt = JsonConvert.DeserializeObject<Model_Price>(url);

          //  Model_Price model_Price = JsonSerializer.Deserialize<Model_Price>(url);


            //foreach (var s in stroki)
            //{
            //    string url = HttpUtility.UrlDecode(s);  // декодируем полученные строки
            //  //  string jsonString = JsonSerializer.Serialize(url); // сериализируем урл в json
            //}

            Console.WriteLine($"name: {ttt?.name}");
        //    Console.WriteLine(url);
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
