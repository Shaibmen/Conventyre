﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Conventer
{
    public class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Введите путь до файла вместе с названием, который надо открыть");
                Console.WriteLine("--------------------------------------------------------------------------");
                Conventer conventer = new Conventer();
                string fileToPath = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Для сохранения файлов F1 Для выхода Escape");
                ConsoleKeyInfo KeyChoise = Console.ReadKey();

                if (KeyChoise.Key == ConsoleKey.F1)
                {
                    conventer.Conventiryem(fileToPath);
                }
                if (KeyChoise.Key == ConsoleKey.Escape)
                {
                   break;
                }
            }
            



           /* Console.WriteLine("Введите путь до файла вместе с названием, который надо открыть");
            Console.WriteLine("--------------------------------------------------------------------------");
            string pathToFile = Console.ReadLine();
            Console.Clear();
            string myText = File.ReadAllText(pathToFile);
            Console.WriteLine(myText);
            Console.WriteLine("Для конверта в json введите \'1\'");
            string choise = Console.ReadLine();
            if (choise == "1")
            {
                string json = JsonConvert.SerializeObject(myText);
                Console.WriteLine("Введите путь до нового файла");
                string JsonPath = Console.ReadLine();
                File.WriteAllText(JsonPath, json);
            }*/



        }
    }
}
