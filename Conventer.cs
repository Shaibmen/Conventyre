using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conventer
{
    internal class Conventer
    {

        public void Conventiryem(string fileToPath)
        {
            bool IsDone = true;

            string[] stroka = File.ReadAllLines(fileToPath);
            List<Figura> figyri = new List<Figura>();

            for (int i = 0; i < stroka.Length; i += 3)
            {
                Figura figure = new Figura
                {
                    Name = stroka[i],
                    Weight = stroka[i + 1],
                    Height = stroka[i + 2]
                };

                figyri.Add(figure);
            }

            Console.Clear();

            foreach (Figura figure in figyri)
            {
                Console.WriteLine($"Название: {figure.Name}, Высота: {figure.Height}, Ширина: {figure.Weight}");
            }
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Введите в какой формат нужно перезаписать \'json\'\'xml\'\'txt\'");
            string choiseFormat = Console.ReadLine();



        }

    }
}
